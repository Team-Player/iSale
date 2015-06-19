using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Models;
using BLL.Services.Events.Interfaces;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace BLL.Services.Events
{
    public class EventService : IEventService
    {
        private ISaleRepository _repository;

        public EventService(ISaleRepository repository)
        {
            _repository = repository;
        }

        public Event CreateEvent(User user, EventModel model)
        {
            Event newEvenet = Mapper.Map<Event>(model);

            return new Event();
        }

        public Event UpdateEvent(User user, EventModel model)
        {
            return new Event();
        }
    }
}
