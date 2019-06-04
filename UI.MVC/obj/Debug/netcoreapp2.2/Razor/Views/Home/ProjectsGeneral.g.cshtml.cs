#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "631dd7bbf27b78563cba0a8fe04fb34f2986124c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"631dd7bbf27b78563cba0a8fe04fb34f2986124c", @"/Views/Home/ProjectsGeneral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProjectsGeneral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<D.UI.MVC.Models.Projects.ProjectVM>>
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
            BeginContext(100, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(104, 9740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "631dd7bbf27b78563cba0a8fe04fb34f2986124c3815", async() => {
                BeginContext(131, 1064, true);
                WriteLiteral(@"


<h2 class=""text-center""><b>Our projects</b></h2>
            <div class=""container mt-3"">  
            <!-- tabs -->
            <ul class=""nav nav-tabs"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" data-toggle=""tab"" href=""#recent""><b>Recent</b></a>
                    
                </li>
                
                <li class=""nav-item"">
                    <a class=""nav-link"" data-toggle=""tab"" href=""#closed""><b>Closed</b></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-toggle=""tab"" href=""#ongoing""><b>Ongoing</b></a>
                </li>

            </ul>
            </div>
            <!-- Tab panes -->
            <div class=""p-5"">
                <div class=""tab-content"">
                            <div id=""recent"" class=""container tab-pane active"">
                                            <div class=""row lg-4"">
                                               <div");
                WriteLiteral(" id=\"projecttitlepadding\" class=\"row\">\r\n");
                EndContext();
#line 34 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                        foreach (var project in @Model)
                                                       {
                                                           if (project.Closed == false)
                                                           {

#line default
#line hidden
                BeginContext(1493, 84, true);
                WriteLiteral("                                                               <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1577, "\"", 1802, 5);
                WriteAttributeValue("", 1587, "location.href", 1587, 13, true);
                WriteAttributeValue(" ", 1600, "=", 1601, 2, true);
                WriteAttributeValue(" ", 1602, "\'", 1603, 2, true);
#line 38 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 1604, Url.Action("ProjectDetailPage", "Project"
                                                                                                                   , new {projectId = project.ProjectId}), 1604, 197, false);

#line default
#line hidden
                WriteAttributeValue("", 1801, "\'", 1801, 1, true);
                EndWriteAttribute();
                BeginContext(1803, 278, true);
                WriteLiteral(@">
                                                                   <div class=""col-md-16"">
                                                                       <div class=""textWithBlurredBg"">
                                                                           <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2081, "\"", 2107, 1);
#line 42 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 2087, project.Base64Image, 2087, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2108, 208, true);
                WriteLiteral("/>\r\n                                                                           <div class=\"text-center\">\r\n                                                                               <h3 class=\"text-light\">");
                EndContext();
                BeginContext(2317, 12, false);
#line 44 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                                 Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2329, 109, true);
                WriteLiteral("</h3>\r\n                                                                               <h4 class=\"text-light\">");
                EndContext();
                BeginContext(2439, 19, false);
#line 45 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                                 Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2458, 445, true);
                WriteLiteral(@"</h4>
                                                                           </div>
                                                                       </div>
                                                                       <div class=""progress center-block"">
                                                                           <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 2903, "\"", 2936, 3);
                WriteAttributeValue("", 2911, "width:", 2911, 6, true);
#line 49 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 2917, project.Progress, 2918, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 2935, "%", 2935, 1, true);
                EndWriteAttribute();
                BeginContext(2937, 502, true);
                WriteLiteral(@">
                                                                           </div>
                                                                       </div>
                                               
                                                                       <div>
                                                                           <p class=""text-dark"">
                                                                               <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(3440, 18, false);
#line 55 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                                           Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(3458, 110, true);
                WriteLiteral("\r\n                                                                               <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(3569, 21, false);
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                                       Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(3590, 113, true);
                WriteLiteral("\r\n                                                                               <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(3704, 24, false);
#line 57 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                                          Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(3728, 308, true);
                WriteLiteral(@"
                                                                           </p>
                                                                       </div>
                                                                   </div>
                                                               </div>
");
                EndContext();
#line 62 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                           }
                                                       }

#line default
#line hidden
                BeginContext(4156, 508, true);
                WriteLiteral(@"                                                   </div>
                                                
                                            </div>
                                        </div>
                    
                    
        
                    <div id=""ongoing"" class=""container tab-pane fade"">
        
                        <div class=""row mb-4"">
                            
                          <div id=""projectelementpadding"" class=""row center-block"">
");
                EndContext();
#line 76 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                               foreach (var project in @Model)
                              {
                                  if (project.Progress > 0 && project.Progress < 100)
                                  {

#line default
#line hidden
                BeginContext(4885, 59, true);
                WriteLiteral("                                      <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4944, "\"", 5144, 5);
                WriteAttributeValue("", 4954, "location.href", 4954, 13, true);
                WriteAttributeValue(" ", 4967, "=", 4968, 2, true);
                WriteAttributeValue(" ", 4969, "\'", 4970, 2, true);
#line 80 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 4971, Url.Action("ProjectDetailPage", "Project"
                                                                                          , new {projectId = project.ProjectId}), 4971, 172, false);

#line default
#line hidden
                WriteAttributeValue("", 5143, "\'", 5143, 1, true);
                EndWriteAttribute();
                BeginContext(5145, 203, true);
                WriteLiteral(">\r\n                                          <div class=\"col-md-16\">\r\n                                              <div class=\"textWithBlurredBg\">\r\n                                                  <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5348, "\"", 5374, 1);
#line 84 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 5354, project.Base64Image, 5354, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5375, 158, true);
                WriteLiteral("/>\r\n                                                  <div class=\"text-center\">\r\n                                                      <h3 class=\"text-light\">");
                EndContext();
                BeginContext(5534, 12, false);
#line 86 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5546, 84, true);
                WriteLiteral("</h3>\r\n                                                      <h4 class=\"text-light\">");
                EndContext();
                BeginContext(5631, 19, false);
#line 87 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                        Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(5650, 373, true);
                WriteLiteral(@"</h4>
                                                  </div>
                                              </div>
                          
                                              <div class=""progress center-block"">
                                                  <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 6023, "\"", 6056, 3);
                WriteAttributeValue("", 6031, "width:", 6031, 6, true);
#line 92 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 6037, project.Progress, 6038, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 6055, "%", 6055, 1, true);
                EndWriteAttribute();
                BeginContext(6057, 356, true);
                WriteLiteral(@">
                                                  </div>
                                              </div>
                          
                                              <div>
                                                  <p class=""text-dark"">
                                                      <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(6414, 18, false);
#line 98 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                  Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(6432, 85, true);
                WriteLiteral("\r\n                                                      <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(6518, 21, false);
#line 99 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                              Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(6539, 88, true);
                WriteLiteral("\r\n                                                      <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(6628, 24, false);
#line 100 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                 Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(6652, 208, true);
                WriteLiteral("\r\n                                                  </p>\r\n                                              </div>\r\n                                          </div>\r\n                                      </div>\r\n");
                EndContext();
#line 105 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                  }
                              }

#line default
#line hidden
                BeginContext(6930, 347, true);
                WriteLiteral(@"                          </div>  



                        </div>
                    </div>
        
                    
                    
                    <div id=""closed"" class=""container tab-pane fade"">
                        <div class=""row mb-4"">
                            <div id=""projecttitlepadding"" class=""row"">
");
                EndContext();
#line 119 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                 foreach (var project in @Model)
                                    {
                                        if (project.Closed == true)
                                        {

#line default
#line hidden
                BeginContext(7494, 65, true);
                WriteLiteral("                                            <div class=\"col-md-3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7559, "\"", 7765, 5);
                WriteAttributeValue("", 7569, "location.href", 7569, 13, true);
                WriteAttributeValue(" ", 7582, "=", 7583, 2, true);
                WriteAttributeValue(" ", 7584, "\'", 7585, 2, true);
#line 123 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 7586, Url.Action("ProjectDetailPage", "Project"
                                                                                                , new {projectId = project.ProjectId}), 7586, 178, false);

#line default
#line hidden
                WriteAttributeValue("", 7764, "\'", 7764, 1, true);
                EndWriteAttribute();
                BeginContext(7766, 221, true);
                WriteLiteral(">\r\n                                                <div class=\"col-md-16\">\r\n                                                    <div class=\"textWithBlurredBg\">\r\n                                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 7987, "\"", 8013, 1);
#line 127 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 7993, project.Base64Image, 7993, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8014, 170, true);
                WriteLiteral("/>\r\n                                                        <div class=\"text-center\">\r\n                                                            <h3 class=\"text-light\">");
                EndContext();
                BeginContext(8185, 12, false);
#line 129 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                              Write(project.Name);

#line default
#line hidden
                EndContext();
                BeginContext(8197, 90, true);
                WriteLiteral("</h3>\r\n                                                            <h4 class=\"text-light\">");
                EndContext();
                BeginContext(8288, 19, false);
#line 130 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                              Write(project.Description);

#line default
#line hidden
                EndContext();
                BeginContext(8307, 369, true);
                WriteLiteral(@"</h4>
                                                        </div>
                                                    </div>
                                                    <div class=""progress center-block"">
                                                        <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar""");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 8676, "\"", 8709, 3);
                WriteAttributeValue("", 8684, "width:", 8684, 6, true);
#line 134 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue(" ", 8690, project.Progress, 8691, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 8708, "%", 8708, 1, true);
                EndWriteAttribute();
                BeginContext(8710, 392, true);
                WriteLiteral(@">
                                                        </div>
                                                    </div>
                                
                                                    <div>
                                                        <p class=""text-dark"">
                                                            <i class=""far fa-lightbulb""></i> ");
                EndContext();
                BeginContext(9103, 18, false);
#line 140 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                        Write(project.IdeaAmount);

#line default
#line hidden
                EndContext();
                BeginContext(9121, 91, true);
                WriteLiteral("\r\n                                                            <i class=\"far fa-heart\"></i> ");
                EndContext();
                BeginContext(9213, 21, false);
#line 141 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                    Write(project.AmountOfLikes);

#line default
#line hidden
                EndContext();
                BeginContext(9234, 94, true);
                WriteLiteral("\r\n                                                            <i class=\"far fa-comments\"></i> ");
                EndContext();
                BeginContext(9329, 24, false);
#line 142 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                                                       Write(project.AmountOfComments);

#line default
#line hidden
                EndContext();
                BeginContext(9353, 232, true);
                WriteLiteral("\r\n                                                        </p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
                EndContext();
#line 147 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                        }
                                    }

#line default
#line hidden
                BeginContext(9667, 170, true);
                WriteLiteral("                            </div>\r\n                            </div>\r\n                    </div>\r\n        \r\n            \r\n                </div>\r\n            </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<D.UI.MVC.Models.Projects.ProjectVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
