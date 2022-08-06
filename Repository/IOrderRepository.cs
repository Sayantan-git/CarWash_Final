using CarWashApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repository
{
    public interface IOrderRepository<TEntity> where TEntity : class
    {
        Task<ActionResult<Order>> CreateAsync(TEntity item);
    }
}
