using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using Business.ValidationRules;
using Core.Aspects.Validation;
using Core.Paging;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate;

public class StudentManager : IStudentService
{
    private IstudentDal studentdal;
    private IMapper mapper;

    public StudentManager(IstudentDal studentdal, IMapper mapper)
    {
        this.studentdal = studentdal;
        this.mapper = mapper;
    }

    [ValidationAspect(typeof(CreateStudentRequestsValidator))]
    public async Task Add(CreateStudentRequest createStudentRequest)
    {
        Student student = mapper.Map<Student>(createStudentRequest);
        student.StudentNumber = "202301015001";
        await studentdal.AddAsync(student);
    }

    public async Task<GetListResponse<StudentResponse>> GetAll(PageRequest pagerequest)
    {
        IPaginate<Student> result =await studentdal.GetListAsync(index:pagerequest.Index,size:pagerequest.Size);
        return  mapper.Map<GetListResponse<StudentResponse>>(result);
    }
}
