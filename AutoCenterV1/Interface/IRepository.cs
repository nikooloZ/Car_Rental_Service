using AutoCenterV1.DTO;

namespace AutoCenterV1.Interface
{
    public interface IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        int SaveChanges();
    }
}
