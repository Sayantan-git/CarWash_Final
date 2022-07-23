using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface IWasherDetails
    {
        public List<WasherDetails> GetAll();
        public WasherDetails GetById(int id);
        public string AddWasherDetails(WasherDetails washer);
        public string UpdateWasherDetails(WasherDetails washer);
        public string RemoveWasherDetails(int id);
    }
}
