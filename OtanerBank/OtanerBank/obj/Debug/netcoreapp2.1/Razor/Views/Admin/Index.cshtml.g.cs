#pragma checksum "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4895789ca309ec217d2fec36f175d5a5f9f4434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\_ViewImports.cshtml"
using OtanerBank;

#line default
#line hidden
#line 2 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\_ViewImports.cshtml"
using OtanerBank.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4895789ca309ec217d2fec36f175d5a5f9f4434", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac29637e3f573f215dc10dc5796fed518f2e9702", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OtanerBank.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(86, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 9 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
 if (Model != null)
{


#line default
#line hidden
            BeginContext(124, 237, true);
            WriteLiteral("    <div class=\"row\">\r\n\r\n        <div class=\"col-md-1\"></div>\r\n\r\n        <div class=\"col-md-4\"></div>\r\n\r\n        <div class=\"col-md-2\"></div>\r\n\r\n        <div class=\"col-md-4\"></div>\r\n\r\n        <div class=\"col-md-1\"></div>\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(363, 62, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 29 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                  
                    Client client = new Client();


#line default
#line hidden
            BeginContext(498, 50, true);
            WriteLiteral("                    <th>\r\n                        ");
            EndContext();
            BeginContext(549, 29, false);
#line 33 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.LabelFor(x => client.id));

#line default
#line hidden
            EndContext();
            BeginContext(578, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(658, 34, false);
#line 36 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.LabelFor(x => client.ACCOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(692, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(772, 30, false);
#line 39 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.LabelFor(x => client.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(802, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(882, 31, false);
#line 42 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.LabelFor(x => client.NAME));

#line default
#line hidden
            EndContext();
            BeginContext(913, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(993, 34, false);
#line 45 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.LabelFor(x => client.BALANCE));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1107, 21, false);
#line 48 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.Label("Options"));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 29, true);
            WriteLiteral("\r\n                    </th>\r\n");
            EndContext();
            BeginContext(1176, 81, true);
            WriteLiteral("                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 55 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1314, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1387, 37, false);
#line 59 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1504, 42, false);
#line 62 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ACCOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1626, 38, false);
#line 65 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1744, 39, false);
#line 68 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NAME));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1863, 42, false);
#line 71 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BALANCE));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        | ");
            EndContext();
            BeginContext(1987, 55, false);
#line 74 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                     Write(Html.ActionLink("Edit", "Edit", new { CPF = item.CPF }));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2071, 61, false);
#line 75 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { CPF = item.CPF }));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 54, true);
            WriteLiteral(" |\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 78 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2201, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 81 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Index.cshtml"
}
else
{

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OtanerBank.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
