#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bed00cedf82808dc53fb3c688a9e412390afaeb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageAdmins), @"mvc.1.0.view", @"/Views/Admin/ManageAdmins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ManageAdmins.cshtml", typeof(AspNetCore.Views_Admin_ManageAdmins))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
using DAL.EF;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bed00cedf82808dc53fb3c688a9e412390afaeb3", @"/Views/Admin/ManageAdmins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageAdmins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task<IList<DAL.EF.ApplicationUser>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/CreateAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
  
    ViewData["Title"] = "Manage admins";

#line default
#line hidden
            BeginContext(198, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(200, 3884, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed00cedf82808dc53fb3c688a9e412390afaeb35056", async() => {
                BeginContext(206, 1255, true);
                WriteLiteral(@"
<div class=""container"">

     <div class=""row center-block"">
            
                <div class=""dark-overlay"">
                    <div class=""container"">
    
                        <div class=""col-lg-9"">
                            <div class=""card bg-light card-form"">
                                <div class=""text-center"">
                                    <h1 class=""display-4"">Welcome</h1>
                                    <h4>Here is a list of all the administrators</h4>
                                </div>
                                <div class=""card-body"">

                                    <table class=""table"">
                                        <tr>
                                            <th>
                                                <p>Firstname</p>
                                            </th>
                                            <th>
                                                <p>Lastname</p>
                              ");
                WriteLiteral("              </th>\r\n                                            <th>\r\n                                                <p>Email</p>\r\n                                            </th>\r\n                                        </tr>\r\n");
                EndContext();
#line 38 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                         foreach (var item in Model.Result)
                                        {

#line default
#line hidden
                BeginContext(1581, 159, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    <p>");
                EndContext();
                BeginContext(1741, 14, false);
#line 42 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                                  Write(item.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1755, 170, true);
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <p>");
                EndContext();
                BeginContext(1926, 13, false);
#line 45 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                                  Write(item.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1939, 170, true);
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <p>");
                EndContext();
                BeginContext(2110, 10, false);
#line 48 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                                  Write(item.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2120, 167, true);
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(2288, 131, false);
#line 51 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                               Write(Html.ActionLink("Edit", "EditAdminPage", "Admin"
                                                        , new {userId = item.Id}));

#line default
#line hidden
                EndContext();
                BeginContext(2419, 56, true);
                WriteLiteral(" |\r\n                                                    ");
                EndContext();
                BeginContext(2476, 135, false);
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                               Write(Html.ActionLink("Delete", "DeleteAdminPage", "Admin"
                                                        , new {userId = item.Id}));

#line default
#line hidden
                EndContext();
                BeginContext(2611, 108, true);
                WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
                EndContext();
#line 57 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManageAdmins.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2762, 757, true);
                WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                        </div>
                            <div class=""col-lg-3"" id=""bodyadmin"">
                            <div class=""card text-center bg-primary text-white mb-3"">
                                                    <div class=""card-body"">
                                                        <h3>Add admin</h3>
                                                        <h4 class=""display-4"">
                                                            <i class=""fas fa-pencil-alt""></i> 
                                                        </h4>
                                                         ");
                EndContext();
                BeginContext(3519, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bed00cedf82808dc53fb3c688a9e412390afaeb311371", async() => {
                    BeginContext(3605, 1, true);
                    WriteLiteral("+");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3610, 467, true);
                WriteLiteral(@"
                                                         
                                                    </div>
                                                </div>
                            </div>
                                                            </div>
                                                        </div>
                                                        </div>
                                                
</div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
