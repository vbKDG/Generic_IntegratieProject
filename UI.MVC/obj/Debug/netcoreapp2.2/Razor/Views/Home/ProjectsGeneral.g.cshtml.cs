#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d388c54935ac1488ee6033b419eb07530e24f15c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d388c54935ac1488ee6033b419eb07530e24f15c", @"/Views/Home/ProjectsGeneral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProjectsGeneral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<@Domain.Project>>
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
  
    ViewData["Title"] = "Overzicht";

#line default
#line hidden
            BeginContext(82, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(86, 5055, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d388c54935ac1488ee6033b419eb07530e24f15c3795", async() => {
                BeginContext(113, 195, true);
                WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h2 id=\"projecttitlepadding\" class=\"text-dark\"> Ongoing projects</h2>\r\n</div>\r\n        \r\n      <div id=\"projectelementpadding\" class=\"row center-block\">    \r\n");
                EndContext();
#line 15 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
             foreach (var project in @Model)
            {

                if (project.startDate < DateTime.Now && DateTime.Now < project.endDate)
                 {

#line default
#line hidden
                BeginContext(480, 194, true);
                WriteLiteral("                     <div class=\"col-md-6\">\r\n                         <div class=\"col-md-12\">\r\n                             <div class=\"textWithBlurredBg\">\r\n                                 <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 674, "\"", 716, 1);
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 680, project.imageField.GetImageString(), 680, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(717, 124, true);
                WriteLiteral("/>\r\n                                 <div class=\"text-center\">\r\n                                     <h3 class=\"text-light\">");
                EndContext();
                BeginContext(842, 12, false);
#line 25 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                       Write(project.name);

#line default
#line hidden
                EndContext();
                BeginContext(854, 67, true);
                WriteLiteral("</h3>\r\n                                     <h4 class=\"text-light\">");
                EndContext();
                BeginContext(922, 19, false);
#line 26 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                       Write(project.description);

#line default
#line hidden
                EndContext();
                BeginContext(941, 871, true);
                WriteLiteral(@"</h4>
                                 </div>
                             </div>
                             
                             <div class=""progress center-block"">
                                 <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar"" style=""width:30%"">
                                 </div>
                             </div>

                             <div>
                                 <p class=""text-dark"">
                                     <i class=""far fa-heart fa-lg""></i> 5
                                     <i class=""far fa-comments fa-lg""></i> 6
                                     <i class=""fas fa-share-alt fa-lg""></i> 8
                                 </p>
                             </div>
                         </div>
                     </div>
");
                EndContext();
#line 44 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                 }
            }

#line default
#line hidden
                BeginContext(1847, 230, true);
                WriteLiteral("        </div>\r\n\r\n\r\n\r\n<div class=\"container.fluid py-5\">\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h2 id=\"projecttitlepadding\" class=\"text-dark\"> In Development</h2>\r\n</div>\r\n        \r\n<div id=\"projecttitlepadding\" class=\"row\">    \r\n");
                EndContext();
#line 59 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
     foreach (var project in @Model)
    {

        if (project.startDate > DateTime.Now)
         {

#line default
#line hidden
                BeginContext(2183, 162, true);
                WriteLiteral("             <div class=\"col-md-4\">\r\n                 <div class=\"col-md-16\">\r\n                     <div class=\"textWithBlurredBg\">\r\n                         <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2345, "\"", 2387, 1);
#line 67 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 2351, project.imageField.GetImageString(), 2351, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2388, 108, true);
                WriteLiteral("/>\r\n                         <div class=\"text-center\">\r\n                             <h3 class=\"text-light\">");
                EndContext();
                BeginContext(2497, 12, false);
#line 69 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                               Write(project.name);

#line default
#line hidden
                EndContext();
                BeginContext(2509, 59, true);
                WriteLiteral("</h3>\r\n                             <h4 class=\"text-light\">");
                EndContext();
                BeginContext(2569, 19, false);
#line 70 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                               Write(project.description);

#line default
#line hidden
                EndContext();
                BeginContext(2588, 721, true);
                WriteLiteral(@"</h4>
                         </div>
                     </div>
                     <div  class=""progress center-block"">
                         <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar"" style=""width:60%"">
                         </div>
                     </div>

                     <div>
                         <p class=""text-dark"">
                             <i class=""far fa-heart fa-lg""></i> 5
                             <i class=""far fa-comments fa-lg""></i> 6
                             <i class=""fas fa-share-alt fa-lg""></i> 8
                         </p>
                     </div>
                 </div>
             </div>
");
                EndContext();
#line 87 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
         }
    }

#line default
#line hidden
                BeginContext(3328, 180, true);
                WriteLiteral("</div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h2 id=\"projecttitlepadding\" class=\"text-dark\"> Closed projects</h2>\r\n</div>\r\n        \r\n      <div class=\"row\">    \r\n");
                EndContext();
#line 104 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
             foreach (var project in @Model)
            {

                if (project.endDate < DateTime.Now)
                 {

#line default
#line hidden
                BeginContext(3644, 194, true);
                WriteLiteral("                     <div class=\"col-md-3\">\r\n                         <div class=\"col-md-16\">\r\n                             <div class=\"textWithBlurredBg\">\r\n                                 <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3838, "\"", 3880, 1);
#line 112 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
WriteAttributeValue("", 3844, project.imageField.GetImageString(), 3844, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3881, 124, true);
                WriteLiteral("/>\r\n                                 <div class=\"text-center\">\r\n                                     <h3 class=\"text-light\">");
                EndContext();
                BeginContext(4006, 12, false);
#line 114 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                       Write(project.name);

#line default
#line hidden
                EndContext();
                BeginContext(4018, 67, true);
                WriteLiteral("</h3>\r\n                                     <h4 class=\"text-light\">");
                EndContext();
                BeginContext(4086, 19, false);
#line 115 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                                                       Write(project.description);

#line default
#line hidden
                EndContext();
                BeginContext(4105, 842, true);
                WriteLiteral(@"</h4>
                                 </div>
                             </div>
                             <div  class=""progress center-block"">
                                 <div class=""progress-bar progress-bar-success progress-bar-striped active"" role=""progressbar"" style=""width:100%"">
                                 </div>
                             </div>

                             <div>
                                 <p class=""text-dark"">
                                     <i class=""far fa-heart fa-lg""></i> 5
                                     <i class=""far fa-comments fa-lg""></i> 6
                                     <i class=""fas fa-share-alt fa-lg""></i> 8
                                 </p>
                             </div>
                         </div>
                     </div>
");
                EndContext();
#line 132 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\ProjectsGeneral.cshtml"
                 }

            }

#line default
#line hidden
                BeginContext(4984, 150, true);
                WriteLiteral("        </div>\r\n        <div class=\"col text-center py-5\">\r\n            <a href=\"#Start\"><i class=\"fas fa-arrow-up fa-2x\"></i></a>\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<@Domain.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591