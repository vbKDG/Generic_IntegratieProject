#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa76439f05d7ae40290a444ef5d7f4064a0807bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Ideas), @"mvc.1.0.view", @"/Views/Project/Ideas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Ideas.cshtml", typeof(AspNetCore.Views_Project_Ideas))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa76439f05d7ae40290a444ef5d7f4064a0807bd", @"/Views/Project/Ideas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Ideas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Idea>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 198, true);
            WriteLiteral("\n<h1>Projects</h1>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            <p>User</p>\n        </th>\n        <th>\n            <p>Title</p>\n        </th>\n        \n        <th>Content</th>\n    </tr>\n");
            EndContext();
#line 16 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(269, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(316, 34, false);
#line 20 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml"
           Write(item.user.firstName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(350, 1, true);
            WriteLiteral(".");
            EndContext();
            BeginContext(352, 48, false);
#line 20 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.user.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(400, 104, true);
            WriteLiteral("\n            \n           \n                          \n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(505, 41, false);
#line 26 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml"
           Write(Html.DisplayFor(modelItem => item.ideaId));

#line default
#line hidden
            EndContext();
            BeginContext(546, 65, true);
            WriteLiteral("\n            </td>\n            \n            <td>\n                ");
            EndContext();
            BeginContext(612, 41, false);
#line 30 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml"
           Write(Html.DisplayFor(modelItem => item.ideaId));

#line default
#line hidden
            EndContext();
            BeginContext(653, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 33 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\Ideas.cshtml"
    }

#line default
#line hidden
            BeginContext(692, 19, true);
            WriteLiteral("    \n    \n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Idea>> Html { get; private set; }
    }
}
#pragma warning restore 1591
