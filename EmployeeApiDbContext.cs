namespace EmployeeServices.Controllers
{
    public class EmployeeApiDbContext
    {
        public object Employee { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        internal void Remove(bool employee) => throw new NotImplementedException();
    }
}