using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Login.Interfaces;
using BLL.Services.Shared;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace BLL.Services.Login
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private ISaleRepository _repository;

        public UserRegistrationService(ISaleRepository repository)
        {
            _repository = repository;
        }

        public User Register(string email, string password, string firstName, string lastName, string nickName, string middleName)
        {
            if (!string.IsNullOrEmpty(email))
            {
                email = email.Trim().ToLower();
            }

            var user = new User()
            {
                Email = email,
                RegistrationDate = DateTime.Now,
                FirstName = firstName,
                LastName = lastName,
                NickName = nickName
            };

            user.AccessTokens = new List<AccessToken>();
            user.AccessTokens.Add(new AccessToken{Key = new RandomStringGenerator().Generate()});

            _repository.SaveUser(user);
            return user;
        }

        public UserLogin CreateUserLogin(User user, string loginProvider, string providerKey, string accessToken, string avatar)
        {
            UserLogin usrLogin = new UserLogin()
            {
                AccessToken = accessToken,
                LoginProvider = loginProvider,
                ProviderKey = providerKey,
                User = user,
                Avatar = avatar
            };

            _repository.AddUserLogin(usrLogin);

            return usrLogin;
        }

        public string CreateAccessToken(User user)
        {
            string accToken = new RandomStringGenerator().Generate();
            AccessToken accessToken = new AccessToken{Key = accToken, User = user};
            
            _repository.CreateAccessToken(accessToken, user);

            return accToken;
        }

        public void DeleteAccessToken(User user, string accesToken)
        {
            AccessToken currAccesToken = user.AccessTokens.FirstOrDefault(at => at.Key == accesToken);
            if (currAccesToken != null)
            {
                _repository.DeleteAccessToken(currAccesToken);
            }
        }

        public void UpdateUserLogin(User user, string accessToken, string loginProvider, string avatar)
        {
            var userLogin = user.UserLogins.FirstOrDefault(ul => ul.LoginProvider == loginProvider);
            if (userLogin != null)
            {
                _repository.UpdateUserLogin(accessToken, userLogin, avatar);
            }
        }
    }
}
