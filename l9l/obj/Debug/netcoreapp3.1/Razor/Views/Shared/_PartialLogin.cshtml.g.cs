#pragma checksum "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab9cb1d3e6b801eb86f1414c6735c7c517fd6ed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialLogin), @"mvc.1.0.view", @"/Views/Shared/_PartialLogin.cshtml")]
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
#line 1 "D:\VS 2019\WEB CORE\l9l\Views\_ViewImports.cshtml"
using l9l;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS 2019\WEB CORE\l9l\Views\_ViewImports.cshtml"
using l9l.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab9cb1d3e6b801eb86f1414c6735c7c517fd6ed2", @"/Views/Shared/_PartialLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc511899038ff953108f383b3aba794fd15dd858", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml"
 if (ViewBag.Session != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"navbar-nav flex-row ml-md-auto d-none d-md-flex\">\r\n        <li class=\"nav-item\">\r\n            ");
#nullable restore
#line 7 "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml"
       Write(await Component.InvokeAsync("ShoppingCartSummery"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        ");
#nullable restore
#line 9 "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml"
   Write(await Component.InvokeAsync("AccountComponent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n");
#nullable restore
#line 11 "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <Div class=\"my-2 my-lg-0\">\r\n        <a href=\"/Account/Login\" class=\"btn btn-primary\">Login</a>\r\n        <a href=\"/Account/Register\" class=\"btn btn-primary\">Sign Up</a>\r\n    </Div>\r\n");
#nullable restore
#line 18 "D:\VS 2019\WEB CORE\l9l\Views\Shared\_PartialLogin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
