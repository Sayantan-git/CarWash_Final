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
    public class AddressController : ControllerBase
    {
        private AddressService _address;
        public AddressController(AddressService address)
        {
            _address = address;
        }
        [HttpGet]
        public IActionResult GetAllAddress()
        {
            return Ok(_address.GetAll());
        }
        [HttpGet("ById")]
        public IActionResult GetAddressById(int id)
        {
            return Ok(_address.GetById(id));
        }
        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
            return Ok(_address.AddAddress(address));
        }
        [HttpPut]
        public IActionResult UpdateAddress(Address address)
        {
            return Ok(_address.UpdateAddress(address));

        }
        [HttpDelete("ById")]
        public IActionResult RemoveAddress(int id)
        {
            return Ok(_address.RemoveAddress(id));
        }
    }

}