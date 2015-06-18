using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using iSale.Domain.Entities;

namespace BLL.Services.Events.Interfaces
{
    public interface IUserInterestsService
    {
        void SaveInterests(User user, EditInterestModel model);
    }
}
