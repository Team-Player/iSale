using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.Login.Interfaces;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;

namespace BLL.Services.Login
{
    public class UserSelectionService : IUserSelectionService
    {
        private ISaleRepository _repository;

        public UserSelectionService(ISaleRepository repository)
        {
            _repository = repository;
        }

        public User GetUserBySocialNetworkBinding(string loginProvider, string providerKey)
        {
            var user = new User();

            UserLogin userLogin =
                _repository.UserLogins.FirstOrDefault(
                    ul => ul.LoginProvider == loginProvider && ul.ProviderKey == providerKey);

            if (userLogin != null)
            {
                return userLogin.User;
            }

            return null;
        }
    }
}
