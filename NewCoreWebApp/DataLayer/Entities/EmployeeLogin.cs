using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class EmployeeLogin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; }
        public int RefLoginId { get; set; }
        public Employee employee { get; set; }

    }
}
