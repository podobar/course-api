using CourseAPI.Data;

namespace CourseAPI.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private DataContext _dataContext;
        public UnitOfWork(DataContext context)
        {
            this._dataContext = context;
            this.Course = new CourseRepository(this._dataContext);
            this.Subject = new SubjectRepository(this._dataContext);
        }
        public ICourseRepository Course { get; private set; }

        public ISubjectRepository Subject { get; private set; }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
