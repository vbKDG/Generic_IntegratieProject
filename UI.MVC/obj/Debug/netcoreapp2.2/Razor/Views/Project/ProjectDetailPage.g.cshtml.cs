#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62b2afd6bda6c1f087d52978279d6b6347a3d05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ProjectDetailPage), @"mvc.1.0.view", @"/Views/Project/ProjectDetailPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/ProjectDetailPage.cshtml", typeof(AspNetCore.Views_Project_ProjectDetailPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62b2afd6bda6c1f087d52978279d6b6347a3d05", @"/Views/Project/ProjectDetailPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_ProjectDetailPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/phaseLine.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/phaseLine.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(114, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a62b2afd6bda6c1f087d52978279d6b6347a3d054597", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(183, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a62b2afd6bda6c1f087d52978279d6b6347a3d056612", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(233, 17, true);
            WriteLiteral("\r\n\r\n<h2>Project: ");
            EndContext();
            BeginContext(251, 18, false);
#line 7 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
        Write(Model.project.name);

#line default
#line hidden
            EndContext();
            BeginContext(269, 47, true);
            WriteLiteral("</h2>\r\n<h4>Description of the project</h4>\r\n<p>");
            EndContext();
            BeginContext(317, 25, false);
#line 9 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
Write(Model.project.description);

#line default
#line hidden
            EndContext();
            BeginContext(342, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.project.imageField != null)
{

#line default
#line hidden
            BeginContext(392, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 400, "", 447, 1);
#line 12 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 405, Model.project.imageField.GetImageString(), 405, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 16, true);
            WriteLiteral(" width=\"500\"/>\r\n");
            EndContext();
#line 13 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
}

#line default
#line hidden
#line 14 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.project.phases.Count > 0)
{

#line default
#line hidden
            BeginContext(508, 104, true);
            WriteLiteral("    <h4>Phases of the project</h4>\r\n    <div class=\"phaseContainer\">\r\n        <ul class=\"progressbar\">\r\n");
            EndContext();
#line 19 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
             for (int i = 0; i < @Model.project.phases.Count(); i++)
            {
                if (i == 0)
                {
                    if (@DateTime.Now > @Model.project.phases.ToList()[i].startDate)
                    {

#line default
#line hidden
            BeginContext(854, 72, true);
            WriteLiteral("                        <li class=\"active popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(927, 37, false);
#line 25 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                   Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(964, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(969, 23, false);
#line 25 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                             Write(Model.project.startDate);

#line default
#line hidden
            EndContext();
            BeginContext(992, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 26 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1071, 65, true);
            WriteLiteral("                        <li class=\"popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1137, 37, false);
#line 29 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                            Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1174, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1179, 23, false);
#line 29 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                      Write(Model.project.startDate);

#line default
#line hidden
            EndContext();
            BeginContext(1202, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 30 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                }
                else if (i == @Model.project.phases.Count() - 1)
                {
                    if (@DateTime.Now > @Model.project.phases.ToList()[i].startDate)
                    {

#line default
#line hidden
            BeginContext(1445, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("id", "  id=\"", 1472, "\"", 1486, 2);
            WriteAttributeValue("", 1478, "phase-", 1478, 6, true);
#line 36 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 1484, i, 1484, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1487, 46, true);
            WriteLiteral("  class=\"active popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1534, 37, false);
#line 36 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                   Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1571, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1576, 21, false);
#line 36 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                                             Write(Model.project.endDate);

#line default
#line hidden
            EndContext();
            BeginContext(1597, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 37 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1676, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("id", "  id=\"", 1703, "\"", 1717, 2);
            WriteAttributeValue("", 1709, "phase-", 1709, 6, true);
#line 40 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 1715, i, 1715, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1718, 38, true);
            WriteLiteral(" class=\"popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1757, 37, false);
#line 40 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                           Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1794, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1799, 21, false);
#line 40 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                                     Write(Model.project.endDate);

#line default
#line hidden
            EndContext();
            BeginContext(1820, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 41 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                }
                else
                {
                    if (@DateTime.Now > @Model.project.phases.ToList()[i].startDate)
                    {

#line default
#line hidden
            BeginContext(2019, 72, true);
            WriteLiteral("                        <li class=\"active popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(2092, 37, false);
#line 47 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                   Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(2129, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 48 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2208, 65, true);
            WriteLiteral("                        <li class=\"popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(2274, 37, false);
#line 51 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                            Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(2311, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 52 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
    
                }

#line default
#line hidden
            BeginContext(2366, 75, true);
            WriteLiteral("                <div class=\"popper-content hide\">\r\n                    <h4>");
            EndContext();
            BeginContext(2442, 37, false);
#line 56 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(2479, 35, true);
            WriteLiteral("</h4>\r\n                    <p>From ");
            EndContext();
            BeginContext(2515, 42, false);
#line 57 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                       Write(Model.project.phases.ToList()[i].startDate);

#line default
#line hidden
            EndContext();
            BeginContext(2557, 36, true);
            WriteLiteral(" <br>\r\n                        Till ");
            EndContext();
            BeginContext(2594, 40, false);
#line 58 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        Write(Model.project.phases.ToList()[i].endDate);

#line default
#line hidden
            EndContext();
            BeginContext(2634, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2664, 44, false);
#line 59 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                  Write(Model.project.phases.ToList()[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(2708, 30, true);
            WriteLiteral("</p>\r\n                </div>\r\n");
            EndContext();
#line 61 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }

#line default
#line hidden
            BeginContext(2753, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 64 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
}

#line default
#line hidden
            BeginContext(2783, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.project.ideations.Count > 0)
{

#line default
#line hidden
            BeginContext(2830, 61, true);
            WriteLiteral("    <table class=\"table\">\r\n        <h4>Top 5 ideations</h4>\r\n");
            EndContext();
#line 70 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
         if (@Model.project.ideations.Count - 1 < 4)
        {
            foreach (var ideation in @Model.project.ideations)
            {

#line default
#line hidden
            BeginContext(3035, 159, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        Ideation\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3195, 116, false);
#line 79 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                            , new {ideationId = ideation.ideationId}));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 83 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }
        else
        {
            for (var i = 0; i < 5; i++)
            {

#line default
#line hidden
            BeginContext(3470, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3543, 44, false);
#line 91 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.ideationQuestions.ToList()[i].question);

#line default
#line hidden
            EndContext();
            BeginContext(3587, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3667, 145, false);
#line 94 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                            , new {id = @Model.ideationQuestions.ToList()[i].ideation.ideationId}));

#line default
#line hidden
            EndContext();
            BeginContext(3812, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 98 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3890, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
            BeginContext(3909, 105, false);
#line 101 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
Write(Html.ActionLink("Show all ideations", "Project", "Project"
        , new { id=Model.project.projectId }));

#line default
#line hidden
            EndContext();
#line 102 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                             
}

#line default
#line hidden
            BeginContext(4019, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 105 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (Model.project.questionnaires.Count > 0)
{

#line default
#line hidden
            BeginContext(4070, 252, true);
            WriteLiteral("    <h4>Top 5 questionnaires</h4>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                <p>Questionnaire name</p>\r\n            </th>\r\n            <th>\r\n                <p>Amount of questions</p>\r\n            </th>\r\n        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
         if (@Model.project.questionnaires.ToList().Count - 1 < 4)
        {
            foreach (var questionnaire in @Model.project.questionnaires)
            {

#line default
#line hidden
            BeginContext(4490, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4563, 18, false);
#line 123 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(questionnaire.name);

#line default
#line hidden
            EndContext();
            BeginContext(4581, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4661, 28, false);
#line 126 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(questionnaire.questionAmount);

#line default
#line hidden
            EndContext();
            BeginContext(4689, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4769, 147, false);
#line 129 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                            , new { questionnaireId=questionnaire.id }));

#line default
#line hidden
            EndContext();
            BeginContext(4916, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 133 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }
        else
        {
            for (var i = 0; i < 5; i++)
            {

#line default
#line hidden
            BeginContext(5075, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5148, 45, false);
#line 141 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.project.questionnaires.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(5193, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5273, 55, false);
#line 144 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.project.questionnaires.ToList()[i].questionAmount);

#line default
#line hidden
            EndContext();
            BeginContext(5328, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5408, 175, false);
#line 147 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                            , new { questionnaireId=@Model.project.questionnaires.ToList()[i].id }));

#line default
#line hidden
            EndContext();
            BeginContext(5583, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 151 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(5661, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
            BeginContext(5680, 130, false);
#line 154 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
Write(Html.ActionLink("Show all questionnaires", "Questionnaires", "Questionnaire"
        , new { projectId=Model.project.projectId }));

#line default
#line hidden
            EndContext();
#line 155 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                    
}

#line default
#line hidden
            BeginContext(5815, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 158 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.ideationQuestions.Count > 0)
{

#line default
#line hidden
            BeginContext(5862, 27, true);
            WriteLiteral("    <h3>Central questions (");
            EndContext();
            BeginContext(5890, 29, false);
#line 160 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5919, 132, true);
            WriteLiteral(")</h3>\r\n    <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\" role=\"listbox\">\r\n");
            EndContext();
#line 163 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
             for (var i = 0; i < @Model.ideationQuestions.Count; i++)
            {
                if (i == 0)
                {

#line default
#line hidden
            BeginContext(6185, 74, true);
            WriteLiteral("                    <div class=\"item active\">\r\n                        <p>");
            EndContext();
            BeginContext(6260, 44, false);
#line 168 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].question);

#line default
#line hidden
            EndContext();
            BeginContext(6304, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(6338, 47, false);
#line 169 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(6385, 32, true);
            WriteLiteral("</p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6417, "\"", 6482, 2);
            WriteAttributeValue("", 6424, "http://", 6424, 7, true);
#line 170 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 6431, Model.ideationQuestions.ToList()[i].backgroundInfo, 6431, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6483, 55, true);
            WriteLiteral(">More background info</a>\r\n                    </div>\r\n");
            EndContext();
#line 172 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(6598, 67, true);
            WriteLiteral("                    <div class=\"item\">\r\n                        <p>");
            EndContext();
            BeginContext(6666, 44, false);
#line 176 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].question);

#line default
#line hidden
            EndContext();
            BeginContext(6710, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(6744, 47, false);
#line 177 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(6791, 32, true);
            WriteLiteral("</p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6823, "\"", 6888, 2);
            WriteAttributeValue("", 6830, "http://", 6830, 7, true);
#line 178 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 6837, Model.ideationQuestions.ToList()[i].backgroundInfo, 6837, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6889, 55, true);
            WriteLiteral(">More background info</a>\r\n                    </div>\r\n");
            EndContext();
#line 180 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(6978, 532, true);
            WriteLiteral(@"        </div>
            
        <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
");
            EndContext();
#line 193 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
