using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.Models
{
    public class EditInterestModel : SecurityModel
    {
        public List<Interest> Interests { get; set; }
    }

    public class Interest
    {
        public long Id { get; set; }
    }
}