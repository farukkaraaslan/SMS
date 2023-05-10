using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Response;
using Business.Dtos.Responses;
using Core.Paging;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles;

public class MappingProfiles:Profile
{
	public MappingProfiles()
	{
		CreateMap<Student,CreateStudentRequest>().ReverseMap();
		CreateMap<Student,StudentResponse>().ReverseMap();	
		CreateMap<IPaginate<Student>,GetListResponse<StudentResponse>>().ReverseMap();

		CreateMap<Instructor,CreateInstructorRequest>().ReverseMap();
		CreateMap<Instructor, InstructorResponse>().ReverseMap();
		CreateMap<IPaginate<Instructor>,GetListResponse<InstructorResponse>>().ReverseMap();


		CreateMap<Course,CreateCourseRequest>().ReverseMap();
		CreateMap<Course,CourseResponse>().ReverseMap();
		CreateMap<IPaginate<Course>,GetListResponse<CourseResponse>>().ReverseMap();

        CreateMap<CourseStudent, CreateCourseStudentRequest>().ReverseMap();
        CreateMap<CourseStudent,CourseStudentResponse>().ReverseMap();
        CreateMap<IPaginate<CourseStudent>,GetListResponse<CourseStudentResponse>>().ReverseMap();

	}
}
