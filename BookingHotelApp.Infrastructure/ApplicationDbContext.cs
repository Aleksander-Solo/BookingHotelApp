using BookingHotelApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Amenitie> Amenities { get; set; }
        public DbSet<Board> Board { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>().Property(x => x.City).HasMaxLength(60);
            modelBuilder.Entity<Amenitie>().Property(x => x.Name).HasMaxLength(40);
            modelBuilder.Entity<Board>().Property(x => x.Description).HasColumnType("text");
            modelBuilder.Entity<Hotel>().Property(x => x.Description).HasColumnType("text");
            modelBuilder.Entity<Hotel>().Property(x => x.PhoneNumber).HasMaxLength(15);
            modelBuilder.Entity<Order>().Property(x => x.PhoneNumber).HasMaxLength(15);
            modelBuilder.Entity<Order>().Property(x => x.FirstName).HasMaxLength(30);
            modelBuilder.Entity<Order>().Property(x => x.LastName).HasMaxLength(30);
            modelBuilder.Entity<Room>().Property(x => x.Description).HasColumnType("text");
            modelBuilder.Entity<User>().Property(x => x.FirstName).HasMaxLength(30);
            modelBuilder.Entity<User>().Property(x => x.LastName).HasMaxLength(30);

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {

                property.SetColumnType("decimal(18,2)");


            }
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");
        }
    }
}
