#pragma checksum "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7e7acbd34160e55c651c97376c9403ffffc3a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_ShowResultsPage), @"mvc.1.0.view", @"/Views/Questionnaire/ShowResultsPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/ShowResultsPage.cshtml", typeof(AspNetCore.Views_Questionnaire_ShowResultsPage))]
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
#line 1 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec7e7acbd34160e55c651c97376c9403ffffc3a9", @"/Views/Questionnaire/ShowResultsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_ShowResultsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionResultModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 126, true);
            WriteLiteral("\r\n<a class=\"previousButton\" onclick=\"previousPage()\">&laquo; Previous</a>\r\n<h1>Questionnaire results</h1>\r\n<h3>Questionnaire: ");
            EndContext();
            BeginContext(170, 24, false);
#line 6 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
              Write(Model.Questionnaire.Name);

#line default
#line hidden
            EndContext();
            BeginContext(194, 46, true);
            WriteLiteral("</h3>\r\n<p>The questionnaire has been answered ");
            EndContext();
            BeginContext(241, 28, false);
#line 7 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                  Write(Model.AnsweredQuestionAmount);

#line default
#line hidden
            EndContext();
            BeginContext(269, 40, true);
            WriteLiteral(" time(s).</p>\r\n\r\n<table class=\"table\">\r\n");
            EndContext();
#line 10 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
     if (Model.Questions == null)
    {

#line default
#line hidden
            BeginContext(351, 85, true);
            WriteLiteral("        <p>Unfortunately there is no data collected for this questionnaire yet.</p>\r\n");
            EndContext();
#line 13 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
    }
    else
    {
        for (var i = 0; i < Model.Questions.Count(); i++)
        {

#line default
#line hidden
            BeginContext(530, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <h4>");
            EndContext();
            BeginContext(595, 39, false);
#line 20 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                   Write(Model.Questions.ToList()[i].TheQuestion);

#line default
#line hidden
            EndContext();
            BeginContext(634, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 21 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                     foreach (var o in @Model.Questions.ToList()[i].Options)
                    {
                        

#line default
#line hidden
            BeginContext(767, 11, false);
#line 23 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                   Write(o.TheOption);

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                    
                        foreach (var aqa in @Model.OptionsAmounts)
                        {
                            if (aqa.OptionId == o.OptionId)
                            {
                                if (o.Question.QuestionType == QuestionType.CHECK_BOX)
                                {

#line default
#line hidden
            BeginContext(1090, 44, true);
            WriteLiteral("                                    <span> (");
            EndContext();
            BeginContext(1135, 9, false);
#line 30 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                       Write(aqa.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 31 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                }
                                else
                                {
                                    double percentage = Convert.ToDouble(aqa.Count) / Convert.ToDouble(@Model.AnsweredQuestionAmount) * 100;

#line default
#line hidden
            BeginContext(1404, 44, true);
            WriteLiteral("                                    <span> (");
            EndContext();
            BeginContext(1449, 9, false);
#line 35 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                       Write(aqa.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 2, true);
            WriteLiteral(") ");
            EndContext();
            BeginContext(1461, 27, false);
#line 35 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                                   Write(percentage.ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 10, true);
            WriteLiteral("%</span>\r\n");
            EndContext();
#line 36 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                                }
                            }
                        }

#line default
#line hidden
            BeginContext(1591, 30, true);
            WriteLiteral("                        <br>\r\n");
            EndContext();
#line 40 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
                    }

#line default
#line hidden
            BeginContext(1644, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\ShowResultsPage.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1704, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionResultModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
