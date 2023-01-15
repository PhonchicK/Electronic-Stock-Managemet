using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<Entity> 
        where Entity : class, IEntity, new()
    {
        List<Entity> GetAll(Expression<Func<Entity, bool>> filter = null);
        Entity Get(Expression<Func<Entity, bool>> filter);
        Entity Add(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
        int Count(Expression<Func<Entity, bool>> filter = null);
        //Pagination
        List<Entity> GetPage(Expression<Func<Entity, bool>> filter = null, int page = 1, int itemByPage = 10);
        int GetPageCount(Expression<Func<Entity, bool>> filter = null);
    }
}
