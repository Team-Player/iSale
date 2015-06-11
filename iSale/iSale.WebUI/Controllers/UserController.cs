using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace iSale.WebUI.Controllers
{
    public class UserController : Controller
    {
        private ISaleRepository repository;

        public UserController(ISaleRepository userRepository)
        {
            this.repository = userRepository;
        }

        public ViewResult List()
        {
            return View(repository.Users);
        }
    }
}