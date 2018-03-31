using System.Collections.Generic;

namespace DigiAeon.ParcelDelivery.Domain
{
    public abstract class ReadOnlyEntityBase<TEntity> where TEntity : IReadOnlyEntity
    {
        protected abstract List<string> Validate(TEntity entity);

        protected void ThrowInvalidEntityException(List<string> errors)
        {
            throw new BrokenRulesException<TEntity>(errors);
        }
    }
}
