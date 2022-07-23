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
    public class AdminController : ControllerBase
    {
        private AdminService _admin;
        public AdminController(AdminService user)
        {
            _admin = user;
        }
        [HttpGet]
        public IActionResult GetAllAdmin()
        {
            return Ok(_admin.GetAll());
        }
        [HttpGet("ById")]
        public IActionResult GetUserById(int id)
        {
            return Ok(_admin.GetById(id));
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            return Ok(_admin.AddAdmin(admin));
        }
        [HttpPut]
        public IActionResult UpdateUser(Admin admin)
        {
            return Ok(_admin.UpdateAdmin(admin));
        }
        [HttpDelete("ById")]
        public IActionResult RemoveUser(int id)
        {
            return Ok(_admin.RemoveAdmin(id));
        }
    }
}
