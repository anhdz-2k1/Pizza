#pragma checksum "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4db26eb1f22eb0284ca58420763008db05520995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
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
#line 1 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\_ViewImports.cshtml"
using Pizza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\_ViewImports.cshtml"
using Pizza.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\_ViewImports.cshtml"
using Pizza.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db26eb1f22eb0284ca58420763008db05520995", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a9612689b08f2c6bf309db0901b39ba4b9430bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>");
#nullable restore
#line 5 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml"
                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 159, "\"", 175, 1);
#nullable restore
#line 6 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml"
WriteAttributeValue("", 165, Model.Img, 165, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("        \r\n    </div>\r\n    <div class=\"card-text p-1\">\r\n        ");
#nullable restore
#line 13 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
