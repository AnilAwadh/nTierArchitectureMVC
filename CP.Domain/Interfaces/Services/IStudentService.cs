using CP.Domain.Entities;
using CP.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain.Interfaces.Services
{
    public interface IStudentService : IDisposable
    {
        ValidationResult AddNewStudent(Student student);
        IEnumerable<Student> GetGrid();
    }
}
