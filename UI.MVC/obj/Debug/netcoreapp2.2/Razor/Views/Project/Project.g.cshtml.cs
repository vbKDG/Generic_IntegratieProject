#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a11cecc97bfa344eae114ed9f8401d5e9a845a"
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
#line 1 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a11cecc97bfa344eae114ed9f8401d5e9a845a", @"/Views/Project/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectAndQuestions>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 7, true);
            WriteLiteral("\r\n<h2> ");
            EndContext();
            BeginContext(51, 18, false);
#line 4 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
Write(Model.project.name);

#line default
#line hidden
            EndContext();
            BeginContext(69, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(79, 110, false);
#line 6 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
Write(Html.ActionLink("Create Ideation", "CreateIdeationPage", "Project" , new {projectId=@Model.project.projectId}));

#line default
#line hidden
            EndContext();
            BeginContext(189, 170, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideation Id </p>\r\n        </th>\r\n\r\n        <th>\r\n            <p>Question</p>\r\n        </th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 18 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
     foreach (var item in Model.ideationQuestions)
    {

#line default
#line hidden
            BeginContext(418, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(467, 55, false);
#line 22 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.DisplayFor( modelItem => item.ideation.ideationId));

#line default
#line hidden
            EndContext();
            BeginContext(522, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(592, 43, false);
#line 26 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(635, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(691, 123, false);
#line 29 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
                    , new { ideationId=item.ideation.ideationId }));

#line default
#line hidden
            EndContext();
            BeginContext(814, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(884, 100, false);
#line 34 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.ActionLink("Ideas", "Ideas", "Idea"
                    , new { id=item.ideation.ideationId }));

#line default
#line hidden
            EndContext();
            BeginContext(984, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\Project.cshtml"
    }

#line default
#line hidden
            BeginContext(1029, 8, true);
            WriteLiteral("</table>");
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
