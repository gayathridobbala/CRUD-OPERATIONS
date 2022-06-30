namespace EmployeeServices.Models
{
    public class UpdateEmployeeRequest
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public decimal Salary { get; set; }
        public string Designation { get; set; }
    }

}

