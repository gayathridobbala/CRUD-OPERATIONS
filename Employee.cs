using System.ComponentModel.DataAnnotations;

namespace trackingapi.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public decimal Salary { get; set; }
        public string Designation { get; set; }
    }
}
