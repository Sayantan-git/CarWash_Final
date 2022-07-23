using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class OrdersService : IOrders
    {
        private IOrders _orders;

        public OrdersService(IOrders orders)
        {
            _orders = orders;
        }


        public List<Orders> GetAll()
        {
            return _orders.GetAll();
        }


        public Orders GetById(int id)
        {
            return _orders.GetById(id);
        }


        public string AddOrders(Orders orders)
        {
            return _orders.AddOrders(orders);
        }


        public string UpdateOrders(Orders orders)
        {
            return _orders.UpdateOrders(orders);
        }


        public string RemoveOrders(int id)
        {
            return _orders.RemoveOrders(id);
        }
    }
}
