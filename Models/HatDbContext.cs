﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hattfabriken.Models
{
    public class HatDbContext : IdentityDbContext
    {
        public HatDbContext(DbContextOptions<HatDbContext> options) : base(options) { }



        public DbSet <Hatt> Hattar {  get; set; }

        public DbSet<Material> Materials { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Forfragan> Forfragor { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}