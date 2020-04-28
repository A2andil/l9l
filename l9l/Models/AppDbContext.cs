using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Rate> Rates { get; set; }
    }
}
