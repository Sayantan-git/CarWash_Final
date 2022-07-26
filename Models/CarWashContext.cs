using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Models
{
    public class CarWashContext :DbContext
    {
        public CarWashContext()
        {
        }

        public CarWashContext(DbContextOptions<CarWashContext> options)
            : base(options)
        {
        }


        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;

        public virtual DbSet<CarInfo> Cars{ get; set; } = null!;

        public virtual DbSet<Order> Orders { get; set; } = null!;

        public virtual DbSet<Address> Addresses { get; set; } = null!;

        public virtual DbSet<Package> Packages { get; set; } = null!;
    }
}
