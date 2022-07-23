using CarWashApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repositories
{
    public class PackageRepo : IPackage
    {
        readonly CarWashContext _dbContext;
        public PackageRepo(CarWashContext context)
        {
            _dbContext = context;
        }


        #region GetAllPackages
        public List<Package> GetAll()
        {
            try
            {
                return _dbContext.Package.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetPackageById
        public Package GetById(int id)
        {
            try
            {
                Package? package = _dbContext.Package.Find(id);
                if (package != null)
                {
                    return package;
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

        #region AddPackage
        public string AddPackage(Package package)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Package.Add(package);
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

        #region UpdatePackage
        public string UpdatePackage(Package package)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(package).State = EntityState.Modified;
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

        #region DeletePackage
        public string RemovePackage(int id)
        {
            string stcode = string.Empty;
            try
            {
                var package = _dbContext.Package.Find(id);
                if (package != null)
                {
                    _dbContext.Package.Remove(package);
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
