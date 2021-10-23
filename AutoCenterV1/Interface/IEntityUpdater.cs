using AutoCenterV1.DTO;

namespace AutoCenterV1.Interface
{
    public interface IEntityUpdater<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        void Update(TEntity entity);
    }
}
