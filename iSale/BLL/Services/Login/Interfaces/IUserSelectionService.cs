using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Entities;

namespace BLL.Services.Login.Interfaces
{
    public interface IUserSelectionService
    {
        User GetUserBySocialNetworkBinding(string loginProvider, string providerKey);
    }
}
