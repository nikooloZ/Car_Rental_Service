using AutoCenterV1.DTO;

namespace AutoCenterV1.Interface
{
    public interface IEntityCreator<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        TEntity Add(TEntity entity);
    }
}
