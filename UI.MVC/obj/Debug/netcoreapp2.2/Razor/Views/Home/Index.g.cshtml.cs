#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab4ddce0daa04660189fb945930c6d5259f37232"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab4ddce0daa04660189fb945930c6d5259f37232", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<D.UI.MVC.Models.Projects.ProjectVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/showCorrectProject.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectsGeneral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Homepage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4ddce0daa04660189fb945930c6d5259f372324965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 3 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
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
            BeginContext(134, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(138, 8266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4ddce0daa04660189fb945930c6d5259f372326952", async() => {
                BeginContext(158, 3655, true);
                WriteLiteral(@"

<section id=""showcase"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item carousel-image-1"">
                <div class=""container"">
                    <div class=""carousel-caption d-none d-sm-block text-right mb-5"">
                        <h1 class=""display-3""></h1>
                        <p class=""lead"">

                        </p>

                    </div>
                </div>
            </div>

            <div class=""carousel-item carousel-image-2"">
                <div class=""container"">
                    <div class=""carousel-caption d-none d-sm-block text-right mb-5"">
                        <h1 class=""displ");
                WriteLiteral(@"ay-3""></h1>
                        <p class=""lead"">

                        </p>

                    </div>
                </div>
            </div>

            <div class=""carousel-item carousel-image-3 active"">
                <div class=""container"">
                    <div class=""carousel-caption d-none d-sm-block text-right mb-5"">
                        <h1 class=""display-3""></h1>
                        <p class=""lead"">

                        </p>

                    </div>
                </div>
            </div>
        </div>

        <a href=""#myCarousel"" data-slide=""prev"" class=""carousel-control-prev"">
            <span class=""carousel-control-prev-icon""></span>
        </a>

        <a href=""#myCarousel"" data-slide=""next"" class=""carousel-control-next"">
            <span class=""carousel-control-next-icon""></span>
        </a>
    </div>
</section>

<!-- HOME SECTION -->
<div class=""container"">
    <div class=""col text-center py-5"">
        <h1 class=""tex");
                WriteLiteral(@"t-dark"">Welcome</h1>
        <h3 class=""text-dark"">

            We have created this platform to get your great ideas on projects in your neighbourhood, because every vote counts!

        </h3>
        <div class=""col text-center py-5"">
            <a class=""btn btn-success btn-lg"" href=""#projectTop"">More</a>

        </div>
    </div>
</div>


<!-- Projects HEAD -->
<section id=""projectTop"">
    <div id=""projects-head-section"" class=""container"">
        <div class=""row"">
            <div class=""col text-center"">
                <h1>Our Projects</h1>
                <h3>
                    Are you interested in projects in your neighbourhood, No need to look further.
                </h3>
            </div>
        </div>

        <div class=""row"">
            <div class=""col text-center py-2"">
                <div class=""btn-group"" data-toggle=""buttons"">
                    <label id=""openProjects"" class=""btn btn-success active"">
                        <input type=""radio"" na");
                WriteLiteral(@"me=""options"" autocomplete=""off"" checked> Open
                    </label>
                    <label id=""ongoingProjects"" class=""btn btn-success"">
                        <input type=""radio"" name=""options"" autocomplete=""off""> Ongoing
                    </label>
                    <label id=""closedProjects"" class=""btn btn-success"">
                        <input type=""radio"" name=""options"" autocomplete=""off""> Closed
                    </label>
                </div>
            </div>
        </div>
        
        
        <div id=""rowPictures"" class=""row"">
");
                EndContext();
#line 109 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
             foreach (var project in @Model)
            {
                if (project.Closed == false)
                {

#line default
#line hidden
                BeginContext(3939, 75, true);
                WriteLiteral("                    <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4014, "\"", 4165, 5);
                WriteAttributeValue("", 4024, "location.href", 4024, 13, true);
                WriteAttributeValue(" ", 4037, "=", 4038, 2, true);
                WriteAttributeValue(" ", 4039, "\'", 4040, 2, true);
#line 113 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4041, Url.Action("ProjectDetailPage", "Project"
                                         , new {projectId = project.ProjectId}), 4041, 123, false);

#line default
#line hidden
                WriteAttributeValue("", 4164, "\'", 4164, 1, true);
                EndWriteAttribute();
                BeginContext(4166, 96, true);
                WriteLiteral(">\r\n                        <h4 id=\"titleindex\" class=\"text-black\">\r\n                            ");
                EndContext();
                BeginContext(4263, 133, false);
#line 116 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                       Write(Html.ActionLink(@project.Name, "ProjectDetailPage", "Project"
                                , new {projectId = project.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(4396, 61, true);
                WriteLiteral("\r\n                        </h4>\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4457, "\"", 4483, 1);
#line 119 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4463, project.Base64Image, 4463, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4484, 173, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                        <div class=\"progress\">\r\n                            <div class=\"progress-bar progress-bar-striped progress-bar-animated\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 4657, "\"", 4690, 3);
                WriteAttributeValue("", 4665, "width:", 4665, 6, true);
#line 121 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4671, project.Progress, 4672, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 4689, "%", 4689, 1, true);
                EndWriteAttribute();
                BeginContext(4691, 188, true);
                WriteLiteral("></div>\r\n                        </div>\r\n                        <div>\r\n                            <p class=\"text-dark\">\r\n                                <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(4880, 18, false);
#line 125 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(4898, 63, true);
                WriteLiteral("\r\n                                <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(4962, 21, false);
#line 126 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                        Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(4983, 66, true);
                WriteLiteral("\r\n                                <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(5050, 24, false);
#line 127 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                           Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(5074, 96, true);
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 131 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                }
                else if (project.Closed == true)
                {

#line default
#line hidden
                BeginContext(5258, 77, true);
                WriteLiteral("                    <div class=\"column text-center text-black closedProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5335, "\"", 5474, 5);
                WriteAttributeValue("", 5345, "location.href", 5345, 13, true);
                WriteAttributeValue(" ", 5358, "=", 5359, 2, true);
                WriteAttributeValue(" ", 5360, "\'", 5361, 2, true);
#line 134 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 5362, Url.Action("ProjectDetailPage", "Project"
                             , new {projectId = project.ProjectId}), 5362, 111, false);

#line default
#line hidden
                WriteAttributeValue("", 5473, "\'", 5473, 1, true);
                EndWriteAttribute();
                BeginContext(5475, 96, true);
                WriteLiteral(">\r\n                        <h4 id=\"titleindex\" class=\"text-black\">\r\n                            ");
                EndContext();
                BeginContext(5572, 133, false);
#line 137 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                       Write(Html.ActionLink(@project.Name, "ProjectDetailPage", "Project"
                                , new {projectId = project.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(5705, 61, true);
                WriteLiteral("\r\n                        </h4>\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5766, "\"", 5792, 1);
#line 140 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 5772, project.Base64Image, 5772, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5793, 173, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                        <div class=\"progress\">\r\n                            <div class=\"progress-bar progress-bar-striped progress-bar-animated\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 5966, "\"", 5999, 3);
                WriteAttributeValue("", 5974, "width:", 5974, 6, true);
#line 142 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5980, project.Progress, 5981, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 5998, "%", 5998, 1, true);
                EndWriteAttribute();
                BeginContext(6000, 188, true);
                WriteLiteral("></div>\r\n                        </div>\r\n                        <div>\r\n                            <p class=\"text-dark\">\r\n                                <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(6189, 18, false);
#line 146 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(6207, 63, true);
                WriteLiteral("\r\n                                <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(6271, 21, false);
#line 147 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                        Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(6292, 66, true);
                WriteLiteral("\r\n                                <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(6359, 24, false);
#line 148 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                           Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(6383, 96, true);
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 152 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                }
                
                if (project.Ongoing == true)
                {

#line default
#line hidden
                BeginContext(6581, 78, true);
                WriteLiteral("                    <div class=\"column text-center text-black ongoingProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6659, "\"", 6878, 5);
                WriteAttributeValue("", 6669, "location.href", 6669, 13, true);
                WriteAttributeValue(" ", 6682, "=", 6683, 2, true);
                WriteAttributeValue(" ", 6684, "\'", 6685, 2, true);
#line 156 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 6686, Url.Action("ProjectDetailPage", "Project"
                                                                                                             , new {projectId = project.ProjectId}), 6686, 191, false);

#line default
#line hidden
                WriteAttributeValue("", 6877, "\'", 6877, 1, true);
                EndWriteAttribute();
                BeginContext(6879, 96, true);
                WriteLiteral(">\r\n                        <h4 id=\"titleindex\" class=\"text-black\">\r\n                            ");
                EndContext();
                BeginContext(6976, 133, false);
#line 159 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                       Write(Html.ActionLink(@project.Name, "ProjectDetailPage", "Project"
                                , new {projectId = project.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(7109, 61, true);
                WriteLiteral("\r\n                        </h4>\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 7170, "\"", 7196, 1);
#line 162 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 7176, project.Base64Image, 7176, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7197, 173, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                        <div class=\"progress\">\r\n                            <div class=\"progress-bar progress-bar-striped progress-bar-animated\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 7370, "\"", 7403, 3);
                WriteAttributeValue("", 7378, "width:", 7378, 6, true);
#line 164 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7384, project.Progress, 7385, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 7402, "%", 7402, 1, true);
                EndWriteAttribute();
                BeginContext(7404, 188, true);
                WriteLiteral("></div>\r\n                        </div>\r\n                        <div>\r\n                            <p class=\"text-dark\">\r\n                                <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(7593, 18, false);
#line 168 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(7611, 63, true);
                WriteLiteral("\r\n                                <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(7675, 21, false);
#line 169 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                        Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(7696, 66, true);
                WriteLiteral("\r\n                                <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(7763, 24, false);
#line 170 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                                                           Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(7787, 96, true);
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 174 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(7917, 178, true);
                WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col text-center py-5\">\r\n                <div id=\"ProjectsButton\" class=\"col text-center\">\r\n                    ");
                EndContext();
                BeginContext(8095, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4ddce0daa04660189fb945930c6d5259f3723225938", async() => {
                    BeginContext(8158, 13, true);
                    WriteLiteral("More projects");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8175, 222, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</section>\r\n\r\n\r\n<div class=\"col text-center py-5\">\r\n    <a href=\"#Start\">\r\n        <i class=\"fas fa-arrow-up fa-2x\"></i>\r\n    </a>\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<D.UI.MVC.Models.Projects.ProjectVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
