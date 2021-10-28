
using AutoCenterV1.Entities;

namespace AutoCenterV1.Interface
{
    public interface IRepository<TEntity, TKey>
       : IEntityCreator<TEntity, TKey>,
         IEntityReader<TEntity, TKey>,
         IEntityUpdater<TEntity, TKey>,
         IEntityRemover<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {

    }
}
