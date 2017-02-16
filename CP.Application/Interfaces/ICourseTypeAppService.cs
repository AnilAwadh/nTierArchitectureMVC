using CP.Application.Validation;
using CP.Application.ViewModels.Course;
using CP.Application.ViewModels.CourseType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Application.Interfaces
{
    public interface ICourseTypeAppService : IDisposable
    {
        IEnumerable<CourseTypeViewModel> ListAll();
    }
}
