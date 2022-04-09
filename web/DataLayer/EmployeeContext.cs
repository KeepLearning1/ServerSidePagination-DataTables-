using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using web.Models;

namespace web.DataLayer
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("name=mycon")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}