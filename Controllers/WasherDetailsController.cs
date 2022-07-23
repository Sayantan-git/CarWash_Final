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
    public class WasherDetailsController : ControllerBase
    {
        private WasherInfoService _washer;
        public WasherDetailsController(WasherInfoService washer)
        {
            _washer = washer;
        }
        [HttpGet]
        public IActionResult GetAllWasherDetails()
        {
            return Ok(_washer.GetAll());
        }
        [HttpGet("ById")]
        public IActionResult GetWasherDetailsById(int id)
        {
            return Ok(_washer.GetById(id));
        }
        [HttpPost]
        public IActionResult AddWasherDetails(WasherDetails washer)
        {
            return Ok(_washer.AddWasherDetails(washer));
        }
        [HttpPut]
        public IActionResult UpdateWasherDetails(WasherDetails washer)
        {
            return Ok(_washer.UpdateWasherDetails(washer));
        }
        [HttpDelete("ById")]
        public IActionResult RemoveWasherDetails(int id)
        {
            return Ok(_washer.RemoveWasherDetails(id));
        }
    }
}
