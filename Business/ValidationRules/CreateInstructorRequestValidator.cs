using Business.Dtos.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules;

public class CreateInstructorRequestValidator : AbstractValidator<CreateInstructorRequest>
{
    public CreateInstructorRequestValidator()
    {
        RuleFor(c => c.Firstname).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50);
        RuleFor(c => c.Lastname).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50);
        RuleFor(c => c.Pbik).Length(7).Must(BeNumericPbik);
        RuleFor(c => c.NationalityId).Length(11).Must(BeNumericNationalityId);
    }
    private bool BeNumericNationalityId(string arg)
    {
        long nationalityId;
        if (long.TryParse(arg, out nationalityId))
        {
            return true; // Dönüşüm başarılı, arg bir sayısal değerdir
        }
        return false; // Dönüşüm başarısız, arg sayısal bir değer değildir
    }
    private bool BeNumericPbik(string arg)
    {
        long pbik;
        if (long.TryParse(arg, out pbik))
        {
            return true; // Dönüşüm başarılı, arg bir sayısal değerdir
        }
        return false; // Dönüşüm başarısız, arg sayısal bir değer değildir
    }
}
