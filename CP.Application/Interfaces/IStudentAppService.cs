using CP.Application.Validation;
using CP.Application.ViewModels.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Application.Interfaces
{
    public interface IStudentAppService : IDisposable
    {
        ValidationAppResult RegisterNewStudent(NewStudentViewModel newStudentVeiwModel);

        IEnumerable<GridStudentViewModel> ListGrid();
    }
}
