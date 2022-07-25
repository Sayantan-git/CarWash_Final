using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Repository
{
    public class ViewInvoiceRepository : IViewInvoiceRepository
    {
        CarWashContext _context;
        public ViewInvoiceRepository(CarWashContext context) => _context = context;
        public List<Invoice> ViewInvoiceAsync(int id)
        {
            try
            {
                var query = (from a in _context.Orders
                             join b in _context.UserProfiles
                                 on a.CustId equals b.UserId
                             join c in _context.Washers
                                on a.WasherId equals c.Id
                             join d in _context.Cars
                                on a.CarId equals d.Id
                             join e in _context.Packages
                                on a.PackageId equals e.Id

                             select new Invoice()
                             {
                                 CustomerName = b.UserName,
                                 DateTime = a.DateTime,
                                 PaymentStatus = a.PaymentStatus,
                                 OrderTotal = a.TotalCost,
                                 WasherName = c.Name,
                                 CarName = d.Name,
                                 PackageName = e.Name
                             });
                List<Invoice> list1 = query.ToList();
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
