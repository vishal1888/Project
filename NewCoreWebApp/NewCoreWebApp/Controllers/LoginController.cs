using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using NewCoreWebApp.Models;

namespace NewCoreWebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        // GET: Login
        public IActionResult Index()
        {
            //var dataContext = _context.EmployeeLogins.Include(e => e.employee);
            //return View(await dataContext.ToListAsync());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginVerify(EmployeeLogin model)
        {
            if (model.Email == "admin" && model.Password == "admin")
            {
                HttpContext.Session.SetString("email", model.Email);
                return RedirectToAction("Index", "Employees");
            }
            else
            {
                var check = await _context.EmployeeLogins.Where(e => e.Email == model.Email && e.Password == model.Password).FirstOrDefaultAsync();

                if (check != null)
                {
                    HttpContext.Session.SetString("email", model.Email);
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ViewBag.LoginMessage = "Username or Password Incorrect";
                    return View("Index");
                }
            }
        }
        public IActionResult AdminLoginVerify(EmployeeLogin model)
        {
            if (model.Email == "admin" && model.Password == "admin")
            {
                HttpContext.Session.SetString("email", model.Email);
                return RedirectToAction("Index", "Employees");
            }
            else
            {
                ViewBag.LoginMessage = "Username or Password Incorrect";
                return View("Index");
            }
        }
        public IActionResult LoggedIn() // if loggedin successfull redirects to this action method
        {
            ViewBag.email = HttpContext.Session.GetString("email");
            return View();
        }
        public IActionResult Logout() // if loggedin successfull redirects to this action method
        {
            return View("Index");
        }

        public string UpdatePassword(EmployeeLogin emp)
        {
            //int id = _context.EmployeeLogins.Where(e => e.Email == email).Select(i=>i.Id).FirstOrDefault();
            var data = _context.EmployeeLogins.First(a => a.Email == emp.Email);
            data.Password = emp.Password;
            _context.SaveChangesAsync();
            return "New password Updated Successfully";
        }
        // GET: Login/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLogin = await _context.EmployeeLogins
                .Include(e => e.employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeLogin == null)
            {
                return NotFound();
            }

            return View(employeeLogin);
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            ViewData["RefLoginId"] = new SelectList(_context.Employees, "Id", "Id");
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Password,Salary,RefLoginId")] EmployeeLogin employeeLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RefLoginId"] = new SelectList(_context.Employees, "Id", "Id", employeeLogin.RefLoginId);
            return View(employeeLogin);
        }

        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLogin = await _context.EmployeeLogins.FindAsync(id);
            if (employeeLogin == null)
            {
                return NotFound();
            }
            ViewData["RefLoginId"] = new SelectList(_context.Employees, "Id", "Id", employeeLogin.RefLoginId);
            return View(employeeLogin);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Password,Salary,RefLoginId")] EmployeeLogin employeeLogin)
        {
            if (id != employeeLogin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeLoginExists(employeeLogin.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RefLoginId"] = new SelectList(_context.Employees, "Id", "Id", employeeLogin.RefLoginId);
            return View(employeeLogin);
        }

        // GET: Login/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLogin = await _context.EmployeeLogins
                .Include(e => e.employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employeeLogin == null)
            {
                return NotFound();
            }

            return View(employeeLogin);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeLogin = await _context.EmployeeLogins.FindAsync(id);
            _context.EmployeeLogins.Remove(employeeLogin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeLoginExists(int id)
        {
            return _context.EmployeeLogins.Any(e => e.Id == id);
        }
    }
}
