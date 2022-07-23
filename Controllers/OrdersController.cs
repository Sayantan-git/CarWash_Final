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
    public class OrdersController : ControllerBase
    {
        private OrdersService _orders;
        public OrdersController(OrdersService orders)
        {
            _orders = orders;
        }



        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(_orders.GetAll());
        }


        [HttpGet("ById")]
        public IActionResult GetOrdersById(int id)
        {
            return Ok(_orders.GetById(id));
        }


        [HttpPost]
        public IActionResult AddOrders(Orders orders)
        {
            return Ok(_orders.AddOrders(orders));
        }


        [HttpPut]
        public IActionResult UpdateOrders(Orders orders)
        {
            return Ok(_orders.UpdateOrders(orders));

        }


        [HttpDelete("ById")]
        public IActionResult RemoveOrders(int id)
        {
            return Ok(_orders.RemoveOrders(id));
        }
    }
}
