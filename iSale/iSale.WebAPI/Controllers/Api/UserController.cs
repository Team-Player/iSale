using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using BLL.Helpers;
using BLL.Models;
using BLL.Models.Response;
using BLL.Services.Events;
using BLL.Services.Events.Interfaces;
using BLL.Services.Login;
using BLL.Services.Login.Interfaces;
using iSale.Domain.Abstract;
using Interest = iSale.Domain.Entities.Interest;

namespace iSale.WebAPI.Controllers.Api
{
    public class UserController : ApiController
    {
        private ISaleRepository _repository;
        private IUserRegistrationService _userRegistrationService;
        private IUserSelectionService _userSelectionService;
        private IUserInterestsService _userInterestsService;

        public UserController(ISaleRepository repository, IUserSelectionService userSelectionService, IUserRegistrationService userRegistrationService, IUserInterestsService userInterestsService)
        {
            _repository = repository;
            _userRegistrationService = new UserRegistrationService(_repository);
            _userSelectionService = new UserSelectionService(_repository);
            _userInterestsService = new UserInterestsService(_repository);
        }

        [HttpPost]
        public IHttpActionResult EditUser()
        {
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult EditUserInterests(EditInterestModel model)
        {
            var user = _userSelectionService.GetUserByAccessToken(AuthorizationHelper.GetHeaderValue(Request, "Authorization"));
            if (user == null)
                return Ok(new DataResponseModel<string> {Success = 0, Message = "Неверный Accesstoken"});
                
            _userInterestsService.SaveInterests(user, model);

            return Ok(new DataResponseModel<string> {Success = 1, Message = "Интересы успешно сохранены"});
        }
        
        [HttpPost]
        public IHttpActionResult GetUserInterests()
        {
            var user = _userSelectionService.GetUserByAccessToken(AuthorizationHelper.GetHeaderValue(Request, "Authorization"));
            if (user == null)
                return Ok(new DataResponseModel<string> {Success = 0, Message = "Неверный AccessToken"});

            List<InterestModel> result = Mapper.Map<List<Interest>, List<InterestModel>>(user.Interests.ToList());

            return Ok(new DataResponseModel<List<InterestModel>>{Data = result, Success = 1});
        }

        [HttpGet]
        public IHttpActionResult GetInterests()
        {
            List<InterestModel> result = Mapper.Map<List<Interest>, List<InterestModel>>(_repository.Interests.ToList());
            return Ok(new DataResponseModel<List<InterestModel>>{Success = 1, Data = result});
        }
    }
}
