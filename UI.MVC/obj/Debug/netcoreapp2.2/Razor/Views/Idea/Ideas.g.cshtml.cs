#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a695a84e1e5cdbf875fba1dca738685043190a7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a695a84e1e5cdbf875fba1dca738685043190a7", @"/Views/Idea/Ideas.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a695a84e1e5cdbf875fba1dca738685043190a74458", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3a695a84e1e5cdbf875fba1dca738685043190a76439", async() => {
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
            BeginContext(376, 314, true);
            WriteLiteral(@"

<script>
    $(document).ready(function() {
        $(""button[id^='likeIdea-']"").each(function() {
            var parts = $(this).attr('id').toString().split(""-"");
            $(this).click(function() {
                setTimeout(function() {
                    $.ajax({
                        url: '");
            EndContext();
            BeginContext(691, 35, false);
#line 18 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                         Write(Url.Action("GetIdeaLikes", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(726, 657, true);
            WriteLiteral(@"',
                        type: ""GET"",
                        data: { ideaId: parts[1] },
                        contentType: 'json',
                        success: function(result) {
                            $(""#ideaLikeCount-"" + parts[1]).text(""("" + result + "")"");
                        }
                    });
                }, 100);
            });
        });
        $(""button[id^='likeReaction-']"").each(function() {
            var parts = $(this).attr('id').toString().split(""-"");
            $(this).click(function() {
                setTimeout(function() {
                    $.ajax({
                        url: '");
            EndContext();
            BeginContext(1384, 39, false);
#line 34 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                         Write(Url.Action("GetReactionLikes", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 902, true);
            WriteLiteral(@"',
                        type: ""GET"",
                        data: { reactionId: parts[1] },
                        contentType: 'json',
                        success: function(result) {
                            $(""#reactionLikeCount-"" + parts[1]).text(""("" + result + "")"");
                        }
                    });
                }, 100);
            });
        });
        $(""button[id^='submitReaction-']"").each(function() {
            var parts = $(this).attr('id').toString().split(""-"");
            $(this).click(function() {
                var text = $(""#reaction-"" + parts[1]).val();
                $(""#newReaction-"" + parts[1]).append(text + ""<br>"");
                $(""#reaction-"" + parts[1]).val("""");
            });
        });
    });
</script>

<table class=""table"">
    <tr>
        <th>
            <p>Ideas</p>
        </th>
    </tr>
");
            EndContext();
#line 62 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
     for (var i = 0; i < Model.ideas.Count; i++)
    {

#line default
#line hidden
            BeginContext(2382, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2431, 38, false);
#line 66 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
           Write(Model.ideas.ToList()[i].user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2471, 52, false);
#line 66 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                   Write(Model.ideas.ToList()[i].user.LastName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(2523, 3, true);
            WriteLiteral(".\r\n");
            EndContext();
#line 67 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(2598, 27, true);
            WriteLiteral("                    <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2625, "\"", 2670, 2);
            WriteAttributeValue("", 2630, "likeIdea-", 2630, 9, true);
#line 69 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2639, Model.ideas.ToList()[i].ideaId, 2639, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2671, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                            onclick=\"", 2685, "\"", 2849, 3);
            WriteAttributeValue("", 2725, "location.href=\'", 2725, 15, true);
#line 70 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2740, Url.Action("LikeIdea", "Idea"
                           , new {ideaId = @Model.ideas.ToList()[i].ideaId}), 2740, 108, false);

#line default
#line hidden
            WriteAttributeValue("", 2848, "\'", 2848, 1, true);
            EndWriteAttribute();
            BeginContext(2850, 42, true);
            WriteLiteral(" >Like</button>\r\n                    <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2892, "\"", 2942, 2);
            WriteAttributeValue("", 2897, "ideaLikeCount-", 2897, 14, true);
#line 72 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 2911, Model.ideas.ToList()[i].ideaId, 2911, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2943, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(2946, 39, false);
#line 72 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                         Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2985, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 73 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3055, 103, true);
            WriteLiteral("                    <button title=\"You have to be signed in\">Like</button>\r\n                    <span>(");
            EndContext();
            BeginContext(3159, 39, false);
#line 77 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                      Write(Model.ideas.ToList()[i].ideaLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(3198, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 78 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }

#line default
#line hidden
            BeginContext(3227, 40, true);
            WriteLiteral("                <br>\r\n                \r\n");
            EndContext();
#line 81 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                 foreach (var field in Model.fields)
                {
                    if (Model.ideas.ToList()[i].ideaId == field.idea.ideaId)
                    {
                        

#line default
#line hidden
            BeginContext(3466, 10, false);
#line 85 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                   Write(field.text);

#line default
#line hidden
            EndContext();
            BeginContext(3478, 30, true);
            WriteLiteral("                        <br>\r\n");
            EndContext();
#line 87 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3550, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 89 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(3622, 27, true);
            WriteLiteral("                    <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3649, "\"", 3713, 5);
            WriteAttributeValue("", 3659, "showPopup(", 3659, 10, true);
#line 91 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3669, Model.ideas.ToList()[i].ideaId, 3669, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 3700, ",", 3700, 1, true);
            WriteAttributeValue(" ", 3701, "\'idea\',", 3702, 8, true);
            WriteAttributeValue(" ", 3709, "0);", 3710, 4, true);
            EndWriteAttribute();
            BeginContext(3714, 27, true);
            WriteLiteral(">Report idea</button><br>\r\n");
            EndContext();
#line 92 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3801, 105, true);
            WriteLiteral("                    <button title=\"You have to be signed in to report an idea\">Report idea</button><br>\r\n");
            EndContext();
#line 96 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                }

#line default
#line hidden
            BeginContext(3925, 41, true);
            WriteLiteral("                \r\n                <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3966, "\"", 3987, 2);
            WriteAttributeValue("", 3971, "showReactions-", 3971, 14, true);
#line 98 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 3985, i, 3985, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3988, 46, true);
            WriteLiteral(">Show reactions</button>\r\n                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4034, "\"", 4051, 2);
            WriteAttributeValue("", 4039, "reactions-", 4039, 10, true);
#line 99 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4049, i, 4049, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4052, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 100 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                     foreach (var reaction in Model.reactions.ToList())
                    {
                        if (reaction.idea.ideaId == @Model.ideas.ToList()[i].ideaId)
                        {
                            

#line default
#line hidden
            BeginContext(4293, 16, false);
#line 104 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                       Write(reaction.content);

#line default
#line hidden
            EndContext();
            BeginContext(4311, 35, true);
            WriteLiteral("                            <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4346, "\"", 4384, 2);
            WriteAttributeValue("", 4351, "likeReaction-", 4351, 13, true);
#line 105 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4364, reaction.reactionId, 4364, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4385, 14, true);
            WriteLiteral(" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " \r\n                                    onclick=\"", 4399, "\"", 4579, 3);
            WriteAttributeValue("", 4447, "location.href=\'", 4447, 15, true);
#line 106 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4462, Url.Action("LikeReaction", "Idea"
                                      , new {reactionId = @reaction.reactionId}), 4462, 116, false);

#line default
#line hidden
            WriteAttributeValue("", 4578, "\'", 4578, 1, true);
            EndWriteAttribute();
            BeginContext(4580, 50, true);
            WriteLiteral(" >Like</button>\r\n                            <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4630, "\"", 4673, 2);
            WriteAttributeValue("", 4635, "reactionLikeCount-", 4635, 18, true);
#line 108 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4653, reaction.reactionId, 4653, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4674, 2, true);
            WriteLiteral(">(");
            EndContext();
            BeginContext(4677, 28, false);
#line 108 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                                                                          Write(reaction.reactionLikes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(4705, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 109 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
            BeginContext(4810, 39, true);
            WriteLiteral("                                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4849, "\"", 4925, 6);
            WriteAttributeValue("", 4859, "showPopup(", 4859, 10, true);
#line 111 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 4869, reaction.idea.ideaId, 4869, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 4890, ",", 4890, 1, true);
            WriteAttributeValue(" ", 4891, "\'reaction\',", 4892, 12, true);
#line 111 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue(" ", 4903, reaction.reactionId, 4904, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 4924, ")", 4924, 1, true);
            EndWriteAttribute();
            BeginContext(4926, 31, true);
            WriteLiteral(">Report reaction</button><br>\r\n");
            EndContext();
#line 112 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5053, 124, true);
            WriteLiteral("                                <button title=\"You have to be signed in to report a reaction\">Report reaction</button><br>\r\n");
            EndContext();
#line 116 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                            }
                        }
                    }

#line default
#line hidden
            BeginContext(5258, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5282, "\"", 5330, 2);
            WriteAttributeValue("", 5287, "newReaction-", 5287, 12, true);
#line 119 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5299, Model.ideas.ToList()[i].ideaId, 5299, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5331, 36, true);
            WriteLiteral("></div>\r\n                    <div>\r\n");
            EndContext();
#line 121 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                         using (Html.BeginForm("ReactIdea", "Idea",
                            FormMethod.Post))
                        {

#line default
#line hidden
            BeginContext(5510, 112, true);
            WriteLiteral("                            <p>Write your own reaction: </p>\r\n                            <input name=\"reaction\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5622, "\"", 5667, 2);
            WriteAttributeValue("", 5627, "reaction-", 5627, 9, true);
#line 125 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5636, Model.ideas.ToList()[i].ideaId, 5636, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5668, 63, true);
            WriteLiteral(" type=\"text\" />\r\n                            <input name=\"idea\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5731, "\"", 5770, 1);
#line 126 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5739, Model.ideas.ToList()[i].ideaId, 5739, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5771, 54, true);
            WriteLiteral(" type=\"hidden\" />\r\n                            <button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5825, "\"", 5876, 2);
            WriteAttributeValue("", 5830, "submitReaction-", 5830, 15, true);
#line 127 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
WriteAttributeValue("", 5845, Model.ideas.ToList()[i].ideaId, 5845, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5877, 31, true);
            WriteLiteral(" type=\"submit\">React</button>\r\n");
            EndContext();
#line 128 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
                        }

#line default
#line hidden
            BeginContext(5935, 86, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 133 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideas.cshtml"
    }

#line default
#line hidden
            BeginContext(6028, 1054, true);
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
