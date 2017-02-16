using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Domain.Interfaces.Validation
{
    public interface IRule<in TEntity>
    {
        string MessageError { get; }
        bool Validate(TEntity entity);
    }
}
