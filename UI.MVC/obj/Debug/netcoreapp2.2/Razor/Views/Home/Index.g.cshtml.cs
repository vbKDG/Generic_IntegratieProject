#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d79e12300b17e35b0888d567c511b1356637843"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d79e12300b17e35b0888d567c511b1356637843", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Projects.ProjectsVM>
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d79e12300b17e35b0888d567c511b13566378435001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 3 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
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
            BeginContext(122, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(130, 9152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d79e12300b17e35b0888d567c511b13566378437008", async() => {
                BeginContext(150, 4105, true);
                WriteLiteral(@"
        <div class=""container-fluid"">
    
            <section id=""showcase"">
                
                <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                    </ol>
                    <div class=""carousel-inner"">
                        <div class=""carousel-item carousel-image-1 active"">
                            <div class=""container"">
                                <div class=""carousel-caption d-none d-sm-block text-right mb-1"">
                                    <h1 class=""display-1 text-white""><b>Think.</b></h1>
                                </div>
                            </div>
                        </div>
                        
     ");
                WriteLiteral(@"                   <div class=""carousel-item carousel-image-2"">
                            <div class=""container"">
                                <div class=""carousel-caption d-none d-sm-block text-right mb-1"">
                                    <h1 class=""display-1 text-white""><b>Share.</b></h1>

                                </div>
                            </div>
                        </div>

                        <div class=""carousel-item carousel-image-3"">
                            <div class=""container"">
                                <div class=""carousel-caption d-none d-sm-block text-right mb-1"">
                                    <h1 class=""display-1 text-white""><b>Connect.</b></h1>

                                   

                                </div>
                            </div>
                        </div>
                    </div>

                    <a href=""#myCarousel"" data-slide=""prev"" class=""carousel-control-prev"">
                        ");
                WriteLiteral(@"<span class=""carousel-control-prev-icon""></span>
                    </a>

                    <a href=""#myCarousel"" data-slide=""next"" class=""carousel-control-next"">
                        <span class=""carousel-control-next-icon""></span>
                    </a>
                </div>
            </section>
        </div>


    <!-- HOME SECTION -->
        <div class=""container"">
    <div class=""col text-center py-5"">
        <h1 class=""text-dark"">Welcome</h1>
        <h3 class=""text-dark"">

            We have created this platform to get your great ideas on projects in your neighbourhood, because every vote counts!

        </h3>
        <div class=""col text-center py-5"">
            <a class=""btn btn-success btn-lg"" href=""#pro"">More</a>

        </div>
        

    </div>
</div>


<!-- Projects HEAD -->
<section id=""projects-head-section"">
    <div  class=""container"" id=""pro"">
        <div class=""row"">
            <div  class=""col text-center"">
                <h1>Our ");
                WriteLiteral(@"Projects</h1>
                <h3>
                    Are you interested in projects in your neighbourhood, No need to look further.
                </h3>
            </div>
        </div>

        <div class=""row"">
            <div class=""col text-center py-2"">
                <div class=""btn-group"" data-toggle=""buttons"">
                    <label id=""openProjects"" class=""btn btn-success active"">
                        <input type=""radio"" name=""options"" autocomplete=""off"" checked> Open
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
        
        <div id=""rowPictures"" class");
                WriteLiteral("=\"row\">\r\n");
                EndContext();
#line 106 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
             foreach (var project in @Model.Projects)
            {
                if (project.Closed == false)
                {

#line default
#line hidden
                BeginContext(4390, 75, true);
                WriteLiteral("                    <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4465, "\"", 4681, 5);
                WriteAttributeValue("", 4475, "location.href", 4475, 13, true);
                WriteAttributeValue(" ", 4488, "=", 4489, 2, true);
                WriteAttributeValue(" ", 4490, "\'", 4491, 2, true);
#line 110 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4492, Url.Action("ProjectDetailPage", "Project"
                                                                                                          , new {projectId = project.ProjectId}), 4492, 188, false);

#line default
#line hidden
                WriteAttributeValue("", 4680, "\'", 4680, 1, true);
                EndWriteAttribute();
                BeginContext(4682, 163, true);
                WriteLiteral(">\r\n                        <div id=\"projectpaddingfix\" class=\"card\">\r\n                            <div class=\"homePageImage\">\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4845, "\"", 4871, 1);
#line 114 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4851, project.Base64Image, 4851, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4872, 217, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                            </div>\r\n                            <div class=\"progress\">\r\n                                <div class=\"progress-bar progress-bar-striped progress-bar-animated\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 5089, "\"", 5122, 3);
                WriteAttributeValue("", 5097, "width:", 5097, 6, true);
#line 117 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5103, project.Progress, 5104, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 5121, "%", 5121, 1, true);
                EndWriteAttribute();
                BeginContext(5123, 137, true);
                WriteLiteral("></div>\r\n                            </div>\r\n                            \r\n                            <h4 class=\"card-title text-black\">");
                EndContext();
                BeginContext(5261, 12, false);
#line 120 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                         Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5273, 166, true);
                WriteLiteral("</h4>\r\n                            <div>\r\n                                <p class=\"text-dark\">\r\n                                    <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(5440, 18, false);
#line 123 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(5458, 67, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(5526, 21, false);
#line 124 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(5547, 70, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(5618, 24, false);
#line 125 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                               Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(5642, 140, true);
                WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                        </div>\r\n");
                EndContext();
#line 130 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                        }
                        
                else if (project.Closed == true)
                {
                
                

#line default
#line hidden
                BeginContext(5940, 77, true);
                WriteLiteral("                    <div class=\"column text-center text-black closedProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6017, "\"", 6235, 5);
                WriteAttributeValue("", 6027, "location.href", 6027, 13, true);
                WriteAttributeValue(" ", 6040, "=", 6041, 2, true);
                WriteAttributeValue(" ", 6042, "\'", 6043, 2, true);
#line 136 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 6044, Url.Action("ProjectDetailPage", "Project"
                                                                                                            , new {projectId = project.ProjectId}), 6044, 190, false);

#line default
#line hidden
                WriteAttributeValue("", 6234, "\'", 6234, 1, true);
                EndWriteAttribute();
                BeginContext(6236, 128, true);
                WriteLiteral(">\r\n                        <div class=\"card\">\r\n                        <div class=\"homePageImage\">\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6364, "\"", 6390, 1);
#line 140 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 6370, project.Base64Image, 6370, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6391, 236, true);
                WriteLiteral(" class=\"img-responsive\" width=\"365\" height=\"200\"/>\r\n                        </div>\r\n                            <div class=\"progress\">\r\n                                <div class=\"progress-bar progress-bar-striped progress-bar-animated\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 6627, "\"", 6660, 3);
                WriteAttributeValue("", 6635, "width:", 6635, 6, true);
#line 143 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 6641, project.Progress, 6642, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 6659, "%", 6659, 1, true);
                EndWriteAttribute();
                BeginContext(6661, 108, true);
                WriteLiteral("></div>\r\n                            </div>\r\n                             <h4 class=\"card-title text-black\">");
                EndContext();
                BeginContext(6770, 12, false);
#line 145 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                          Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6782, 166, true);
                WriteLiteral("</h4>\r\n                            <div>\r\n                                <p class=\"text-dark\">\r\n                                    <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(6949, 18, false);
#line 148 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(6967, 67, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(7035, 21, false);
#line 149 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(7056, 70, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(7127, 24, false);
#line 150 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                               Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(7151, 140, true);
                WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            </div>\r\n                    </div>\r\n");
                EndContext();
#line 155 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(7325, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 157 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
             foreach (var project in @Model.OngoingProjects)
            {
                if (project.Ongoing == true)
                {

#line default
#line hidden
                BeginContext(7467, 78, true);
                WriteLiteral("                    <div class=\"column text-center text-black ongoingProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7545, "\"", 7764, 5);
                WriteAttributeValue("", 7555, "location.href", 7555, 13, true);
                WriteAttributeValue(" ", 7568, "=", 7569, 2, true);
                WriteAttributeValue(" ", 7570, "\'", 7571, 2, true);
#line 161 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 7572, Url.Action("ProjectDetailPage", "Project"
                                                                                                             , new {projectId = project.ProjectId}), 7572, 191, false);

#line default
#line hidden
                WriteAttributeValue("", 7763, "\'", 7763, 1, true);
                EndWriteAttribute();
                BeginContext(7765, 96, true);
                WriteLiteral(">\r\n                        <h4 id=\"titleindex\" class=\"text-black\">\r\n                            ");
                EndContext();
                BeginContext(7862, 133, false);
#line 164 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                       Write(Html.ActionLink(@project.Name, "ProjectDetailPage", "Project"
                                , new {projectId = project.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(7995, 61, true);
                WriteLiteral("\r\n                        </h4>\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 8056, "\"", 8082, 1);
#line 167 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 8062, project.Base64Image, 8062, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8083, 173, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                        <div class=\"progress\">\r\n                            <div class=\"progress-bar progress-bar-striped progress-bar-animated\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 8256, "\"", 8289, 3);
                WriteAttributeValue("", 8264, "width:", 8264, 6, true);
#line 169 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 8270, project.Progress, 8271, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 8288, "%", 8288, 1, true);
                EndWriteAttribute();
                BeginContext(8290, 188, true);
                WriteLiteral("></div>\r\n                        </div>\r\n                        <div>\r\n                            <p class=\"text-dark\">\r\n                                <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(8479, 18, false);
#line 173 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(8497, 63, true);
                WriteLiteral("\r\n                                <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(8561, 21, false);
#line 174 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                        Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(8582, 66, true);
                WriteLiteral("\r\n                                <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(8649, 24, false);
#line 175 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                           Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(8673, 96, true);
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 179 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(8803, 178, true);
                WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col text-center py-5\">\r\n                <div id=\"ProjectsButton\" class=\"col text-center\">\r\n                    ");
                EndContext();
                BeginContext(8981, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d79e12300b17e35b0888d567c511b135663784327701", async() => {
                    BeginContext(9044, 13, true);
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
                BeginContext(9061, 214, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n<div class=\"col text-center py-5\">\r\n    <a href=\"#Start\">\r\n        <i class=\"fas fa-arrow-up fa-2x\"></i>\r\n    </a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Projects.ProjectsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
