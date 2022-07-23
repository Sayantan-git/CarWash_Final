using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Models
{
    public class CarWashContext :DbContext
    {
        public CarWashContext(DbContextOptions options) : base(options) { }
        public DbSet<UserDetails> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<CarInfo> CarInfo { get; set; }
        public DbSet<WasherDetails> washers { get; set; }
    }
}
