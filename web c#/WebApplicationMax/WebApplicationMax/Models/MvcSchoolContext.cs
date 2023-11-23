using Microsoft.EntityFrameworkCore;
using WebApplicationMax.Views.Home;

namespace WebApplicationMax.Models
{
    public class MvcSchoolContext : DbContext
    {
        public MvcSchoolContext(DbContextOptions<MvcSchoolContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
