using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SimpleCrud.Domain.Entities
{
    public class STSearchVM
    {
        public string GirishTarih { get; set; }
        public string CikishTarih { get; set; }
        public string MalCode { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> STKList { get; set; }

    }
}
