#pragma checksum "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d403bc42f17eed67f5b727bd48f89d7a70fac746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteModeratorPage), @"mvc.1.0.view", @"/Views/Admin/DeleteModeratorPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DeleteModeratorPage.cshtml", typeof(AspNetCore.Views_Admin_DeleteModeratorPage))]
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
#line 1 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
using DAL.EF;

#line default
#line hidden
#line 2 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d403bc42f17eed67f5b727bd48f89d7a70fac746", @"/Views/Admin/DeleteModeratorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteModeratorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.EF.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
  
    ViewData["Title"] = "Delete moderator";

#line default
#line hidden
            BeginContext(188, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 12 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
 using (Html.BeginForm("DeleteUser", "Admin", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(262, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(271, 17, false);
#line 14 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(288, 47, true);
            WriteLiteral("</h1>\r\n    <h3>Are you sure you want to delete ");
            EndContext();
            BeginContext(336, 11, false);
#line 15 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
                                   Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(347, 11, true);
            WriteLiteral("</h3>\r\n    ");
            EndContext();
            BeginContext(358, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d403bc42f17eed67f5b727bd48f89d7a70fac7465397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(392, 79, true);
            WriteLiteral("\r\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Delete moderator\"/>\r\n");
            EndContext();
#line 18 "C:\Users\Cem\Documents\identityrepo\Generic_IntegratieProject\UI.MVC\Views\Admin\DeleteModeratorPage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.EF.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
