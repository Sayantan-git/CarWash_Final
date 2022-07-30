using CarWashApi.Models;
using CarWashApi.Repository;
using CarWashApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _Service;
        private IToken _token;

        public LoginController(LoginService service, IToken token)
        {

            _Service = service;
            _token = token;
        }

        [HttpPost, Route("login")]

        public async Task<ActionResult<Token>> Login(Login item)
        {


            var res = await _Service.Login(item);


            if (res == 200)
            {

                string token = _token.CreateToken(item);
                Token tk = new Token();
                tk.token = token;
                return tk;
            }
            else if (res == 404)
            {
                return BadRequest("You are not registered");
            }
            else if (res == 401)
            {
                return Unauthorized("Password is wrong");
            }
            else
            {
                return Unauthorized("Your account is blocked,please contact Admininstrator");

            }
        }
    }
}

