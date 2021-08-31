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
    public class STIRepository : BaseRepository<STI>, ISTIRepository
    {
        public virtual DbSet<STViewModel> STViewModels { get; set; }

        public STIRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            STViewModels = dbContext.Set<STViewModel>();
        }

        public IEnumerable<STViewModel> GetReport()
        {
            string sp = string.Format("exec GetSTIList");
            var result = STViewModels.FromSqlRaw(sp).ToList();
            return result;
        }

        public IEnumerable<STViewModel> Search(string FromDate, string ToDate, string Value)
        {
            string sp = string.Format("exec SEARCHSTI '{0}','{1}','{2}'", Convert.ToInt32((DateTime.Parse(FromDate)).ToOADate()), Convert.ToInt32((DateTime.Parse(ToDate)).ToOADate()), Value);
            var result = STViewModels.FromSqlRaw(sp).ToList();
            return result;
        }
    }
}
