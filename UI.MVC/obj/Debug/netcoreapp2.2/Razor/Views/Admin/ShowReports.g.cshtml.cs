#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba3a8b47fc328d4d61eafce3e0da0cd5c7bccf11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowReports), @"mvc.1.0.view", @"/Views/Admin/ShowReports.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ShowReports.cshtml", typeof(AspNetCore.Views_Admin_ShowReports))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba3a8b47fc328d4d61eafce3e0da0cd5c7bccf11", @"/Views/Admin/ShowReports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowReports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReportModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/showPostChange.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/reportPopUp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(107, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba3a8b47fc328d4d61eafce3e0da0cd5c7bccf114484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
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
            BeginContext(179, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(181, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba3a8b47fc328d4d61eafce3e0da0cd5c7bccf116472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(233, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
  
    ViewData["Title"] = "Show reports";

#line default
#line hidden
            BeginContext(285, 130, true);
            WriteLiteral("\r\n<div id=\"blur\" name=\"blur\"></div>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>\r\n            <b>Fields of the idea:</b><br>\r\n\r\n");
            EndContext();
#line 17 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
             foreach (var textfield in Model.TextFields)
            {
                

#line default
#line hidden
            BeginContext(505, 14, false);
#line 19 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
           Write(textfield.text);

#line default
#line hidden
            EndContext();
            BeginContext(519, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 20 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
            }

#line default
#line hidden
            BeginContext(540, 26, true);
            WriteLiteral("        </td>\r\n    </tr>\r\n");
            EndContext();
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
     foreach (var report in Model.reports)
    {
        if (report.reaction == null)
        {

#line default
#line hidden
            BeginContext(666, 82, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <b>Idea is from:</b>\r\n");
            EndContext();
#line 30 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                     if (Model.idea.ideaId == report.idea.ideaId)
                    {
                        

#line default
#line hidden
            BeginContext(863, 21, false);
#line 32 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                   Write(Model.idea.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(886, 45, true);
            WriteLiteral("                        <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 931, "\"", 1058, 3);
            WriteAttributeValue("", 941, "location.href=\'", 941, 15, true);
#line 33 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 956, Url.Action("BlockUser", "Admin"
                             , new { userId = @Model.idea.user.Id}), 956, 101, false);

#line default
#line hidden
            WriteAttributeValue("", 1057, "\'", 1057, 1, true);
            EndWriteAttribute();
            BeginContext(1059, 27, true);
            WriteLiteral(" >Block user</button><br>\r\n");
            EndContext();
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                    }

#line default
#line hidden
            BeginContext(1109, 40, true);
            WriteLiteral("                    <b>Reported by:</b> ");
            EndContext();
            BeginContext(1150, 17, false);
#line 36 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                                   Write(report.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 47, true);
            WriteLiteral("<br>\r\n                    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1214, "\"", 1340, 3);
            WriteAttributeValue("", 1224, "location.href=\'", 1224, 15, true);
#line 37 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 1239, Url.Action("ApproveIdea", "Admin"
                           , new { ideaId = @Model.idea.ideaId}), 1239, 100, false);

#line default
#line hidden
            WriteAttributeValue("", 1339, "\'", 1339, 1, true);
            EndWriteAttribute();
            BeginContext(1341, 61, true);
            WriteLiteral(" >Approve</button>\r\n                    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1402, "\"", 1531, 3);
            WriteAttributeValue("", 1412, "location.href=\'", 1412, 15, true);
#line 39 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 1427, Url.Action("DisapproveIdea", "Admin"
                           , new { ideaId = @Model.idea.ideaId}), 1427, 103, false);

#line default
#line hidden
            WriteAttributeValue("", 1530, "\'", 1530, 1, true);
            EndWriteAttribute();
            BeginContext(1532, 23, true);
            WriteLiteral(" >Disapprove</button>\r\n");
            EndContext();
#line 41 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                     if (User.IsInRole("Moderator"))
                    {

#line default
#line hidden
            BeginContext(1632, 45, true);
            WriteLiteral("                        <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1677, "\"", 1801, 3);
            WriteAttributeValue("", 1687, "location.href=\'", 1687, 15, true);
#line 43 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 1702, Url.Action("SendToAdmin", "Admin"
                               , new { reportId = @report.id}), 1702, 98, false);

#line default
#line hidden
            WriteAttributeValue("", 1800, "\'", 1800, 1, true);
            EndWriteAttribute();
            BeginContext(1802, 38, true);
            WriteLiteral(" >Send to administrator</button><br>\r\n");
            EndContext();
#line 45 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                    } 

#line default
#line hidden
            BeginContext(1864, 113, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    <b>Report message:</b><br>\r\n                    ");
            EndContext();
            BeginContext(1978, 20, false);
#line 49 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
               Write(report.reportMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 112, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <b>Submit date:</b><br>\r\n                    ");
            EndContext();
            BeginContext(2111, 20, false);
#line 53 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
               Write(report.dateSubmitted);

#line default
#line hidden
            EndContext();
            BeginContext(2131, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
            
        }
        else if (report.reaction != null && report.reaction.approved == false && report.reaction.disapproved == false)
        {

#line default
#line hidden
            BeginContext(2331, 86, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <b>Reaction is from:</b>\r\n");
            EndContext();
#line 63 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                     foreach (var reaction in Model.reactions)
                    {
                        if (reaction.reactionId == report.reaction.reactionId)
                        {
                            

#line default
#line hidden
            BeginContext(2640, 19, false);
#line 67 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                       Write(reaction.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2662, 49, true);
            WriteLiteral("                            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2711, "\"", 2840, 3);
            WriteAttributeValue("", 2721, "location.href=\'", 2721, 15, true);
#line 68 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 2736, Url.Action("BlockUser", "Admin"
                                 , new { userId = @reaction.user.Id}), 2736, 103, false);

#line default
#line hidden
            WriteAttributeValue("", 2839, "\'", 2839, 1, true);
            EndWriteAttribute();
            BeginContext(2841, 27, true);
            WriteLiteral(" >Block user</button><br>\r\n");
            EndContext();
#line 70 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2918, 40, true);
            WriteLiteral("                    <b>Reported by:</b> ");
            EndContext();
            BeginContext(2959, 17, false);
#line 72 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                                   Write(report.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2976, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 73 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                     if (report.reaction != null)
                    {
                        foreach (var reaction in Model.reactions)
                        {
                            if (reaction.reactionId == report.reaction.reactionId)
                            {
                                using (Html.BeginForm("ChangeReaction", "Admin", 
                                    new { reactionId = @reaction.reactionId, ideaId = @Model.idea.ideaId }, FormMethod.Post))
                                {

#line default
#line hidden
            BeginContext(3510, 54, true);
            WriteLiteral("                                    <div class=\"popup\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3564, "\"", 3595, 2);
            WriteAttributeValue("", 3569, "popup-", 3569, 6, true);
#line 82 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 3575, reaction.reactionId, 3575, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3596, 184, true);
            WriteLiteral(" name=\"popup\">\r\n                                        <div name=\"popupContent\" id=\"popupContent\">\r\n                                            <div name=\"inputArea\" class=\"inputArea\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3780, "\"", 3815, 2);
            WriteAttributeValue("", 3785, "inputArea-", 3785, 10, true);
#line 84 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 3795, reaction.reactionId, 3795, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3816, 267, true);
            WriteLiteral(@">
                                                <p id=""titelRep"">Change this reaction</p>
                                                <div id=""repTextContainer"">
                                                    <textarea id=""reportText"" name=""reportText"">");
            EndContext();
            BeginContext(4084, 16, false);
#line 87 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                                                                                           Write(reaction.content);

#line default
#line hidden
            EndContext();
            BeginContext(4100, 407, true);
            WriteLiteral(@"</textarea>
                                                </div>
                                            </div>
                                        </div>
                                        <div id=""submitReportContainer"">
                                            <button class=""submitButton"" type=""submit"">Change reaction</button>
                                            <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4507, "\"", 4549, 3);
            WriteAttributeValue("", 4517, "closePopup(", 4517, 11, true);
#line 93 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 4528, reaction.reactionId, 4528, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4548, ")", 4548, 1, true);
            EndWriteAttribute();
            BeginContext(4550, 109, true);
            WriteLiteral(">Close</button>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 96 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                                }

#line default
#line hidden
            BeginContext(4694, 50, true);
            WriteLiteral("                                <b>Reaction:</b>\r\n");
            EndContext();
            BeginContext(4777, 16, false);
#line 98 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                           Write(reaction.content);

#line default
#line hidden
            EndContext();
            BeginContext(4793, 45, true);
            WriteLiteral("<br>\r\n                                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4838, "\"", 4880, 3);
            WriteAttributeValue("", 4848, "showPopup(", 4848, 10, true);
#line 99 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 4858, reaction.reactionId, 4858, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4878, ");", 4878, 2, true);
            EndWriteAttribute();
            BeginContext(4881, 80, true);
            WriteLiteral(">Change reaction</button>\r\n                                <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4961, "\"", 5111, 3);
            WriteAttributeValue("", 4971, "location.href=\'", 4971, 15, true);
#line 100 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 4986, Url.Action("ApproveReaction", "Admin"
                                         , new { reactionId = @reaction.reactionId}), 4986, 124, false);

#line default
#line hidden
            WriteAttributeValue("", 5110, "\'", 5110, 1, true);
            EndWriteAttribute();
            BeginContext(5112, 73, true);
            WriteLiteral(" >Approve</button>\r\n                                <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5185, "\"", 5338, 3);
            WriteAttributeValue("", 5195, "location.href=\'", 5195, 15, true);
#line 102 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 5210, Url.Action("DisapproveReaction", "Admin"
                                         , new { reactionId = @reaction.reactionId}), 5210, 127, false);

#line default
#line hidden
            WriteAttributeValue("", 5337, "\'", 5337, 1, true);
            EndWriteAttribute();
            BeginContext(5339, 23, true);
            WriteLiteral(" >Disapprove</button>\r\n");
            EndContext();
#line 104 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                            }
                        }
                    }

#line default
#line hidden
            BeginContext(5443, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 107 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                     if (User.IsInRole("Moderator"))
                    {

#line default
#line hidden
            BeginContext(5520, 45, true);
            WriteLiteral("                        <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5565, "\"", 5688, 3);
            WriteAttributeValue("", 5575, "location.href=\'", 5575, 15, true);
#line 109 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
WriteAttributeValue("", 5590, Url.Action("SendToAdmin", "Admin"
                              , new { reportId = @report.id}), 5590, 97, false);

#line default
#line hidden
            WriteAttributeValue("", 5687, "\'", 5687, 1, true);
            EndWriteAttribute();
            BeginContext(5689, 38, true);
            WriteLiteral(" >Send to administrator</button><br>\r\n");
            EndContext();
#line 111 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
                    }  

#line default
#line hidden
            BeginContext(5752, 113, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    <b>Report message:</b><br>\r\n                    ");
            EndContext();
            BeginContext(5866, 20, false);
#line 115 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
               Write(report.reportMessage);

#line default
#line hidden
            EndContext();
            BeginContext(5886, 112, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <b>Submit date:</b><br>\r\n                    ");
            EndContext();
            BeginContext(5999, 20, false);
#line 119 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
               Write(report.dateSubmitted);

#line default
#line hidden
            EndContext();
            BeginContext(6019, 45, true);
            WriteLiteral("\r\n                </td>\r\n            </tr> \r\n");
            EndContext();
#line 122 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Admin\ShowReports.cshtml"
        }
        
    }

#line default
#line hidden
            BeginContext(6092, 8, true);
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
