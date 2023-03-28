using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_codefirst__EFDemo
{

    class mydbcontext:DbContext
    {
        public mydbcontext() : base("MyDbConn")
        {
            Database.SetInitializer<mydbcontext>(new CreateDatabaseIfNotExists<mydbcontext>());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
