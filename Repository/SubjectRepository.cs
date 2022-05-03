using CourseAPI.Data;
using CourseAPI.Models;

namespace CourseAPI.Repository
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        private DataContext _context;

        public SubjectRepository(DataContext context) :base(context)
        {
            this._context = context;
        }
        public void Update(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
