using AutoCenterV1.Entities;
using AutoCenterV1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenterV1.Repositories
{
    abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        protected readonly MyDbContext _mydbContext;

        public BaseRepository(MyDbContext myDbContext)
        {
            this._mydbContext = myDbContext;
        }

        public TEntity Add(TEntity entity)
        {
            _mydbContext.Add(entity);
            return entity;
        }

        public TEntity Get(TKey id)
        {
            return _mydbContext.Find<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _mydbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            return _mydbContext.Set<TEntity>().Where(predicate);
        }

        public void Remove(TEntity entity)
        {
            _mydbContext.Remove(entity);
        }

        virtual public void Remove(TKey id)
        {
            Remove(Get(id));
        }

        public int SaveChanges()
        {
            return _mydbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _mydbContext.Update(entity);
        }
    }
}
