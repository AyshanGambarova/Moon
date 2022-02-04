using Microsoft.EntityFrameworkCore;
using Moon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.DAL
{
    public class ConnectToDb:DbContext
    {
        public ConnectToDb(DbContextOptions<ConnectToDb> options) : base(options)
        { }
        public DbSet<Service> Services { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Navbar> Navbars { get; set; }
        




    }
}
