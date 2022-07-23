using CarWashApi.Models;
using CarWashApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarInfoController : ControllerBase
    {
        private CarInfoService _car;
        public CarInfoController(CarInfoService car)
        {
            _car = car;
        }
        [HttpGet]
        public IActionResult GetAllCarInfo()
        {
            return Ok(_car.GetAll());
        }
        [HttpGet("ById")]
        public IActionResult GetCarById(int id)
        {
            return Ok(_car.GetById(id));
        }
        [HttpPost]
        public IActionResult AddCar(CarInfo car)
        {
            return Ok(_car.AddCar(car));
        }
        [HttpPut]
        public IActionResult UpdateCar(CarInfo car)
        {
            return Ok(_car.UpdateCar(car));
        }
        [HttpDelete("ById")]
        public IActionResult RemoveCar(int id)
        {
            return Ok(_car.RemoveCar(id));
        }
    }
}
