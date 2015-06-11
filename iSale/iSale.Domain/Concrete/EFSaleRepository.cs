using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSale.Domain.Abstract;
using iSale.Domain.Entities;


namespace iSale.Domain.Concrete
{
    public class EFSaleRepository : ISaleRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}
