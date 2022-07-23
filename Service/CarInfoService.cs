using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class CarInfoService : ICarInfo
    {
        private ICarInfo _car;

        public CarInfoService(ICarInfo car)
        {
            _car = car;
        }
        public List<CarInfo> GetAll()
        {
            return _car.GetAll();
        }
        public CarInfo GetById(int id)
        {
            return _car.GetById(id);
        }
        public string AddCar(CarInfo car)
        {
            return _car.AddCar(car);
        }
        public string UpdateCar(CarInfo car)
        {
            return _car.UpdateCar(car);
        }

        public string RemoveCar(int id)
        {
            return _car.RemoveCar(id);
        }
    }
}
