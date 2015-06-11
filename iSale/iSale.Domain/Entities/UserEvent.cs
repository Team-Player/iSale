using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Enums;

namespace iSale.Domain.Entities
{
    public class UserEvent
    {
        public long Id { get; set; }

        public virtual User User { get; set; }

        public virtual Event Event { get; set; }

        public ParticipationStatus Status { get; set; }
    }
}
