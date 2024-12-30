using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        //user.GetAll(s => s.userName == "kardel").Where(s => s.id >1);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
