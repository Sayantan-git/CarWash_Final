using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface IAddress
    {
        public List<Address> GetAll();
        public Address GetById(int id);
        public string AddAddress(Address address);
        public string UpdateAddress(Address address);
        public string RemoveAddress(int id);
    }
}
