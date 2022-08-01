using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.DTOs.UserProfile
{
    public class UpdateUserDto :BaseUserDto
    {
        public string UserName { get; set; } = null!;
        public string UserPhnumber { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
    }
}
