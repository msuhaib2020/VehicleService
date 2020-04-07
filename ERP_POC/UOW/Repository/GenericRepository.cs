using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERP_POC.UOW.IRepository;
using System.Linq.Expressions;
using ERP_POC.Models;
using ERP_POC.Models.EF;
using System.Data.Entity;

namespace ERP_POC.UOW.Repository
{ 
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        //Here DBEntities is out context  
        protected readonly ERP_DBEntities db;
        public GenericRepository(ERP_DBEntities context)
        {
            db = context;
        }
        protected override void  Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }
        protected override void AddRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
        }
        protected override void Update(int id, TEntity entity)
        {
            var oldentity = Get(id);
            db.Entry(oldentity).CurrentValues.SetValues(entity);
        }
        protected override void Remove(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            db.Entry(entity).State = EntityState.Deleted;
        }
        protected override void RemoveRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
        }
        protected override TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }
        protected override IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }
        protected override IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate);
        }
       
    }  
}