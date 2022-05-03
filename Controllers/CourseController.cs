using CourseAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<object> GetCourses()
        {
            return new string[] { "d", "e", "f" };
        }       


        [HttpGet]
        public object GetCourse()
        {
            return "d";
        }
        
        


    }
}
