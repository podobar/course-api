using CourseAPI.Data;
using CourseAPI.Models;

namespace CourseAPI.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private DataContext _context;
        public CourseRepository(DataContext context): base(context)
        {
            _context = context;
        }
        public void Update(Course subject)
        {
            throw new NotImplementedException();
        }
    }
}
