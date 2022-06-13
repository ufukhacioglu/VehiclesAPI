using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using VehiclesAPI.Models.Concrete;
using VehiclesAPI.Services.Abstract;

namespace VehiclesAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        [HttpGet]
        public IActionResult GetCarsByColor(string color)
        {
            return new JsonResult(_vehicleService.GetCarsByColor(color));
        }

        [HttpGet]
        public IActionResult GetBoatsByColor(string color)
        {
            return new JsonResult(_vehicleService.GetBoatsByColor(color));
        }
        [HttpGet]
        public IActionResult GetBusesByColor(string color)
        {
            return new JsonResult(_vehicleService.GetBusesByColor(color));
        }
        [HttpPost]
        public IActionResult HeadLightOnOff(int id)
        {
            return new JsonResult(_vehicleService.HeadLightOnOff(id));
        }
        [HttpDelete("Delete car with body")]
        public IActionResult Delete(Car car)
        {
            try
            {
                _vehicleService.Delete(car);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
