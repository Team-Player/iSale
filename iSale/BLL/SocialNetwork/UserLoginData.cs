using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SocialNetwork
{
    public class UserLoginData
    {
        public string ProviderKey { get; set; }

        public string Email { get; set; }

        public string AccessToken { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
