#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4283bc757c68da2747dc09f4d58729043e1b518a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProjectsGeneral), @"mvc.1.0.view", @"/Views/Home/ProjectsGeneral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ProjectsGeneral.cshtml", typeof(AspNetCore.Views_Home_ProjectsGeneral))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4283bc757c68da2747dc09f4d58729043e1b518a", @"/Views/Home/ProjectsGeneral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProjectsGeneral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Projects.ProjectsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("projectsgeneral"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
  
    ViewData["Title"] = "Projects";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(92, 11507, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4283bc757c68da2747dc09f4d58729043e1b518a3802", async() => {
                BeginContext(119, 1216, true);
                WriteLiteral(@"


<h2 class=""text-center"">
    <b>Our projects</b>
</h2>
<div class=""container mt-3"">
    <!-- tabs -->
    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#recent"">
                <b>Open</b>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#closed"">
                <b>Closed</b>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#ongoing"">
                <b>Ongoing</b>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#popular"">
                <b>Popular</b>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#startDate"">
                <b>Start date</b>
            </a>
        </li>
    </ul>
</div>
<!-- Tab panes -->
<div class=""p-5");
                WriteLiteral("\">\r\n    <div class=\"tab-content\">\r\n        <div id=\"recent\" class=\"container tab-pane active\">\r\n            <div class=\"row lg-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 49 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects)
                    {
                        if (project.Closed == false)
                        {

#line default
#line hidden
                BeginContext(1502, 49, true);
                WriteLiteral("                            <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1551, "\"", 1741, 5);
                WriteAttributeValue("", 1561, "location.href", 1561, 13, true);
                WriteAttributeValue(" ", 1574, "=", 1575, 2, true);
                WriteAttributeValue(" ", 1576, "\'", 1577, 2, true);
#line 53 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 1578, Url.Action("ProjectDetailPage", "Project"
                                                                                , new {projectId = project.ProjectId}), 1578, 162, false);

#line default
#line hidden
                WriteAttributeValue("", 1740, "\'", 1740, 1, true);
                EndWriteAttribute();
                BeginContext(1742, 173, true);
                WriteLiteral(">\r\n                                <div class=\"col-md-16\">\r\n                                    <div class=\"textWithBlurredBg\">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1915, "\"", 1941, 1);
#line 57 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 1921, project.Base64Image, 1921, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1942, 138, true);
                WriteLiteral("/>\r\n                                        <div class=\"text-center\">\r\n                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(2081, 12, false);
#line 59 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2093, 74, true);
                WriteLiteral("</h3>\r\n                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(2168, 19, false);
#line 60 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2187, 305, true);
                WriteLiteral(@"</h4>
                                        </div>
                                    </div>
                                    <div class=""progress center-block"">
                                        <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 2492, "\"", 2525, 3);
                WriteAttributeValue("", 2500, "width:", 2500, 6, true);
#line 64 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 2506, project.Progress, 2507, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 2524, "%", 2524, 1, true);
                EndWriteAttribute();
                BeginContext(2526, 280, true);
                WriteLiteral(@">
                                        </div>
                                    </div>

                                    <div>
                                        <p class=""text-dark"">
                                            <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(2807, 18, false);
#line 70 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(2825, 75, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(2901, 21, false);
#line 71 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(2922, 78, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(3001, 24, false);
#line 72 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(3025, 168, true);
                WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 77 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(3243, 241, true);
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div id=\"ongoing\" class=\"container tab-pane fade\">\r\n\r\n            <div class=\"row mb-4\">\r\n\r\n                <div id=\"projectelementpadding\" class=\"row center-block\">\r\n");
                EndContext();
#line 90 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects)
                    {
                        if (project.Progress > 0 && project.Progress < 100)
                        {

#line default
#line hidden
                BeginContext(3674, 49, true);
                WriteLiteral("                            <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3723, "\"", 3913, 5);
                WriteAttributeValue("", 3733, "location.href", 3733, 13, true);
                WriteAttributeValue(" ", 3746, "=", 3747, 2, true);
                WriteAttributeValue(" ", 3748, "\'", 3749, 2, true);
#line 94 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 3750, Url.Action("ProjectDetailPage", "Project"
                                                                                , new {projectId = project.ProjectId}), 3750, 162, false);

#line default
#line hidden
                WriteAttributeValue("", 3912, "\'", 3912, 1, true);
                EndWriteAttribute();
                BeginContext(3914, 173, true);
                WriteLiteral(">\r\n                                <div class=\"col-md-16\">\r\n                                    <div class=\"textWithBlurredBg\">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4087, "\"", 4113, 1);
#line 98 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 4093, project.Base64Image, 4093, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4114, 138, true);
                WriteLiteral("/>\r\n                                        <div class=\"text-center\">\r\n                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(4253, 12, false);
#line 100 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4265, 74, true);
                WriteLiteral("</h3>\r\n                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(4340, 19, false);
#line 101 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(4359, 307, true);
                WriteLiteral(@"</h4>
                                        </div>
                                    </div>

                                    <div class=""progress center-block"">
                                        <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 4666, "\"", 4699, 3);
                WriteAttributeValue("", 4674, "width:", 4674, 6, true);
#line 106 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 4680, project.Progress, 4681, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 4698, "%", 4698, 1, true);
                EndWriteAttribute();
                BeginContext(4700, 280, true);
                WriteLiteral(@">
                                        </div>
                                    </div>

                                    <div>
                                        <p class=""text-dark"">
                                            <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(4981, 18, false);
#line 112 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(4999, 75, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(5075, 21, false);
#line 113 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(5096, 78, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(5175, 24, false);
#line 114 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(5199, 168, true);
                WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 119 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(5417, 223, true);
                WriteLiteral("                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div id=\"closed\" class=\"container tab-pane fade\">\r\n            <div class=\"row mb-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 131 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects)
                    {
                        if (project.Closed == true)
                        {

#line default
#line hidden
                BeginContext(5806, 49, true);
                WriteLiteral("                            <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5855, "\"", 6045, 5);
                WriteAttributeValue("", 5865, "location.href", 5865, 13, true);
                WriteAttributeValue(" ", 5878, "=", 5879, 2, true);
                WriteAttributeValue(" ", 5880, "\'", 5881, 2, true);
#line 135 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 5882, Url.Action("ProjectDetailPage", "Project"
                                                                                , new {projectId = project.ProjectId}), 5882, 162, false);

#line default
#line hidden
                WriteAttributeValue("", 6044, "\'", 6044, 1, true);
                EndWriteAttribute();
                BeginContext(6046, 173, true);
                WriteLiteral(">\r\n                                <div class=\"col-md-16\">\r\n                                    <div class=\"textWithBlurredBg\">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6219, "\"", 6245, 1);
#line 139 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 6225, project.Base64Image, 6225, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6246, 138, true);
                WriteLiteral("/>\r\n                                        <div class=\"text-center\">\r\n                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(6385, 12, false);
#line 141 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6397, 74, true);
                WriteLiteral("</h3>\r\n                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(6472, 19, false);
#line 142 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(6491, 305, true);
                WriteLiteral(@"</h4>
                                        </div>
                                    </div>
                                    <div class=""progress center-block"">
                                        <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 6796, "\"", 6829, 3);
                WriteAttributeValue("", 6804, "width:", 6804, 6, true);
#line 146 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 6810, project.Progress, 6811, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 6828, "%", 6828, 1, true);
                EndWriteAttribute();
                BeginContext(6830, 280, true);
                WriteLiteral(@">
                                        </div>
                                    </div>

                                    <div>
                                        <p class=""text-dark"">
                                            <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(7111, 18, false);
#line 152 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(7129, 75, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(7205, 21, false);
#line 153 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(7226, 78, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(7305, 24, false);
#line 154 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(7329, 168, true);
                WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 159 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(7547, 216, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div id=\"popular\" class=\"container tab-pane fade\">\r\n            <div class=\"row lg-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 167 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects.OrderByDescending(i => i.CombinedTotal))
                    {

#line default
#line hidden
                BeginContext(7889, 45, true);
                WriteLiteral("                        <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7934, "\"", 8120, 5);
                WriteAttributeValue("", 7944, "location.href", 7944, 13, true);
                WriteAttributeValue(" ", 7957, "=", 7958, 2, true);
                WriteAttributeValue(" ", 7959, "\'", 7960, 2, true);
#line 169 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 7961, Url.Action("ProjectDetailPage", "Project"
                                                                            , new {projectId = project.ProjectId}), 7961, 158, false);

#line default
#line hidden
                WriteAttributeValue("", 8119, "\'", 8119, 1, true);
                EndWriteAttribute();
                BeginContext(8121, 161, true);
                WriteLiteral(">\r\n                            <div class=\"col-md-16\">\r\n                                <div class=\"textWithBlurredBg\">\r\n                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 8282, "\"", 8308, 1);
#line 173 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 8288, project.Base64Image, 8288, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8309, 130, true);
                WriteLiteral("/>\r\n                                    <div class=\"text-center\">\r\n                                        <h3 class=\"text-light\">");
                EndContext();
                BeginContext(8440, 12, false);
#line 175 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                          Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(8452, 70, true);
                WriteLiteral("</h3>\r\n                                        <h4 class=\"text-light\">");
                EndContext();
                BeginContext(8523, 19, false);
#line 176 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                          Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(8542, 289, true);
                WriteLiteral(@"</h4>
                                    </div>
                                </div>
                                <div class=""progress center-block"">
                                    <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 8831, "\"", 8864, 3);
                WriteAttributeValue("", 8839, "width:", 8839, 6, true);
#line 180 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 8845, project.Progress, 8846, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 8863, "%", 8863, 1, true);
                EndWriteAttribute();
                BeginContext(8865, 260, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div>
                                    <p class=""text-dark"">
                                        <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(9126, 18, false);
#line 186 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(9144, 71, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(9216, 21, false);
#line 187 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(9237, 74, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(9312, 24, false);
#line 188 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                   Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(9336, 152, true);
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
                EndContext();
#line 193 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                    }

#line default
#line hidden
                BeginContext(9511, 220, true);
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div id=\"startDate\" class=\"container tab-pane fade\">\r\n            <div class=\"row lg-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 201 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects.OrderByDescending(i => i.StartDate).ThenByDescending(i => i.EndDate))
                    {

#line default
#line hidden
                BeginContext(9886, 45, true);
                WriteLiteral("                        <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 9931, "\"", 10117, 5);
                WriteAttributeValue("", 9941, "location.href", 9941, 13, true);
                WriteAttributeValue(" ", 9954, "=", 9955, 2, true);
                WriteAttributeValue(" ", 9956, "\'", 9957, 2, true);
#line 203 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 9958, Url.Action("ProjectDetailPage", "Project"
                                                                            , new {projectId = project.ProjectId}), 9958, 158, false);

#line default
#line hidden
                WriteAttributeValue("", 10116, "\'", 10116, 1, true);
                EndWriteAttribute();
                BeginContext(10118, 161, true);
                WriteLiteral(">\r\n                            <div class=\"col-md-16\">\r\n                                <div class=\"textWithBlurredBg\">\r\n                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10279, "\"", 10305, 1);
#line 207 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 10285, project.Base64Image, 10285, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10306, 130, true);
                WriteLiteral("/>\r\n                                    <div class=\"text-center\">\r\n                                        <h3 class=\"text-light\">");
                EndContext();
                BeginContext(10437, 12, false);
#line 209 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                          Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(10449, 70, true);
                WriteLiteral("</h3>\r\n                                        <h4 class=\"text-light\">");
                EndContext();
                BeginContext(10520, 19, false);
#line 210 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                          Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(10539, 289, true);
                WriteLiteral(@"</h4>
                                    </div>
                                </div>
                                <div class=""progress center-block"">
                                    <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 10828, "\"", 10861, 3);
                WriteAttributeValue("", 10836, "width:", 10836, 6, true);
#line 214 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 10842, project.Progress, 10843, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 10860, "%", 10860, 1, true);
                EndWriteAttribute();
                BeginContext(10862, 260, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div>
                                    <p class=""text-dark"">
                                        <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(11123, 18, false);
#line 220 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(11141, 71, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(11213, 21, false);
#line 221 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(11234, 74, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(11309, 24, false);
#line 222 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                   Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(11333, 154, true);
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>  \r\n");
                EndContext();
#line 227 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                    }

#line default
#line hidden
                BeginContext(11510, 82, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Projects.ProjectsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
