#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad79cb010cd7802a7e7b9fb2d678d7f96195a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminPage), @"mvc.1.0.view", @"/Views/Admin/AdminPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AdminPage.cshtml", typeof(AspNetCore.Views_Admin_AdminPage))]
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad79cb010cd7802a7e7b9fb2d678d7f96195a0e", @"/Views/Admin/AdminPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bad79cb010cd7802a7e7b9fb2d678d7f96195a0e3106", async() => {
                BeginContext(6, 767, true);
                WriteLiteral(@"
<a class=""previousButton"" onclick=""previousPage()"">&laquo; Previous</a>

<div class=""dark-overlay"">
                        <div class=""home-inner container py-5"">
                            <div class=""col-md-8"">
                                <div class=""card text-center card-form"">
                                    <div class=""card-body bg-dark"">
                                            <h3>
                                                <b class=""text-light"">Admin settings</b>
                                            </h3>
                                            <hr/>
                    
                                            
                                            
                                            
");
                EndContext();
#line 17 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                               if (User.IsInRole("SuperAdmin"))
                                                        {

#line default
#line hidden
                BeginContext(913, 790, true);
                WriteLiteral(@"                                                            <div class=""col-md-6 py-2"">
                                                                <div class=""card text-center bg-primary text-white mb-3"">
                                                                    <div class=""card-body"">
                                                                        <h3>Manage admins</h3>
                                                                        <h4 class=""display-4"">
                                                                            <i class=""fas fa-pencil-alt""></i>
                                                                        </h4>
                                                                        <button class=""btn btn-success""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1703, "\"", 1767, 5);
                WriteAttributeValue("", 1713, "location.href", 1713, 13, true);
                WriteAttributeValue(" ", 1726, "=", 1727, 2, true);
                WriteAttributeValue(" ", 1728, "\'", 1729, 2, true);
#line 26 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 1730, Url.Action("ManageAdmins", "Admin"), 1730, 36, false);

#line default
#line hidden
                WriteAttributeValue("", 1766, "\'", 1766, 1, true);
                EndWriteAttribute();
                BeginContext(1768, 393, true);
                WriteLiteral(@">
                                                                            Manage admins
                                                                        </button>
                                                                    </div>
                                                                </div>
                                                            </div>
");
                EndContext();
#line 32 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(2220, 92, true);
                WriteLiteral("                                            \r\n                                            \r\n");
                EndContext();
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                      if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
                                                                {

#line default
#line hidden
                BeginContext(2493, 866, true);
                WriteLiteral(@"                                                                    <div class=""col-md-6 py-2"" id=""bodyadmin"">
                                                                        <div class=""card text-center bg-success text-white mb-3"">
                                                                            <div class=""card-body"">
                                                                                <h3>Manage moderators</h3>
                                                                                <h4 class=""display-4"">
                                                                                    <i class=""fas fa-folder""></i>
                                                                                </h4>
                                                                                <button class=""btn btn-info""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3359, "\"", 3427, 5);
                WriteAttributeValue("", 3369, "location.href", 3369, 13, true);
                WriteAttributeValue(" ", 3382, "=", 3383, 2, true);
                WriteAttributeValue(" ", 3384, "\'", 3385, 2, true);
#line 44 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 3386, Url.Action("ManageModerators", "Admin"), 3386, 40, false);

#line default
#line hidden
                WriteAttributeValue("", 3426, "\'", 3426, 1, true);
                EndWriteAttribute();
                BeginContext(3428, 437, true);
                WriteLiteral(@">
                                                                                    Manage moderators
                                                                                </button>
                                                                            </div>
                                                                        </div>
                                                                    </div>
");
                EndContext();
#line 50 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                }

#line default
#line hidden
                BeginContext(3932, 108, true);
                WriteLiteral("                                                            \r\n                                            \r\n");
                EndContext();
#line 53 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                          if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
                                                                                    {    

#line default
#line hidden
                BeginContext(4249, 1028, true);
                WriteLiteral(@"                                                                                        <div class=""col-md-6 py-2"" id=""bodyadmin"">
                                                                                            <div class=""card text-center bg-success text-white mb-3"">
                                                                                                <div class=""card-body"">
                                                                                                    <h3>Manage projects</h3>
                                                                                                    <h4 class=""display-4"">
                                                                                                        <i class=""fas fa-pencil-alt""></i>
                                                                                                    </h4>
                                                                                                    <button class=""btn btn-i");
                WriteLiteral("nfo\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5277, "\"", 5339, 5);
                WriteAttributeValue("", 5287, "location.href", 5287, 13, true);
                WriteAttributeValue(" ", 5300, "=", 5301, 2, true);
                WriteAttributeValue(" ", 5302, "\'", 5303, 2, true);
#line 62 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 5304, Url.Action("Projects", "Project"), 5304, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 5338, "\'", 5338, 1, true);
                EndWriteAttribute();
                BeginContext(5340, 535, true);
                WriteLiteral(@">
                                                                                                        Manage projects
                                                                                                    </button>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
");
                EndContext();
#line 68 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                                    }

#line default
#line hidden
                BeginContext(5962, 84, true);
                WriteLiteral("                                                                                    ");
                EndContext();
#line 69 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                                     if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
                                                                                    {

#line default
#line hidden
                BeginContext(6224, 1024, true);
                WriteLiteral(@"                                                                                        <div class=""col-md-6 py-2"" id=""bodyadmin"">
                                                                                            <div class=""card text-center bg-primary text-white mb-3"">
                                                                                                <div class=""card-body"">
                                                                                                    <h3>Manage posts</h3>
                                                                                                    <h4 class=""display-4"">
                                                                                                        <i class=""fas fa-folder""></i>
                                                                                                    </h4>
                                                                                                    <button class=""btn btn-success""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7248, "\"", 7332, 5);
                WriteAttributeValue("", 7258, "location.href", 7258, 13, true);
                WriteAttributeValue(" ", 7271, "=", 7272, 2, true);
                WriteAttributeValue(" ", 7273, "\'", 7274, 2, true);
#line 78 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 7275, Url.Action("ManagePosts", "Admin", new {projectId = 1}), 7275, 56, false);

#line default
#line hidden
                WriteAttributeValue("", 7331, "\'", 7331, 1, true);
                EndWriteAttribute();
                BeginContext(7333, 532, true);
                WriteLiteral(@">
                                                                                                        Manage posts
                                                                                                    </button>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
");
                EndContext();
#line 84 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                                    }

#line default
#line hidden
                BeginContext(7952, 246, true);
                WriteLiteral("                                            \r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                \r\n                    </div>\r\n\r\n");
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
            BeginContext(8205, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
