using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using VehiclesAPI.Context;
using VehiclesAPI.Models.Concrete;
using VehiclesAPI.Services.Abstract;

namespace VehiclesAPI.Services.Concrete
{
    public class VehicleService : IVehicleService
    {
        private readonly DbContext _dbContext;
        public VehicleService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(Car car)
        {
            var result = _dbContext.Set<Car>().Remove(car);
            _dbContext.SaveChanges();
        }

        public List<Boat> GetBoatsByColor(string color)
        {
            var result = _dbContext.Set<Boat>().Where(x=>x.Color == color).ToList();
            return result;
        }

        public List<Bus> GetBusesByColor(string color)
        {
            var result = _dbContext.Set<Bus>().Where(x => x.Color == color).ToList();
            return result;
        }

        public List<Car> GetCarsByColor(string color)
        {
            var result = _dbContext.Set<Car>().Where(x => x.Color == color).ToList();
            return result;
        }

        public string HeadLightOnOff(int id)
        {
            var result = _dbContext.Set<Car>().FirstOrDefault(x => x.Id == id);
            if (result.HeadLight == false)
            {
                result.HeadLight = true;
                _dbContext.SaveChanges();
                return $"{result.Model} headlights turned on";
            }
            else if(result.HeadLight == true)
            {
                result.HeadLight = false;
                _dbContext.SaveChanges();
                return $"{result.Model} headlights turned off";
            }
            else
            {
                return "This car was not found";
            }
            
        }
    }
}
