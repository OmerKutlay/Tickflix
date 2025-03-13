using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tickflix.Repository.Shared.Abstract
{
    internal interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        List<T> AddRange(List<T> entities);
        T GetFirstOrDefatult(Expression<Func<T, bool>> predicate);
        void Save();
    }
}
