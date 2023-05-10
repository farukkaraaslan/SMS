using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response;

public class InstructorResponse
{
    public Guid Id { get; set; }
    public string Pbik { get; set; }
    public string? NationalityId { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
}
