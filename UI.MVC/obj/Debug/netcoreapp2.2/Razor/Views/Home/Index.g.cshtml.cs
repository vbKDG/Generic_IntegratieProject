#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb36fb8b22874e3596d48d7f181fd2249c24a1ce"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb36fb8b22874e3596d48d7f181fd2249c24a1ce", @"/Views/Home/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb36fb8b22874e3596d48d7f181fd2249c24a1ce5001", async() => {
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
            BeginContext(130, 10540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb36fb8b22874e3596d48d7f181fd2249c24a1ce7009", async() => {
                BeginContext(150, 4115, true);
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
        
        
        <div id=""rowPictu");
                WriteLiteral("res\" class=\"row\">\r\n");
                EndContext();
#line 107 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
             foreach (var project in @Model.Projects)
            {
                if (project.Closed == false)
                {
              

#line default
#line hidden
                BeginContext(4416, 87, true);
                WriteLiteral("                                <div class=\"column text-center text-black openProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4503, "\"", 4731, 5);
                WriteAttributeValue("", 4513, "location.href", 4513, 13, true);
                WriteAttributeValue(" ", 4526, "=", 4527, 2, true);
                WriteAttributeValue(" ", 4528, "\'", 4529, 2, true);
#line 112 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4530, Url.Action("ProjectDetailPage", "Project"
                                                                                                                      , new {projectId = project.ProjectId}), 4530, 200, false);

#line default
#line hidden
                WriteAttributeValue("", 4730, "\'", 4730, 1, true);
                EndWriteAttribute();
                BeginContext(4732, 203, true);
                WriteLiteral(">\r\n                                    <div id=\"projectpaddingfix\" class=\"card\">\r\n                                        <div class=\"textWithBlurredBg\">\r\n                                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4935, "\"", 4961, 1);
#line 116 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4941, project.Base64Image, 4941, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4962, 196, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                       \r\n                                            <div class=\"text-center\">\r\n                                                <h3 class=\"text-light\">");
                EndContext();
                BeginContext(5159, 12, false);
#line 119 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                  Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5171, 78, true);
                WriteLiteral("</h3>\r\n                                                <h4 class=\"text-light\">");
                EndContext();
                BeginContext(5250, 19, false);
#line 120 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                  Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(5269, 320, true);
                WriteLiteral(@"</h4>
                                            </div>
                        
                                        </div>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 5589, "\"", 5622, 3);
                WriteAttributeValue("", 5597, "width:", 5597, 6, true);
#line 125 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5603, project.Progress, 5604, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 5621, "%", 5621, 1, true);
                EndWriteAttribute();
                BeginContext(5623, 256, true);
                WriteLiteral(@"></div>
                                        </div>


                                        <div>
                                            <p class=""text-dark"">
                                                <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(5880, 18, false);
#line 131 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                            Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(5898, 79, true);
                WriteLiteral("\r\n                                                <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(5978, 21, false);
#line 132 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                        Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(5999, 82, true);
                WriteLiteral("\r\n                                                <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(6082, 24, false);
#line 133 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                           Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(6106, 184, true);
                WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 138 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                   
                        }
                        
                else if (project.Closed == true)
                {
                
                

#line default
#line hidden
                BeginContext(6469, 77, true);
                WriteLiteral("                    <div class=\"column text-center text-black closedProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6546, "\"", 6764, 5);
                WriteAttributeValue("", 6556, "location.href", 6556, 13, true);
                WriteAttributeValue(" ", 6569, "=", 6570, 2, true);
                WriteAttributeValue(" ", 6571, "\'", 6572, 2, true);
#line 145 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 6573, Url.Action("ProjectDetailPage", "Project"
                                                                                                            , new {projectId = project.ProjectId}), 6573, 190, false);

#line default
#line hidden
                WriteAttributeValue("", 6763, "\'", 6763, 1, true);
                EndWriteAttribute();
                BeginContext(6765, 203, true);
                WriteLiteral(">\r\n                                  \r\n                        <div id=\"projectpaddingfix\" class=\"card\">\r\n                            <div class=\"textWithBlurredBg\">\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6968, "\"", 6994, 1);
#line 150 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 6974, project.Base64Image, 6974, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6995, 196, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                                               \r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"text-light\">");
                EndContext();
                BeginContext(7192, 12, false);
#line 153 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                      Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7204, 66, true);
                WriteLiteral("</h3>\r\n                                    <h4 class=\"text-light\">");
                EndContext();
                BeginContext(7271, 19, false);
#line 154 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                      Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(7290, 296, true);
                WriteLiteral(@"</h4>
                                </div>
                                                
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 7586, "\"", 7619, 3);
                WriteAttributeValue("", 7594, "width:", 7594, 6, true);
#line 159 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7600, project.Progress, 7601, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 7618, "%", 7618, 1, true);
                EndWriteAttribute();
                BeginContext(7620, 256, true);
                WriteLiteral(@"></div>
                            </div>
                        
                        
                            <div>
                                <p class=""text-dark"">
                                    <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(7877, 18, false);
#line 165 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(7895, 67, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(7963, 21, false);
#line 166 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                            Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(7984, 70, true);
                WriteLiteral("\r\n                                    <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(8055, 24, false);
#line 167 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                               Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(8079, 136, true);
                WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 172 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                    
                }
            }

#line default
#line hidden
                BeginContext(8271, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 175 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
             foreach (var project in @Model.OngoingProjects)
            {
                if (project.Ongoing == true)
                {

#line default
#line hidden
                BeginContext(8413, 78, true);
                WriteLiteral("                    <div class=\"column text-center text-black ongoingProjects\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 8491, "\"", 8710, 5);
                WriteAttributeValue("", 8501, "location.href", 8501, 13, true);
                WriteAttributeValue(" ", 8514, "=", 8515, 2, true);
                WriteAttributeValue(" ", 8516, "\'", 8517, 2, true);
#line 179 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 8518, Url.Action("ProjectDetailPage", "Project"
                                                                                                             , new {projectId = project.ProjectId}), 8518, 191, false);

#line default
#line hidden
                WriteAttributeValue("", 8709, "\'", 8709, 1, true);
                EndWriteAttribute();
                BeginContext(8711, 205, true);
                WriteLiteral(">\r\n                        \r\n                            <div id=\"projectpaddingfix\" class=\"card\">\r\n                                <div class=\"textWithBlurredBg\">\r\n                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 8916, "\"", 8942, 1);
#line 184 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 8922, project.Base64Image, 8922, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8943, 180, true);
                WriteLiteral(" width=\"365\" height=\"200\"/>\r\n                       \r\n                                    <div class=\"text-center\">\r\n                                        <h3 class=\"text-light\">");
                EndContext();
                BeginContext(9124, 12, false);
#line 187 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                          Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(9136, 70, true);
                WriteLiteral("</h3>\r\n                                        <h4 class=\"text-light\">");
                EndContext();
                BeginContext(9207, 19, false);
#line 188 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                          Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(9226, 288, true);
                WriteLiteral(@"</h4>
                                    </div>
                        
                                </div>
                                <div class=""progress"">
                                    <div class=""progress-bar bg-success progress-bar-striped progress-bar-animated""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 9514, "\"", 9547, 3);
                WriteAttributeValue("", 9522, "width:", 9522, 6, true);
#line 193 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 9528, project.Progress, 9529, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 9546, "%", 9546, 1, true);
                EndWriteAttribute();
                BeginContext(9548, 224, true);
                WriteLiteral("></div>\r\n                                </div>\r\n\r\n\r\n                                <div>\r\n                                    <p class=\"text-dark\">\r\n                                        <i class=\"far fa-lightbulb\"></i> ");
                EndContext();
                BeginContext(9773, 18, false);
#line 199 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                    Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(9791, 71, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(9863, 21, false);
#line 200 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(9884, 74, true);
                WriteLiteral("\r\n                                        <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(9959, 24, false);
#line 201 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                                                                   Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(9983, 152, true);
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
                EndContext();
#line 206 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Home\Index.cshtml"
                    
                }
            }

#line default
#line hidden
                BeginContext(10191, 178, true);
                WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col text-center py-5\">\r\n                <div id=\"ProjectsButton\" class=\"col text-center\">\r\n                    ");
                EndContext();
                BeginContext(10369, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb36fb8b22874e3596d48d7f181fd2249c24a1ce30410", async() => {
                    BeginContext(10432, 13, true);
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
                BeginContext(10449, 214, true);
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
