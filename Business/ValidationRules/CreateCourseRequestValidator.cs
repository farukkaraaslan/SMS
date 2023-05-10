using Business.Dtos.Requests;
using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules;

public class CreateCourseRequestValidator :AbstractValidator<CreateCourseRequest>
{
    public CreateCourseRequestValidator()
    {
        RuleFor(c => c.Name).NotEmpty().NotNull().MaximumLength(50).MinimumLength(2);
        RuleFor(c => c.Shortname).NotEmpty().NotNull().MaximumLength(50).MinimumLength(2);
        RuleFor(c => c.Credit).NotEmpty().NotNull().GreaterThan(0).GreaterThanOrEqualTo(100);
    }

}
