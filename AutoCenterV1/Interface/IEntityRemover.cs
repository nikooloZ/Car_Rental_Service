using AutoCenterV1.DTO;

namespace AutoCenterV1.Interface
{
    public interface IEntityRemover<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        void Remove(TEntity entity);
        void Remove(TKey id);

    }
}
