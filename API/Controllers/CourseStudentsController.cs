using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseStudentsController : ControllerBase
    {
        private ICourseStudentService courseStudentService;

        public CourseStudentsController(ICourseStudentService courseStudentService)
        {
            this.courseStudentService = courseStudentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseStudentRequest createCourseStudentRequest)
        {
            await courseStudentService.Add(createCourseStudentRequest);
            return Ok();
        }

        [HttpGet]

        public async Task<GetListResponse<CourseStudentResponse>> GelAll([FromQuery]PageRequest pageRequest)
        {
            return await courseStudentService.GetAll(pageRequest);
        }
    }
}
