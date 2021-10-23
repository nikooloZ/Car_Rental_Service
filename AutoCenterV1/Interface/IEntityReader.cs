using AutoCenterV1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenterV1.Interface
{
     public interface IEntityReader<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
         TEntity Get(TKey id);
         IEnumerable<TEntity> GetAll();
         IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate);
    }
}
