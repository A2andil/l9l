#pragma checksum "D:\Github\l9l\l9l\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8409f854320a6da5b4401599ca08c3d07e23da04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8409f854320a6da5b4401599ca08c3d07e23da04", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc511899038ff953108f383b3aba794fd15dd858", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<l9l.Data.ViewModels.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
   
    Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-5"" style=""margin-left:28%"">
            <div class=""logo mb-3"">
                <div class=""col-md-12 text-center"">
                    <h1></h1>
                </div>
            </div>
");
#nullable restore
#line 15 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
             using (Html.BeginForm())
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 19 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.LabelFor(c => c.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(c => c.FullName, new
                             {
                                 @class = "form-control",
                                 @placeholder = "Enter Full Name"
                             }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 28 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.LabelFor(c => c.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(c => c.Email, new
                             {
                                 @class = "form-control",
                                 @placeholder = "Enter Your Email"
                             }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 37 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.LabelFor(c => c.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.TextBoxFor(c => c.Phone,
                    new { @class = "form-control",
                        @placeholder = "Enter Your Email"
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 45 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.LabelFor(c => c.Membership));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 46 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.DropDownListFor(c => c.Membership,
                    new SelectList(Model.Types, "Key", "Value"),
                    new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 53 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.LabelFor(c => c.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
               Write(Html.PasswordFor(c => c.Password, new
                             {
                                 @class = "form-control",
                                 @placeholder = "Enter Your Password"
                             }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""col-md-12 text-center mb-3"">
                    <button type=""submit"" class="" btn btn-block mybtn btn-primary tx-tfm"">Get Started For Free</button>
                </div>
                <div class=""col-md-12 "">
                    <div class=""form-group"">
                        <p class=""text-center""><a href=""/Account/Login"" id=""signin"">Already have an account?</a></p>
                    </div>
                </div>
");
#nullable restore
#line 69 "D:\Github\l9l\l9l\Views\Account\Register.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</div>\r\n      </div> ");
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
