using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
// added dummy comments

namespace SampleWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly TestContext _context;
        public EmployeeController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            using (TestContext context = new TestContext())
            {
                return context.Employee.ToList();
            }
        }

        [HttpGet("{id}")]
        public IEnumerable<Employee> GetById(int id)
        {
            using (TestContext context = new TestContext())
            {
                return context.Employee.Where(e => e.Id == id).ToList();
            }
        }

        [HttpPut("{id}")]
        public IEnumerable<Employee> UpdateEmployee(int id, Employee emp)
        {
            using (TestContext context = new TestContext())
            {
                var existingemployee = context.Employee.Where(e => e.Id == id).FirstOrDefault<Employee>();
                if (existingemployee != null)
                {
                    existingemployee.Address = emp.Address;
                    existingemployee.Age = emp.Age;
                    existingemployee.name = emp.name;
                    existingemployee.Salary = emp.Salary;
                    existingemployee.Gender = emp.Gender;
                    context.SaveChanges();
                }
                else
                {
                    // return NotFound();
                }
                return context.Employee.Where(e => e.Id == id).ToList();
            }
        }

        [HttpPost]
        public IEnumerable<Employee> AddEmployee(Employee emp)
        {
            using (TestContext context = new TestContext())
            {
                context.Employee.Add(new Employee() { Id = emp.Id, Address = emp.Address, name = emp.name, Age = emp.Age,Gender=emp.Gender, Salary = emp.Salary });
                context.SaveChanges();
                return context.Employee.ToList();
            }
        }
        // DELETE: api/Employee/5

        //public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        [HttpDelete("{id}")]
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            using (TestContext context = new TestContext())
            {
                var existingemployee = context.Employee.Where(e => e.Id == id).FirstOrDefault<Employee>();
                if (existingemployee == null)
                {
                    //return NotFound();
                }
                else
                {
                    context.Employee.Remove(existingemployee);
                    context.SaveChanges();
                }
                return context.Employee.Where(e => e.Id == id).ToList(); 
            }               
        }
    }
}
