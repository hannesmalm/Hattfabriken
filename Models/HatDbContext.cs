using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hattfabriken.Models
{
    public class HatDbContext : IdentityDbContext<User>
    {
        public HatDbContext(DbContextOptions<HatDbContext> options) : base(options) { }

        public DbSet <Hatt> Hats {  get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
