using SimpleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Application.Services
{
    public interface ISTIService
    {
        IEnumerable<STViewModel> GetAllSTIs();

        IEnumerable<STViewModel> Serach(string GirishTarih, string CikisTarih, string Malkodu);
    }
}
