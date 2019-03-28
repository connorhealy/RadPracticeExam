using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadPracticeExam
{
    class BusinessDbContextInitializer : DropCreateDatabaseIfModelChanges<BusinessDbContext>
    {
        public BusinessDbContextInitializer()
        {

        }

        protected override void Seed(BusinessDbContext context)
        {
            context.Orders.AddOrUpdate(new Orders[]
            {
                new Orders{ Total = 10000, OrderDate = new DateTime(1965,12,02) },
                new Orders{ Total = 20000, OrderDate = new DateTime(1985,10,22) },
                new Orders{ Total = 40000, OrderDate = new DateTime(1995,12,12) },
            });
          
            base.Seed(context);
        }
    }
}
