#pragma checksum "D:\Github\l9l\l9l\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2579408b837bdf28a5ba0e3c999b31fddcc50663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "D:\Github\l9l\l9l\Views\_ViewImports.cshtml"
using l9l;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\l9l\l9l\Views\_ViewImports.cshtml"
using l9l.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2579408b837bdf28a5ba0e3c999b31fddcc50663", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc511899038ff953108f383b3aba794fd15dd858", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<l9l.Data.ViewModels.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
  
    Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-5 mx-auto lp"">
            <div class=""myform form"">
                <div class=""logo mb-3"">
                    <div class=""col-md-12 text-center"">
                        <h1></h1>
                    </div>
                </div>

");
#nullable restore
#line 16 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 19 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                   Write(Html.LabelFor(c => c.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(c => c.Email,
                            new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(c => c.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 26 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                   Write(Html.LabelFor(c => c.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(c => c.Password,
                            new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 29 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(c => c.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""form-group"">
                        <p class=""text-center"">
                            <a href=""#"">
                                Don't Remember Password
                            </a>
                        </p>
                    </div>
");
            WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""col-md-12 text-center"">
                            <button type=""submit""
                                    class=""btn btn-block btn-primary mybtn tx-tfm"">
                                Login
                            </button>
                        </div>

                    </div>
");
            WriteLiteral(@"                    <div class=""form-group"">
                        <p class=""text-center"">
                            Don't have account?
                            <a href=""/Account/Register"" id=""signup"">
                                Sign up
                            </a>
                        </p>
                    </div>
");
#nullable restore
#line 58 "D:\Github\l9l\l9l\Views\Account\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<l9l.Data.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
