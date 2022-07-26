using AutoMapper;
using CarWashApi.DTOs;
using CarWashApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Configurations
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<CreateUserDto, UserProfile>().ReverseMap();
        }
    }
}
