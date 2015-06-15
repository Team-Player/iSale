using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace iSale.WebAPI.Controllers
{
    public class UserController : Controller
    {
        private IEventRepository repository;

        public UserController(IEventRepository eventRepository)
        {
            this.repository = eventRepository;
        }

        public ViewResult List()
        {
            return View(repository.Users);
        }
    }
}