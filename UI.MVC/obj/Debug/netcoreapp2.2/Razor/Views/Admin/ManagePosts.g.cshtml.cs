#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d17014298de59945bfe1ab7ba6947918c69a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManagePosts), @"mvc.1.0.view", @"/Views/Admin/ManagePosts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ManagePosts.cshtml", typeof(AspNetCore.Views_Admin_ManagePosts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d17014298de59945bfe1ab7ba6947918c69a68", @"/Views/Admin/ManagePosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManagePosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReportModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/changeProjectPosts.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
  
    ViewData["Title"] = "Manage posts";

#line default
#line hidden
            BeginContext(70, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(157, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d17014298de59945bfe1ab7ba6947918c69a684264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
            BeginContext(233, 74, true);
            WriteLiteral("\r\n\r\n<h1>Current project</h1>\r\n<select onchange = \"redirect(this.value)\">\r\n");
            EndContext();
#line 12 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
     foreach (var project in Model.projects)
    {
        if (project.projectId == Model.selectedProject)
        {

#line default
#line hidden
            BeginContext(428, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(440, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d17014298de59945bfe1ab7ba6947918c69a686734", async() => {
                BeginContext(485, 12, false);
#line 16 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                   Write(project.name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
               WriteLiteral(project.projectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(506, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(544, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(556, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d17014298de59945bfe1ab7ba6947918c69a689337", async() => {
                BeginContext(592, 12, false);
#line 20 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                          Write(project.name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
               WriteLiteral(project.projectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(613, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
        }
       
    }

#line default
#line hidden
            BeginContext(642, 36, true);
            WriteLiteral("</select>\r\n\r\n<table class=\"table\">\r\n");
            EndContext();
#line 27 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
     foreach (var ideation in Model.ideations)
    {
        foreach (var idea in ideation.ideas)
        {
            var reportReactions = 0;
            foreach (var report in Model.reports)
            {
                if (report.idea.ideaId == idea.ideaId)
                {
                    reportReactions++;
                }
            }

#line default
#line hidden
            BeginContext(1043, 71, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    Idea from: ");
            EndContext();
            BeginContext(1115, 15, false);
#line 41 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                          Write(idea.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 46, true);
            WriteLiteral(" <br>\r\n                    Amount of reports: ");
            EndContext();
            BeginContext(1177, 15, false);
#line 42 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                  Write(reportReactions);

#line default
#line hidden
            EndContext();
            BeginContext(1192, 48, true);
            WriteLiteral(" <br>\r\n                    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1240, "\"", 1357, 3);
            WriteAttributeValue("", 1250, "location.href=\'", 1250, 15, true);
#line 43 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
WriteAttributeValue("", 1265, Url.Action("ShowReports", "Admin"
                        , new { ideaId = @idea.ideaId}), 1265, 91, false);

#line default
#line hidden
            WriteAttributeValue("", 1356, "\'", 1356, 1, true);
            EndWriteAttribute();
            BeginContext(1358, 67, true);
            WriteLiteral(" >Handle posts</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 47 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1443, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReportModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
