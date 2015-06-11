using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class Photo
    {
        public long Id { get; set; }

        public virtual Event Event { get; set; }

        public virtual Location Location { get; set; }
    }
}
