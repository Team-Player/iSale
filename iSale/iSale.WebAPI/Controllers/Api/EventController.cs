using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Helpers;
using BLL.Models;
using BLL.Models.Response;
using BLL.Services.Events;
using BLL.Services.Events.Interfaces;
using BLL.Services.Login;
using BLL.Services.Login.Interfaces;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace iSale.WebAPI.Controllers.Api
{
    public class EventController : ApiController
    {
        private ISaleRepository _repository;
        private IUserSelectionService _userSelectionService;
        private IEventService _eventService;

        public EventController(ISaleRepository repository, IUserSelectionService userSelectionService, IEventService eventService)
        {
            _repository = repository;
            _userSelectionService = new UserSelectionService(_repository);
            _eventService = new EventService(_repository);
        }

        [HttpPost]
        public IHttpActionResult Create(EventModel model)
        {
            var user = _userSelectionService.GetUserByAccessToken(AuthorizationHelper.GetHeaderValue(Request, "Authorization"));
            if (user == null)
                return Ok(new DataResponseModel<string> {Success = 0, Message = "Неверный AccessToken", Data = null});

            Event result = _eventService.CreateEvent(user, model);
            return Ok(new DataResponseModel<Event>{Success = 1, Data = result});
        }

        [HttpPost]
        public IHttpActionResult EditEvent(EventModel model)
        {
            var user = _userSelectionService.GetUserByAccessToken(AuthorizationHelper.GetHeaderValue(Request, "Authorization"));
            if (user == null)
                return Ok(new DataResponseModel<string> {Success = 0, Message = "Неверный AccessToken", Data = null});

            Event result = _eventService.UpdateEvent(user, model);
            return Ok(new DataResponseModel<Event>{Success = 1, Data = result});
        }

        
    }
}
