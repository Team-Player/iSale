using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BLL.Models.Response;
using iSale.Domain.Entities;

namespace iSale.WebAPI.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void Register()
        {
            Mapper.CreateMap<User, UserModel>();
            Mapper.CreateMap<Interest, InterestModel>();
        }
    }
}