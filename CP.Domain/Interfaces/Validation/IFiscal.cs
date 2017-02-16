using CP.Domain.Validation.Base;
using CP.Domain.ValueObjects;

namespace CP.Domain.Interfaces.Validation
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validate(TEntity entity);
    }
}
