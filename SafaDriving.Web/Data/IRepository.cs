using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SafaDriving.Web.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetByID(object id);        
        void Insert(T entity);
        void Delete(object id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
    }
}
