using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IInstructorService
{
    Task Add(CreateInstructorRequest createInstructorRequest);

    Task<GetListResponse<InstructorResponse>> GetAll(PageRequest pageRequest);
}
