using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class Interest
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
