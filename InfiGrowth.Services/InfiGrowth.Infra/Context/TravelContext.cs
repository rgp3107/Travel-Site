//using InfiGrowth.Entity.Manage;
using InfiGrowth.Entity.Manage;
using Microsoft.EntityFrameworkCore;
using Skyttus.Core.Infra.Context;

namespace InfiGrowth.Infra.Context
{
    public class TravelContext : SkyttusBaseContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options)
        {

        }

     
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<CityImage> CityImages { get; set; }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
