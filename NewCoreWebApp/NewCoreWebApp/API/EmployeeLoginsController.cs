using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Entities;

namespace NewCoreWebApp.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeLoginsController : ControllerBase
    {
        private readonly DataContext _context;

        public EmployeeLoginsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeLogins
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeLogin>>> GetEmployeeLogins()
        {
            return await _context.EmployeeLogins.ToListAsync();
        }

        // GET: api/EmployeeLogins/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeLogin>> GetEmployeeLogin(int id)
        {
            var employeeLogin = await _context.EmployeeLogins.FindAsync(id);

            if (employeeLogin == null)
            {
                return NotFound();
            }

            return employeeLogin;
        }

        // PUT: api/EmployeeLogins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeLogin(int id, EmployeeLogin employeeLogin)
        {
            if (id != employeeLogin.Id)
            {
                return BadRequest();
            }

            _context.Entry(employeeLogin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeLoginExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmployeeLogins
        [HttpPost]
        public async Task<ActionResult<EmployeeLogin>> PostEmployeeLogin(EmployeeLogin employeeLogin)
        {
            _context.EmployeeLogins.Add(employeeLogin);
            Console.WriteLine("true");
            await _context.SaveChangesAsync();
        

            return employeeLogin;
        }

        // DELETE: api/EmployeeLogins/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeLogin>> DeleteEmployeeLogin(int id)
        {
            var employeeLogin = await _context.EmployeeLogins.FindAsync(id);
            if (employeeLogin == null)
            {
                return NotFound();
            }

            _context.EmployeeLogins.Remove(employeeLogin);
            await _context.SaveChangesAsync();

            return employeeLogin;
        }

        private bool EmployeeLoginExists(int id)
        {
            return _context.EmployeeLogins.Any(e => e.Id == id);
        }
    }
}
