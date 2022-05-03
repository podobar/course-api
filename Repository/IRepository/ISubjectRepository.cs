using CourseAPI.Models;

namespace CourseAPI.Repository
{
    public interface ISubjectRepository: IRepository<Subject>
    {
        void Update(Subject subject);
    }
}
