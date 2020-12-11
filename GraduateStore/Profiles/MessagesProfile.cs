using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GraduateStore.Dtos;
using GraduateStore.Models;


namespace GraduateStore.Profiles
{
    public class MessagesProfile : Profile
    {
        public MessagesProfile()
        {
            CreateMap<User, UserLoginDto>();
        }
    }
}
