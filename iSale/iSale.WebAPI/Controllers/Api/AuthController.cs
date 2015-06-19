using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using AutoMapper;
using BLL.Helpers;
using BLL.Models;
using BLL.Models.Response;
using BLL.Services.Login;
using BLL.Services.Login.Interfaces;
using BLL.SocialNetwork;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace iSale.WebAPI.Controllers.Api
{
    public class AuthController : ApiController
    {
        private IUserRegistrationService _userRegistrationService;
        private IUserSelectionService _userSelectionService;
        private ISaleRepository _repository;

        public AuthController(IUserRegistrationService userRegistrationService, IUserSelectionService userSelectionService, ISaleRepository repository)
        {
            ;
             //userSelectionService;
            _repository = repository;
            _userSelectionService = new UserSelectionService(_repository);
            _userRegistrationService = new UserRegistrationService(_repository); //userRegistrationService
        }

        [HttpPost]
        public IHttpActionResult Login(LoginModel model)
        {
            string result = "success";
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Logout(SecurityModel model)
        {
            var currentUser = _userSelectionService.GetUserByAccessToken(AuthorizationHelper.GetHeaderValue(Request, "Authorization"));
            if (currentUser == null)
                return Ok(new DataResponseModel<string> {Message = "Неверный AccessToken", Success = 0});
            
            _userRegistrationService.DeleteAccessToken(currentUser, model.AccessToken);
            return Ok(new DataResponseModel<string> { Message = "Вы успешно вышли", Success = 1 });
        }

        [HttpPost]
        public IHttpActionResult LoginViaSocialNetwork(LoginSocialNetworkModel model)
        {
            var socialAccountProvider = SocialAccountProviderFactory.GetProvider(model.LoginProvider);
            UserLoginData userData = socialAccountProvider.GetUserData(model.AccessCode);
            
            string accessToken = string.Empty;

            var user = _userSelectionService.GetUserBySocialNetworkBinding(model.LoginProvider, userData.ProviderKey);
            if (user == null)
            {
                user = _userRegistrationService.Register(userData.Email, model.Password, userData.FirstName, userData.LastName, model.NickName, "");
                UserLogin userLogin = _userRegistrationService.CreateUserLogin(user, model.LoginProvider,
                    userData.ProviderKey, userData.AccessToken, userData.Avatar);
                accessToken = user.AccessTokens.FirstOrDefault().Key;
            }
            else
            {
                accessToken = _userRegistrationService.CreateAccessToken(user);
                _userRegistrationService.UpdateUserLogin(user, userData.AccessToken, model.LoginProvider, userData.Avatar);
            }

            var userModel = Mapper.Map<UserModel>(user);
            userModel.Avatar = userData.Avatar;
            userModel.AccessToken = accessToken;
            return Ok(new DataResponseModel<UserModel> {Success = 1, Data = userModel});
        }

        public IHttpActionResult Register(RegistrationModel model)
        {
            var user = _userRegistrationService.Register(model.Email, model.Password, model.FirstName, model.LastName,
                model.NickName, "");

            return Ok(user.AccessTokens.FirstOrDefault());
        }
    }
}
