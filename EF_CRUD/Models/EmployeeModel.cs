
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CRUD.Models
{
    [Table("tblEmployee")] //represents the employee table maps with employeemodel
    public class EmployeeModel 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Nullable <int> EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeMobile { get; set; }
        public string EmployeeCity { get; set; }

    }
}