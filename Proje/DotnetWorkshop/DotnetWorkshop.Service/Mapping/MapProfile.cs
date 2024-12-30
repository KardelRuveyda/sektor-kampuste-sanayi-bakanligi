using AutoMapper;
using DotnetWorkshop.Core.DTOs;
using DotnetWorkshop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();


            //Dto'dan Entity'e çevirmek istersem;
            CreateMap<TeamDto, Team>();
            CreateMap<UserDto, User>();
            CreateMap<UserProfileDto, UserProfile>();
        }
    }
}
