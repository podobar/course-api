namespace CourseAPI.Repository
{
    public interface IUnitOfWork
    {
        ICourseRepository Course { get; }
        ISubjectRepository Subject { get; }

        void Save();
    }
}
