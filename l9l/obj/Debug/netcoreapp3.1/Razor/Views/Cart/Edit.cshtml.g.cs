#pragma checksum "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d83c6ae16b918543bc2abe8d2ef9c0a70d70640"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Edit), @"mvc.1.0.view", @"/Views/Cart/Edit.cshtml")]
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
#line 1 "E:\Visual Studio\VS 2019\l9l\Views\_ViewImports.cshtml"
using l9l;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Visual Studio\VS 2019\l9l\Views\_ViewImports.cshtml"
using l9l.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d83c6ae16b918543bc2abe8d2ef9c0a70d70640", @"/Views/Cart/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc511899038ff953108f383b3aba794fd15dd858", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<l9l.Data.ViewModels.CartItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml"
Write(Html.HiddenFor(c => c.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container row\">\r\n        <table class=\"table-borderless col-md-12 col-lg-12 col-sm-12\">\r\n            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 319, "\"", 337, 1);
#nullable restore
#line 11 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml"
WriteAttributeValue("", 325, Model.Image, 325, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                             style=\"width:50px; height:50px\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 15 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 18 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml"
                   Write(Html.EditorFor(c => c.Count,
                        new { @class = "edc" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <input type=\"submit\" class=\"btn btn-primary\" />\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 28 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Edit.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<l9l.Data.ViewModels.CartItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
