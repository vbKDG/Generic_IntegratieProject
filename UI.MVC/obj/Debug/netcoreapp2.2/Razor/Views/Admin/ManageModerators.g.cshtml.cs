#pragma checksum "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "271369216f68f18b21e5693376b07ab5ab06aa29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageModerators), @"mvc.1.0.view", @"/Views/Admin/ManageModerators.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ManageModerators.cshtml", typeof(AspNetCore.Views_Admin_ManageModerators))]
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
#line 1 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
using DAL.EF;

#line default
#line hidden
#line 2 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"271369216f68f18b21e5693376b07ab5ab06aa29", @"/Views/Admin/ManageModerators.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageModerators : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task<IList<DAL.EF.ApplicationUser>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/CreateModerator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
  
    ViewData["Title"] = "Manage moderators";

#line default
#line hidden
            BeginContext(202, 137, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n<h4>Here is a list of all the moderators</h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(339, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "271369216f68f18b21e5693376b07ab5ab06aa294737", async() => {
                BeginContext(398, 22, true);
                WriteLiteral("Create a new Moderator");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(424, 231, true);
            WriteLiteral(" \r\n</p>\r\n    \r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Firstname</p>\r\n        </th>\r\n        <th>\r\n            <p>Lastname</p>\r\n        </th>\r\n        <th>\r\n            <p>Email</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 32 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
     foreach (var item in Model.Result)
    {

#line default
#line hidden
            BeginContext(703, 51, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <p>");
            EndContext();
            BeginContext(755, 14, false);
#line 36 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
              Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(769, 62, true);
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
            EndContext();
            BeginContext(832, 13, false);
#line 39 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
              Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(845, 62, true);
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                <p>");
            EndContext();
            BeginContext(908, 10, false);
#line 42 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
              Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(918, 59, true);
            WriteLiteral("</p>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(978, 99, false);
#line 45 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
           Write(Html.ActionLink("Edit", "EditModeratorPage", "Admin"
                    , new {userId = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 21, true);
            WriteLiteral(" | \r\n                ");
            EndContext();
            BeginContext(1099, 103, false);
#line 47 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
           Write(Html.ActionLink("Delete", "DeleteModeratorPage", "Admin"
                    , new {userId = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\ManageModerators.cshtml"
    }

#line default
#line hidden
            BeginContext(1245, 8, true);
            WriteLiteral("</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task<IList<DAL.EF.ApplicationUser>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
