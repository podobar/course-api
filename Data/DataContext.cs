using CourseAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseAPI.Data
{
    public class DataContext: DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
