#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f394d5ea28dbe15173e12c6cd6db472ff604027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_Ideas), @"mvc.1.0.view", @"/Views/Idea/Ideas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/Ideas.cshtml", typeof(AspNetCore.Views_Idea_Ideas))]
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
#line 1 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
using D.UI.MVC.Models.Ideas;

#line default
#line hidden
#line 2 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f394d5ea28dbe15173e12c6cd6db472ff604027", @"/Views/Idea/Ideas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_Ideas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Ideas.IdeasVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toastr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/showReactionsReport.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/reportPopUp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/modal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(83, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(170, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f394d5ea28dbe15173e12c6cd6db472ff6040276257", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(233, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f394d5ea28dbe15173e12c6cd6db472ff6040277517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(280, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(282, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f394d5ea28dbe15173e12c6cd6db472ff6040278770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 8 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
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
            BeginContext(359, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(361, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f394d5ea28dbe15173e12c6cd6db472ff60402710770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(413, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(415, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f394d5ea28dbe15173e12c6cd6db472ff60402712024", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 11, true);
            WriteLiteral("\r\n\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 472, "\"", 530, 1);
#line 12 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 478, Url.Content("~/Scripts/jquery.unobtrusive-ajax.js"), 478, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(531, 53, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n<h1>Ideas</h1>\r\n");
            EndContext();
            BeginContext(585, 99, false);
#line 15 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
    , new { ideationId=@Model.IdeationId}));

#line default
#line hidden
            EndContext();
            BeginContext(684, 103, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideas</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 24 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
     for (var i = 0; i < Model.ideas.Count; i++)
    {
        if (Model.ideas.ToList()[i].Disapproved == false)
        {

#line default
#line hidden
            BeginContext(914, 64, true);
            WriteLiteral("             <tr>\r\n                <td>\r\n                    <b>");
            EndContext();
            BeginContext(979, 38, false);
#line 30 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                  Write(Model.ideas.ToList()[i].User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1019, 52, false);
#line 30 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                          Write(Model.ideas.ToList()[i].User.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 8, true);
            WriteLiteral(". </b>\r\n");
            EndContext();
#line 31 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (@Model.ideas.ToList()[i].Verified)
                    {

#line default
#line hidden
            BeginContext(1163, 71, true);
            WriteLiteral("                        <i class=\"glyphicon glyphicon-ok-circle\"></i>\r\n");
            EndContext();
#line 34 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(1257, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 35 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(1337, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1368, "\"", 1413, 2);
            WriteAttributeValue("", 1373, "likeIdea-", 1373, 9, true);
#line 37 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1382, Model.ideas.ToList()[i].IdeaId, 1382, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1414, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                onclick=\"", 1428, "\"", 1617, 4);
            WriteAttributeValue("", 1472, "location.href=\'", 1472, 15, true);
#line 38 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1487, Url.Action("LikeIdea", "Idea"
                               , new {ideaId = @Model.ideas.ToList()[i].IdeaId}), 1487, 112, false);

#line default
#line hidden
            WriteAttributeValue("", 1599, "\',", 1599, 2, true);
            WriteAttributeValue(" ", 1601, "userLikedIdea()", 1602, 16, true);
            EndWriteAttribute();
            BeginContext(1618, 46, true);
            WriteLiteral(" >Like</button>\r\n                        <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1664, "\"", 1714, 2);
            WriteAttributeValue("", 1669, "ideaLikeCount-", 1669, 14, true);
#line 40 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1683, Model.ideas.ToList()[i].IdeaId, 1683, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1715, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(1718, 39, false);
#line 40 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                             Write(Model.ideas.ToList()[i].IdeaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1757, 14, true);
            WriteLiteral(")</span><br>\r\n");
            EndContext();
#line 41 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1843, 111, true);
            WriteLiteral("                        <button title=\"You have to be signed in\">Like</button>\r\n                        <span>(");
            EndContext();
            BeginContext(1955, 39, false);
#line 45 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                          Write(Model.ideas.ToList()[i].IdeaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 14, true);
            WriteLiteral(")</span><br>\r\n");
            EndContext();
#line 46 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(2031, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 47 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     foreach (var field in Model.fields)
                    {
                        if (Model.ideas.ToList()[i].IdeaId == field.Idea.IdeaId)
                        {
                            

#line default
#line hidden
            BeginContext(2250, 10, false);
#line 51 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                       Write(field.Text);

#line default
#line hidden
            EndContext();
            BeginContext(2262, 34, true);
            WriteLiteral("                            <br>\r\n");
            EndContext();
#line 53 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2346, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 55 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(2426, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2457, "\"", 2521, 5);
            WriteAttributeValue("", 2467, "showPopup(", 2467, 10, true);
#line 57 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2477, Model.ideas.ToList()[i].IdeaId, 2477, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 2508, ",", 2508, 1, true);
            WriteAttributeValue(" ", 2509, "\'idea\',", 2510, 8, true);
            WriteAttributeValue(" ", 2517, "0);", 2518, 4, true);
            EndWriteAttribute();
            BeginContext(2522, 27, true);
            WriteLiteral(">Report idea</button><br>\r\n");
            EndContext();
#line 58 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2621, 109, true);
            WriteLiteral("                        <button title=\"You have to be signed in to report an idea\">Report idea</button><br>\r\n");
            EndContext();
#line 62 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(2753, 49, true);
            WriteLiteral("                    \r\n                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2802, "\"", 2823, 2);
            WriteAttributeValue("", 2807, "showReactions-", 2807, 14, true);
#line 64 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2821, i, 2821, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2824, 50, true);
            WriteLiteral(">Show reactions</button>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2874, "\"", 2891, 2);
            WriteAttributeValue("", 2879, "reactions-", 2879, 10, true);
#line 65 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2889, i, 2889, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2892, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 66 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                         foreach (var reaction in Model.reactions.ToList())
                        {
                            if (reaction.Disapproved == false)
                            {
                                if (reaction.Idea.IdeaId == @Model.ideas.ToList()[i].IdeaId)
                                {

#line default
#line hidden
            BeginContext(3223, 39, true);
            WriteLiteral("                                    <b>");
            EndContext();
            BeginContext(3263, 23, false);
#line 72 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                  Write(reaction.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3286, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3288, 37, false);
#line 72 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                           Write(reaction.User.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(3325, 7, true);
            WriteLiteral(".</b>\r\n");
            EndContext();
#line 73 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    if (@reaction.Verified)
                                    {

#line default
#line hidden
            BeginContext(3432, 87, true);
            WriteLiteral("                                        <i class=\"glyphicon glyphicon-ok-circle\"></i>\r\n");
            EndContext();
#line 76 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                    

#line default
#line hidden
            BeginContext(3595, 16, false);
#line 77 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                               Write(reaction.Content);

#line default
#line hidden
            EndContext();
            BeginContext(3613, 43, true);
            WriteLiteral("                                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3656, "\"", 3694, 2);
            WriteAttributeValue("", 3661, "likeReaction-", 3661, 13, true);
#line 78 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3674, reaction.ReactionId, 3674, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3695, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                            onclick=\"", 3709, "\"", 3926, 4);
            WriteAttributeValue("", 3765, "location.href=\'", 3765, 15, true);
#line 79 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3780, Url.Action("LikeReaction", "Idea"
                                              , new {reactionId = @reaction.ReactionId}), 3780, 124, false);

#line default
#line hidden
            WriteAttributeValue("", 3904, "\',", 3904, 2, true);
            WriteAttributeValue(" ", 3906, "userLikedReaction()", 3907, 20, true);
            EndWriteAttribute();
            BeginContext(3927, 58, true);
            WriteLiteral(" >Like</button>\r\n                                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3985, "\"", 4028, 2);
            WriteAttributeValue("", 3990, "reactionLikeCount-", 3990, 18, true);
#line 81 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4008, reaction.ReactionId, 4008, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4029, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(4032, 28, false);
#line 81 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                                  Write(reaction.ReactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4060, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 82 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
            BeginContext(4181, 47, true);
            WriteLiteral("                                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4228, "\"", 4304, 6);
            WriteAttributeValue("", 4238, "showPopup(", 4238, 10, true);
#line 84 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4248, reaction.Idea.IdeaId, 4248, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4269, ",", 4269, 1, true);
            WriteAttributeValue(" ", 4270, "\'reaction\',", 4271, 12, true);
#line 84 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue(" ", 4282, reaction.ReactionId, 4283, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4303, ")", 4303, 1, true);
            EndWriteAttribute();
            BeginContext(4305, 31, true);
            WriteLiteral(">Report reaction</button><br>\r\n");
            EndContext();
#line 85 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4456, 132, true);
            WriteLiteral("                                        <button title=\"You have to be signed in to report a reaction\">Report reaction</button><br>\r\n");
            EndContext();
#line 89 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                }
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4758, 35, true);
            WriteLiteral("                                <b>");
            EndContext();
            BeginContext(4794, 23, false);
#line 94 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                              Write(reaction.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4817, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4819, 37, false);
#line 94 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(reaction.User.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(4856, 46, true);
            WriteLiteral(".</b>\r\n                                <span>(");
            EndContext();
            BeginContext(4903, 28, false);
#line 95 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                  Write(reaction.ReactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4931, 112, true);
            WriteLiteral(")</span>\r\n                                <span class=\"text-danger\">This reaction has been blocked!</span><br>\r\n");
            EndContext();
#line 97 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5101, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5129, "\"", 5177, 2);
            WriteAttributeValue("", 5134, "newReaction-", 5134, 12, true);
#line 99 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5146, Model.ideas.ToList()[i].IdeaId, 5146, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5178, 40, true);
            WriteLiteral("></div>\r\n                        <div>\r\n");
            EndContext();
#line 101 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                             using (Html.BeginForm("ReactIdea", "Idea",
                                FormMethod.Post))
                            {

#line default
#line hidden
            BeginContext(5373, 120, true);
            WriteLiteral("                                <p>Write your own reaction: </p>\r\n                                <input name=\"reaction\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5493, "\"", 5538, 2);
            WriteAttributeValue("", 5498, "reaction-", 5498, 9, true);
#line 105 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5507, Model.ideas.ToList()[i].IdeaId, 5507, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5539, 67, true);
            WriteLiteral(" type=\"text\" />\r\n                                <input name=\"idea\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5606, "\"", 5645, 1);
#line 106 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5614, Model.ideas.ToList()[i].IdeaId, 5614, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5646, 58, true);
            WriteLiteral(" type=\"hidden\" />\r\n                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5704, "\"", 5755, 2);
            WriteAttributeValue("", 5709, "submitReaction-", 5709, 15, true);
#line 107 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5724, Model.ideas.ToList()[i].IdeaId, 5724, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5756, 65, true);
            WriteLiteral(" type=\"submit\" onclick=\"userSubmittedReaction()\">React</button>\r\n");
            EndContext();
#line 108 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }

#line default
#line hidden
            BeginContext(5852, 102, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 113 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(5990, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(6051, 38, false);
#line 118 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
               Write(Model.ideas.ToList()[i].User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(6089, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6091, 52, false);
#line 118 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(Model.ideas.ToList()[i].User.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(6143, 30, true);
            WriteLiteral(".\r\n                    <span>(");
            EndContext();
            BeginContext(6174, 39, false);
#line 119 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                      Write(Model.ideas.ToList()[i].IdeaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(6213, 138, true);
            WriteLiteral(")</span><br>\r\n                    <span class=\"text-danger\">This idea has been blocked!</span>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 123 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(6369, 1507, true);
            WriteLiteral(@"</table>

<div id=""blur"" name=""blur""></div>
<div id=""popup"" name=""popup"">
    <div name=""popupContent"" id=""popupContent"">
        <div name=""inputArea"" id=""inputArea"">
            <p id=""titelRep"">Why do you want to report this 
                <span id=""reportType""></span>?
            </p>
            <div id=""repTextContainer"">
                <textarea id=""reportText"" name=""reportText""></textarea>
            </div>
        </div>
        <div name=""successMessage"" id=""successMessage"">
            <img src=""/images/green_check.png"" id=""succesImg"" />
            <p>Your report has been successfully submitted.</p>
        </div>
        <div name=""failureMessage"" id=""failureMessage"">
            <img src=""/images/red_cross.jpg"" id=""failureImgr""/>
            <p>Something went wrong, please try again later.</p>
        </div>
    </div>
    <div id=""submitReportContainer"">
        <button onclick=""submitReportIdea(), userSubmittedReport()"" id=""submitButton"">Submit</button><button oncli");
            WriteLiteral(@"ck=""closePopup()"">Close</button>
    </div>
</div>
<div class=""container"">
<button type=""button"" class=""btn btn-info btn-lg"" data-target=""#MyModal"" data-toggle=""modal""> SAFE THE BIRDS </button>
<div class=""modal"" id=""MyModal"" role=""dialog"">
    <div id=""content"" class=""modal-dialog modal-lg"">
       
        
    </div>
    <script>
        $(document).ready(function() {
            $(""#content"").load(""/Idea/Idea"");
        });
    </script>
    
</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Ideas.IdeasVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
