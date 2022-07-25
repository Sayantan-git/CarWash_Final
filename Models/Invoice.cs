using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }

        public int CustId { get; set; }
        [ForeignKey("CustId")]
        public UserProfile UserProfile { get; set; }
        public DateTime DateTime { get; set; }
        public double OrderTotal { get; set; }
        public string PaymentStatus { get; set; }
        public string PackageName { get; set; }
        public string CarName { get; set; }
        public string WasherName { get; set; }
    }
}
