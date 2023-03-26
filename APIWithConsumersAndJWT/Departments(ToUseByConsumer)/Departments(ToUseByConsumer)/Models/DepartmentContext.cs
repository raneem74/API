using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Departments_ToUseByConsumer_.Models
{
    public class DepartmentContext : IdentityDbContext<AppUser>
    {

        public DepartmentContext(DbContextOptions<DepartmentContext> options): base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
