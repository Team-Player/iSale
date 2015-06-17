using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using iSale.Domain.Entities;
using iSale.WebAPI.Models.Response;

namespace iSale.WebAPI.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void Register()
        {
            Mapper.CreateMap<User, UserModel>();
        }
    }
}