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

public class CourseManager : ICourseService
{
    private ICourseDal courseDal;
    private IMapper mapper;

    public CourseManager(ICourseDal courseDal, IMapper mapper)
    {
        this.courseDal = courseDal;
        this.mapper = mapper;
    }
    [ValidationAspect(typeof(CreateCourseRequestValidator))]
    public async Task Add(CreateCourseRequest createCourseRequest)
    {
        Course course =new Course();

        course.Name = createCourseRequest.Name;
        course.Shortname = createCourseRequest.Shortname;
        course.Credit = createCourseRequest.Credit;

         await  courseDal.AddAsync(course);
    }

    public async Task<GetListResponse<CourseResponse>> GetAll(PageRequest pageRequest)
    {
        IPaginate<Course> result = await courseDal.GetListAsync(index:pageRequest.Index,size:pageRequest.Size);
        return mapper.Map<GetListResponse<CourseResponse>>(result);

    }
}

