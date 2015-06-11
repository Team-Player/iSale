using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Entities;

namespace iSale.Domain.Abstract
{
    public interface ISaleRepository
    {
        IEnumerable<User> Users { get; }
    }
}
