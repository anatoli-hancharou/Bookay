using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bookay.Models
{
    public class BookayDbContext : DbContext
    {
        //public BookayDbContext()
        //{
        //    Database.EnsureCreated();
        //    this.Database.Migrate();
        //}

        public BookayDbContext(DbContextOptions<BookayDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
