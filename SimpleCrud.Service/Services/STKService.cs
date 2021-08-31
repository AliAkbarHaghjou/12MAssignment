using SimpleCrud.Application.Repositories;
using SimpleCrud.Application.Services;
using SimpleCrud.Domain.Entities;
using SimpleCrud.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Service.Services
{
    public class STKService : ISTKService
    {
        private readonly ISTKRepository _ISTKRepository;
        public STKService(ISTKRepository ISTKRepository)
        {
            _ISTKRepository = ISTKRepository;
        }
        public async Task<IEnumerable<STK>> GetAllSTK()
        {
            var result = await _ISTKRepository.GetAll();
            return result;
        }
    }
}
