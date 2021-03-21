using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Concrete.EntitiyFramework
{
   public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentCar;Trusted_Connection=true");

        }

        public DbSet<Car> Cars { get; set; } // Bu işlem ile bizim classımızın hangi tabloya bağlanması gerektiğini belirtiyoruz.

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Rental> Rentals { get; set; }


    }
}
