#pragma checksum "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45fadac066c4b8c3d1e8f1ffecf6606badf3720"
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
#line 1 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c45fadac066c4b8c3d1e8f1ffecf6606badf3720", @"/Views/Questionnaire/Questionnaire.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 69, true);
            WriteLiteral("\r\n<h1>Complete a questionnaire</h1>\r\n<h4>The questionnaire is about: ");
            EndContext();
            BeginContext(118, 24, false);
#line 5 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Model.questionnaire.name);

#line default
#line hidden
            EndContext();
            BeginContext(142, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 6 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
 using (Html.BeginForm("CreateUserQuestion", "Questionnaire",
    FormMethod.Post))
{

#line default
#line hidden
            BeginContext(238, 27, true);
            WriteLiteral("    <table class=\"table\">\r\n");
            EndContext();
#line 10 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
         foreach (var item in Model.questions)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (item.questionType == QuestionType.MAILADDRESS)
                {

#line default
#line hidden
            BeginContext(475, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(560, 43, false);
#line 18 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(603, 127, true);
            WriteLiteral(" <br>\r\n                            <input name=\"email\" type=\"text\">\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 22 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                }
            }
            if (item.questionType == QuestionType.DROPDOWN)
            {

#line default
#line hidden
            BeginContext(840, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(913, 43, false);
#line 28 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(956, 54, true);
            WriteLiteral(" <br>\r\n                        <select id=\"ddlOptions\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1010, "\"", 1041, 3);
            WriteAttributeValue("", 1017, "Answer-", 1017, 7, true);
#line 29 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1024, item.id, 1024, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1032, "-dropdown", 1032, 9, true);
            EndWriteAttribute();
            BeginContext(1042, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1073, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45fadac066c4b8c3d1e8f1ffecf6606badf37207484", async() => {
                BeginContext(1091, 13, true);
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
            BeginContext(1113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(1213, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1245, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45fadac066c4b8c3d1e8f1ffecf6606badf37209277", async() => {
                BeginContext(1277, 13, false);
#line 33 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                          Write(option.option);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
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
            BeginContext(1299, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(1332, 85, true);
            WriteLiteral("                        </select>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.OPEN_QUESTION)
            {

#line default
#line hidden
            BeginContext(1513, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1586, 43, false);
#line 43 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 40, true);
            WriteLiteral(" <br>\r\n                        <textarea");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1669, "\"", 1704, 3);
            WriteAttributeValue("", 1676, "Answer-", 1676, 7, true);
#line 44 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1683, item.id, 1683, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1691, "-openquestion", 1691, 13, true);
            EndWriteAttribute();
            BeginContext(1705, 76, true);
            WriteLiteral(" type=\"text\"></textarea>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.RADIO_BUTTON)
            {

#line default
#line hidden
            BeginContext(1876, 81, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1957, "\"", 1970, 1);
#line 52 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1962, item.id, 1962, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1971, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(2003, 43, false);
#line 53 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 7, true);
            WriteLiteral(" <br>\r\n");
            EndContext();
#line 54 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(2151, 51, true);
            WriteLiteral("                                <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2202, "\"", 2224, 1);
#line 56 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2210, option.option, 2210, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2225, "\"", 2259, 3);
            WriteAttributeValue("", 2232, "Answer-", 2232, 7, true);
#line 56 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2239, item.id, 2239, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2247, "-radiobutton", 2247, 12, true);
            EndWriteAttribute();
            BeginContext(2260, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
            BeginContext(2297, 43, false);
#line 57 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 58 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(2377, 87, true);
            WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 62 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.CHECK_BOX)
            {

#line default
#line hidden
            BeginContext(2556, 81, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2637, "\"", 2650, 1);
#line 67 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2642, item.id, 2642, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2651, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(2683, 43, false);
#line 68 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 7, true);
            WriteLiteral(" <br>\r\n");
            EndContext();
#line 69 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(2831, 54, true);
            WriteLiteral("                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2885, "\"", 2907, 1);
#line 71 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2893, option.option, 2893, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2908, "\"", 2939, 3);
            WriteAttributeValue("", 2915, "Answer-", 2915, 7, true);
#line 71 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2922, item.id, 2922, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2930, "-checkbox", 2930, 9, true);
            EndWriteAttribute();
            BeginContext(2940, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
            BeginContext(2977, 43, false);
#line 72 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
            EndContext();
            BeginContext(3020, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 73 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(3057, 87, true);
            WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 77 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3170, 61, true);
            WriteLiteral("    </table>\r\n    <input type=\"hidden\" name=\"questionnaireId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3231, "\"", 3262, 1);
#line 80 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 3239, Model.questionnaire.id, 3239, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3263, 125, true);
            WriteLiteral("/>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Submit answers\" class=\"btn btn-default\"/>\r\n    </div>\r\n");
            EndContext();
#line 84 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
}

#line default
#line hidden
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
