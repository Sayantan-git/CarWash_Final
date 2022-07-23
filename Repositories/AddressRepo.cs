using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class AddressRepo : IAddress
    {
        readonly CarWashContext _dbContext;
        public AddressRepo(CarWashContext context)
        {
            _dbContext = context;
        }

        #region GetAllAddress
        public List<Address> GetAll()
        {
            try
            {
                return _dbContext.Address.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetAddressById
        public Address GetById(int id)
        {
            try
            {
                Address? address = _dbContext.Address.Find(id);
                if (address != null)
                {
                    return address;
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

        #region AddAddress
        public string AddAddress(Address address)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Address.Add(address);
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

        #region UpdateAddress
        public string UpdateAddress(Address address)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(address).State = EntityState.Modified;
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

        #region DeleteAddress
        public string RemoveAddress(int id)
        {
            string stcode = string.Empty;
            try
            {
                var address = _dbContext.Address.Find(id);
                if (address != null)
                {
                    _dbContext.Address.Remove(address);
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
