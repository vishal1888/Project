using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
   public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> employees { get; set; }
    }
}
