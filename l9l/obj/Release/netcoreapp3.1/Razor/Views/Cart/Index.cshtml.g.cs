#pragma checksum "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff8123272e0ba6e1b25df73b0c24e4b711d8dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#nullable restore
#line 1 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
using l9l.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff8123272e0ba6e1b25df73b0c24e4b711d8dfa", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc511899038ff953108f383b3aba794fd15dd858", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
  
    Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-striped"" style=""margin-top:70px"">
    <thead>
        <tr>
            <th>Image</th>
            <th>Name</th>
            <th>Count</th>
            <th>Price</th>
            <th>Total Price</th>
            <th>Modify</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
         foreach (var item in Model.items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"font-size:large\">\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 539, "\"", 556, 1);
#nullable restore
#line 25 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
WriteAttributeValue("", 545, item.Image, 545, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                         style=\"width:35px; height:35px\" />\r\n                </td>\r\n                <td>");
#nullable restore
#line 28 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
                Write(item.Price * item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                <td>
                    <a href=""#""
                       class=""btn btn-warning"">
                        Edit
                    </a>
                    <a href=""#""
                       class=""btn btn-danger"">
                        Delete
                    </a>
                </td>
            </tr>
");
#nullable restore
#line 43 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"6\">\r\n                <div class=\"pull-right\">\r\n                    Total Price: ");
#nullable restore
#line 49 "E:\Visual Studio\VS 2019\l9l\Views\Cart\Index.cshtml"
                            Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n                    <a href=\"#\" class=\"btn btn-primary\">\r\n                        Confirm\r\n                    </a>\r\n                </div>\r\n\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591