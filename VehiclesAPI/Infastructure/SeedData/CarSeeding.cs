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
    public class CarSeeding : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x => x.Wheel).IsRequired();
            builder.HasData(
                new Car { Id = 1, Model = "BMW", Color = "red", Wheel = 4, HeadLight = false },
                new Car { Id = 2, Model = "Mercedes", Color = "blue", Wheel = 4, HeadLight = false },
                new Car { Id = 3, Model = "Lamborghini", Color = "black", Wheel = 4, HeadLight = false },
                new Car { Id = 4, Model = "Mercedes", Color = "red", Wheel = 4, HeadLight = false },
                new Car { Id = 5, Model = "Lamborghini", Color = "white", Wheel = 4, HeadLight = false },
                new Car { Id = 6, Model = "BMW", Color = "black", Wheel = 4, HeadLight = false },
                new Car { Id = 7, Model = "BMW", Color = "red", Wheel = 4, HeadLight = false },
                new Car { Id = 8, Model = "Lamborghini", Color = "red", Wheel = 4, HeadLight = false },
                new Car { Id = 9, Model = "Lamborghini", Color = "blue", Wheel = 4, HeadLight = false },
                new Car { Id = 10, Model = "BMW", Color = "black", Wheel = 4, HeadLight = false }

                );
        }
    }
}
