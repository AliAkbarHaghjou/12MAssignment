using SimpleCrud.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Domain.Entities
{
    public class STK : BaseEntity
    {
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
    }
}
