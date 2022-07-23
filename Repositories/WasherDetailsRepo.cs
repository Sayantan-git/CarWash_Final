using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class WasherDetailsRepo : IWasherDetails
    {
        readonly CarWashContext _dbContext;

        public WasherDetailsRepo(CarWashContext context)
        {
            _dbContext = context;
        }

        #region GetAllWasherDetails
        public List<WasherDetails> GetAll()
        {
            try
            {
                return _dbContext.washers.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetWasherDetailsById
        public WasherDetails GetById(int id)
        {
            try
            {
                WasherDetails? washer = _dbContext.washers.Find(id);
                if (washer != null)
                {
                    return washer;
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

        #region AddWasherDetails
        public string AddWasherDetails(WasherDetails washer)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.washers.Add(washer);
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

        #region UpdateWasherDetails
        public string UpdateWasherDetails(WasherDetails washer)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(washer).State = EntityState.Modified;
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

        #region DeleteWasherDetails
        public string RemoveWasherDetails(int id)
        {
            string stcode = string.Empty;
            try
            {
                var washer = _dbContext.washers.Find(id);
                if (washer != null)
                {
                    _dbContext.washers.Remove(washer);
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