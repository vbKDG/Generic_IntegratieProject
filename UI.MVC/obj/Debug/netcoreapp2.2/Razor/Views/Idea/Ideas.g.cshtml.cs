#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff9b24e9c9201af1aa35a1b2b9df60cef4afc7d"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff9b24e9c9201af1aa35a1b2b9df60cef4afc7d", @"/Views/Idea/Ideas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_Ideas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Ideas.IdeasVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/toastr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/toastr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/showReactionsReport.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/reportPopUp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(125, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff9b24e9c9201af1aa35a1b2b9df60cef4afc7d5567", async() => {
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
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ff9b24e9c9201af1aa35a1b2b9df60cef4afc7d6827", async() => {
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
            BeginContext(235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(237, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff9b24e9c9201af1aa35a1b2b9df60cef4afc7d8080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 6 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
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
            BeginContext(314, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(316, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ff9b24e9c9201af1aa35a1b2b9df60cef4afc7d10077", async() => {
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
            BeginContext(368, 20, true);
            WriteLiteral("\r\n\r\n<h1>Ideas</h1>\r\n");
            EndContext();
            BeginContext(389, 99, false);
#line 10 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
    , new { ideationId=@Model.IdeationId}));

#line default
#line hidden
            EndContext();
            BeginContext(488, 103, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideas</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 19 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
     for (var i = 0; i < Model.ideas.Count; i++)
    {
        if (Model.ideas.ToList()[i].disapproved == false)
        {

#line default
#line hidden
            BeginContext(718, 61, true);
            WriteLiteral("             <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(780, 38, false);
#line 25 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
               Write(Model.ideas.ToList()[i].user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(818, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(820, 52, false);
#line 25 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(Model.ideas.ToList()[i].user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(872, 3, true);
            WriteLiteral(".\r\n");
            EndContext();
#line 26 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(955, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 986, "\"", 1031, 2);
            WriteAttributeValue("", 991, "likeIdea-", 991, 9, true);
#line 28 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1000, Model.ideas.ToList()[i].ideaId, 1000, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1032, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                onclick=\"", 1046, "\"", 1235, 4);
            WriteAttributeValue("", 1090, "location.href=\'", 1090, 15, true);
#line 29 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1105, Url.Action("LikeIdea", "Idea"
                               , new {ideaId = @Model.ideas.ToList()[i].ideaId}), 1105, 112, false);

#line default
#line hidden
            WriteAttributeValue("", 1217, "\',", 1217, 2, true);
            WriteAttributeValue(" ", 1219, "userLikedIdea()", 1220, 16, true);
            EndWriteAttribute();
            BeginContext(1236, 46, true);
            WriteLiteral(" >Like</button>\r\n                        <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1282, "\"", 1332, 2);
            WriteAttributeValue("", 1287, "ideaLikeCount-", 1287, 14, true);
#line 31 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1301, Model.ideas.ToList()[i].ideaId, 1301, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1333, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(1336, 39, false);
#line 31 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                             Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1375, 14, true);
            WriteLiteral(")</span><br>\r\n");
            EndContext();
#line 32 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1461, 111, true);
            WriteLiteral("                        <button title=\"You have to be signed in\">Like</button>\r\n                        <span>(");
            EndContext();
            BeginContext(1573, 39, false);
#line 36 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                          Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 14, true);
            WriteLiteral(")</span><br>\r\n");
            EndContext();
#line 37 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(1649, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 38 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                     foreach (var field in Model.fields)
                    {
                        if (Model.ideas.ToList()[i].ideaId == field.idea.ideaId)
                        {
                            

#line default
#line hidden
            BeginContext(1868, 10, false);
#line 42 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                       Write(field.text);

#line default
#line hidden
            EndContext();
            BeginContext(1880, 34, true);
            WriteLiteral("                            <br>\r\n");
            EndContext();
#line 44 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1964, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 46 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(2044, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2075, "\"", 2139, 5);
            WriteAttributeValue("", 2085, "showPopup(", 2085, 10, true);
#line 48 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2095, Model.ideas.ToList()[i].ideaId, 2095, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 2126, ",", 2126, 1, true);
            WriteAttributeValue(" ", 2127, "\'idea\',", 2128, 8, true);
            WriteAttributeValue(" ", 2135, "0);", 2136, 4, true);
            EndWriteAttribute();
            BeginContext(2140, 27, true);
            WriteLiteral(">Report idea</button><br>\r\n");
            EndContext();
#line 49 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2239, 109, true);
            WriteLiteral("                        <button title=\"You have to be signed in to report an idea\">Report idea</button><br>\r\n");
            EndContext();
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(2371, 49, true);
            WriteLiteral("                    \r\n                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2420, "\"", 2441, 2);
            WriteAttributeValue("", 2425, "showReactions-", 2425, 14, true);
#line 55 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2439, i, 2439, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2442, 50, true);
            WriteLiteral(">Show reactions</button>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2492, "\"", 2509, 2);
            WriteAttributeValue("", 2497, "reactions-", 2497, 10, true);
#line 56 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2507, i, 2507, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2510, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 57 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                         foreach (var reaction in Model.reactions.ToList())
                        {
                            if (reaction.disapproved == false)
                            {
                                if (reaction.idea.ideaId == @Model.ideas.ToList()[i].ideaId)
                                {

#line default
#line hidden
            BeginContext(2841, 39, true);
            WriteLiteral("                                    <b>");
            EndContext();
            BeginContext(2881, 23, false);
#line 63 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                  Write(reaction.user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2904, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2906, 37, false);
#line 63 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                                           Write(reaction.user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(2943, 7, true);
            WriteLiteral(".</b>\r\n");
            EndContext();
            BeginContext(2987, 16, false);
#line 64 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                               Write(reaction.content);

#line default
#line hidden
            EndContext();
            BeginContext(3005, 43, true);
            WriteLiteral("                                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3048, "\"", 3086, 2);
            WriteAttributeValue("", 3053, "likeReaction-", 3053, 13, true);
#line 65 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3066, reaction.reactionId, 3066, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3087, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                            onclick=\"", 3101, "\"", 3318, 4);
            WriteAttributeValue("", 3157, "location.href=\'", 3157, 15, true);
#line 66 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3172, Url.Action("LikeReaction", "Idea"
                                              , new {reactionId = @reaction.reactionId}), 3172, 124, false);

#line default
#line hidden
            WriteAttributeValue("", 3296, "\',", 3296, 2, true);
            WriteAttributeValue(" ", 3298, "userLikedReaction()", 3299, 20, true);
            EndWriteAttribute();
            BeginContext(3319, 58, true);
            WriteLiteral(" >Like</button>\r\n                                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3377, "\"", 3420, 2);
            WriteAttributeValue("", 3382, "reactionLikeCount-", 3382, 18, true);
#line 68 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3400, reaction.reactionId, 3400, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3421, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(3424, 28, false);
#line 68 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                                  Write(reaction.reactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3452, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 69 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                    if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
            BeginContext(3573, 47, true);
            WriteLiteral("                                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3620, "\"", 3696, 6);
            WriteAttributeValue("", 3630, "showPopup(", 3630, 10, true);
#line 71 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3640, reaction.idea.ideaId, 3640, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3661, ",", 3661, 1, true);
            WriteAttributeValue(" ", 3662, "\'reaction\',", 3663, 12, true);
#line 71 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue(" ", 3674, reaction.reactionId, 3675, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 3695, ")", 3695, 1, true);
            EndWriteAttribute();
            BeginContext(3697, 31, true);
            WriteLiteral(">Report reaction</button><br>\r\n");
            EndContext();
#line 72 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3848, 132, true);
            WriteLiteral("                                        <button title=\"You have to be signed in to report a reaction\">Report reaction</button><br>\r\n");
            EndContext();
#line 76 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                }
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4150, 35, true);
            WriteLiteral("                                <b>");
            EndContext();
            BeginContext(4186, 23, false);
#line 81 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                              Write(reaction.user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4209, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4211, 37, false);
#line 81 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(reaction.user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(4248, 46, true);
            WriteLiteral(".</b>\r\n                                <span>(");
            EndContext();
            BeginContext(4295, 28, false);
#line 82 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                  Write(reaction.reactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4323, 112, true);
            WriteLiteral(")</span>\r\n                                <span class=\"text-danger\">This reaction has been blocked!</span><br>\r\n");
            EndContext();
#line 84 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4493, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4521, "\"", 4569, 2);
            WriteAttributeValue("", 4526, "newReaction-", 4526, 12, true);
#line 86 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4538, Model.ideas.ToList()[i].ideaId, 4538, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4570, 40, true);
            WriteLiteral("></div>\r\n                        <div>\r\n");
            EndContext();
#line 88 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                             using (Html.BeginForm("ReactIdea", "Idea",
                                FormMethod.Post))
                            {

#line default
#line hidden
            BeginContext(4765, 120, true);
            WriteLiteral("                                <p>Write your own reaction: </p>\r\n                                <input name=\"reaction\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4885, "\"", 4930, 2);
            WriteAttributeValue("", 4890, "reaction-", 4890, 9, true);
#line 92 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4899, Model.ideas.ToList()[i].ideaId, 4899, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4931, 67, true);
            WriteLiteral(" type=\"text\" />\r\n                                <input name=\"idea\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4998, "\"", 5037, 1);
#line 93 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5006, Model.ideas.ToList()[i].ideaId, 5006, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5038, 58, true);
            WriteLiteral(" type=\"hidden\" />\r\n                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5096, "\"", 5147, 2);
            WriteAttributeValue("", 5101, "submitReaction-", 5101, 15, true);
#line 94 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5116, Model.ideas.ToList()[i].ideaId, 5116, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5148, 65, true);
            WriteLiteral(" type=\"submit\" onclick=\"userSubmittedReaction()\">React</button>\r\n");
            EndContext();
#line 95 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                            }

#line default
#line hidden
            BeginContext(5244, 102, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 100 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(5382, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5443, 38, false);
#line 105 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
               Write(Model.ideas.ToList()[i].user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(5481, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5483, 52, false);
#line 105 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(Model.ideas.ToList()[i].user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(5535, 30, true);
            WriteLiteral(".\r\n                    <span>(");
            EndContext();
            BeginContext(5566, 39, false);
#line 106 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
                      Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5605, 138, true);
            WriteLiteral(")</span><br>\r\n                    <span class=\"text-danger\">This idea has been blocked!</span>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 110 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Idea\Ideas.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(5761, 1077, true);
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
        <button onclick=""submitReportIdea(), userSubmittedReport()"" id=""submitButton"">Submit</button><button oncl");
            WriteLiteral("ick=\"closePopup()\">Close</button>\r\n    </div>\r\n</div>");
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
