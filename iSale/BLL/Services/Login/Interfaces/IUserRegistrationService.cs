using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Entities;

namespace BLL.Services.Login.Interfaces
{
    public interface IUserRegistrationService
    {
        User Register(string email, string password, string firstName, string lastName, string nickName,
            string middleName);

        UserLogin CreateUserLogin(long userId, string loginProvider, string providerKey);
    }
}
