using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TutorialsController : ControllerBase
    {
        private readonly TestContext _context;
        public TutorialsController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Tutorials> Get()
        {
            using (TestContext context = new TestContext())
            {
                return context.Tutorials.ToList();
            }
        }

        [HttpGet("{id}")]
        public int GetById(int id)
        {
            //using (TestContext context = new TestContext())
            //{
                TestContext context = new TestContext();
                //int count = 0;
                var product = context.Tutorials.FromSqlRaw("EXECUTE dbo.sp_GetTutorialDetailsById {0}",id).AsEnumerable();
                int cnt = product.Count();
                return product.Count();
                //return context.Tutorials.Where(e => e.Id == id).ToList();
           // }
        }

        //[HttpPut("{id}")]
        //public IEnumerable<Employee> UpdateEmployee(int id , Employee emp)
        //{
        //    using (TestContext context = new TestContext())
        //    {
        //        var existingemployee = context.Employee.Where(e => e.Id == id).FirstOrDefault<Employee>();
        //        if (existingemployee != null)
        //        {
        //            existingemployee.Address = emp.Address;
        //            existingemployee.Age = emp.Age;
        //            existingemployee.Name = emp.Name;
        //            existingemployee.Salary = emp.Salary;
        //            context.SaveChanges();
        //        }
        //        else
        //        {
        //           // return NotFound();
        //        }

        //        return context.Employee.Where(e => e.Id == id).ToList();
        //    }
        //}

        [HttpPost]
        public IEnumerable<Tutorials> AddTutorial(Tutorials tut)
        {
            using (TestContext context=new TestContext())
            {
                context.Tutorials.Add(new Tutorials() { Id=tut.Id , Title=tut.Title, Description=tut.Description});
                context.SaveChanges();
                return context.Tutorials.ToList(); ;
            }           
        }

        // DELETE: api/Employee/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        //{
        //    var employee = await _context.Employee.FindAsync(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Employee.Remove(employee);
        //    await _context.SaveChangesAsync();

        //    return employee;
        //}
        
    }
}
