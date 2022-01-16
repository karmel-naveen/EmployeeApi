using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Models
{
    public class EmployeeDetailContext:DbContext
    {
        public EmployeeDetailContext(DbContextOptions<EmployeeDetailContext> options) : base(options)
        {

        }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
