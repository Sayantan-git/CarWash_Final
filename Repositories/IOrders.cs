using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface IOrders
    {
        public List<Orders> GetAll();
        public Orders GetById(int id);
        public string AddOrders(Orders orders);
        public string UpdateOrders(Orders orders);
        public string RemoveOrders(int id);
    }
}
