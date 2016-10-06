using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1 
{
    public class CompanyContext : DbContext
    {
        public DbSet<Costumer> Costumers { get; set; }
        public CompanyContext()
            : base(@"Data Source=(localdb)\MSSQLLOCALDb; Initial Catalog=ConcurrencyDemo;")
        {

        }

    }
}
