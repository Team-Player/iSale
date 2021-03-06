﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class Location
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual Photo Photo { get; set; }
    }
}
