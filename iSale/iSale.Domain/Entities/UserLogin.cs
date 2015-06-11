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

        public User User { get; set; }
    }
}
