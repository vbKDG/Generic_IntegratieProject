#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a23e130aad154f3e4a1ffd0625d35d84a854dee"
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
#line 1 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a23e130aad154f3e4a1ffd0625d35d84a854dee", @"/Views/Admin/AdminPage.cshtml")]
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
            BeginContext(0, 8138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a23e130aad154f3e4a1ffd0625d35d84a854dee3163", async() => {
                BeginContext(6, 694, true);
                WriteLiteral(@"

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
#line 16 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                               if (User.IsInRole("SuperAdmin"))
                                                        {

#line default
#line hidden
                BeginContext(840, 790, true);
                WriteLiteral(@"                                                            <div class=""col-md-6 py-2"">
                                                                <div class=""card text-center bg-primary text-white mb-3"">
                                                                    <div class=""card-body"">
                                                                        <h3>Manage admins</h3>
                                                                        <h4 class=""display-4"">
                                                                            <i class=""fas fa-pencil-alt""></i>
                                                                        </h4>
                                                                        <button class=""btn btn-default""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1630, "\"", 1694, 5);
                WriteAttributeValue("", 1640, "location.href", 1640, 13, true);
                WriteAttributeValue(" ", 1653, "=", 1654, 2, true);
                WriteAttributeValue(" ", 1655, "\'", 1656, 2, true);
#line 25 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 1657, Url.Action("ManageAdmins", "Admin"), 1657, 36, false);

#line default
#line hidden
                WriteAttributeValue("", 1693, "\'", 1693, 1, true);
                EndWriteAttribute();
                BeginContext(1695, 393, true);
                WriteLiteral(@">
                                                                            Manage admins
                                                                        </button>
                                                                    </div>
                                                                </div>
                                                            </div>
");
                EndContext();
#line 31 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(2147, 92, true);
                WriteLiteral("                                            \r\n                                            \r\n");
                EndContext();
#line 34 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                      if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
                                                                {

#line default
#line hidden
                BeginContext(2420, 869, true);
                WriteLiteral(@"                                                                    <div class=""col-md-6 py-2"" id=""bodyadmin"">
                                                                        <div class=""card text-center bg-success text-white mb-3"">
                                                                            <div class=""card-body"">
                                                                                <h3>Manage moderators</h3>
                                                                                <h4 class=""display-4"">
                                                                                    <i class=""fas fa-folder""></i>
                                                                                </h4>
                                                                                <button class=""btn btn-default""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3289, "\"", 3357, 5);
                WriteAttributeValue("", 3299, "location.href", 3299, 13, true);
                WriteAttributeValue(" ", 3312, "=", 3313, 2, true);
                WriteAttributeValue(" ", 3314, "\'", 3315, 2, true);
#line 43 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 3316, Url.Action("ManageModerators", "Admin"), 3316, 40, false);

#line default
#line hidden
                WriteAttributeValue("", 3356, "\'", 3356, 1, true);
                EndWriteAttribute();
                BeginContext(3358, 437, true);
                WriteLiteral(@">
                                                                                    Manage moderators
                                                                                </button>
                                                                            </div>
                                                                        </div>
                                                                    </div>
");
                EndContext();
#line 49 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                }

#line default
#line hidden
                BeginContext(3862, 108, true);
                WriteLiteral("                                                            \r\n                                            \r\n");
                EndContext();
#line 52 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                          if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
                                                                                    {    

#line default
#line hidden
                BeginContext(4179, 1031, true);
                WriteLiteral(@"                                                                                        <div class=""col-md-6 py-2"" id=""bodyadmin"">
                                                                                            <div class=""card text-center bg-success text-white mb-3"">
                                                                                                <div class=""card-body"">
                                                                                                    <h3>Manage projects</h3>
                                                                                                    <h4 class=""display-4"">
                                                                                                        <i class=""fas fa-pencil-alt""></i>
                                                                                                    </h4>
                                                                                                    <button class=""btn btn-d");
                WriteLiteral("efault\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5210, "\"", 5272, 5);
                WriteAttributeValue("", 5220, "location.href", 5220, 13, true);
                WriteAttributeValue(" ", 5233, "=", 5234, 2, true);
                WriteAttributeValue(" ", 5235, "\'", 5236, 2, true);
#line 61 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 5237, Url.Action("Projects", "Project"), 5237, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 5271, "\'", 5271, 1, true);
                EndWriteAttribute();
                BeginContext(5273, 535, true);
                WriteLiteral(@">
                                                                                                        Manage projects
                                                                                                    </button>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
");
                EndContext();
#line 67 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                                    }

#line default
#line hidden
                BeginContext(5895, 84, true);
                WriteLiteral("                                                                                    ");
                EndContext();
#line 68 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                                     if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
                                                                                    {

#line default
#line hidden
                BeginContext(6157, 1024, true);
                WriteLiteral(@"                                                                                        <div class=""col-md-6 py-2"" id=""bodyadmin"">
                                                                                            <div class=""card text-center bg-primary text-white mb-3"">
                                                                                                <div class=""card-body"">
                                                                                                    <h3>Manage posts</h3>
                                                                                                    <h4 class=""display-4"">
                                                                                                        <i class=""fas fa-folder""></i>
                                                                                                    </h4>
                                                                                                    <button class=""btn btn-default""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7181, "\"", 7265, 5);
                WriteAttributeValue("", 7191, "location.href", 7191, 13, true);
                WriteAttributeValue(" ", 7204, "=", 7205, 2, true);
                WriteAttributeValue(" ", 7206, "\'", 7207, 2, true);
#line 77 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
WriteAttributeValue("", 7208, Url.Action("ManagePosts", "Admin", new {projectId = 1}), 7208, 56, false);

#line default
#line hidden
                WriteAttributeValue("", 7264, "\'", 7264, 1, true);
                EndWriteAttribute();
                BeginContext(7266, 532, true);
                WriteLiteral(@">
                                                                                                        Manage posts
                                                                                                    </button>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
");
                EndContext();
#line 83 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\AdminPage.cshtml"
                                                                                    }

#line default
#line hidden
                BeginContext(7885, 246, true);
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
            BeginContext(8138, 2, true);
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
