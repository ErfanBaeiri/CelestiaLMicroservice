using AutoMapper;
using IDP.Application.Command.Auth;
using IDP.Application.Command.User;
using IDP.Domain.Entites;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Application.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<AuthCommand, User>().ReverseMap();
           
        }
    }

}
