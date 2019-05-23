#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b344a9c52f523973c9d601a7c35f4b40e9498e64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_Questionnaire), @"mvc.1.0.view", @"/Views/Questionnaire/Questionnaire.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/Questionnaire.cshtml", typeof(AspNetCore.Views_Questionnaire_Questionnaire))]
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b344a9c52f523973c9d601a7c35f4b40e9498e64", @"/Views/Questionnaire/Questionnaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FillInQuestionnaireModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 3854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b344a9c52f523973c9d601a7c35f4b40e9498e643887", async() => {
                BeginContext(56, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 6 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
 using (Html.BeginForm("CreateUserQuestion", "Questionnaire",
    FormMethod.Post))
{
    
    
   

#line default
#line hidden
                BeginContext(166, 200, true);
                WriteLiteral("    <div class=\"row center-block\">\r\n        \r\n    <div class=\"dark-overlay\">\r\n    <div class=\"container\">\r\n\r\n    <div class=\"col-lg-4\">\r\n    <div class=\"card bg-light text-center card-form\">\r\n    <h1>");
                EndContext();
                BeginContext(367, 24, false);
#line 19 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
   Write(Model.questionnaire.name);

#line default
#line hidden
                EndContext();
                BeginContext(391, 91, true);
                WriteLiteral("</h1>\r\n    <h4>Questionnaire</h4>\r\n    <div class=\"card-body\">\r\n    <table class=\"table\">\r\n");
                EndContext();
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
         foreach (var item in Model.questions)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (item.questionType == QuestionType.MAILADDRESS)
                {

#line default
#line hidden
                BeginContext(692, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(777, 43, false);
#line 31 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(820, 127, true);
                WriteLiteral(" <br>\r\n                            <input name=\"email\" type=\"text\">\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                }
            }
            if (item.questionType == QuestionType.DROPDOWN)
            {

#line default
#line hidden
                BeginContext(1057, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1130, 43, false);
#line 41 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(1173, 54, true);
                WriteLiteral(" <br>\r\n                        <select id=\"ddlOptions\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1227, "\"", 1258, 3);
                WriteAttributeValue("", 1234, "Answer-", 1234, 7, true);
#line 42 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1241, item.id, 1241, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1249, "-dropdown", 1249, 9, true);
                EndWriteAttribute();
                BeginContext(1259, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(1290, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b344a9c52f523973c9d601a7c35f4b40e9498e647931", async() => {
                    BeginContext(1308, 13, true);
                    WriteLiteral("Please select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1330, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(1430, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1462, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b344a9c52f523973c9d601a7c35f4b40e9498e649786", async() => {
                    BeginContext(1494, 13, false);
#line 46 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                          Write(option.option);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                   WriteLiteral(option.option);

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
                BeginContext(1516, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(1549, 85, true);
                WriteLiteral("                        </select>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 51 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.OPEN_QUESTION)
            {

#line default
#line hidden
                BeginContext(1730, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1803, 43, false);
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(1846, 40, true);
                WriteLiteral(" <br>\r\n                        <textarea");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1886, "\"", 1921, 3);
                WriteAttributeValue("", 1893, "Answer-", 1893, 7, true);
#line 57 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1900, item.id, 1900, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1908, "-openquestion", 1908, 13, true);
                EndWriteAttribute();
                BeginContext(1922, 76, true);
                WriteLiteral(" type=\"text\"></textarea>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 60 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.RADIO_BUTTON)
            {

#line default
#line hidden
                BeginContext(2093, 81, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2174, "\"", 2187, 1);
#line 65 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2179, item.id, 2179, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2188, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(2220, 43, false);
#line 66 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(2263, 7, true);
                WriteLiteral(" <br>\r\n");
                EndContext();
#line 67 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(2368, 51, true);
                WriteLiteral("                                <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2419, "\"", 2441, 1);
#line 69 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2427, option.option, 2427, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2442, "\"", 2476, 3);
                WriteAttributeValue("", 2449, "Answer-", 2449, 7, true);
#line 69 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2456, item.id, 2456, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2464, "-radiobutton", 2464, 12, true);
                EndWriteAttribute();
                BeginContext(2477, 4, true);
                WriteLiteral("/>\r\n");
                EndContext();
                BeginContext(2514, 43, false);
#line 70 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
                EndContext();
                BeginContext(2557, 6, true);
                WriteLiteral("<br>\r\n");
                EndContext();
#line 71 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(2594, 87, true);
                WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 75 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.CHECK_BOX)
            {

#line default
#line hidden
                BeginContext(2773, 81, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2854, "\"", 2867, 1);
#line 80 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2859, item.id, 2859, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2868, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(2900, 43, false);
#line 81 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(2943, 7, true);
                WriteLiteral(" <br>\r\n");
                EndContext();
#line 82 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(3048, 54, true);
                WriteLiteral("                                <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3102, "\"", 3124, 1);
#line 84 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3110, option.option, 3110, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3125, "\"", 3156, 3);
                WriteAttributeValue("", 3132, "Answer-", 3132, 7, true);
#line 84 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3139, item.id, 3139, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 3147, "-checkbox", 3147, 9, true);
                EndWriteAttribute();
                BeginContext(3157, 4, true);
                WriteLiteral("/>\r\n");
                EndContext();
                BeginContext(3194, 43, false);
#line 85 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
                EndContext();
                BeginContext(3237, 6, true);
                WriteLiteral("<br>\r\n");
                EndContext();
#line 86 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(3274, 87, true);
                WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 90 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            

        }

#line default
#line hidden
                BeginContext(3403, 81, true);
                WriteLiteral("    \r\n    </table>\r\n            \r\n    <input type=\"hidden\" name=\"questionnaireId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3484, "\"", 3515, 1);
#line 97 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3492, Model.questionnaire.id, 3492, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3516, 354, true);
                WriteLiteral(@"/>
    <div class=""form-group"">
        <input type=""submit"" value=""Submit answers"" class=""btn btn-default btn-success""/>
    </div>
    
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                       </div>
");
                EndContext();
#line 108 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"

            

    }

#line default
#line hidden
                BeginContext(3895, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FillInQuestionnaireModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
