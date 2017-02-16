using CP.Domain.Interfaces.Repositories;
using CP.Domain.Entities;
using CP.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Data.Repositories
{
    public class CourseTypeRepository : RepositoryBase<CourseType>, ICourseTypeRepository
    {
        public CourseTypeRepository(CPContext dbContext)
            : base(dbContext)
        {

        }

        public IEnumerable<CourseType> Listar()
        {
            return GetAllReadOnly();
        }
    }
}
