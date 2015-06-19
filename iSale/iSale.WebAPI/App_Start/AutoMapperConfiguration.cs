using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BLL.Models;
using BLL.Models.Response;
using iSale.Domain.Entities;
using Interest = iSale.Domain.Entities.Interest;

namespace iSale.WebAPI.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void Register()
        {
            Mapper.CreateMap<User, UserModel>();
            Mapper.CreateMap<Interest, InterestModel>();
            Mapper.CreateMap<Event, EventModel>();
        }
    }
}