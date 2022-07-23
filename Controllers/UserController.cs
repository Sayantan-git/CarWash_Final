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
    public class UserController : ControllerBase
    {
        private UserService _user;
        public UserController(UserService user)
        {
            _user = user;
        }
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_user.GetAll());
        }
        [HttpGet("ById")]
        public IActionResult GetUserById(int id)
        {
            return Ok(_user.GetById(id));
        }
        [HttpPost]
        public IActionResult AddUser(UserDetails user)
        {
            return Ok(_user.AddUser(user));
        }
        [HttpPut]
        public IActionResult UpdateUser(UserDetails user)
        {
            return Ok(_user.UpdateUser(user));
        }
        [HttpDelete("ById")]
        public IActionResult RemoveUser(int id)
        {
            return Ok(_user.RemoveUser(id));
        }
    }
}
