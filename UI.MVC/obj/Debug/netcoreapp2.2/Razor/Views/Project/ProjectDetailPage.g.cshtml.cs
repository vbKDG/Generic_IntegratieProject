#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a563fd380d61cb939efb82ef3adced8df09713bc"
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a563fd380d61cb939efb82ef3adced8df09713bc", @"/Views/Project/ProjectDetailPage.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a563fd380d61cb939efb82ef3adced8df09713bc4540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a563fd380d61cb939efb82ef3adced8df09713bc6536", async() => {
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
#line 7 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
        Write(Model.project.name);

#line default
#line hidden
            EndContext();
            BeginContext(269, 47, true);
            WriteLiteral("</h2>\r\n<h4>Description of the project</h4>\r\n<p>");
            EndContext();
            BeginContext(317, 25, false);
#line 9 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
Write(Model.project.description);

#line default
#line hidden
            EndContext();
            BeginContext(342, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.project.imageField != null)
{

#line default
#line hidden
            BeginContext(392, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 400, "", 447, 1);
#line 12 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 405, Model.project.imageField.GetImageString(), 405, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 16, true);
            WriteLiteral(" width=\"500\"/>\r\n");
            EndContext();
#line 13 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
}

#line default
#line hidden
            BeginContext(466, 92, true);
            WriteLiteral("<h4>Phases of the project</h4>\r\n<div class=\"phaseContainer\">\r\n    <ul class=\"progressbar\">\r\n");
            EndContext();
#line 17 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
         for (int i = 0; i < @Model.project.phases.Count(); i++)
        {
            if (i == 0)
            {
                if (@DateTime.Now > @Model.project.phases.ToList()[i].startDate)
                {

#line default
#line hidden
            BeginContext(776, 68, true);
            WriteLiteral("                    <li class=\"active popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(845, 37, false);
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                               Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(882, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(887, 23, false);
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                         Write(Model.project.startDate);

#line default
#line hidden
            EndContext();
            BeginContext(910, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(977, 61, true);
            WriteLiteral("                    <li class=\"popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1039, 37, false);
#line 27 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                        Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1081, 23, false);
#line 27 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                  Write(Model.project.startDate);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 28 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
            }
            else if (i == @Model.project.phases.Count() - 1)
            {
                if (@DateTime.Now > @Model.project.phases.ToList()[i].startDate)
                {

#line default
#line hidden
            BeginContext(1323, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("id", "  id=\"", 1346, "\"", 1360, 2);
            WriteAttributeValue("", 1352, "phase-", 1352, 6, true);
#line 34 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 1358, i, 1358, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1361, 46, true);
            WriteLiteral("  class=\"active popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1408, 37, false);
#line 34 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                               Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1445, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1450, 21, false);
#line 34 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                                         Write(Model.project.endDate);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1538, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("id", "  id=\"", 1561, "\"", 1575, 2);
            WriteAttributeValue("", 1567, "phase-", 1567, 6, true);
#line 38 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 1573, i, 1573, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1576, 38, true);
            WriteLiteral(" class=\"popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1615, 37, false);
#line 38 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                       Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 4, true);
            WriteLiteral("<br>");
            EndContext();
            BeginContext(1657, 21, false);
#line 38 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                                                                 Write(Model.project.endDate);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 39 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
            }
            else
            {
                if (@DateTime.Now > @Model.project.phases.ToList()[i].startDate)
                {

#line default
#line hidden
            BeginContext(1853, 68, true);
            WriteLiteral("                    <li class=\"active popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(1922, 37, false);
#line 45 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                               Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(1959, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 46 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2026, 61, true);
            WriteLiteral("                    <li class=\"popper\" data-toggle=\"popover\">");
            EndContext();
            BeginContext(2088, 37, false);
#line 49 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                        Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(2125, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 50 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }

            }

#line default
#line hidden
            BeginContext(2168, 67, true);
            WriteLiteral("            <div class=\"popper-content hide\">\r\n                <h4>");
            EndContext();
            BeginContext(2236, 37, false);
#line 54 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
               Write(Model.project.phases.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(2273, 31, true);
            WriteLiteral("</h4>\r\n                <p>From ");
            EndContext();
            BeginContext(2305, 42, false);
#line 55 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.project.phases.ToList()[i].startDate);

#line default
#line hidden
            EndContext();
            BeginContext(2347, 32, true);
            WriteLiteral(" <br>\r\n                    Till ");
            EndContext();
            BeginContext(2380, 40, false);
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    Write(Model.project.phases.ToList()[i].endDate);

#line default
#line hidden
            EndContext();
            BeginContext(2420, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(2446, 44, false);
#line 57 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
              Write(Model.project.phases.ToList()[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(2490, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 59 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
        }

#line default
#line hidden
            BeginContext(2527, 21, true);
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n");
            EndContext();
#line 63 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.project.ideations.Count > 0)
{

#line default
#line hidden
            BeginContext(2593, 129, true);
            WriteLiteral("    <table class=\"table\">\r\n        <h4>Top 5 ideations</h4>\r\n        <tr>\r\n            <th>Central question</th>\r\n        </tr>\r\n");
            EndContext();
#line 70 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
         if (@Model.project.ideations.Count - 1 < 4)
        {
            foreach (var ideationQuestion in @Model.ideationQuestions)
            {

#line default
#line hidden
            BeginContext(2874, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2947, 25, false);
#line 76 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(ideationQuestion.question);

#line default
#line hidden
            EndContext();
            BeginContext(2972, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3052, 133, false);
#line 79 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                            , new {ideationId = ideationQuestion.ideation.ideationId}));

#line default
#line hidden
            EndContext();
            BeginContext(3185, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 83 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }
        else
        {
            for (var i = 0; i < 5; i++)
            {

#line default
#line hidden
            BeginContext(3344, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3417, 44, false);
#line 91 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.ideationQuestions.ToList()[i].question);

#line default
#line hidden
            EndContext();
            BeginContext(3461, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3541, 145, false);
#line 94 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                            , new {id = @Model.ideationQuestions.ToList()[i].ideation.ideationId}));

#line default
#line hidden
            EndContext();
            BeginContext(3686, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 98 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3764, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
            BeginContext(3783, 105, false);
#line 101 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
Write(Html.ActionLink("Show all ideations", "Project", "Project"
        , new { id=Model.project.projectId }));

#line default
#line hidden
            EndContext();
#line 102 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                             
}

#line default
#line hidden
            BeginContext(3893, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 105 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (Model.project.questionnaires.Count > 0)
{

#line default
#line hidden
            BeginContext(3944, 252, true);
            WriteLiteral("    <h4>Top 5 questionnaires</h4>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                <p>Questionnaire name</p>\r\n            </th>\r\n            <th>\r\n                <p>Amount of questions</p>\r\n            </th>\r\n        </tr>\r\n");
            EndContext();
#line 117 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
         if (@Model.project.questionnaires.ToList().Count - 1 < 4)
        {
            foreach (var questionnaire in @Model.project.questionnaires)
            {

#line default
#line hidden
            BeginContext(4364, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4437, 18, false);
#line 123 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(questionnaire.name);

#line default
#line hidden
            EndContext();
            BeginContext(4455, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4535, 28, false);
#line 126 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(questionnaire.questionAmount);

#line default
#line hidden
            EndContext();
            BeginContext(4563, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4643, 147, false);
#line 129 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                            , new { questionnaireId=questionnaire.id }));

#line default
#line hidden
            EndContext();
            BeginContext(4790, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 133 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }
        else
        {
            for (var i = 0; i < 5; i++)
            {

#line default
#line hidden
            BeginContext(4949, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5022, 45, false);
#line 141 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.project.questionnaires.ToList()[i].name);

#line default
#line hidden
            EndContext();
            BeginContext(5067, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5147, 55, false);
#line 144 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Model.project.questionnaires.ToList()[i].questionAmount);

#line default
#line hidden
            EndContext();
            BeginContext(5202, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5282, 175, false);
#line 147 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                            , new { questionnaireId=@Model.project.questionnaires.ToList()[i].id }));

#line default
#line hidden
            EndContext();
            BeginContext(5457, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 151 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(5535, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
            BeginContext(5554, 130, false);
#line 154 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
Write(Html.ActionLink("Show all questionnaires", "Questionnaires", "Questionnaire"
        , new { projectId=Model.project.projectId }));

#line default
#line hidden
            EndContext();
#line 155 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                    
}

#line default
#line hidden
            BeginContext(5689, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 158 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
 if (@Model.ideationQuestions.Count > 0)
{

#line default
#line hidden
            BeginContext(5736, 27, true);
            WriteLiteral("    <h3>Central questions (");
            EndContext();
            BeginContext(5764, 29, false);
#line 160 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5793, 132, true);
            WriteLiteral(")</h3>\r\n    <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\" role=\"listbox\">\r\n");
            EndContext();
#line 163 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
             for (var i = 0; i < @Model.ideationQuestions.Count; i++)
            {
                if (i == 0)
                {

#line default
#line hidden
            BeginContext(6059, 74, true);
            WriteLiteral("                    <div class=\"item active\">\r\n                        <p>");
            EndContext();
            BeginContext(6134, 44, false);
#line 168 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].question);

#line default
#line hidden
            EndContext();
            BeginContext(6178, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(6212, 47, false);
#line 169 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(6259, 32, true);
            WriteLiteral("</p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6291, "\"", 6356, 2);
            WriteAttributeValue("", 6298, "http://", 6298, 7, true);
#line 170 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 6305, Model.ideationQuestions.ToList()[i].backgroundInfo, 6305, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6357, 55, true);
            WriteLiteral(">More background info</a>\r\n                    </div>\r\n");
            EndContext();
#line 172 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(6472, 67, true);
            WriteLiteral("                    <div class=\"item\">\r\n                        <p>");
            EndContext();
            BeginContext(6540, 44, false);
#line 176 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].question);

#line default
#line hidden
            EndContext();
            BeginContext(6584, 33, true);
            WriteLiteral("</p>\r\n                        <p>");
            EndContext();
            BeginContext(6618, 47, false);
#line 177 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.ideationQuestions.ToList()[i].description);

#line default
#line hidden
            EndContext();
            BeginContext(6665, 32, true);
            WriteLiteral("</p>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6697, "\"", 6762, 2);
            WriteAttributeValue("", 6704, "http://", 6704, 7, true);
#line 178 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 6711, Model.ideationQuestions.ToList()[i].backgroundInfo, 6711, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6763, 55, true);
            WriteLiteral(">More background info</a>\r\n                    </div>\r\n");
            EndContext();
#line 180 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(6852, 532, true);
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
#line 193 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
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
