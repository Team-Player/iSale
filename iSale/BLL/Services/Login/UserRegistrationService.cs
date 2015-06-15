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
    public class UserRegistrationService : IUserRegistrationService
    {
        private IEventRepository _repository;

        public UserRegistrationService(IEventRepository repository)
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

            return user;
        }
    }
}
