using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesAPI.Models.Concrete;

namespace VehiclesAPI.Infastructure.SeedData
{
    public class BoatSeeding : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasData(
               new Boat { Id = 1, Model = "Raptor", Color = "red" },
               new Boat { Id = 2, Model = "Terhi", Color = "blue" },
               new Boat { Id = 3, Model = "Hydrolift", Color = "black" },
               new Boat { Id = 4, Model = "Terhi", Color = "red" },
               new Boat { Id = 5, Model = "Raptor", Color = "white" },
               new Boat { Id = 6, Model = "Raptor", Color = "black" },
               new Boat { Id = 7, Model = "Raptor", Color = "red" },
               new Boat { Id = 8, Model = "Hydrolift", Color = "red" },
               new Boat { Id = 9, Model = "Hydrolift", Color = "blue" },
               new Boat { Id = 10, Model = "Terhi", Color = "black" }

               );
        }
    }
}
