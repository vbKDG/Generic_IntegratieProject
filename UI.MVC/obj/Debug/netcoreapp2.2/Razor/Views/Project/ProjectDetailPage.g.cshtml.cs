#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f82a863cc19eded98ccad640728b268bd1052f"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f82a863cc19eded98ccad640728b268bd1052f", @"/Views/Project/ProjectDetailPage.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(114, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f82a863cc19eded98ccad640728b268bd1052f4728", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62f82a863cc19eded98ccad640728b268bd1052f6740", async() => {
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
            BeginContext(233, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(237, 7663, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f82a863cc19eded98ccad640728b268bd1052f7999", async() => {
                BeginContext(384, 42, true);
                WriteLiteral("\r\n<div id=\"fontFamily\">\r\n    <h2>Project: ");
                EndContext();
                BeginContext(427, 18, false);
#line 9 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            Write(Model.Project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(445, 55, true);
                WriteLiteral("</h2>\r\n    <h4>Description of the project</h4>\r\n    <p>");
                EndContext();
                BeginContext(501, 25, false);
#line 11 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
  Write(Model.Project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(526, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 12 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
     if (@Model.Project.ImageField != null)
    {

#line default
#line hidden
                BeginContext(584, 12, true);
                WriteLiteral("        <img");
                EndContext();
                BeginWriteAttribute("src", " src=", 596, "", 636, 1);
#line 14 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 601, Model.Project.ImageField.ImageData, 601, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(636, 16, true);
                WriteLiteral(" width=\"500\"/>\r\n");
                EndContext();
#line 15 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
    }

#line default
#line hidden
                BeginContext(659, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 16 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
     if (@Model.Project.Phases.Count > 0)
    {

#line default
#line hidden
                BeginContext(709, 116, true);
                WriteLiteral("        <h4>Phases of the project</h4>\r\n        <div class=\"phaseContainer\">\r\n            <ul class=\"progressbar\">\r\n");
                EndContext();
#line 21 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                 for (int i = 0; i < @Model.Project.Phases.Count(); i++)
                {
                    if (i == 0)
                    {
                        if (@DateTime.Now > @Model.Project.Phases.ToList()[i].StartDate)
                        {

#line default
#line hidden
                BeginContext(1091, 110, true);
                WriteLiteral("                            <li class=\"active popper\" data-toggle=\"popover\">\r\n                                ");
                EndContext();
                BeginContext(1202, 37, false);
#line 28 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                           Write(Model.Project.Phases.ToList()[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(1239, 4, true);
                WriteLiteral("<br>");
                EndContext();
                BeginContext(1244, 23, false);
#line 28 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                     Write(Model.Project.StartDate);

#line default
#line hidden
                EndContext();
                BeginContext(1267, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 29 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1358, 103, true);
                WriteLiteral("                            <li class=\"popper\" data-toggle=\"popover\">\r\n                                ");
                EndContext();
                BeginContext(1462, 37, false);
#line 33 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                           Write(Model.Project.Phases.ToList()[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(1499, 4, true);
                WriteLiteral("<br>");
                EndContext();
                BeginContext(1504, 23, false);
#line 33 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                     Write(Model.Project.StartDate);

#line default
#line hidden
                EndContext();
                BeginContext(1527, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 34 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        }
                    }
                    else if (i == @Model.Project.Phases.Count() - 1)
                    {
                        if (@DateTime.Now > @Model.Project.Phases.ToList()[i].StartDate)
                        {

#line default
#line hidden
                BeginContext(1794, 31, true);
                WriteLiteral("                            <li");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1825, "\"", 1838, 2);
                WriteAttributeValue("", 1830, "phase-", 1830, 6, true);
#line 40 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 1836, i, 1836, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1839, 79, true);
                WriteLiteral(" class=\"active popper\" data-toggle=\"popover\">\r\n                                ");
                EndContext();
                BeginContext(1919, 37, false);
#line 41 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                           Write(Model.Project.Phases.ToList()[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(1956, 4, true);
                WriteLiteral("<br>");
                EndContext();
                BeginContext(1961, 21, false);
#line 41 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                     Write(Model.Project.EndDate);

#line default
#line hidden
                EndContext();
                BeginContext(1982, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 42 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2073, 31, true);
                WriteLiteral("                            <li");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2104, "\"", 2117, 2);
                WriteAttributeValue("", 2109, "phase-", 2109, 6, true);
#line 45 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 2115, i, 2115, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2118, 72, true);
                WriteLiteral(" class=\"popper\" data-toggle=\"popover\">\r\n                                ");
                EndContext();
                BeginContext(2191, 32, false);
#line 46 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                           Write(Model.Project.Phases.ToList()[i]);

#line default
#line hidden
                EndContext();
                BeginContext(2223, 9, true);
                WriteLiteral(".?ame<br>");
                EndContext();
                BeginContext(2233, 21, false);
#line 46 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                     Write(Model.Project.EndDate);

#line default
#line hidden
                EndContext();
                BeginContext(2254, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 47 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        }
                    }
                    else
                    {
                        if (@DateTime.Now > @Model.Project.Phases.ToList()[i].StartDate)
                        {

#line default
#line hidden
                BeginContext(2477, 76, true);
                WriteLiteral("                            <li class=\"active popper\" data-toggle=\"popover\">");
                EndContext();
                BeginContext(2554, 37, false);
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                       Write(Model.Project.Phases.ToList()[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(2591, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 54 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2682, 69, true);
                WriteLiteral("                            <li class=\"popper\" data-toggle=\"popover\">");
                EndContext();
                BeginContext(2752, 37, false);
#line 57 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                                Write(Model.Project.Phases.ToList()[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(2789, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 58 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(2846, 83, true);
                WriteLiteral("                    <div class=\"popper-content hide\">\r\n                        <h4>");
                EndContext();
                BeginContext(2930, 37, false);
#line 61 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                       Write(Model.Project.Phases.ToList()[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(2967, 69, true);
                WriteLiteral("</h4>\r\n                        <p>\r\n                            From ");
                EndContext();
                BeginContext(3037, 42, false);
#line 63 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                            Write(Model.Project.Phases.ToList()[i].StartDate);

#line default
#line hidden
                EndContext();
                BeginContext(3079, 40, true);
                WriteLiteral(" <br>\r\n                            Till ");
                EndContext();
                BeginContext(3120, 40, false);
#line 64 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                            Write(Model.Project.Phases.ToList()[i].EndDate);

#line default
#line hidden
                EndContext();
                BeginContext(3160, 33, true);
                WriteLiteral("</p>\r\n                        <p>");
                EndContext();
                BeginContext(3194, 44, false);
#line 65 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                      Write(Model.Project.Phases.ToList()[i].Description);

#line default
#line hidden
                EndContext();
                BeginContext(3238, 34, true);
                WriteLiteral("</p>\r\n                    </div>\r\n");
                EndContext();
#line 67 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                }

#line default
#line hidden
                BeginContext(3291, 35, true);
                WriteLiteral("            </ul>\r\n        </div>\r\n");
                EndContext();
#line 70 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
    }

#line default
#line hidden
                BeginContext(3333, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 72 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
     if (@Model.Project.Ideations.Count > 0)
    {

#line default
#line hidden
                BeginContext(3388, 82, true);
                WriteLiteral("        <table class=\"table\">\r\n            <h4>Top 5 most popular ideations</h4>\r\n");
                EndContext();
#line 76 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
             foreach (var ideation in @Model.Project.Ideations)
            {
                foreach (var countLikes in Model.LikeAmounts)
                {
                    if (countLikes.Key == ideation.IdeationId)
                    {

#line default
#line hidden
                BeginContext(3719, 153, true);
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <span>Ideation -</span>\r\n                                ");
                EndContext();
                BeginContext(3873, 16, false);
#line 85 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                           Write(countLikes.Value);

#line default
#line hidden
                EndContext();
                BeginContext(3889, 81, true);
                WriteLiteral("\r\n                                <i class=\"glyphicon glyphicon-thumbs-up\"></i>\r\n");
                EndContext();
#line 87 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                 foreach (var countComments in Model.CommentAmounts)
                                {
                                    if (countComments.Key == ideation.IdeationId)
                                    {
                                        

#line default
#line hidden
                BeginContext(4254, 19, false);
#line 91 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                   Write(countComments.Value);

#line default
#line hidden
                EndContext();
                BeginContext(4275, 85, true);
                WriteLiteral("                                        <i class=\"glyphicon glyphicon-comment\"></i>\r\n");
                EndContext();
#line 93 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                    }
                                }

#line default
#line hidden
                BeginContext(4434, 101, true);
                WriteLiteral("                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(4536, 124, false);
#line 97 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                           Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                                    , new {ideationId = ideation.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(4660, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 101 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                }
            }

#line default
#line hidden
                BeginContext(4785, 18, true);
                WriteLiteral("        </table>\r\n");
                EndContext();
                BeginContext(4812, 109, false);
#line 105 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
   Write(Html.ActionLink("Show all ideations", "Project", "Project"
            , new {id = Model.Project.ProjectId}));

#line default
#line hidden
                EndContext();
#line 106 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                 
    }

#line default
#line hidden
                BeginContext(4930, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 109 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
     if (Model.Project.Questionnaires.Count > 0)
    {

#line default
#line hidden
                BeginContext(4989, 290, true);
                WriteLiteral(@"        <h4>All questionnaires</h4>
        <table class=""table"">
            <tr>
                <th>
                    <p>Questionnaire name</p>
                </th>
                <th>
                    <p>Amount of questions</p>
                </th>
            </tr>
");
                EndContext();
#line 121 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
             foreach (var questionnaire in @Model.Project.Questionnaires)
            {

#line default
#line hidden
                BeginContext(5369, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(5442, 18, false);
#line 125 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(questionnaire.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5460, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(5540, 28, false);
#line 128 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(questionnaire.QuestionAmount);

#line default
#line hidden
                EndContext();
                BeginContext(5568, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(5648, 160, false);
#line 131 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                   Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                            , new {questionnaireId = questionnaire.QuestionnaireId}));

#line default
#line hidden
                EndContext();
                BeginContext(5808, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 135 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
            }

#line default
#line hidden
                BeginContext(5875, 18, true);
                WriteLiteral("        </table>\r\n");
                EndContext();
                BeginContext(5902, 134, false);
#line 137 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
   Write(Html.ActionLink("Show all questionnaires", "Questionnaires", "Questionnaire"
            , new {projectId = Model.Project.ProjectId}));

#line default
#line hidden
                EndContext();
#line 138 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                                                        
    }

#line default
#line hidden
                BeginContext(6045, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 141 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
     if (@Model.IdeationQuestions.Count > 0)
    {

#line default
#line hidden
                BeginContext(6100, 31, true);
                WriteLiteral("        <h3>Central questions (");
                EndContext();
                BeginContext(6132, 29, false);
#line 143 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                          Write(Model.IdeationQuestions.Count);

#line default
#line hidden
                EndContext();
                BeginContext(6161, 152, true);
                WriteLiteral(")</h3>\r\n        <div id=\"myCarousel\" class=\"carousel slide text-center\" data-ride=\"carousel\">\r\n            <div class=\"carousel-inner\" role=\"listbox\">\r\n");
                EndContext();
#line 146 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                 for (var i = 0; i < @Model.IdeationQuestions.Count; i++)
                {
                    if (i == 0)
                    {

#line default
#line hidden
                BeginContext(6463, 82, true);
                WriteLiteral("                        <div class=\"item active\">\r\n                            <p>");
                EndContext();
                BeginContext(6546, 44, false);
#line 151 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                          Write(Model.IdeationQuestions.ToList()[i].Question);

#line default
#line hidden
                EndContext();
                BeginContext(6590, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(6628, 47, false);
#line 152 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                          Write(Model.IdeationQuestions.ToList()[i].Description);

#line default
#line hidden
                EndContext();
                BeginContext(6675, 36, true);
                WriteLiteral("</p>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6711, "\"", 6776, 2);
                WriteAttributeValue("", 6718, "http://", 6718, 7, true);
#line 153 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 6725, Model.IdeationQuestions.ToList()[i].BackgroundInfo, 6725, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6777, 59, true);
                WriteLiteral(">More background info</a>\r\n                        </div>\r\n");
                EndContext();
#line 155 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(6908, 75, true);
                WriteLiteral("                        <div class=\"item\">\r\n                            <p>");
                EndContext();
                BeginContext(6984, 44, false);
#line 159 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                          Write(Model.IdeationQuestions.ToList()[i].Question);

#line default
#line hidden
                EndContext();
                BeginContext(7028, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(7066, 47, false);
#line 160 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                          Write(Model.IdeationQuestions.ToList()[i].Description);

#line default
#line hidden
                EndContext();
                BeginContext(7113, 36, true);
                WriteLiteral("</p>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 7149, "\"", 7214, 2);
                WriteAttributeValue("", 7156, "http://", 7156, 7, true);
#line 161 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
WriteAttributeValue("", 7163, Model.IdeationQuestions.ToList()[i].BackgroundInfo, 7163, 51, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7215, 59, true);
                WriteLiteral(">More background info</a>\r\n                        </div>\r\n");
                EndContext();
#line 163 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
                    }
                }

#line default
#line hidden
                BeginContext(7316, 560, true);
                WriteLiteral(@"            </div>

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
#line 176 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
    }

#line default
#line hidden
                BeginContext(7883, 10, true);
                WriteLiteral("</div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onload", 9, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 251, "loadPage(\'", 251, 10, true);
#line 7 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
AddHtmlAttributeValue("", 261, Model.Project.Setting.BackGroundColor1, 261, 39, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 300, "\',", 300, 2, true);
            AddHtmlAttributeValue(" ", 302, "\'", 303, 2, true);
#line 7 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
AddHtmlAttributeValue("", 304, Model.Project.Setting.BackGroundColor2, 304, 39, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 343, "\',", 343, 2, true);
            AddHtmlAttributeValue(" ", 345, "\'", 346, 2, true);
#line 7 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Project\ProjectDetailPage.cshtml"
AddHtmlAttributeValue("", 347, Model.Project.Setting.FontFamily, 347, 33, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 380, "\')", 380, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
