using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface ICarInfo
    {
        public List<CarInfo> GetAll();
        public CarInfo GetById(int id);
        public string AddCar(CarInfo car);
        public string UpdateCar(CarInfo car);
        public string RemoveCar(int id);
    }
}
