using CarWashApi.Models;
using CarWashApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Service
{
    public class PackageService : IPackage
    {
        private IPackage _package;

        public PackageService(IPackage package)
        {
            _package = package;
        }
        public List<Package> GetAll()
        {
            return _package.GetAll();
        }
        public Package GetById(int id)
        {
            return _package.GetById(id);
        }
        public string AddPackage(Package package)
        {
            return _package.AddPackage(package);
        }
        public string UpdatePackage(Package package)
        {
            return _package.UpdatePackage(package);
        }
        public string RemovePackage(int id)
        {
            return _package.RemovePackage(id);
        }
    }
}
