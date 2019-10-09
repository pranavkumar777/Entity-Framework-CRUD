using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF_CRUD.Models
{
   [Table("tblSalary")]
    public class EmployeeSalary
    {
        [Key]
        public string Salary { get; set; }
        
        public EmployeeModel EmployeeId { get; set; }
    }
}