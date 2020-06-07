using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCoreWebApp.Models
{
    public class DbManager
    {
        private readonly DataContext _context;

        public DbManager(DataContext context)
        {
            _context = context;
        }
        
        public int GetDepartmentId(string depName)
        {
            //gets deptID corresponds to DepartmentName I am recieving 
            int getId = _context.Departments.Where(e => e.DepartmentName == depName).Select(id => id.DepartmentId).First();
            return getId;
        }
        public string GetDepartmentName(Employee emp)
        {
            var getDepartmentName = _context.Departments.Where(d => d.DepartmentId ==emp.deptId).Select(n => n.DepartmentName).First();
            return getDepartmentName;
        }

        public IEnumerable<Employee> GetEmployeeData()
        {
            var employee = _context.Employees.Include(e => e.department);
            return employee;
        }
        public async Task<Employee> GetDataWithId(int? id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return employee;
        }

        public IEnumerable<Department> Dept()
        {
            var dept = _context.Departments;
            return dept.ToList();
        }
        public IEnumerable<State> States()
        {
            var state = _context.States;
            return state.ToList();
        }
        public void Add(Employee emp)
        {
            _context.Add(emp);
          
        }
        public Employee GetDataForEditWithId(int id)
        {
            var emp=_context.Employees.First(a => a.Id == id);
            return emp;
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Delete(Employee emp)
        {
            _context.Employees.Remove(emp);
        }
       
        public IEnumerable<City> Cities()
        {
            var city = _context.City;
            return city.ToList();
        }
        public IEnumerable<EmployeeLogin> EmpLogin()
        {
            var login = _context.EmployeeLogins;
            return login.ToList();
        }
        public EmployeeLogin AddLogins(EmployeeLogin emp)
        {
            _context.EmployeeLogins.Add(emp);
            _context.SaveChangesAsync();

            return emp;
        }

    }
}
