using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class StudentsController : ControllerBase
    {
        private IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateStudentRequest createdStudentRequest)
        {
            await studentService.Add(createdStudentRequest);
            return Ok();
        }

        [HttpGet]
        public Task<GetListResponse<StudentResponse>> GetAll([FromQuery] PageRequest pageRequest)
        {
            return studentService.GetAll(pageRequest);
        }
    }
}
