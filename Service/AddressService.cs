using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class AddressService : IAddress
    {
        private IAddress _address;

        public AddressService(IAddress address)
        {
            _address = address;
        }
        public List<Address> GetAll()
        {
            return _address.GetAll();
        }
        public Address GetById(int id)
        {
            return _address.GetById(id);
        }
        public string AddAddress(Address address)
        {
            return _address.AddAddress(address);
        }
        public string UpdateAddress(Address address)
        {
            return _address.UpdateAddress(address);
        }
        public string RemoveAddress(int id)
        {
            return _address.RemoveAddress(id);
        }
    }
}
