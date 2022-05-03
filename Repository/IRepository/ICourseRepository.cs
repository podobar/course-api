using CourseAPI.Models;

namespace CourseAPI.Repository
{
    public interface ICourseRepository: IRepository<Course>
    {
        void Update(Course subject);
    }
}
