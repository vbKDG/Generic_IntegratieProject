#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e971d69ebb0e08c27d6070c86f8088dd1fed04a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Project), @"mvc.1.0.view", @"/Views/Project/Project.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Project.cshtml", typeof(AspNetCore.Views_Project_Project))]
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e971d69ebb0e08c27d6070c86f8088dd1fed04a5", @"/Views/Project/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectAndQuestions>
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
            BeginContext(43, 881, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e971d69ebb0e08c27d6070c86f8088dd1fed04a53260", async() => {
                BeginContext(49, 60, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n    \r\n\r\n<h2 class=\"text-center\"> ");
                EndContext();
                BeginContext(110, 18, false);
#line 7 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
                    Write(Model.Project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(128, 9, true);
                WriteLiteral("</h2>\r\n\r\n");
                EndContext();
                BeginContext(138, 110, false);
#line 9 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
Write(Html.ActionLink("Create Ideation", "CreateIdeationPage", "Project" , new {projectId=@Model.Project.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(248, 108, true);
                WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideation Id </p>\r\n        </th>\r\n    </tr>\r\n");
                EndContext();
#line 16 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
     foreach (var item in Model.Project.Ideations)
    {

#line default
#line hidden
                BeginContext(415, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(464, 46, false);
#line 20 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.DisplayFor( modelItem => item.IdeationId));

#line default
#line hidden
                EndContext();
                BeginContext(510, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(566, 114, false);
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
                    , new { ideationId=item.IdeationId }));

#line default
#line hidden
                EndContext();
                BeginContext(680, 69, true);
                WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
                EndContext();
                BeginContext(750, 104, false);
#line 28 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                    , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(854, 38, true);
                WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
                EndContext();
#line 33 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
    }

#line default
#line hidden
                BeginContext(899, 18, true);
                WriteLiteral("</table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectAndQuestions> Html { get; private set; }
    }
}
#pragma warning restore 1591
