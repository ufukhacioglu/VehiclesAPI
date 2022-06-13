using System.Collections.Generic;
using VehiclesAPI.Models.Concrete;

namespace VehiclesAPI.Services.Abstract
{
    public interface IVehicleService
    {
        List<Car> GetCarsByColor(string color);
        List<Bus> GetBusesByColor(string color);
        List<Boat> GetBoatsByColor(string color);

        public string HeadLightOnOff(int id);

        public void Delete(Car car);

    }
}
