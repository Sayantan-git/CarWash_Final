using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminUsername { get; set; } = null!;
        public string AdminPassword { get; set; } = null!;
    }
}
