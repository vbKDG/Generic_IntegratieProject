#pragma checksum "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42b1e6c10fb0ddb0db3961139e6995470ca8e73e"
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
#line 1 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b1e6c10fb0ddb0db3961139e6995470ca8e73e", @"/Views/Questionnaire/Questionnaire.cshtml")]
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
            BeginContext(48, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(49, 3854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b1e6c10fb0ddb0db3961139e6995470ca8e73e3960", async() => {
                BeginContext(55, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 5 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
 using (Html.BeginForm("CreateUserQuestion", "Questionnaire",
    FormMethod.Post))
{
    
    
   

#line default
#line hidden
                BeginContext(165, 200, true);
                WriteLiteral("    <div class=\"row center-block\">\r\n        \r\n    <div class=\"dark-overlay\">\r\n    <div class=\"container\">\r\n\r\n    <div class=\"col-lg-4\">\r\n    <div class=\"card bg-light text-center card-form\">\r\n    <h1>");
                EndContext();
                BeginContext(366, 24, false);
#line 18 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
   Write(Model.questionnaire.name);

#line default
#line hidden
                EndContext();
                BeginContext(390, 91, true);
                WriteLiteral("</h1>\r\n    <h4>Questionnaire</h4>\r\n    <div class=\"card-body\">\r\n    <table class=\"table\">\r\n");
                EndContext();
#line 22 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
         foreach (var item in Model.questions)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (item.questionType == QuestionType.MAILADDRESS)
                {

#line default
#line hidden
                BeginContext(691, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(776, 43, false);
#line 30 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(819, 127, true);
                WriteLiteral(" <br>\r\n                            <input name=\"email\" type=\"text\">\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 34 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                }
            }
            if (item.questionType == QuestionType.DROPDOWN)
            {

#line default
#line hidden
                BeginContext(1056, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1129, 43, false);
#line 40 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(1172, 54, true);
                WriteLiteral(" <br>\r\n                        <select id=\"ddlOptions\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1226, "\"", 1257, 3);
                WriteAttributeValue("", 1233, "Answer-", 1233, 7, true);
#line 41 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1240, item.id, 1240, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1248, "-dropdown", 1248, 9, true);
                EndWriteAttribute();
                BeginContext(1258, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(1289, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b1e6c10fb0ddb0db3961139e6995470ca8e73e8137", async() => {
                    BeginContext(1307, 13, true);
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
                BeginContext(1329, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 43 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(1429, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1461, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42b1e6c10fb0ddb0db3961139e6995470ca8e73e10011", async() => {
                    BeginContext(1493, 13, false);
#line 45 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                          Write(option.option);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 45 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
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
                BeginContext(1515, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(1548, 85, true);
                WriteLiteral("                        </select>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 50 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.OPEN_QUESTION)
            {

#line default
#line hidden
                BeginContext(1729, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1802, 43, false);
#line 55 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(1845, 40, true);
                WriteLiteral(" <br>\r\n                        <textarea");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1885, "\"", 1920, 3);
                WriteAttributeValue("", 1892, "Answer-", 1892, 7, true);
#line 56 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1899, item.id, 1899, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1907, "-openquestion", 1907, 13, true);
                EndWriteAttribute();
                BeginContext(1921, 76, true);
                WriteLiteral(" type=\"text\"></textarea>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 59 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.RADIO_BUTTON)
            {

#line default
#line hidden
                BeginContext(2092, 81, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2173, "\"", 2186, 1);
#line 64 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2178, item.id, 2178, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2187, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(2219, 43, false);
#line 65 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(2262, 7, true);
                WriteLiteral(" <br>\r\n");
                EndContext();
#line 66 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(2367, 51, true);
                WriteLiteral("                                <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2418, "\"", 2440, 1);
#line 68 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2426, option.option, 2426, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2441, "\"", 2475, 3);
                WriteAttributeValue("", 2448, "Answer-", 2448, 7, true);
#line 68 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2455, item.id, 2455, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2463, "-radiobutton", 2463, 12, true);
                EndWriteAttribute();
                BeginContext(2476, 4, true);
                WriteLiteral("/>\r\n");
                EndContext();
                BeginContext(2513, 43, false);
#line 69 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
                EndContext();
                BeginContext(2556, 6, true);
                WriteLiteral("<br>\r\n");
                EndContext();
#line 70 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(2593, 87, true);
                WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 74 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.CHECK_BOX)
            {

#line default
#line hidden
                BeginContext(2772, 81, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2853, "\"", 2866, 1);
#line 79 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2858, item.id, 2858, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2867, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(2899, 43, false);
#line 80 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
                EndContext();
                BeginContext(2942, 7, true);
                WriteLiteral(" <br>\r\n");
                EndContext();
#line 81 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(3047, 54, true);
                WriteLiteral("                                <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3101, "\"", 3123, 1);
#line 83 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3109, option.option, 3109, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3124, "\"", 3155, 3);
                WriteAttributeValue("", 3131, "Answer-", 3131, 7, true);
#line 83 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3138, item.id, 3138, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 3146, "-checkbox", 3146, 9, true);
                EndWriteAttribute();
                BeginContext(3156, 4, true);
                WriteLiteral("/>\r\n");
                EndContext();
                BeginContext(3193, 43, false);
#line 84 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
                EndContext();
                BeginContext(3236, 6, true);
                WriteLiteral("<br>\r\n");
                EndContext();
#line 85 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(3273, 87, true);
                WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 89 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            

        }

#line default
#line hidden
                BeginContext(3402, 81, true);
                WriteLiteral("    \r\n    </table>\r\n            \r\n    <input type=\"hidden\" name=\"questionnaireId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3483, "\"", 3514, 1);
#line 96 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3491, Model.questionnaire.id, 3491, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3515, 354, true);
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
#line 107 "C:\Users\sefik\OneDrive\Documenten\GitHub\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"

            

    }

#line default
#line hidden
                BeginContext(3894, 2, true);
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
