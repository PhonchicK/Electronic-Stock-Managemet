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

        public List<TEntity> GetPage(Expression<Func<TEntity, bool>> filter = null, int page = 1, int itemByPage = 10)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().OrderBy(e => e.ID).Skip((page - 1) * itemByPage).Take(itemByPage).ToList()
                    : context.Set<TEntity>().Where(filter).OrderBy(e => e.ID).Skip((page - 1) * itemByPage).Take(itemByPage).ToList();
            }     
        }

        public int GetPageCount(Expression<Func<TEntity, bool>> filter = null, int itemByPage = 10)
        {
            using (TContext context = new TContext())
            {
                var count = context.Set<TEntity>().Count(filter);
                return ((int)count / itemByPage) + (count % itemByPage != 0 ? 1 : 0);
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
