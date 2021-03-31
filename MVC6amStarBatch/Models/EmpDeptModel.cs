using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC6amStarBatch.Models
{
    public class EmpDeptModel
    {
        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}