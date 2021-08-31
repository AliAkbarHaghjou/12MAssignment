using SimpleCrud.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleCrud.Persistence.Context;

namespace SimpleCrud.Persistence.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext dbContext;
        protected readonly DbSet<TEntity> entities;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            entities = dbContext.Set<TEntity>();
        }

        public virtual async Task<ICollection<TEntity>> GetAll()
        {
            return await entities.ToListAsync();
        }
        public virtual async Task<TEntity> Find(int Id)
        {
            return await entities.FindAsync(Id);
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            return (await entities.AddAsync(entity)).Entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            return (entities.Update(entity)).Entity;
        }

        public virtual TEntity Remove(TEntity entity)
        {
            return (entities.Remove(entity)).Entity;
        }

        public virtual async Task<int> SaveChanges()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
