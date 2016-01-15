using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFDataAnnotationColumnAttribute
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFDatabase")
        {

            Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee1> Employees1 { get; set; }
        public DbSet<Employee2> Employees2 { get; set; }
        public DbSet<Employee3> Employees3 { get; set; }
    }


}
