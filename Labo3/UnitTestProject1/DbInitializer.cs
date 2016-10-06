using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace UnitTestProject1
{
   public  class DbInitializer : DropCreateDatabaseAlways<DbContext>
    {
        public void Seed(CompanyContext context)
        {
            Costumer costumer = new Costumer()
            {
                Name = "Albert Dupont",
                AddresseLine1 = "Rue des cerisiers, 16",
                City = "Arlon",
                Country = "Belgique",
                Email = "info@me.com",
                Id = 3,
                Remark = "Ne pas avoir peur des chien pour aller chez ce client",
                PostCode = "6700"

            };
            context.Costumers.Add(costumer);
            context.SaveChanges();
        }
    }
}
