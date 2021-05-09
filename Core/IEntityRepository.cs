using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T GetById(Expression<Func<T, bool>> filter);
    }
}
