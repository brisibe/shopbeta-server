using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace shopbeta.Core.Interfaces
{
    public interface IRepositoryBase<T> 
    {
        IQueryable<T> Findall(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        void Create(T entity);

        void Delete(T entity);
    }
}
