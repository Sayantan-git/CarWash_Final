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
                             
                             select new Invoice()
                             {
                                 
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
