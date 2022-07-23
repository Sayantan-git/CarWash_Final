using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface IAdmin
    {
        public List<Admin> GetAll();
        public Admin GetById(int id);
        public string AddAdmin(Admin user);
        public string UpdateAdmin(Admin user);
        public string RemoveAdmin(int id);

    }
}
