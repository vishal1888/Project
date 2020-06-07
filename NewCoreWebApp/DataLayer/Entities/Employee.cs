using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Employee
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime JoiningDate { get; set; }
        public int deptId { get; set; }
        public Department department { get; set; }
        public EmployeeLogin empLogin { get; set; }
    }
}
