using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hattfabriken.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Hattfabriken.Controllers
{
    public class OrdersController : Controller
    {
        private readonly HatDbContext _context;

        public OrdersController(HatDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Orders()
        {
            var orders = await _context.Orders.ToListAsync();
            return View(orders);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            order.Status = status;
            _context.Update(order);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
