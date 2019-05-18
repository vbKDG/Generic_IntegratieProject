#pragma checksum "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a43b5a04ab05913040048be83dfa4e650d3fc35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_Questionnaires), @"mvc.1.0.view", @"/Views/Questionnaire/Questionnaires.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/Questionnaires.cshtml", typeof(AspNetCore.Views_Questionnaire_Questionnaires))]
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
#line 1 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a43b5a04ab05913040048be83dfa4e650d3fc35", @"/Views/Questionnaire/Questionnaires.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaires : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Questionnaire>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 27, true);
            WriteLiteral("\r\n<h1>Questionnaires</h1>\r\n");
            EndContext();
#line 4 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
 if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(133, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(151, 158, false);
#line 7 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
   Write(Html.ActionLink("Create a new questionnaire", "CreateQuestionnairePage", 
            "Questionnaire", new { projectId=Model.ToList()[0].project.projectId }));

#line default
#line hidden
            EndContext();
            BeginContext(309, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 10 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
}

#line default
#line hidden
            BeginContext(324, 169, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>name</p>\r\n        </th>\r\n        <th>\r\n            <p>Amount of questions</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 21 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
     foreach (var item in Model)
    {    

#line default
#line hidden
            BeginContext(538, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(587, 39, false);
#line 25 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(626, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(682, 49, false);
#line 28 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.DisplayFor(modelItem => item.questionAmount));

#line default
#line hidden
            EndContext();
            BeginContext(731, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(787, 130, false);
#line 31 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                    , new { questionnaireId=item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(917, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 34 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
             if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(1026, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1069, 128, false);
#line 37 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Show results", "ShowResultsPage", "Questionnaire"
                        , new { questionnaireId = item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1265, 124, false);
#line 41 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Edit", "EditQuestionnairePage", "Questionnaire"
                        , new {questionnaireId = item.id}));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 25, true);
            WriteLiteral(" | \r\n                    ");
            EndContext();
            BeginContext(1415, 128, false);
#line 43 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Delete", "DeleteQuestionnairePage", "Questionnaire"
                        , new {questionnaireId = item.id}));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 46 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
            }

#line default
#line hidden
            BeginContext(1583, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
        
    }

#line default
#line hidden
            BeginContext(1615, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Questionnaire>> Html { get; private set; }
    }
}
#pragma warning restore 1591
