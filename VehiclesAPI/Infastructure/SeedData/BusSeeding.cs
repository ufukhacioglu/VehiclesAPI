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
    public class BusSeeding : IEntityTypeConfiguration<Bus>
    {

        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
                new Bus { Id = 1, Model = "BMC", Color = "red" },
                new Bus { Id = 2, Model = "Man", Color = "blue" },
                new Bus { Id = 3, Model = "Setra", Color = "black" },
                new Bus { Id = 4, Model = "Setra", Color = "red" },
                new Bus { Id = 5, Model = "BMC", Color = "white" },
                new Bus { Id = 6, Model = "BMC", Color = "black" },
                new Bus { Id = 7, Model = "Man", Color = "red" },
                new Bus { Id = 8, Model = "Man", Color = "red" },
                new Bus { Id = 9, Model = "Man", Color = "blue" },
                new Bus { Id = 10, Model = "Setra", Color = "black" }

                );
        }

    }
}
