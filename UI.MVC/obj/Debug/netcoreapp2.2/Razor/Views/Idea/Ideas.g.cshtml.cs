#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205d9edd5f13263585b2d27e0623d70bcea85bf8"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205d9edd5f13263585b2d27e0623d70bcea85bf8", @"/Views/Idea/Ideas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_Ideas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Ideas.IdeasVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/showReactionsReport.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(125, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205d9edd5f13263585b2d27e0623d70bcea85bf84584", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
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
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(204, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "205d9edd5f13263585b2d27e0623d70bcea85bf86607", async() => {
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
            BeginContext(256, 20, true);
            WriteLiteral("\r\n\r\n<h1>Ideas</h1>\r\n");
            EndContext();
            BeginContext(277, 99, false);
#line 8 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
    , new { ideationId=@Model.IdeationId}));

#line default
#line hidden
            EndContext();
            BeginContext(376, 103, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideas</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
     for (var i = 0; i < Model.ideas.Count; i++)
    {
        if (Model.ideas.ToList()[i].disapproved == false)
        {

#line default
#line hidden
            BeginContext(606, 61, true);
            WriteLiteral("             <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(668, 38, false);
#line 23 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
               Write(Model.ideas.ToList()[i].user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(706, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(708, 52, false);
#line 23 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(Model.ideas.ToList()[i].user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(760, 3, true);
            WriteLiteral(".\r\n");
            EndContext();
#line 24 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(843, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 874, "\"", 919, 2);
            WriteAttributeValue("", 879, "likeIdea-", 879, 9, true);
#line 26 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 888, Model.ideas.ToList()[i].ideaId, 888, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(920, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                onclick=\"", 934, "\"", 1106, 3);
            WriteAttributeValue("", 978, "location.href=\'", 978, 15, true);
#line 27 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 993, Url.Action("LikeIdea", "Idea"
                               , new {ideaId = @Model.ideas.ToList()[i].ideaId}), 993, 112, false);

#line default
#line hidden
            WriteAttributeValue("", 1105, "\'", 1105, 1, true);
            EndWriteAttribute();
            BeginContext(1107, 46, true);
            WriteLiteral(" >Like</button>\r\n                        <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1153, "\"", 1203, 2);
            WriteAttributeValue("", 1158, "ideaLikeCount-", 1158, 14, true);
#line 29 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1172, Model.ideas.ToList()[i].ideaId, 1172, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1204, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(1207, 39, false);
#line 29 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                             Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 14, true);
            WriteLiteral(")</span><br>\r\n");
            EndContext();
#line 30 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1332, 111, true);
            WriteLiteral("                        <button title=\"You have to be signed in\">Like</button>\r\n                        <span>(");
            EndContext();
            BeginContext(1444, 39, false);
#line 34 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                          Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1483, 14, true);
            WriteLiteral(")</span><br>\r\n");
            EndContext();
#line 35 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(1520, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 36 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     foreach (var field in Model.fields)
                    {
                        if (Model.ideas.ToList()[i].ideaId == field.idea.ideaId)
                        {
                            

#line default
#line hidden
            BeginContext(1739, 10, false);
#line 40 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                       Write(field.text);

#line default
#line hidden
            EndContext();
            BeginContext(1751, 34, true);
            WriteLiteral("                            <br>\r\n");
            EndContext();
#line 42 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1835, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 44 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(1915, 31, true);
            WriteLiteral("                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1946, "\"", 2010, 5);
            WriteAttributeValue("", 1956, "showPopup(", 1956, 10, true);
#line 46 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1966, Model.ideas.ToList()[i].ideaId, 1966, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 1997, ",", 1997, 1, true);
            WriteAttributeValue(" ", 1998, "\'idea\',", 1999, 8, true);
            WriteAttributeValue(" ", 2006, "0);", 2007, 4, true);
            EndWriteAttribute();
            BeginContext(2011, 27, true);
            WriteLiteral(">Report idea</button><br>\r\n");
            EndContext();
#line 47 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2110, 109, true);
            WriteLiteral("                        <button title=\"You have to be signed in to report an idea\">Report idea</button><br>\r\n");
            EndContext();
#line 51 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }

#line default
#line hidden
            BeginContext(2242, 49, true);
            WriteLiteral("                    \r\n                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2291, "\"", 2312, 2);
            WriteAttributeValue("", 2296, "showReactions-", 2296, 14, true);
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2310, i, 2310, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2313, 50, true);
            WriteLiteral(">Show reactions</button>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2363, "\"", 2380, 2);
            WriteAttributeValue("", 2368, "reactions-", 2368, 10, true);
#line 54 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2378, i, 2378, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2381, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 55 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                         foreach (var reaction in Model.reactions.ToList())
                        {
                            if (reaction.disapproved == false)
                            {
                                if (reaction.idea.ideaId == @Model.ideas.ToList()[i].ideaId)
                                {

#line default
#line hidden
            BeginContext(2712, 39, true);
            WriteLiteral("                                    <b>");
            EndContext();
            BeginContext(2752, 23, false);
#line 61 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                  Write(reaction.user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2775, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2777, 37, false);
#line 61 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                           Write(reaction.user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(2814, 7, true);
            WriteLiteral(".</b>\r\n");
            EndContext();
            BeginContext(2858, 16, false);
#line 62 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                               Write(reaction.content);

#line default
#line hidden
            EndContext();
            BeginContext(2876, 43, true);
            WriteLiteral("                                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2919, "\"", 2957, 2);
            WriteAttributeValue("", 2924, "likeReaction-", 2924, 13, true);
#line 63 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2937, reaction.reactionId, 2937, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2958, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                            onclick=\"", 2972, "\"", 3194, 3);
            WriteAttributeValue("", 3028, "location.href=\'", 3028, 15, true);
#line 64 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3043, Url.Action("LikeReaction", "Idea"
                                                                        , new {reactionId = @reaction.reactionId}), 3043, 150, false);

#line default
#line hidden
            WriteAttributeValue("", 3193, "\'", 3193, 1, true);
            EndWriteAttribute();
            BeginContext(3195, 58, true);
            WriteLiteral(" >Like</button>\r\n                                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3253, "\"", 3296, 2);
            WriteAttributeValue("", 3258, "reactionLikeCount-", 3258, 18, true);
#line 66 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3276, reaction.reactionId, 3276, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3297, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(3300, 28, false);
#line 66 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                                  Write(reaction.reactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3328, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 67 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
            BeginContext(3449, 47, true);
            WriteLiteral("                                        <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3496, "\"", 3572, 6);
            WriteAttributeValue("", 3506, "showPopup(", 3506, 10, true);
#line 69 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3516, reaction.idea.ideaId, 3516, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 3537, ",", 3537, 1, true);
            WriteAttributeValue(" ", 3538, "\'reaction\',", 3539, 12, true);
#line 69 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue(" ", 3550, reaction.reactionId, 3551, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 3571, ")", 3571, 1, true);
            EndWriteAttribute();
            BeginContext(3573, 31, true);
            WriteLiteral(">Report reaction</button><br>\r\n");
            EndContext();
#line 70 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3724, 132, true);
            WriteLiteral("                                        <button title=\"You have to be signed in to report a reaction\">Report reaction</button><br>\r\n");
            EndContext();
#line 74 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                    }
                                }
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4026, 35, true);
            WriteLiteral("                                <b>");
            EndContext();
            BeginContext(4062, 23, false);
#line 79 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                              Write(reaction.user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4085, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4087, 37, false);
#line 79 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(reaction.user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(4124, 46, true);
            WriteLiteral(".</b>\r\n                                <span>(");
            EndContext();
            BeginContext(4171, 28, false);
#line 80 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                  Write(reaction.reactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4199, 112, true);
            WriteLiteral(")</span>\r\n                                <span class=\"text-danger\">This reaction has been blocked!</span><br>\r\n");
            EndContext();
#line 82 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4369, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4397, "\"", 4445, 2);
            WriteAttributeValue("", 4402, "newReaction-", 4402, 12, true);
#line 84 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4414, Model.ideas.ToList()[i].ideaId, 4414, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4446, 40, true);
            WriteLiteral("></div>\r\n                        <div>\r\n");
            EndContext();
#line 86 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                             using (Html.BeginForm("ReactIdea", "Idea",
                                FormMethod.Post))
                            {

#line default
#line hidden
            BeginContext(4641, 120, true);
            WriteLiteral("                                <p>Write your own reaction: </p>\r\n                                <input name=\"reaction\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4761, "\"", 4806, 2);
            WriteAttributeValue("", 4766, "reaction-", 4766, 9, true);
#line 90 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4775, Model.ideas.ToList()[i].ideaId, 4775, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4807, 67, true);
            WriteLiteral(" type=\"text\" />\r\n                                <input name=\"idea\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4874, "\"", 4913, 1);
#line 91 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4882, Model.ideas.ToList()[i].ideaId, 4882, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4914, 58, true);
            WriteLiteral(" type=\"hidden\" />\r\n                                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4972, "\"", 5023, 2);
            WriteAttributeValue("", 4977, "submitReaction-", 4977, 15, true);
#line 92 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4992, Model.ideas.ToList()[i].ideaId, 4992, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5024, 31, true);
            WriteLiteral(" type=\"submit\">React</button>\r\n");
            EndContext();
#line 93 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }

#line default
#line hidden
            BeginContext(5086, 102, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 98 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(5224, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5285, 38, false);
#line 103 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
               Write(Model.ideas.ToList()[i].user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(5323, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5325, 52, false);
#line 103 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                       Write(Model.ideas.ToList()[i].user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(5377, 30, true);
            WriteLiteral(".\r\n                    <span>(");
            EndContext();
            BeginContext(5408, 39, false);
#line 104 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                      Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(5447, 138, true);
            WriteLiteral(")</span><br>\r\n                    <span class=\"text-danger\">This idea has been blocked!</span>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 108 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(5603, 1054, true);
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
        <button onclick=""submitReportIdea()"" id=""submitButton"">Submit</button><button onclick=""closePopup()"">Clos");
            WriteLiteral("e</button>\r\n    </div>\r\n</div>");
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
