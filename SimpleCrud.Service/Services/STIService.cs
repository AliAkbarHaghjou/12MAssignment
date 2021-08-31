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
    public class STIService : ISTIService
    {
        private readonly ISTIRepository _ISTIRepository;
        public STIService(ISTIRepository ISTIRepository)
        {
            _ISTIRepository = ISTIRepository;
        }
        public IEnumerable<STViewModel> GetAllSTIs()
        {
            var result = _ISTIRepository.GetReport();
            return result;
        }

        public IEnumerable<STViewModel> Serach(string GirishTarih, string CikisTarih, string Malkodu)
        {
            var result = _ISTIRepository.Search(GirishTarih, CikisTarih, Malkodu);
            return result;
        }

    }
}
