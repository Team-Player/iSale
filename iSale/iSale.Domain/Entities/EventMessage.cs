using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class EventMessage
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual User User { get; set; }

        public virtual Event Event { get; set; }

    }
}
