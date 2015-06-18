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

        UserLogin CreateUserLogin(User user, string loginProvider, string providerKey, string accessToken, string avatar);

        void UpdateUserLogin(User user, string accessToken, string loginProvider, string avatar);

        string CreateAccessToken(User user);

        void DeleteAccessToken(User user, string accesToken);
    }
}
