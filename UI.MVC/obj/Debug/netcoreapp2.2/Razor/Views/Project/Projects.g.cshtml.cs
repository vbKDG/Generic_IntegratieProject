#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a81aea24caff2b1a3e557c8f77f857c14397a7c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Projects), @"mvc.1.0.view", @"/Views/Project/Projects.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Projects.cshtml", typeof(AspNetCore.Views_Project_Projects))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81aea24caff2b1a3e557c8f77f857c14397a7c4", @"/Views/Project/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("projectspage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(40, 7094, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a81aea24caff2b1a3e557c8f77f857c14397a7c43589", async() => {
                BeginContext(64, 2426, true);
                WriteLiteral(@"
<a class=""previousButton"" onclick=""previousPage()"">&laquo; Previous</a>
<div class=""container"">

     <div class=""row center-block"">
            
                <div class=""dark-overlay"">
                    <div class=""container"">
    
                        <div class=""col-lg-9"">
                            <div class=""card bg-light card-form"">
                                <div class=""text-center"">
                                    <h1 class=""display-4"">Projects</h1>
                                    <h4>Here is a list of all the Projects.</h4>
                                    
                                </div>
                                <div class=""card-body"">
                                
    
                                    <table class=""table"">
                                        <tr>
                                            <th>
                                                <p>Name</p>
                                            </th>
     ");
                WriteLiteral(@"                                       <th>
                                                <p>Description</p>
                                            </th>
                                            <th>
                                                <p>Ideations</p>
                                            </th>
                                            <th>
                                                <p>Questionnaires</p>
                                            </th>
                                            <th>
                                                <p>Details</p>
                                            </th>
                                            <th>
                                                <p>Edit</p>
                                            </th>
                                            <th>
                                                <p>Close</p>
                                            </th>
                               ");
                WriteLiteral(@"             
                                                                                        
                                            
                                            
                                            
                                            
                                        </tr>
                                        
");
                EndContext();
#line 54 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
                BeginContext(2603, 156, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(2760, 39, false);
#line 58 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(2799, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(2963, 46, false);
#line 61 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(3009, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(3173, 137, false);
#line 64 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                               Write(Html.ActionLink("Ideations", "Ideations", "Project"
                                                        , new {id = item.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(3310, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(3474, 160, false);
#line 68 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                               Write(Html.ActionLink("Questionnaires", "Questionnaires", "Questionnaire"
                                                        , new {projectId = item.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(3634, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(3798, 150, false);
#line 72 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                               Write(Html.ActionLink("Details", "ProjectDetailPage", "Project"
                                                        , new {projectId = item.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(3948, 163, true);
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
                EndContext();
                BeginContext(4112, 145, false);
#line 76 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                               Write(Html.ActionLink("Edit", "EditProjectPage", "Project"
                                                        , new {projectId = item.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(4257, 57, true);
                WriteLiteral("\r\n                                                </td>\r\n");
                EndContext();
#line 79 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                                 if (item.Closed)
                                                {

#line default
#line hidden
                BeginContext(4432, 114, true);
                WriteLiteral("                                                    <td>\r\n                                                        ");
                EndContext();
                BeginContext(4547, 145, false);
#line 82 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                                   Write(Html.ActionLink("Open", "OpenProject", "Project"
                                                            , new {projectId = item.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(4692, 61, true);
                WriteLiteral("\r\n                                                    </td>\r\n");
                EndContext();
#line 85 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
                BeginContext(4909, 114, true);
                WriteLiteral("                                                    <td>\r\n                                                        ");
                EndContext();
                BeginContext(5024, 147, false);
#line 89 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                                   Write(Html.ActionLink("Close", "CloseProject", "Project"
                                                            , new {projectId = item.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(5171, 61, true);
                WriteLiteral("\r\n                                                    </td>\r\n");
                EndContext();
#line 92 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                                }

#line default
#line hidden
                BeginContext(5283, 51, true);
                WriteLiteral("                                            </tr>\r\n");
                EndContext();
#line 94 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                        }

#line default
#line hidden
                BeginContext(5377, 1085, true);
                WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                        </div>
                        
                         <div class=""col-lg-3"" id=""bodyadmin"">
                                                    <div class=""card text-center bg-success text-white mb-3"">
                                                                            <div class=""card-body"">
                                                                                <h3>Create a Project</h3>
                                                                                <h4 class=""display-4"">
                                                                                    <i class=""fas fa-pencil-alt""></i> 
                                                                                </h4>
                                                                                <div class=""btn-success center-block text-light"">
                   ");
                WriteLiteral("                                                             ");
                EndContext();
                BeginContext(6463, 54, false);
#line 108 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
                                                                           Write(Html.ActionLink("Add", "CreateProjectPage", "Project"));

#line default
#line hidden
                EndContext();
                BeginContext(6517, 610, true);
                WriteLiteral(@"
                                                                                </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
