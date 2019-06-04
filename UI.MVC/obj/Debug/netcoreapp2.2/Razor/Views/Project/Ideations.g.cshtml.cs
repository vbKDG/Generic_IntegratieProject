#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf721ad6f1086bfd659c447e047af2ec0d72115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Ideations), @"mvc.1.0.view", @"/Views/Project/Ideations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Ideations.cshtml", typeof(AspNetCore.Views_Project_Ideations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf721ad6f1086bfd659c447e047af2ec0d72115", @"/Views/Project/Ideations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Ideations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Project>
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
            BeginContext(23, 1704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf721ad6f1086bfd659c447e047af2ec0d721153185", async() => {
                BeginContext(29, 131, true);
                WriteLiteral("\r\n<a class=\"previousButton\" onclick=\"previousPage()\">&laquo; Previous</a>\r\n<div class=\"container\">\r\n\r\n    <h2 class=\"text-center\"> ");
                EndContext();
                BeginContext(161, 10, false);
#line 6 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                        Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(171, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 7 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
     if (User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
    {
        

#line default
#line hidden
                BeginContext(259, 103, false);
#line 9 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
   Write(Html.ActionLink("Create Ideation", "CreateIdeationPage", "Project", new {projectId = @Model.ProjectId}));

#line default
#line hidden
                EndContext();
#line 9 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                                                                                                                
    }

#line default
#line hidden
                BeginContext(371, 125, true);
                WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                Centrale vraag\r\n            </th>\r\n        </tr>\r\n");
                EndContext();
#line 17 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
         foreach (var item in Model.Ideations)
        {

#line default
#line hidden
                BeginContext(555, 40, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n");
                EndContext();
#line 21 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                     if (item.Questions.Count > 0)
                    {
                        

#line default
#line hidden
                BeginContext(695, 35, false);
#line 23 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                   Write(item.Questions.ToList()[0].Question);

#line default
#line hidden
                EndContext();
#line 23 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                                                            
                    }

#line default
#line hidden
                BeginContext(755, 65, true);
                WriteLiteral("                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(821, 118, false);
#line 27 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
               Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
                        , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(939, 69, true);
                WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1009, 111, false);
#line 32 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
               Write(Html.ActionLink("Show ideas", "Ideation", "Idea"
                        , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(1120, 25, true);
                WriteLiteral("\r\n                </td>\r\n");
                EndContext();
#line 35 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                 if (item.Closed)
                {

#line default
#line hidden
                BeginContext(1199, 50, true);
                WriteLiteral("                    <td>\r\n                        ");
                EndContext();
                BeginContext(1250, 113, false);
#line 38 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                   Write(Html.ActionLink("Open", "OpenIdeation", "Idea"
                            , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(1363, 29, true);
                WriteLiteral("\r\n                    </td>\r\n");
                EndContext();
#line 41 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1452, 50, true);
                WriteLiteral("                    <td>\r\n                        ");
                EndContext();
                BeginContext(1503, 115, false);
#line 45 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                   Write(Html.ActionLink("Close", "CloseIdeation", "Idea"
                            , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(1618, 29, true);
                WriteLiteral("\r\n                    </td>\r\n");
                EndContext();
#line 48 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                }

#line default
#line hidden
                BeginContext(1666, 19, true);
                WriteLiteral("            </tr>\r\n");
                EndContext();
#line 50 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
        }

#line default
#line hidden
                BeginContext(1696, 24, true);
                WriteLiteral("    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
