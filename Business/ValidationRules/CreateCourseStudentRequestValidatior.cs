using Business.Dtos.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CreateCourseStudentRequestValidatior: AbstractValidator<CreateCourseStudentRequest>
    {
        public CreateCourseStudentRequestValidatior()
        {
            RuleFor(c=> c.StudentId).NotEmpty().NotNull();
            RuleFor(c=> c.CourseId).NotEmpty().NotNull();
        }
    }
}
