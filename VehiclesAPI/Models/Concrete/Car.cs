using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesAPI.Models.Concrete
{
    public class Car : Vehicle
    {
        public int Wheel { get; set;} = 4;
        public bool HeadLight { get; set; }
    }
}
