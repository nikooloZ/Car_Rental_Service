using AutoCenterV1.Entities;

namespace AutoCenterV1.Interface
{
    public interface IEntityCreator<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
    {
        TEntity Add(TEntity entity);
    }
}
