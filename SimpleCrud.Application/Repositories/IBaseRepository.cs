using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Application.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<ICollection<TEntity>> GetAll();
        Task<TEntity> Find(int Id);
        Task<TEntity> Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Remove(TEntity entity);
        Task<int> SaveChanges();
    }
}
