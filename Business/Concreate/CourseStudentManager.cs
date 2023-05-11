using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Response;
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

public class CourseStudentManager : ICourseStudentService
{
    private ICourseStudentDal courseStudentDal;
    private IMapper mapper;

    public CourseStudentManager(ICourseStudentDal courseStudentDal, IMapper mapper)
    {
        this.courseStudentDal = courseStudentDal;
        this.mapper = mapper;
    }

    [ValidationAspect(typeof(CreateCourseStudentValidatior))]
    public async Task Add(CreateCourseStudentRequest createCourseStudentRequest)
    {
        CourseStudent courseStudent = mapper.Map<CourseStudent>(createCourseStudentRequest);

        await courseStudentDal.AddAsync(courseStudent);
    }

    public async Task<GetListResponse<CourseStudentResponse>> GetAll(PageRequest pageRequest)
    {
        IPaginate<CourseStudent> result= await courseStudentDal.GetListAsync(index:pageRequest.Index,size:pageRequest.Size);

        return mapper.Map<GetListResponse<CourseStudentResponse>>(result);
    }
}
