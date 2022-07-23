using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class UserRepo :IUser
    {
        readonly CarWashContext _dbContext;

        public UserRepo(CarWashContext context)
        {
            _dbContext = context;
        }

        #region GetAllGuests
        public List<UserDetails> GetAll()
        {
            try
            {
                return _dbContext.Users.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetGuestById
        public UserDetails GetById(int id)
        {
            try
            {
                UserDetails? user = _dbContext.Users.Find(id);
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

        #region AddGuest
        public string AddUser(UserDetails user)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Users.Add(user);
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
        public string UpdateUser(UserDetails user)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(user).State = EntityState.Modified;
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
        public string RemoveUser(int id)
        {
            string stcode = string.Empty;
            try
            {
                var user = _dbContext.Users.Find(id);
                if (user != null)
                {
                    _dbContext.Users.Remove(user);
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
