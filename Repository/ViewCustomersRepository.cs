using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repository
{
    public class ViewCustomersRepository : IViewCustomersRepository
    {
        CarWashContext _context;
        public ViewCustomersRepository(CarWashContext context) => _context = context;

        public List<Customer> ViewCustomersAsync()
        {
            try
            {
                var query = (from a in _context.UserProfiles
                             where a.Role == "Customer"

                             select new Customer()
                             {
                                 UserId = a.UserId,
                                 UserName = a.UserName,
                                 UserPhnumber = a.UserPhnumber,
                                 UserEmail = a.UserEmail,
                                 UserStatus = a.UserStatus
                             });

                List<Customer> list1 = query.ToList();
                return list1;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
