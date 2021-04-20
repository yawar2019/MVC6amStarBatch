using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adonet.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        [ScaffoldColumn(false)]
        public bool status { get; set; }

    }
}