using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public interface IPackage
    {
        public List<Package> GetAll();
        public Package GetById(int id);
        public string AddPackage(Package package);
        public string UpdatePackage(Package package);
        public string RemovePackage(int id);
    }
}
