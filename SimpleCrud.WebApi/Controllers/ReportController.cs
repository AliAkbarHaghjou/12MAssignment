using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SimpleCrud.Application.Services;
using SimpleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.WebApi.Controllers
{
    public class ReportController : Controller
    {
        private ISTIService _ISTIService;
        private ISTKService _ISTKService;
        public ReportController(ISTIService STIService, ISTKService ISTKService)
        {
            _ISTIService = STIService;
            _ISTKService = ISTKService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<STViewModel>> Index()
        {
            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("_ViewAll", _ISTIService.GetAllSTIs());
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<STViewModel>>> Search()
        {
            var STKLists = await _ISTKService.GetAllSTK();

            var _STSearchVM = new STSearchVM()
            {
                STKList = STKLists.ToList().ConvertAll(item =>
                {
                    return new SelectListItem()
                    {
                        Text = item.MalAdi.ToString(),
                        Value = item.MalKodu.ToString(),
                        Selected = false
                    };
                })
            };

            if (HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView("_Search", _STSearchVM);

            return View();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<STViewModel>>> Search(STSearchVM _STSearchVM)
        {
            var result = _ISTIService.Serach(_STSearchVM.GirishTarih, _STSearchVM.CikishTarih, _STSearchVM.MalCode);
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", result) });
        }
    }
}
