#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c79f89f18b667cca27cd98478d1b096a769140"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c79f89f18b667cca27cd98478d1b096a769140", @"/Views/Home/ProjectsGeneral.cshtml")]
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
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
  
    ViewData["Title"] = "Projects";

#line default
#line hidden
            BeginContext(88, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(92, 12343, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c79f89f18b667cca27cd98478d1b096a7691403866", async() => {
                BeginContext(119, 1231, true);
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
                <b><Recent></Recent></b>
            </a>
        </li>    
    </ul>
</div>
<!-- Tab panes -->
<d");
                WriteLiteral("iv class=\"p-5\">\r\n    \r\n    <div class=\"tab-content\">\r\n        \r\n        \r\n        <div id=\"recent\" class=\"container tab-pane active\">\r\n            <div class=\"row\">\r\n                <div id=\"\" class=\"row\">\r\n");
                EndContext();
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects)
                    {
                        if (project.Closed == false)
                        {

#line default
#line hidden
                BeginContext(1517, 83, true);
                WriteLiteral("                            <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1600, "\"", 1824, 5);
                WriteAttributeValue("", 1610, "location.href", 1610, 13, true);
                WriteAttributeValue(" ", 1623, "=", 1624, 2, true);
                WriteAttributeValue(" ", 1625, "\'", 1626, 2, true);
#line 57 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 1627, Url.Action("ProjectDetailPage", "Project"
                                                                                                                  , new {projectId = project.ProjectId}), 1627, 196, false);

#line default
#line hidden
                WriteAttributeValue("", 1823, "\'", 1823, 1, true);
                EndWriteAttribute();
                BeginContext(1825, 191, true);
                WriteLiteral(">\r\n                                <div id=\"projectpaddingfix\" class=\"card\">\r\n                                    <div class=\"textWithBlurredBg\">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2016, "\"", 2042, 1);
#line 61 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 2022, project.Base64Image, 2022, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2043, 165, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n\r\n                                        <div class=\"text-center\">\r\n                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(2209, 12, false);
#line 64 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2221, 74, true);
                WriteLiteral("</h3>\r\n                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(2296, 19, false);
#line 65 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2315, 280, true);
                WriteLiteral(@"</h4>
                                        </div>

                                    </div>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 2595, "\"", 2628, 3);
                WriteAttributeValue("", 2603, "width:", 2603, 6, true);
#line 70 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 2609, project.Progress, 2610, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 2627, "%", 2627, 1, true);
                EndWriteAttribute();
                BeginContext(2629, 240, true);
                WriteLiteral("></div>\r\n                                    </div>\r\n\r\n\r\n                                    <div>\r\n                                        <p class=\"text-dark\">\r\n                                            <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(2870, 18, false);
#line 76 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(2888, 75, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(2964, 21, false);
#line 77 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(2985, 78, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(3064, 24, false);
#line 78 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(3088, 168, true);
                WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 83 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(3306, 200, true);
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n        \r\n\r\n        <div id=\"ongoing\" class=\"container tab-pane fade\">\r\n            <div class=\"row\">\r\n                <div class=\"row\">\r\n");
                EndContext();
#line 94 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects)
                    {
                        if (project.Progress > 0 && project.Progress < 100)
                        {

#line default
#line hidden
                BeginContext(3696, 83, true);
                WriteLiteral("                            <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3779, "\"", 4003, 5);
                WriteAttributeValue("", 3789, "location.href", 3789, 13, true);
                WriteAttributeValue(" ", 3802, "=", 3803, 2, true);
                WriteAttributeValue(" ", 3804, "\'", 3805, 2, true);
#line 98 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 3806, Url.Action("ProjectDetailPage", "Project"
                                                                                                                  , new {projectId = project.ProjectId}), 3806, 196, false);

#line default
#line hidden
                WriteAttributeValue("", 4002, "\'", 4002, 1, true);
                EndWriteAttribute();
                BeginContext(4004, 191, true);
                WriteLiteral(">\r\n                                <div id=\"projectpaddingfix\" class=\"card\">\r\n                                    <div class=\"textWithBlurredBg\">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4195, "\"", 4221, 1);
#line 102 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 4201, project.Base64Image, 4201, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4222, 165, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n\r\n                                        <div class=\"text-center\">\r\n                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(4388, 12, false);
#line 105 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4400, 74, true);
                WriteLiteral("</h3>\r\n                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(4475, 19, false);
#line 106 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(4494, 280, true);
                WriteLiteral(@"</h4>
                                        </div>

                                    </div>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 4774, "\"", 4807, 3);
                WriteAttributeValue("", 4782, "width:", 4782, 6, true);
#line 111 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 4788, project.Progress, 4789, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 4806, "%", 4806, 1, true);
                EndWriteAttribute();
                BeginContext(4808, 240, true);
                WriteLiteral("></div>\r\n                                    </div>\r\n\r\n\r\n                                    <div>\r\n                                        <p class=\"text-dark\">\r\n                                            <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(5049, 18, false);
#line 117 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(5067, 75, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(5143, 21, false);
#line 118 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(5164, 78, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(5243, 24, false);
#line 119 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(5267, 168, true);
                WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 124 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                        }
                        
                    }

#line default
#line hidden
                BeginContext(5511, 215, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div id=\"closed\" class=\"container tab-pane fade\">\r\n            <div class=\"row mb-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 133 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects)
                    {
                        if (project.Closed == true)
                        {

#line default
#line hidden
                BeginContext(5892, 83, true);
                WriteLiteral("                            <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5975, "\"", 6199, 5);
                WriteAttributeValue("", 5985, "location.href", 5985, 13, true);
                WriteAttributeValue(" ", 5998, "=", 5999, 2, true);
                WriteAttributeValue(" ", 6000, "\'", 6001, 2, true);
#line 137 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 6002, Url.Action("ProjectDetailPage", "Project"
                                                                                                                  , new {projectId = project.ProjectId}), 6002, 196, false);

#line default
#line hidden
                WriteAttributeValue("", 6198, "\'", 6198, 1, true);
                EndWriteAttribute();
                BeginContext(6200, 191, true);
                WriteLiteral(">\r\n                                <div id=\"projectpaddingfix\" class=\"card\">\r\n                                    <div class=\"textWithBlurredBg\">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6391, "\"", 6417, 1);
#line 141 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 6397, project.Base64Image, 6397, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6418, 165, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n\r\n                                        <div class=\"text-center\">\r\n                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(6584, 12, false);
#line 144 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6596, 74, true);
                WriteLiteral("</h3>\r\n                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(6671, 19, false);
#line 145 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(6690, 280, true);
                WriteLiteral(@"</h4>
                                        </div>

                                    </div>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 6970, "\"", 7003, 3);
                WriteAttributeValue("", 6978, "width:", 6978, 6, true);
#line 150 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 6984, project.Progress, 6985, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 7002, "%", 7002, 1, true);
                EndWriteAttribute();
                BeginContext(7004, 240, true);
                WriteLiteral("></div>\r\n                                    </div>\r\n\r\n\r\n                                    <div>\r\n                                        <p class=\"text-dark\">\r\n                                            <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(7245, 18, false);
#line 156 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(7263, 75, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(7339, 21, false);
#line 157 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(7360, 78, true);
                WriteLiteral("\r\n                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(7439, 24, false);
#line 158 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(7463, 168, true);
                WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 163 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(7681, 216, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div id=\"popular\" class=\"container tab-pane fade\">\r\n            <div class=\"row lg-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 171 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects.OrderByDescending(i => i.CombinedTotal))
                    {

#line default
#line hidden
                BeginContext(8023, 103, true);
                WriteLiteral("                                                <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8126, "\"", 8370, 5);
                WriteAttributeValue("", 8136, "location.href", 8136, 13, true);
                WriteAttributeValue(" ", 8149, "=", 8150, 2, true);
                WriteAttributeValue(" ", 8151, "\'", 8152, 2, true);
#line 173 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 8153, Url.Action("ProjectDetailPage", "Project"
                                                                                                                                      , new {projectId = project.ProjectId}), 8153, 216, false);

#line default
#line hidden
                WriteAttributeValue("", 8369, "\'", 8369, 1, true);
                EndWriteAttribute();
                BeginContext(8371, 251, true);
                WriteLiteral(">\r\n                                                    <div id=\"projectpaddingfix\" class=\"card\">\r\n                                                        <div class=\"textWithBlurredBg\">\r\n                                                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 8622, "\"", 8648, 1);
#line 177 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 8628, project.Base64Image, 8628, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8649, 225, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                    \r\n                                                            <div class=\"text-center\">\r\n                                                                <h3 class=\"text-light\">");
                EndContext();
                BeginContext(8875, 12, false);
#line 180 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                  Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(8887, 94, true);
                WriteLiteral("</h3>\r\n                                                                <h4 class=\"text-light\">");
                EndContext();
                BeginContext(8982, 19, false);
#line 181 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                  Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(9001, 380, true);
                WriteLiteral(@"</h4>
                                                            </div>
                    
                                                        </div>
                                                        <div class=""progress"">
                                                            <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 9381, "\"", 9414, 3);
                WriteAttributeValue("", 9389, "width:", 9389, 6, true);
#line 186 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 9395, project.Progress, 9396, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 9413, "%", 9413, 1, true);
                EndWriteAttribute();
                BeginContext(9415, 360, true);
                WriteLiteral(@"></div>
                                                        </div>
                    
                    
                                                        <div>
                                                            <p class=""text-dark"">
                                                                <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(9776, 18, false);
#line 192 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                            Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(9794, 95, true);
                WriteLiteral("\r\n                                                                <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(9890, 21, false);
#line 193 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                        Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(9911, 98, true);
                WriteLiteral("\r\n                                                                <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(10010, 24, false);
#line 194 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                           Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(10034, 248, true);
                WriteLiteral("\r\n                                                            </p>\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </div>\r\n");
                EndContext();
#line 199 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                            }

#line default
#line hidden
                BeginContext(10329, 240, true);
                WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div id=\"startDate\" class=\"container tab-pane fade\">\r\n            <div class=\"row lg-4\">\r\n                <div id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 207 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                     foreach (var project in @Model.Projects.OrderByDescending(i => i.StartDate).ThenByDescending(i => i.EndDate))
                    {

#line default
#line hidden
                BeginContext(10724, 45, true);
                WriteLiteral("                        <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 10769, "\"", 10955, 5);
                WriteAttributeValue("", 10779, "location.href", 10779, 13, true);
                WriteAttributeValue(" ", 10792, "=", 10793, 2, true);
                WriteAttributeValue(" ", 10794, "\'", 10795, 2, true);
#line 209 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 10796, Url.Action("ProjectDetailPage", "Project"
                                                                            , new {projectId = project.ProjectId}), 10796, 158, false);

#line default
#line hidden
                WriteAttributeValue("", 10954, "\'", 10954, 1, true);
                EndWriteAttribute();
                BeginContext(10956, 161, true);
                WriteLiteral(">\r\n                            <div class=\"col-md-16\">\r\n                                <div class=\"textWithBlurredBg\">\r\n                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 11117, "\"", 11143, 1);
#line 213 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 11123, project.Base64Image, 11123, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11144, 130, true);
                WriteLiteral("/>\r\n                                    <div class=\"text-center\">\r\n                                        <h3 class=\"text-light\">");
                EndContext();
                BeginContext(11275, 12, false);
#line 215 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                          Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(11287, 70, true);
                WriteLiteral("</h3>\r\n                                        <h4 class=\"text-light\">");
                EndContext();
                BeginContext(11358, 19, false);
#line 216 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                          Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(11377, 289, true);
                WriteLiteral(@"</h4>
                                    </div>
                                </div>
                                <div class=""progress center-block"">
                                    <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 11666, "\"", 11699, 3);
                WriteAttributeValue("", 11674, "width:", 11674, 6, true);
#line 220 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 11680, project.Progress, 11681, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 11698, "%", 11698, 1, true);
                EndWriteAttribute();
                BeginContext(11700, 260, true);
                WriteLiteral(@">
                                    </div>
                                </div>

                                <div>
                                    <p class=""text-dark"">
                                        <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(11961, 18, false);
#line 226 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                    Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(11979, 71, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(12051, 21, false);
#line 227 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(12072, 74, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(12147, 24, false);
#line 228 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                   Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(12171, 152, true);
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
                EndContext();
#line 233 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                    }

#line default
#line hidden
                BeginContext(12346, 82, true);
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
