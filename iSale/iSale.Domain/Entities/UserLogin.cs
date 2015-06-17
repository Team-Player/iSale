using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class UserLogin
    {
        public long Id { get; set; }

        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }

        public string AccessToken { get; set; }

        public virtual User User { get; set; }
    }
}
