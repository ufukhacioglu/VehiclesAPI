using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesAPI.Abstract;

namespace VehiclesAPI.Models.Concrete
{
    public class Vehicle : IEntity
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
    }
}
