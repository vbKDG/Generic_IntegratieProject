#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f313dcb5d5889e2996fee82a6b73f439c1b23608"
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using System.Xml.Linq;

#line default
#line hidden
#line 3 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using D.UI.MVC.Models.Ideas;

#line default
#line hidden
#line 4 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f313dcb5d5889e2996fee82a6b73f439c1b23608", @"/Views/Idea/CreateIdeaPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_CreateIdeaPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Ideas.IdeaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Idea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
 foreach (var item in Model.ideationQuestion)
{

#line default
#line hidden
            BeginContext(160, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(168, 4, false);
#line 9 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
  Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(172, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 10 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
}

#line default
#line hidden
            BeginContext(181, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(187, 513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f313dcb5d5889e2996fee82a6b73f439c1b236086887", async() => {
                BeginContext(283, 19, true);
                WriteLiteral("\r\n\r\n   \r\n    \r\n    ");
                EndContext();
                BeginContext(302, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f313dcb5d5889e2996fee82a6b73f439c1b236087292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 18 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ideationId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 18 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                           WriteLiteral(Model.ideationId);

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
                BeginContext(371, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(378, 34, false);
#line 19 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
Write(Html.EditorFor(x => x.textFieldVM));

#line default
#line hidden
                EndContext();
                BeginContext(412, 10, true);
                WriteLiteral("    \r\n    ");
                EndContext();
                BeginContext(423, 35, false);
#line 20 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
Write(Html.EditorFor(x => x.imageFieldVM));

#line default
#line hidden
                EndContext();
                BeginContext(458, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(465, 35, false);
#line 21 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
Write(Html.EditorFor(x => x.videoFieldVM));

#line default
#line hidden
                EndContext();
                BeginContext(500, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(507, 33, false);
#line 22 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
Write(Html.EditorFor(x => x.mapFieldVM));

#line default
#line hidden
                EndContext();
                BeginContext(540, 153, true);
                WriteLiteral("\r\n     \r\n\r\n   \r\n  \r\n\r\n\r\n                                       \r\n    \r\n        \r\n     \r\n   \r\n    <input type=\"submit\" value=\"save\">   \r\n         \r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(700, 2, true);
            WriteLiteral("\r\n");
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
