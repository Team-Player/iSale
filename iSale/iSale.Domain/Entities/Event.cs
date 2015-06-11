using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class Event
    {
        public long Id { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public virtual ICollection<UserEvent> UserEvents { get; set; }

        public virtual ICollection<Interest> Interests { get; set; }

        public virtual Location Location { get; set; }

        public virtual ICollection<EventMessage> EventMessages { get; set; }

        public virtual Photo Photo { get; set; }

    }
}
