using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<object> GetSubjects()
        {
            return new string[] {"a", "b", "c"};
        }


        [HttpGet]
        public object GetSubject()
        {
            return "a";
        }
    }
}
