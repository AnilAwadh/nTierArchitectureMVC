using CP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain.Interfaces.Repositories
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        Student GetByCPF(string cpf);
        Student GetByEmail(string email);
        IEnumerable<Student> GetGrid();
    }
}
