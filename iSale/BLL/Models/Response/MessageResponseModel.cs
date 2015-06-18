using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.Models.Response;

namespace BLL.Models.Response
{
    public class MessageResponseModel : BaseResponseModel
    {
        public string Message { get; set; }
    }
}