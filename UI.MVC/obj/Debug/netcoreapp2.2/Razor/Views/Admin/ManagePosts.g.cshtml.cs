#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc9c5f15b0aa232fca1141e4e837896cd9d5f0d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc9c5f15b0aa232fca1141e4e837896cd9d5f0d", @"/Views/Admin/ManagePosts.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc9c5f15b0aa232fca1141e4e837896cd9d5f0d4404", async() => {
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
            BeginContext(233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(235, 4763, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc9c5f15b0aa232fca1141e4e837896cd9d5f0d6413", async() => {
                BeginContext(241, 1430, true);
                WriteLiteral(@"
<a class=""previousButton"" onclick=""previousPage()"">&laquo; Previous</a>
<div class=""container"">
    <h1 class=""py-3 text-center"">Manage Posts</h1>
</div>

<div class=""container"">

    <div class=""row center-block"">

        <div class=""dark-overlay"">
            <div class=""container"">

                <div class=""col-lg-9"">
                    <div class=""card bg-light card-form"">
                        <div class=""text-center"">
                            <h1 class=""display-4"">Posts</h1>
                            <h4>Here is a list of all the Posts</h4>
                        </div>
                        <div class=""card-body"">

                            <table class=""table"">
                                <tr>
                                    <th>
                                        <p>Idea is from</p>
                                    </th>

                                    <th>
                                        <p></p>
                             ");
                WriteLiteral(@"       </th>
                                    <th>
                                        <p></p>
                                    </th>

                                    <th>
                                        <p id=""reportelement"">Reports</p>
                                    </th>

                                </tr>
                                <table class=""table"">
");
                EndContext();
#line 49 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                     foreach (var ideation in Model.Ideations)
                                    {
                                        foreach (var idea in ideation.Ideas)
                                        {
                                            var reportReactions = 0;
                                            foreach (var report in Model.Reports)
                                            {
                                                if (report.Idea.IdeaId == idea.IdeaId)
                                                {
                                                    reportReactions++;
                                                }
                                            }


#line default
#line hidden
                BeginContext(2422, 159, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    <p>");
                EndContext();
                BeginContext(2582, 15, false);
#line 64 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                  Write(idea.User.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2597, 170, true);
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <p>");
                EndContext();
                BeginContext(2768, 15, false);
#line 67 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                  Write(reportReactions);

#line default
#line hidden
                EndContext();
                BeginContext(2783, 212, true);
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <button class=\"btn btn-success\" type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2995, "\"", 3193, 5);
                WriteAttributeValue("", 3005, "location.href", 3005, 13, true);
                WriteAttributeValue(" ", 3018, "=", 3019, 2, true);
                WriteAttributeValue(" ", 3020, "\'", 3021, 2, true);
#line 70 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
WriteAttributeValue("", 3022, Url.Action("ShowReports", "Admin"
                                                                                                        , new {ideaId = @idea.IdeaId}), 3022, 170, false);

#line default
#line hidden
                WriteAttributeValue("", 3192, "\'", 3192, 1, true);
                EndWriteAttribute();
                BeginContext(3194, 132, true);
                WriteLiteral(">Handle posts</button>\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
                EndContext();
#line 75 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                        }
                                    }

#line default
#line hidden
                BeginContext(3408, 680, true);
                WriteLiteral(@"                                </table>

                            </table>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3"" id=""bodyadmin"">
                    <div class=""card text-center bg-primary text-white mb-3"">
                        <div class=""card-body"">
                            <h3>Select Project</h3>
                            <h4 class=""display-4"">
                                <i class=""fas fa-pencil-alt""></i>
                            </h4>
                            <div class=""py-2"">
                                <select onchange=""redirect(this.value)"">

");
                EndContext();
#line 93 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                     foreach (var project in Model.Projects)
                                    {
                                        if (project.ProjectId == Model.SelectedProject)
                                        {

#line default
#line hidden
                BeginContext(4337, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(4381, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc9c5f15b0aa232fca1141e4e837896cd9d5f0d13335", async() => {
                    BeginContext(4426, 12, false);
#line 97 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                                   Write(project.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 97 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                               WriteLiteral(project.ProjectId);

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
                BeginContext(4447, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 98 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(4581, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(4625, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cc9c5f15b0aa232fca1141e4e837896cd9d5f0d16251", async() => {
                    BeginContext(4661, 12, false);
#line 101 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                          Write(project.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 101 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                               WriteLiteral(project.ProjectId);

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
                BeginContext(4682, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                        }

                                    }

#line default
#line hidden
                BeginContext(4768, 223, true);
                WriteLiteral("                                </select>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReportModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
