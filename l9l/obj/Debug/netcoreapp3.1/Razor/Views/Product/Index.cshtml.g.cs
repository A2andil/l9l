#pragma checksum "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c7f8c5dcbb2b9f3d3cc1d18fd515d2c2582255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
using l9l.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c7f8c5dcbb2b9f3d3cc1d18fd515d2c2582255", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc511899038ff953108f383b3aba794fd15dd858", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row container\">\r\n");
#nullable restore
#line 9 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6 col-md-4 col-lg-3\" style=\"min-width:260px\">\r\n            <div class=\"thumbnail\">\r\n                <img style=\"height:280px; width:250px\"");
            BeginWriteAttribute("src", " src=\"", 322, "\"", 345, 1);
#nullable restore
#line 13 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
WriteAttributeValue("", 328, product.ImageUrl, 328, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 346, "\"", 352, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"caption\">\r\n                    <table class=\"table borderless\"\r\n                           style=\"margin-bottom:-13px\">\r\n                        <tr>\r\n                            <td>\r\n                                <h5>");
#nullable restore
#line 19 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </td>\r\n                            <td>\r\n                                <h5 style=\"text-align:right\">\r\n                                    ");
#nullable restore
#line 23 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
                               Write(product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td colspan=\"2\" style=\"text-align:right\">\r\n                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1070, "\"", 1146, 3);
            WriteAttributeValue("", 1080, "location.href=\'", 1080, 15, true);
#nullable restore
#line 29 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
WriteAttributeValue("", 1095, Url.Action("Add", "Cart", new { Id = product.Id}), 1095, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1145, "\'", 1145, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                        class=""btn btn-primary pull-right"">
                                    Add to Card
                                </button>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
");
#nullable restore
#line 39 "E:\Visual Studio\VS 2019\l9l\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
