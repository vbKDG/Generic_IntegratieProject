#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c36f95f77f765101f6ed70b6054cba0cb9e02225"
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c36f95f77f765101f6ed70b6054cba0cb9e02225", @"/Views/Idea/Ideas.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c36f95f77f765101f6ed70b6054cba0cb9e022254458", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 4 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c36f95f77f765101f6ed70b6054cba0cb9e022256439", async() => {
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
#line 8 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
    , new { ideationId=@Model.IdeationId}));

#line default
#line hidden
            EndContext();
            BeginContext(376, 103, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideas</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 17 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
     for (var i = 0; i < Model.ideas.Count; i++)
    {

#line default
#line hidden
            BeginContext(536, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(585, 28, false);
#line 21 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
           Write(Model.ideas.ToList()[i].user);

#line default
#line hidden
            EndContext();
            BeginContext(613, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(687, 41, true);
            WriteLiteral("                    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 728, "\"", 862, 3);
            WriteAttributeValue("", 738, "location.href=\'", 738, 15, true);
#line 24 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 753, Url.Action("LikeIdea", "Idea"
                           , new {ideaId = @Model.ideas.ToList()[i].ideaId}), 753, 108, false);

#line default
#line hidden
            WriteAttributeValue("", 861, "\'", 861, 1, true);
            EndWriteAttribute();
            BeginContext(863, 44, true);
            WriteLiteral(" >Like</button>\r\n                    <span>(");
            EndContext();
            BeginContext(908, 39, false);
#line 26 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                      Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(947, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 27 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1017, 103, true);
            WriteLiteral("                    <button title=\"You have to be signed in\">Like</button>\r\n                    <span>(");
            EndContext();
            BeginContext(1121, 39, false);
#line 31 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                      Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 32 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }

#line default
#line hidden
            BeginContext(1189, 40, true);
            WriteLiteral("                <br>\r\n                \r\n");
            EndContext();
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                 foreach (var field in Model.fields)
                {
                    if (Model.ideas.ToList()[i].ideaId == field.idea.ideaId)
                    {
                        

#line default
#line hidden
            BeginContext(1428, 10, false);
#line 39 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                   Write(field.text);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 30, true);
            WriteLiteral("                        <br>\r\n");
            EndContext();
#line 41 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1512, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 43 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1584, 27, true);
            WriteLiteral("                    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1611, "\"", 1675, 5);
            WriteAttributeValue("", 1621, "showPopup(", 1621, 10, true);
#line 45 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1631, Model.ideas.ToList()[i].ideaId, 1631, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 1662, ",", 1662, 1, true);
            WriteAttributeValue(" ", 1663, "\'idea\',", 1664, 8, true);
            WriteAttributeValue(" ", 1671, "0);", 1672, 4, true);
            EndWriteAttribute();
            BeginContext(1676, 27, true);
            WriteLiteral(">Report idea</button><br>\r\n");
            EndContext();
#line 46 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1763, 105, true);
            WriteLiteral("                    <button title=\"You have to be signed in to report an idea\">Report idea</button><br>\r\n");
            EndContext();
#line 50 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }

#line default
#line hidden
            BeginContext(1887, 41, true);
            WriteLiteral("                \r\n                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1928, "\"", 1949, 2);
            WriteAttributeValue("", 1933, "showReactions-", 1933, 14, true);
#line 52 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 1947, i, 1947, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1950, 46, true);
            WriteLiteral(">Show reactions</button>\r\n                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1996, "\"", 2013, 2);
            WriteAttributeValue("", 2001, "reactions-", 2001, 10, true);
#line 53 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2011, i, 2011, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2014, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 54 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     foreach (var reaction in Model.reactions.ToList())
                    {
                        if (reaction.idea.ideaId == @Model.ideas.ToList()[i].ideaId)
                        {
                            

#line default
#line hidden
            BeginContext(2255, 16, false);
#line 58 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                       Write(reaction.content);

#line default
#line hidden
            EndContext();
            BeginContext(2273, 49, true);
            WriteLiteral("                            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2322, "\"", 2464, 3);
            WriteAttributeValue("", 2332, "location.href=\'", 2332, 15, true);
#line 59 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2347, Url.Action("LikeReaction", "Idea"
                                      , new {reactionId = @reaction.reactionId}), 2347, 116, false);

#line default
#line hidden
            WriteAttributeValue("", 2463, "\'", 2463, 1, true);
            EndWriteAttribute();
            BeginContext(2465, 52, true);
            WriteLiteral(" >Like</button>\r\n                            <span>(");
            EndContext();
            BeginContext(2518, 28, false);
#line 61 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                              Write(reaction.reactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2546, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 62 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
            BeginContext(2651, 39, true);
            WriteLiteral("                                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2690, "\"", 2766, 6);
            WriteAttributeValue("", 2700, "showPopup(", 2700, 10, true);
#line 64 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2710, reaction.idea.ideaId, 2710, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 2731, ",", 2731, 1, true);
            WriteAttributeValue(" ", 2732, "\'reaction\',", 2733, 12, true);
#line 64 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue(" ", 2744, reaction.reactionId, 2745, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 2765, ")", 2765, 1, true);
            EndWriteAttribute();
            BeginContext(2767, 31, true);
            WriteLiteral(">Report reaction</button><br>\r\n");
            EndContext();
#line 65 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2894, 124, true);
            WriteLiteral("                                <button title=\"You have to be signed in to report a reaction\">Report reaction</button><br>\r\n");
            EndContext();
#line 69 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                        }
                    }

#line default
#line hidden
            BeginContext(3099, 27, true);
            WriteLiteral("                    <div>\r\n");
            EndContext();
#line 73 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                         using (Html.BeginForm("ReactIdea", "Idea",
                            FormMethod.Post))
                        {

#line default
#line hidden
            BeginContext(3269, 175, true);
            WriteLiteral("                            <p>Write your own reaction: </p>\r\n                            <input name=\"reaction\" type=\"text\" />\r\n                            <input name=\"idea\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3444, "\"", 3483, 1);
#line 78 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3452, Model.ideas.ToList()[i].ideaId, 3452, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3484, 86, true);
            WriteLiteral(" type=\"hidden\" />\r\n                            <input type=\"submit\" value=\"React\" />\r\n");
            EndContext();
#line 80 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                        }

#line default
#line hidden
            BeginContext(3597, 86, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 85 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
    }

#line default
#line hidden
            BeginContext(3690, 1054, true);
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
