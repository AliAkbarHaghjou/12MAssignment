using SimpleCrud.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Domain.Entities
{
    public class STI : BaseEntity
    {
        public int IslemTur { get; set; }
        public string EvrakNo { get; set; }
        public int Tarih { get; set; }
        public int Miktar { get; set; }
        public int Fiyat { get; set; }
        public int Tutar { get; set; }
        public string Birim { get; set; }
        public string MalKodu { get; set; }
    }
}
