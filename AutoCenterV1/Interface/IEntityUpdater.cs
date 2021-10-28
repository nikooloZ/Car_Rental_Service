
using AutoCenterV1.Entities;

namespace AutoCenterV1.Interface
{
    public interface IEntityUpdater<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        void Update(TEntity entity);
    }
}
