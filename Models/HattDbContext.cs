using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hattfabriken.Models
{
    public class HattDbContext : IdentityDbContext
    {
        public HattDbContext(DbContextOptions<HattDbContext> options) : base(options) { }

       public HattDbContext()
        {

        }

    }
}
