using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Enums;

namespace iSale.Domain.Entities
{
    public class UserFriend
    {
        public long Id { get; set; }

        public virtual User User { get; set; }

        public virtual User Friend { get; set; }

        public FriendStatus Status { get; set; }
    }
}
