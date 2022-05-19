using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_web.Models;

namespace E_Commerce_web.Models
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<E_Commerce_web.Models.Orders> Orders { get; set; }
        public DbSet<E_Commerce_web.Models.Products> Products { get; set; }
        public DbSet<E_Commerce_web.Models.OrderDetails> OrderDetails { get; set; }
    }
}
