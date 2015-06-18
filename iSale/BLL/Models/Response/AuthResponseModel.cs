using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.Models.Response
{
    public class AuthResponseModel : BaseResponseModel
    {
        public UserModel User { get; set; }

        public string AccessToken { get; set; }
    }
}