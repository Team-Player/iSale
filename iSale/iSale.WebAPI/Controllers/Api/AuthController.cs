using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Services.Login.Interfaces;
using iSale.Domain.Abstract;
using iSale.WebAPI.Models;

namespace iSale.WebAPI.Controllers.Api
{
    public class AuthController : ApiController
    {
        private IUserRegistrationService _userRegistrationService;
        private IEventRepository _repository;

        public AuthController(IUserRegistrationService userRegistrationService, IEventRepository repository)
        {
            _userRegistrationService = userRegistrationService;
            _repository = repository;
        }

        [HttpPost]
        public IHttpActionResult Login(LoginModel model)
        {
            string result = "success";
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Logout()
        {
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult LoginViaSocialNetwork()
        {
            return Ok();
        }

        public IHttpActionResult Register(RegistrationModel model)
        {
            var user = _userRegistrationService.Register(model.Email, model.Password, model.FirstName, model.LastName,
                model.NickName, "");

            return Ok(user);
        }
    }
}
