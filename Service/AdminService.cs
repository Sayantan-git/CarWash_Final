using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class AdminService : IAdmin
    {
        private IAdmin _admin;

        public AdminService(IAdmin admin)
        {
            _admin = admin;
        }
        public List<Admin> GetAll()
        {
            return _admin.GetAll();
        }
        public Admin GetById(int id)
        {
            return _admin.GetById(id);
        }
        public string AddAdmin(Admin admin)
        {
            return _admin.AddAdmin(admin);
        }
        public string UpdateAdmin(Admin admin)
        {
            return _admin.UpdateAdmin(admin);
        }
        public string RemoveAdmin(int id)
        {
            return _admin.RemoveAdmin(id);
        }
    }
}
