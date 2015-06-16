using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class AccessToken
    {
        public long Id { get; set; }

        public string Key { get; set; }

        public virtual User User { get; set; }

    }
}
