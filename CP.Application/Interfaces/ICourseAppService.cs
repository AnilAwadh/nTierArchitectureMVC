using CP.Application.Validation;
using CP.Application.ViewModels.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Application.Interfaces
{
    public interface ICourseAppService : IDisposable
    {
        ValidationAppResult RegisterNewCourse(NewCourseViewModel newCourseViewModel);
        ValidationAppResult EditCourse(EditionCourseViewModel courseViewModel);
        EditionCourseViewModel GetToEdit(Guid cursoId);
        IEnumerable<GridCourseViewModel> ListGrid();
    }
}
