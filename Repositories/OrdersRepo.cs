using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class OrdersRepo : IOrders
    {
        readonly CarWashContext _dbContext;
        public OrdersRepo(CarWashContext context)
        {
            _dbContext = context;
        }

        #region GetAllOrders
        public List<Orders> GetAll()
        {
            try
            {
                return _dbContext.Orders.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetOrdersById
        public Orders GetById(int id)
        {
            try
            {
                Orders? orders = _dbContext.Orders.Find(id);
                if (orders != null)
                {
                    return orders;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region AddOrders
        public string AddOrders(Orders orders)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Orders.Add(orders);
                _dbContext.SaveChanges();
                stcode = "200";
            }
            catch
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region UpdateOrders
        public string UpdateOrders(Orders orders)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(orders).State = EntityState.Modified;
                _dbContext.SaveChanges();
                stcode = "200";
            }
            catch
            {
                stcode = "400";
            }
            return stcode;

        }
        #endregion

        #region DeleteOrders
        public string RemoveOrders(int id)
        {
            string stcode = string.Empty;
            try
            {
                var orders = _dbContext.Orders.Find(id);
                if (orders != null)
                {
                    _dbContext.Orders.Remove(orders);
                    _dbContext.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }
            }
            catch
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion
    }
}
