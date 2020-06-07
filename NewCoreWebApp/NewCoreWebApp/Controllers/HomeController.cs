using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewCoreWebApp.Models;

namespace NewCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly DbManager _context1;
        public HomeController(DbManager context)
        {
            _context1 = context;
        }

        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee emp)
        {
            Employee getemp= await _context1.GetDataWithId(emp.Id);
            var depname = _context1.GetDepartmentName(getemp);
            _context1.Add(emp);
            _context1.Save();
            ViewBag.success = "Success";
            ViewBag.depname = depname;
            return View(emp);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
