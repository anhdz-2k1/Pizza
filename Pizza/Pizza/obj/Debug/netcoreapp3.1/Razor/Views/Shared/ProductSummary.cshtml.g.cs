#pragma checksum "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627b552d6f7f3feea0569f306f918b0bae2caf13"
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
#nullable restore
#line 4 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\_ViewImports.cshtml"
using Pizza.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627b552d6f7f3feea0569f306f918b0bae2caf13", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5db5bbf42f7a455e68f35349d1d05da5013ab1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""productModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""productTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                ");
#nullable restore
#line 6 "E:\scholl\ASM-pizza\Pizza\Pizza\Pizza\Views\Shared\ProductSummary.cshtml"
           Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"modal-body\">\r\n");
            WriteLiteral("            </div>\r\n\r\n            <div class=\"modal-footer\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
