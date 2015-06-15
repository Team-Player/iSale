using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSale.Domain.Entities
{
    public class Photo
    {
        public long Id { get; set; }

        [Required]
        public virtual Event Event { get; set; }

        [Required]
        public virtual Location Location { get; set; }
    }
}
