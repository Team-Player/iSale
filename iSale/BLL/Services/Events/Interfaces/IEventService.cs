using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using iSale.Domain.Entities;

namespace BLL.Services.Events.Interfaces
{
    public interface IEventService
    {
        Event CreateEvent(User user, EventModel model);

        Event UpdateEvent(User user, EventModel model);
    }
}
