#pragma checksum "C:\Users\AliAkbar\Desktop\SampleCrud-CleanArchitecture-main\SimpleCrud.WebApi\Views\Report\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ea539f455daa778c75a8ed01b55dace9b9a2b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report__ViewAll), @"mvc.1.0.view", @"/Views/Report/_ViewAll.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AliAkbar\Desktop\SampleCrud-CleanArchitecture-main\SimpleCrud.WebApi\Views\_ViewImports.cshtml"
using SimpleCrud.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AliAkbar\Desktop\SampleCrud-CleanArchitecture-main\SimpleCrud.WebApi\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ea539f455daa778c75a8ed01b55dace9b9a2b6", @"/Views/Report/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ddc2b24839f634c43c64cab4bfefdee93d03fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Report__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<STViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AliAkbar\Desktop\SampleCrud-CleanArchitecture-main\SimpleCrud.WebApi\Views\Report\_ViewAll.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.SiraNo).Titled("SiraNo");
        columns.Add(model => model.IslemTur).Titled("IslemTur");
        columns.Add(model => model.Tarih).Titled("Tarih");
        columns.Add(model => model.GirisMiktar).Titled("GirisMiktar");
        columns.Add(model => model.CikisMiktar).Titled("CikisMiktar");
    })
    .Empty("No data found")
    .Pageable(pager =>
    {
        pager.PagesToDisplay = 5;
        pager.RowsPerPage = 10;
    })
    .Sortable()
);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<STViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591