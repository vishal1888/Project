using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Entities;
using NewCoreWebApp.Models;
using System.Net;
using System.Net.Mail;

namespace NewCoreWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DbManager _context;

        public EmployeesController(DbManager context)
        {
            _context = context;
        }

        // GET: Employees
        public IActionResult Index()
        {
            var d = _context.GetEmployeeData().Select(e => new EmployeeModel
            {
                Name = e.Name,
                Email = e.Email,
                Dob = e.Dob,
                State = e.State,
                Address = e.Address,
                City = e.City,
                Id = e.Id,
                Zip = e.Zip,
                Phone = e.Phone,
                JoiningDate = e.JoiningDate,
                DepartmentName = e.department.DepartmentName
            }).ToList();
            return View(d);

        }

        // GET: Employees/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var employee = await _context.Employees
        //        .Include(e => e.department)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employee);
        //}

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["deptId"] = new SelectList(_context.Dept(), "DepartmentName", "DepartmentName");
            ViewData["state"] = new SelectList(_context.States(), "StateName", "StateName");
            return View();
        }

        // POST: Employees/Create
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Dob,Phone,Email,Address,State,City,Zip,JoiningDate,DepartmentName")] EmployeeModel employee)
        {
            //gets deptID corresponds to DepartmentName I am recieving 
            int getId = _context.GetDepartmentId(employee.DepartmentName);
                if (employee != null)
                {
                Employee emp = new Employee();
                ViewData["deptId"] = new SelectList(_context.Dept(), "DepartmentId", "DepartmentId", emp.deptId);
                emp.Name = employee.Name;
                emp.Dob = employee.Dob;
                emp.Email = employee.Email;
                emp.Address = employee.Address;
                emp.Phone = employee.Phone;
                emp.deptId = getId;
                emp.State = employee.State;
                emp.City = employee.City;
                emp.Zip = employee.Zip;
                emp.JoiningDate = employee.JoiningDate;
                _context.Add(emp);
                await _context.Save();
            }
            return RedirectToAction(nameof(Index)); 
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.GetDataWithId(id);
            //getting department name for sending to edit modal as i have deptId but i am showing deptName .
            var getDepartmentName = _context.GetDepartmentName(employee);
            var editEmployee = new EmployeeModel();
            editEmployee.Id = employee.Id;
            editEmployee.Name = employee.Name;
            editEmployee.Dob = employee.Dob;
            editEmployee.Email = employee.Email;
            editEmployee.Phone = employee.Phone;
            editEmployee.Address = employee.Address;
            editEmployee.DepartmentName = getDepartmentName;
            editEmployee.State = employee.State;
            editEmployee.City = employee.City;
            editEmployee.Zip = employee.Zip;
            editEmployee.JoiningDate = employee.JoiningDate;

            if (editEmployee == null)
            {
                return NotFound();
            }
            ViewData["deptId"] = new SelectList(_context.Dept(), "DepartmentName", "DepartmentName");
            ViewData["state"] = new SelectList(_context.States(), "StateName", "StateName");
            return View(editEmployee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Dob,Phone,Email,Address,State,City,Zip,JoiningDate,DepartmentName")] EmployeeModel employee)
        {
            int getId = _context.GetDepartmentId(employee.DepartmentName);
            var emp = _context.GetDataForEditWithId(id);
            if (id != emp.Id)
            {
                return NotFound();
            }
            if(employee != null)
            {
                emp.Name = employee.Name;
                emp.Dob = employee.Dob;
                emp.Phone = employee.Phone;
                emp.Email = employee.Email;
                emp.Address = employee.Address;
                emp.State = employee.State;
                emp.City = employee.City;
                emp.Zip = employee.Zip;
                emp.JoiningDate = employee.JoiningDate;
                emp.deptId = getId;
                    await _context.Save();
                
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!EmployeeExists(employee.Id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public IActionResult Delete(int id)
        {
            
            var employee = _context.GetDataForEditWithId(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.GetDataWithId(id);
            _context.Delete(employee);
            await _context.Save();
            return RedirectToAction(nameof(Index));
        }

        //private bool EmployeeExists(int id)
        //{
        //    return _context.Employees.Any(e => e.Id == id);
        //}

        public JsonResult GetCity(int id)
        {
            var city = _context.Cities().Where(i => i.StateId == id).Select(n => n.CityName).ToList();

            return Json(city);
        }

        public JsonResult GetLoginDetails(int id)
        {
            var data = _context.GetEmployeeData().Where(i => i.Id == id).Select(x=> new Employee {
                Id=x.Id,
                Name=x.Name,
                Dob=x.Dob,
                Email=x.Email
            }).Single();

            return Json(data);
        }

        public void AddLogins(EmployeeLogin login)
        {
            _context.AddLogins(login);
          
        }

        public string SendEmail(string Email, string Password)
        {
            try
            {
                string Message = "Welcome to Organization";
                // Credentials
                var credentials = new NetworkCredential("guptavishal1888@gmail.com", "vishaldik@1");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("noreply@codinginfinite.com"),
                    Subject = "EManager - Employee Login Credentials",
                    Body = "<html><body><h1>EManager</h1><p>"+ Message + "</p><p>Your Email : " + Email + "<p>Password : " +Password+"</p></body></html>"
                };
                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(Email));
                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }

        }

    }
}
