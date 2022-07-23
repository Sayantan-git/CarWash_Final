using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Models
{
    public class UserDetails
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "FirstName cannot be empty")]
        [DataType("varchar(25)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName cannot be empty")]
        [DataType("varchar(25)")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Phone Number cannot be empty")]
        [DataType("varchar(10)")]
        [MinLength(10, ErrorMessage = "Phone number cannot be last be 10")]
        public string Mobile { get; set; }


        public string Email { get; set; }
        public string Password { get; set; }
        public string CnfPassword { get; set; }
    }
}
