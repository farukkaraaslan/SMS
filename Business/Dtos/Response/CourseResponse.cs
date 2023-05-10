using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response;

public class CourseResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Shortname { get; set; }
    public int Credit { get; set; }


}
