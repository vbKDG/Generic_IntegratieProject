#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d4c5a369dd4a778eaacf28a344a9587e35b4f8"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20d4c5a369dd4a778eaacf28a344a9587e35b4f8", @"/Views/Admin/ManagePosts.cshtml")]
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
#line 3 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
  
    ViewData["Title"] = "Manage posts";

#line default
#line hidden
            BeginContext(70, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(157, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d4c5a369dd4a778eaacf28a344a9587e35b4f84392", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
            BeginContext(235, 7046, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d4c5a369dd4a778eaacf28a344a9587e35b4f86398", async() => {
                BeginContext(241, 232, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"py-3 text-center\">Manage Posts</h1>\r\n</div>\r\n\r\n<a class=\"previousButton\" onclick=\"previousPage()\">&laquo; Previous</a>\r\n<h1>Current project</h1>\r\n<select onchange = \"redirect(this.value)\">\r\n");
                EndContext();
#line 17 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
     foreach (var project in Model.Projects)
    {
        if (project.ProjectId == Model.SelectedProject)
        {

#line default
#line hidden
                BeginContext(594, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(606, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d4c5a369dd4a778eaacf28a344a9587e35b4f87426", async() => {
                    BeginContext(651, 12, false);
#line 21 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                   Write(project.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
                BeginContext(672, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
        }
        else
        {

#line default
#line hidden
                BeginContext(710, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(722, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d4c5a369dd4a778eaacf28a344a9587e35b4f810136", async() => {
                    BeginContext(758, 12, false);
#line 25 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                          Write(project.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
                BeginContext(779, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
        }
       
    }

#line default
#line hidden
                BeginContext(808, 1576, true);
                WriteLiteral(@"</select>
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
                                                <p>From</p>
                                            </th>
                                            
                                            <th>
                                                <p></p>");
                WriteLiteral(@"
                                            </th>
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
#line 64 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
                BeginContext(3335, 195, true);
                WriteLiteral("                                                        <tr>\r\n                                                            <td>\r\n                                                                <p>");
                EndContext();
                BeginContext(3531, 15, false);
#line 79 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                              Write(idea.User.Email);

#line default
#line hidden
                EndContext();
                BeginContext(3546, 206, true);
                WriteLiteral("</p>\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                <p>");
                EndContext();
                BeginContext(3753, 15, false);
#line 82 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                              Write(reportReactions);

#line default
#line hidden
                EndContext();
                BeginContext(3768, 224, true);
                WriteLiteral("</p>\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                <button type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3992, "\"", 4198, 3);
                WriteAttributeValue("", 4002, "location.href=\'", 4002, 15, true);
#line 85 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
WriteAttributeValue("", 4017, Url.Action("ShowReports", "Admin"
                                                                                                                  , new {ideaId = @idea.IdeaId}), 4017, 180, false);

#line default
#line hidden
                WriteAttributeValue("", 4197, "\'", 4197, 1, true);
                EndWriteAttribute();
                BeginContext(4199, 216, true);
                WriteLiteral(">Handle posts</button>\r\n                                                            </td>\r\n                                                            \r\n                                                        </tr>\r\n");
                EndContext();
#line 90 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                    }
                                                }

#line default
#line hidden
                BeginContext(4521, 1043, true);
                WriteLiteral(@"                                            </table>
                                       
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
                WriteLiteral("                 \r\n");
                EndContext();
#line 108 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                      foreach (var project in Model.Projects)
                                                                     {
                                                                         if (project.ProjectId == Model.SelectedProject)
                                                                         {

#line default
#line hidden
                BeginContext(5945, 77, true);
                WriteLiteral("                                                                             ");
                EndContext();
                BeginContext(6022, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d4c5a369dd4a778eaacf28a344a9587e35b4f820013", async() => {
                    BeginContext(6067, 12, false);
#line 112 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                                                                    Write(project.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
                BeginContext(6088, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 113 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                         }
                                                                         else
                                                                         {

#line default
#line hidden
                BeginContext(6321, 77, true);
                WriteLiteral("                                                                             ");
                EndContext();
                BeginContext(6398, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20d4c5a369dd4a778eaacf28a344a9587e35b4f823121", async() => {
                    BeginContext(6434, 12, false);
#line 116 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                                                           Write(project.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 116 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
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
                BeginContext(6455, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 117 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Admin\ManagePosts.cshtml"
                                                                         }
                                                         
                                                                     }

#line default
#line hidden
                BeginContext(6664, 610, true);
                WriteLiteral(@"                                                                 </select>
                                                             </div>
                                                         
                                                    </div>
                                                </div>
                            </div>
                                                            </div>
                                                        </div>
                                                        </div>
                                                
</div>
");
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
