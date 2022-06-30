using Microsoft.EntityFrameworkCore;
using trackingapi.Models;

namespace trackingapi.Data
{
    public class EmpApiContext : DbContext
    {
        public EmpApiContext(DbContextOptions<EmpApiContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
