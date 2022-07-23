using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class WasherInfoService : IWasherDetails
    {
        private IWasherDetails _washer;

        public WasherInfoService(IWasherDetails washer)
        {
            _washer = washer;
        }
        public List<WasherDetails> GetAll()
        {
            return _washer.GetAll();
        }
        public WasherDetails GetById(int id)
        {
            return _washer.GetById(id);
        }
        public string AddWasherDetails(WasherDetails washer)
        {
            return _washer.AddWasherDetails(washer);
        }
        public string UpdateWasherDetails(WasherDetails washer)
        {
            return _washer.UpdateWasherDetails(washer);
        }
        public string RemoveWasherDetails(int id)
        {
            return _washer.RemoveWasherDetails(id);
        }
    }
}
