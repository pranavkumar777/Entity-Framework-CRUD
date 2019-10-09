using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_CRUD.Models
{
    public class EmployeeContext :DbContext
    {
        public EmployeeContext(): base("name=EmployeeConnection")
        {
        }
        public DbSet<EmployeeModel> EmployeeTable { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalary { get; set; }
    }
}