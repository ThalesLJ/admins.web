#pragma checksum "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c03ac04c21216d5216e0f7cdea6335032203b61d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Details.cshtml", typeof(AspNetCore.Views_Admin_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c03ac04c21216d5216e0f7cdea6335032203b61d", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac29637e3f573f215dc10dc5796fed518f2e9702", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OtanerBank.Models.Client>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Client Details";

#line default
#line hidden
            BeginContext(85, 1051, true);
            WriteLiteral(@"

<style>

    .a {
    }

    .button {
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
    }

    .button2 {
        border-radius: 12px;
    }

</style>

<div>

    <fieldset>

        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">

                    <div class=""modal fade"" tabindex=""-1"" id=""DetailsModal""
                         data-keyboard=""false"" data-backdrop=""static"">
                        <div class=""modal-dialog modal-lg"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <button id=""btnDimiss"" type=""button"" class=""close"">
                                        ×
                                    </button>
             ");
            WriteLiteral("                       <h4>");
            EndContext();
            BeginContext(1137, 10, false);
#line 47 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                   Write(Model.NAME);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 141, true);
            WriteLiteral("</h4>\r\n                                </div>\r\n                                <div class=\"modal-body\">\r\n                                    ");
            EndContext();
            BeginContext(1288, 3977, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d8c56e69fe4e51857c75d74e98a97f", async() => {
                BeginContext(1294, 229, true);
                WriteLiteral("\r\n\r\n                                        <div>\r\n                                            <dl class=\"dl-horizontal\">\r\n                                                <dt>\r\n                                                    ");
                EndContext();
                BeginContext(1524, 43, false);
#line 55 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.ACCOUNT));

#line default
#line hidden
                EndContext();
                BeginContext(1567, 163, true);
                WriteLiteral("\r\n                                                </dt>\r\n                                                <dd>\r\n                                                    ");
                EndContext();
                BeginContext(1731, 39, false);
#line 58 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.ACCOUNT));

#line default
#line hidden
                EndContext();
                BeginContext(1770, 163, true);
                WriteLiteral("\r\n                                                </dd>\r\n                                                <dt>\r\n                                                    ");
                EndContext();
                BeginContext(1934, 39, false);
#line 61 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
                EndContext();
                BeginContext(1973, 163, true);
                WriteLiteral("\r\n                                                </dt>\r\n                                                <dd>\r\n                                                    ");
                EndContext();
                BeginContext(2137, 35, false);
#line 64 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
                EndContext();
                BeginContext(2172, 163, true);
                WriteLiteral("\r\n                                                </dd>\r\n                                                <dt>\r\n                                                    ");
                EndContext();
                BeginContext(2336, 43, false);
#line 67 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.BALANCE));

#line default
#line hidden
                EndContext();
                BeginContext(2379, 163, true);
                WriteLiteral("\r\n                                                </dt>\r\n                                                <dd>\r\n                                                    ");
                EndContext();
                BeginContext(2543, 39, false);
#line 70 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.BALANCE));

#line default
#line hidden
                EndContext();
                BeginContext(2582, 59, true);
                WriteLiteral("\r\n                                                </dd>\r\n\r\n");
                EndContext();
#line 73 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                  
                                                    if (Model.ACCOUNT.EndsWith("-2"))
                                                    {

#line default
#line hidden
                BeginContext(2835, 122, true);
                WriteLiteral("                                                        <dt>\r\n                                                            ");
                EndContext();
                BeginContext(2958, 47, false);
#line 77 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.LAST_ACCESS));

#line default
#line hidden
                EndContext();
                BeginContext(3005, 187, true);
                WriteLiteral("\r\n                                                        </dt>\r\n                                                        <dd>\r\n                                                            ");
                EndContext();
                BeginContext(3193, 43, false);
#line 80 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.LAST_ACCESS));

#line default
#line hidden
                EndContext();
                BeginContext(3236, 187, true);
                WriteLiteral("\r\n                                                        </dd>\r\n                                                        <dt>\r\n                                                            ");
                EndContext();
                BeginContext(3424, 50, false);
#line 83 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.BALANCE_EARNED));

#line default
#line hidden
                EndContext();
                BeginContext(3474, 187, true);
                WriteLiteral("\r\n                                                        </dt>\r\n                                                        <dd>\r\n                                                            ");
                EndContext();
                BeginContext(3662, 46, false);
#line 86 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.BALANCE_EARNED));

#line default
#line hidden
                EndContext();
                BeginContext(3708, 65, true);
                WriteLiteral("\r\n                                                        </dd>\r\n");
                EndContext();
#line 88 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                    }
                                                

#line default
#line hidden
                BeginContext(3879, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 91 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                  
                                                    if (Model.ACCOUNT.EndsWith("-3"))
                                                    {

#line default
#line hidden
                BeginContext(4075, 122, true);
                WriteLiteral("                                                        <dt>\r\n                                                            ");
                EndContext();
                BeginContext(4198, 48, false);
#line 95 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.MANAGER_NAME));

#line default
#line hidden
                EndContext();
                BeginContext(4246, 187, true);
                WriteLiteral("\r\n                                                        </dt>\r\n                                                        <dd>\r\n                                                            ");
                EndContext();
                BeginContext(4434, 44, false);
#line 98 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.MANAGER_NAME));

#line default
#line hidden
                EndContext();
                BeginContext(4478, 187, true);
                WriteLiteral("\r\n                                                        </dd>\r\n                                                        <dt>\r\n                                                            ");
                EndContext();
                BeginContext(4666, 49, false);
#line 101 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.MANAGER_EMAIL));

#line default
#line hidden
                EndContext();
                BeginContext(4715, 187, true);
                WriteLiteral("\r\n                                                        </dt>\r\n                                                        <dd>\r\n                                                            ");
                EndContext();
                BeginContext(4903, 45, false);
#line 104 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.MANAGER_EMAIL));

#line default
#line hidden
                EndContext();
                BeginContext(4948, 65, true);
                WriteLiteral("\r\n                                                        </dd>\r\n");
                EndContext();
#line 106 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                                    }
                                                

#line default
#line hidden
                BeginContext(5119, 139, true);
                WriteLiteral("                                            </dl>\r\n                                        </div>\r\n\r\n\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5265, 187, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"modal-footer\">\r\n\r\n                                    <div>\r\n                                        ");
            EndContext();
            BeginContext(5453, 63, false);
#line 117 "C:\projects\OtanersBank\WebAdmins\master\OtanerBank\OtanerBank\Views\Admin\Details.cshtml"
                                   Write(Html.ActionLink("Edit Client", "Edit", new { CPF = Model.CPF }));

#line default
#line hidden
            EndContext();
            BeginContext(5516, 650, true);
            WriteLiteral(@"
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </fieldset>
</div>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"">
</script>
<script src=""bootstrap/js/bootstrap.min.js""></script>

<script type=""text/javascript"">

    $(document).ready(function () {
        $(""#DetailsModal"").modal('show');
    });

    $(""#btnDimiss"").click(function () {
        window.location.href = ""\."";
    });

</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OtanerBank.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
