using Microsoft.EntityFrameworkCore;
using SimpleCrud.Application.Repositories;
using SimpleCrud.Domain.Entities;
using SimpleCrud.Persistence.Context;
using SimpleCrud.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Persistence.Repositories
{
    public class STKRepository : BaseRepository<STK>, ISTKRepository
    {
        public DbSet<STK> STKs { get; set; }

        public STKRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            STKs = dbContext.Set<STK>();
        }
    }
}
