#pragma checksum "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007a91b0d4634015b8d79a736c446468a7bf3948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_CreateIdeaPage), @"mvc.1.0.view", @"/Views/Idea/CreateIdeaPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/CreateIdeaPage.cshtml", typeof(AspNetCore.Views_Idea_CreateIdeaPage))]
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
#line 1 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 2 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using System.Collections.Immutable;

#line default
#line hidden
#line 3 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using System.Xml.Linq;

#line default
#line hidden
#line 4 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using D.UI.MVC.Models.Ideas;

#line default
#line hidden
#line 5 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using Domain;

#line default
#line hidden
#line 6 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007a91b0d4634015b8d79a736c446468a7bf3948", @"/Views/Idea/CreateIdeaPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_CreateIdeaPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Ideas.IdeaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ideaForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Idea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 75, true);
            WriteLiteral("\r\n<a class=\"previousButton\" onclick=\"previousPage()\">&laquo; Previous</a>\r\n");
            EndContext();
            BeginContext(263, 2935, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "007a91b0d4634015b8d79a736c446468a7bf39486633", async() => {
                BeginContext(269, 170, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n<div class=\"row center-block\">\r\n    <div class=\"col-lg-12\">\r\n        \r\n\r\n<div id=\"cardcreate\" class=\"card\">\r\n<div class=\"card-body py-5\">\r\n\r\n\r\n");
                EndContext();
#line 20 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
 foreach (var item in Model.IdeationQuestion)
{

#line default
#line hidden
                BeginContext(489, 58, true);
                WriteLiteral("    <b>\r\n        <u>\r\n            <h1 class=\"text-center\">");
                EndContext();
                BeginContext(548, 4, false);
#line 24 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                               Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(552, 15, true);
                WriteLiteral("</h1></u></b>\r\n");
                EndContext();
#line 25 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
}

#line default
#line hidden
                BeginContext(570, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
                BeginContext(578, 2527, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "007a91b0d4634015b8d79a736c446468a7bf39488246", async() => {
                    BeginContext(688, 45, true);
                    WriteLiteral("\r\n<h3 class=\"py-4\"><b>Pick a title</b></h3>\r\n");
                    EndContext();
                    BeginContext(733, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "007a91b0d4634015b8d79a736c446468a7bf39488695", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 32 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdeationId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 32 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                       WriteLiteral(Model.IdeationId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(802, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(804, 28, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "007a91b0d4634015b8d79a736c446468a7bf394811283", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdeaTitle);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(832, 4, true);
                    WriteLiteral("\r\n\r\n");
                    EndContext();
#line 35 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
 if (@Model.TextFieldVms.Count != 0)
{

#line default
#line hidden
                    BeginContext(877, 61, true);
                    WriteLiteral("    <h3><b>Upload Text</b></h3>\r\n    <div id=\"TextUploads\">\r\n");
                    EndContext();
#line 39 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
         for (int i = 0; i < @Model.TextFieldVms.Count; i++)
        {

            

#line default
#line hidden
                    BeginContext(1026, 55, false);
#line 42 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
       Write(Html.EditorFor(x => x.TextFieldVms[i], new {index = i}));

#line default
#line hidden
                    EndContext();
#line 42 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                    
        }

#line default
#line hidden
                    BeginContext(1094, 12, true);
                    WriteLiteral("    </div>\r\n");
                    EndContext();
#line 45 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
}

#line default
#line hidden
                    BeginContext(1109, 22, true);
                    WriteLiteral("\r\n<div class=\"py-3\">\r\n");
                    EndContext();
#line 48 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.ImageFieldVms.Count != 0)
    {

#line default
#line hidden
                    BeginContext(1181, 85, true);
                    WriteLiteral("        <h3><b>Upload Images</b></h3>\r\n        <div id=\"ImageUploads\" class=\"py-3\">\r\n");
                    EndContext();
#line 52 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.ImageFieldVms.Count; i++)
            {
                

#line default
#line hidden
                    BeginContext(1365, 56, false);
#line 54 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
           Write(Html.EditorFor(x => x.ImageFieldVms[i], new {index = i}));

#line default
#line hidden
                    EndContext();
#line 54 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                         

            }

#line default
#line hidden
                    BeginContext(1440, 20, true);
                    WriteLiteral("\r\n\r\n        </div>\r\n");
                    EndContext();
#line 60 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
    }

#line default
#line hidden
                    BeginContext(1467, 32, true);
                    WriteLiteral("\r\n</div>\r\n\r\n<div class=\"py-3\">\r\n");
                    EndContext();
#line 65 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.VideoFieldVms.Count != 0)
    {

#line default
#line hidden
                    BeginContext(1549, 77, true);
                    WriteLiteral("        <h3><b>Videos</b></h3>\r\n        <div id=\"VideoUploads\"class=\"py-2\">\r\n");
                    EndContext();
#line 69 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.VideoFieldVms.Count; i++)
            {
                

#line default
#line hidden
                    BeginContext(1725, 56, false);
#line 71 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
           Write(Html.EditorFor(x => x.VideoFieldVms[i], new {index = i}));

#line default
#line hidden
                    EndContext();
#line 71 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                         

            }

#line default
#line hidden
                    BeginContext(1800, 16, true);
                    WriteLiteral("        </div>\r\n");
                    EndContext();
#line 75 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"

    }

#line default
#line hidden
                    BeginContext(1825, 28, true);
                    WriteLiteral("</div>\r\n<div class=\"py-3\">\r\n");
                    EndContext();
#line 79 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.MapFieldVms.Count != 0)
    {

#line default
#line hidden
                    BeginContext(1901, 86, true);
                    WriteLiteral("        <h3 class=\"py-2\"><b>Upload Locations</b></h3>\r\n        <div id=\"MapUploads\">\r\n");
                    EndContext();
#line 83 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.MapFieldVms.Count; i++)
            {
                

#line default
#line hidden
                    BeginContext(2084, 54, false);
#line 85 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
           Write(Html.EditorFor(x => x.MapFieldVms[i], new {index = i}));

#line default
#line hidden
                    EndContext();
#line 85 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                       

            }

#line default
#line hidden
                    BeginContext(2157, 16, true);
                    WriteLiteral("        </div>\r\n");
                    EndContext();
#line 89 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"

    }

#line default
#line hidden
                    BeginContext(2182, 12, true);
                    WriteLiteral("</div>\r\n\r\n\r\n");
                    EndContext();
#line 94 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
 if (@Model.QuestionFieldVms.Count != 0)
{

#line default
#line hidden
                    BeginContext(2239, 287, true);
                    WriteLiteral(@"    <h3><b>Upload Questions</b></h3>
    <div class=""row"">
        <div class=""dark-overlay"">
            <div class=""container"">
                <div class=""d-flex"">
                        <div class=""card-body"" id=""card"">
                            <div id=""QuestionUploads"">
");
                    EndContext();
#line 103 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                 for (int i = 0; i < @Model.QuestionFieldVms.Count; i++)
                                {
                                    

#line default
#line hidden
                    BeginContext(2688, 63, false);
#line 105 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                               Write(Html.EditorFor(x => x.QuestionFieldVms[i], new {index = i + 1}));

#line default
#line hidden
                    EndContext();
#line 105 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                                                    

                                }

#line default
#line hidden
                    BeginContext(2790, 162, true);
                    WriteLiteral("                            </div> \r\n                        </div> \r\n                    </div> \r\n                </div> \r\n            </div> \r\n        </div> \r\n");
                    EndContext();
#line 114 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
        
}

#line default
#line hidden
                    BeginContext(2965, 133, true);
                    WriteLiteral("<div class=\"py-3\">\r\n        <input type=\"submit\" class=\"btn btn-success center-block\" value=\"save\" onclick=\"disable()\">\r\n    </div>\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3105, 86, true);
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n        \r\n    </div>\r\n</div>\r\n</div>\r\n</div>\r\n");
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
            BeginContext(3198, 9, true);
            WriteLiteral("\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3207, "\"", 3247, 1);
#line 142 "C:\Users\lukas\Documents\GitHub\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
WriteAttributeValue("", 3213, Url.Content("~/js/createIdea.js"), 3213, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3248, 12, true);
            WriteLiteral("></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Ideas.IdeaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
