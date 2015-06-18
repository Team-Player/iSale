using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.Models.Response
{
    public class UserModel
    {
        public long Id { get; set; }

        public string NickName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int Rating { get; set; }

        public string Avatar { get; set; }
    }
}