using CP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain.Interfaces.Services
{
    public interface ICourseTypeService : IDisposable
    {
        IEnumerable<CourseType> GetAll();
        IEnumerable<CourseType> Lists();
        CourseType GetById(Guid id);
    }
}
