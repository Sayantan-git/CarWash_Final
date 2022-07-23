using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Models
{
    public class Orders
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime DateTime { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; }
        public string IsScheduledLater { get; set; }
        public string Instructions { get; set; }
        public string PaymentStatus { get; set; }


        public int? CustId { get; set; }
        [ForeignKey("CustId")]
        public UserDetails UserDetails { get; set; }

        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }


        public int? PackageId { get; set; }
        [ForeignKey("PackageId")]
        public Package Package{ get; set; }

        public int? CarId { get; set; }
        [ForeignKey("CarId")]
        public CarInfo CarInfo { get; set; }


        public int? WasherId { get; set; }
        [ForeignKey("WasherId")]
        public WasherDetails WasherDetails { get; set; }




    }
}
