#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bbc3c7f0186038aabdd3661b6d6a170b45360b8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bbc3c7f0186038aabdd3661b6d6a170b45360b8", @"/Views/Project/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 182, true);
            WriteLiteral("\r\n<h1>Projects</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Name</p>\r\n        </th>\r\n        <th>\r\n            <p>Description</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(259, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(308, 39, false);
#line 18 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(347, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(403, 46, false);
#line 21 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
           Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
            EndContext();
            BeginContext(449, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(505, 124, false);
#line 24 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
           Write(Html.ActionLink("Questionnaires", "Questionnaires", "Questionnaire"
                    , new { projectId=item.projectId }));

#line default
#line hidden
            EndContext();
            BeginContext(629, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(685, 99, false);
#line 28 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
           Write(Html.ActionLink("Ideations", "Project", "Project"
                    , new { id=item.projectId }));

#line default
#line hidden
            EndContext();
            BeginContext(784, 54, true);
            WriteLiteral("\r\n                \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Projects.cshtml"
    }

#line default
#line hidden
            BeginContext(845, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
