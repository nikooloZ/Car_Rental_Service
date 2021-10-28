
using AutoCenterV1.Entities;

namespace AutoCenterV1.Interface
{
    public interface IEntityRemover<TEntity, TKey>  where TEntity : BaseEntity<TKey>
    {
        void Remove(TEntity entity);
        void Remove(TKey id);
    }
}
