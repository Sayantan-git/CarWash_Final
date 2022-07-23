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
    public class PackageController : ControllerBase
    {
        private PackageService _package;
        public PackageController(PackageService package)
        {
            _package = package;
        }


        [HttpGet]
        public IActionResult GetAllPackage()
        {
            return Ok(_package.GetAll());
        }


        [HttpGet("ById")]
        public IActionResult GetPackageById(int id)
        {
            return Ok(_package.GetById(id));
        }


        [HttpPost]
        public IActionResult AddPackage(Package package)
        {
            return Ok(_package.AddPackage(package));
        }


        [HttpPut]
        public IActionResult UpdatePackage(Package package)
        {
            return Ok(_package.UpdatePackage(package));

        }


        [HttpDelete("ById")]
        public IActionResult RemovePackage(int id)
        {
            return Ok(_package.RemovePackage(id));
        }
    }
}
