using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IStudentService
{
    Task Add(CreateStudentRequest createStudentRequest);
    Task<GetListResponse<StudentResponse>> GetAll(PageRequest pageRequest);
}
