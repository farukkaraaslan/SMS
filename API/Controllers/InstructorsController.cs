using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Core.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase

    {
       private IInstructorService instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            this.instructorService = instructorService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest createInstructorRequest)
        {
            await instructorService.Add(createInstructorRequest);
            return Ok(createInstructorRequest);
        }

        [HttpGet]
        public Task<GetListResponse<InstructorResponse>> GetList([FromQuery] PageRequest pageRequest)
        {
            return instructorService.GetAll(pageRequest);
        }
    }
}
