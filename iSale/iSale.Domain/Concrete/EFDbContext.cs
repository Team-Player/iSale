using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using iSale.Domain.Entities;

namespace iSale.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
