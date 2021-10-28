using AutoCenterV1.Entities;
using System;
using System.Collections.Generic;

namespace AutoCenterV1.Interface
{
    public interface IEntityReader<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate);
    }
}
