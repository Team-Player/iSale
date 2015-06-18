using System.Collections;
using iSale.Domain.Entities;

namespace iSale.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<iSale.Domain.Concrete.EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(iSale.Domain.Concrete.EFDbContext context)
        {
            context.Interests.AddOrUpdate(i => i.Id,
                new Interest {Id = 1, Title = "������"},
                new Interest {Id = 2, Title = "�������"},
                new Interest { Id = 3, Title = "�������"},
                new Interest { Id = 4, Title = "����"}
                );
            
        }
    }
}
