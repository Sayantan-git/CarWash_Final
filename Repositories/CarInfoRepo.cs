using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class CarInfoRepo : ICarInfo
    {
        readonly CarWashContext _dbContext;

        public CarInfoRepo(CarWashContext context)
        {
            _dbContext = context;
        }

        #region GetAllCarInfo
        public List<CarInfo> GetAll()
        {
            try
            {
                return _dbContext.CarInfo.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetCarInfoById
        public CarInfo GetById(int id)
        {
            try
            {
                CarInfo? car = _dbContext.CarInfo.Find(id);
                if (car != null)
                {
                    return car;
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

        #region AddCarDetails
        public string AddCar(CarInfo car)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.CarInfo.Add(car);
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

        #region UpdateCarDetails
        public string UpdateCar(CarInfo car)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(car).State = EntityState.Modified;
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

        #region DeleteCarDetails
        public string RemoveCar(int id)
        {
            string stcode = string.Empty;
            try
            {
                var car = _dbContext.CarInfo.Find(id);
                if (car != null)
                {
                    _dbContext.CarInfo.Remove(car);
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