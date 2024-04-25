using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hattfabriken.Models;
using System.Linq;
using System.Threading.Tasks;
using Hattfabriken.Models.Interfaces;

namespace Hattfabriken.Controllers
{
    public class OrdersController : Controller
    {
        private readonly HatDbContext _context;
        private readonly IImageService _imageService;

        public OrdersController(HatDbContext context , ImageService imageservice)
        {
            _context = context;
            _imageService = imageservice;
        }

        public async Task<IActionResult> Orders()
        {
            var orders = await _context.Orders.ToListAsync();
            return View(orders);
        }

        public void Add(Offer offer)
        {
            Order newOrder = new Order()
            {
                HatType = offer.HatType,
                Material = offer.Material,
                SpecialEffects = offer.SpecialEffect,
                Measurement = offer.Measurement,
                Height = offer.Height,
                Commentary = offer.HatmakerComment,
                HatImage = offer.HatImage,
                MaterialCost = offer.MaterialCost,
                SpecialEffectCost = offer.SpecialEffectCost,
                ShippingCost = offer.ShippingCost,
                Address = offer.Address,
                PostalCode = offer.PostalCode,
                PhoneNumber = offer.PhoneNumber,
                Country = offer.Country,
                Email = offer.Email,
                Name = offer.Name,
                Date = offer.EstimatedDeliveryDate,
                Delivery = offer.Delivery,
                Urgent = offer.Urgent
            };

            _context.Orders.Add(newOrder);
            _context.SaveChangesAsync();
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

        [HttpGet]
        public async Task<IActionResult> ReadMore(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
