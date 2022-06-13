using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesAPI.Infastructure.SeedData;
using VehiclesAPI.Models.Concrete;

namespace VehiclesAPI.Context
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarSeeding());
            modelBuilder.ApplyConfiguration(new BusSeeding());
            modelBuilder.ApplyConfiguration(new BoatSeeding());

        }


    }
}
