
using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class AdminRepo : IAdmin
    {
        readonly CarWashContext _dbContext;

        public AdminRepo(CarWashContext context)
        {
            _dbContext = context;
        }

        #region GetAllAdmin
        public List<Admin> GetAll()
        {
            try
            {
                return _dbContext.Admin.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetAdminById
        public Admin GetById(int id)
        {
            try
            {
                Admin? user = _dbContext.Admin.Find(id);
                if (user != null)
                {
                    return user;
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

        #region AddAdmin
        public string AddAdmin(Admin admin)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Admin.Add(admin);
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

        #region UpdateGuest
        public string UpdateAdmin(Admin admin)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(admin).State = EntityState.Modified;
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

        #region DeleteGuest
        public string RemoveAdmin(int id)
        {
            string stcode = string.Empty;
            try
            {
                var admin = _dbContext.Admin.Find(id);
                if (admin != null)
                {
                    _dbContext.Admin.Remove(admin);
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
