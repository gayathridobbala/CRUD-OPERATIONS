using Microsoft.AspNetCore.Mvc;
using trackingapi.Models;

namespace EmployeeServices.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeApiDbContext dbContext;

        public object EmployeeFirstName { get; private set; }
        public object EmployeeLastName { get; private set; }
        public object Salary { get; private set; }
        public object Designation { get; private set; }

        public EmployeeController(EmployeeApiDbContext dbcontext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployee() => Ok(dbContext.Employee.ToString());
        private IActionResult Ok(object value)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(AddEmployeeRequest addEmployeeRequest)
        {
            var employee = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                EmployeeFirstName = addEmployeeRequest.EmployeeFirstName,
                EmployeeLastName = addEmployeeRequest.EmployeeLastName,
                Salary = addEmployeeRequest.Salary,
                Designation = addEmployeeRequest.Designation
            };
            dbContext.Employee.Equals(employee);
            await dbContext.SaveChangesAsync();
            return Ok(employee);

        }

        [HttpDelete]
        [Route("(id:guid)")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            var Employee = dbContext.Employee.Equals(id);
            if(Employee!= null)
            {
                dbContext.Remove(Employee);
                await dbContext.SaveChangesAsync();
                return Ok(Employee);
            }
            return NotFound();
        }


        [HttpPut]
        [Route("(id:guid)")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id )
        {
            var Employee = dbContext.Employee.Equals(id);
            if (Employee != null)
            {
                EmployeeFirstName = UpdateEmployeeRequest.EmployeeFirstName;
                EmployeeLastName = UpdateEmployeeRequest.EmployeeLastName;
                Salary = UpdateEmployeeRequest.Salary;
                Designation = UpdateEmployeeRequest.Designation;
                
                await dbContext.SaveChangesAsync();
                return Ok(Employee);
            }
            return NotFound();
        }



    }
}
