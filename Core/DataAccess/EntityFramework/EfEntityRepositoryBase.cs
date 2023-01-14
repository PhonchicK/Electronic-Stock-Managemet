using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public abstract class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public virtual TEntity Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Added;
                context.SaveChanges();
                return result.Entity;
            }
        }

        public virtual int Count(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Count(filter);
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Deleted;
                context.SaveChangesAsync();
            }
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public virtual void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var result = context.Entry(entity);
                result.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
