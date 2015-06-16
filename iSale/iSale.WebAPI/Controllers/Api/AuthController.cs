using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Services.Login.Interfaces;
using BLL.SocialNetwork;
using iSale.Domain.Abstract;
using iSale.WebAPI.Models;

namespace iSale.WebAPI.Controllers.Api
{
    public class AuthController : ApiController
    {
        private IUserRegistrationService _userRegistrationService;
        private IUserSelectionService _userSelectionService;
        private ISaleRepository _repository;

        public AuthController(IUserRegistrationService userRegistrationService, IUserSelectionService userSelectionService, ISaleRepository repository)
        {
            _userRegistrationService = userRegistrationService;
            _userSelectionService = userSelectionService;
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
        public IHttpActionResult LoginViaSocialNetwork(LoginSocialNetworkModel model)
        {
            var socialAccountProvider = SocialAccountProviderFactory.GetProvider(model.LoginProvider);
            string providerAccesssToken = socialAccountProvider.GetAccessToken(model.AccessCode);

            var user = _userSelectionService.GetUserBySocialNetworkBinding(model.LoginProvider, model.ProviderKey);
            if (user == null)
            {
                //user = _userRegistrationService.Register(model.Email, model.Password, model.FirstName, model.LastName, model.NickName, "");
            }

            return Ok();
        }

        public IHttpActionResult Register(RegistrationModel model)
        {
            var user = _userRegistrationService.Register(model.Email, model.Password, model.FirstName, model.LastName,
                model.NickName, "");

            return Ok(user.AccessTokens.FirstOrDefault());
        }
    }
}
