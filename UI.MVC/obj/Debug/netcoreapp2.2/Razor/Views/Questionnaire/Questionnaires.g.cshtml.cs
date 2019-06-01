#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b573f145ba35105a9a9d55584a24910b24893a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_Questionnaires), @"mvc.1.0.view", @"/Views/Questionnaire/Questionnaires.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/Questionnaires.cshtml", typeof(AspNetCore.Views_Questionnaire_Questionnaires))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b573f145ba35105a9a9d55584a24910b24893a", @"/Views/Questionnaire/Questionnaires.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaires : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectAndQuestionnaires>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b573f145ba35105a9a9d55584a24910b24893a3215", async() => {
                BeginContext(39, 72, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n<h1 class=\"text-center\">Questionnaires</h1>\r\n");
                EndContext();
#line 5 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
 if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
{
    if (Model != null)
    {

#line default
#line hidden
                BeginContext(206, 47, true);
                WriteLiteral("        <div class=\"text-center\">\r\n            ");
                EndContext();
                BeginContext(254, 149, false);
#line 10 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
       Write(Html.ActionLink("Create a new questionnaire", "CreateQuestionnairePage",
                "Questionnaire", new {projectId = Model.Project.ProjectId}));

#line default
#line hidden
                EndContext();
                BeginContext(403, 19, true);
                WriteLiteral("\r\n        </div> \r\n");
                EndContext();
#line 13 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
    }
}

#line default
#line hidden
                BeginContext(432, 169, true);
                WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>name</p>\r\n        </th>\r\n        <th>\r\n            <p>Amount of questions</p>\r\n        </th>\r\n    </tr>\r\n");
                EndContext();
#line 25 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
     foreach (var item in Model.Questionnaires)
    {    

#line default
#line hidden
                BeginContext(661, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(710, 39, false);
#line 29 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(749, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(805, 49, false);
#line 32 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuestionAmount));

#line default
#line hidden
                EndContext();
                BeginContext(854, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(910, 143, false);
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                    , new { questionnaireId=item.QuestionnaireId }));

#line default
#line hidden
                EndContext();
                BeginContext(1053, 21, true);
                WriteLiteral("\r\n            </td>\r\n");
                EndContext();
#line 38 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
             if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
            {

#line default
#line hidden
                BeginContext(1162, 42, true);
                WriteLiteral("                <td>\r\n                    ");
                EndContext();
                BeginContext(1205, 141, false);
#line 41 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Show results", "ShowResultsPage", "Questionnaire"
                        , new { questionnaireId = item.QuestionnaireId }));

#line default
#line hidden
                EndContext();
                BeginContext(1346, 25, true);
                WriteLiteral("\r\n                </td>\r\n");
                EndContext();
#line 44 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
                if (item.Closed)
                {

#line default
#line hidden
                BeginContext(1424, 50, true);
                WriteLiteral("                    <td>\r\n                        ");
                EndContext();
                BeginContext(1475, 137, false);
#line 47 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
                   Write(Html.ActionLink("Open", "OpenQuestionnaire", "Questionnaire"
                            , new {questionnaireId = item.QuestionnaireId}));

#line default
#line hidden
                EndContext();
                BeginContext(1612, 29, true);
                WriteLiteral("\r\n                    </td>\r\n");
                EndContext();
#line 50 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1701, 50, true);
                WriteLiteral("                    <td>\r\n                        ");
                EndContext();
                BeginContext(1752, 139, false);
#line 54 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
                   Write(Html.ActionLink("Close", "CloseQuestionnaire", "Questionnaire"
                            , new {questionnaireId = item.QuestionnaireId}));

#line default
#line hidden
                EndContext();
                BeginContext(1891, 29, true);
                WriteLiteral("\r\n                    </td>\r\n");
                EndContext();
#line 57 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
                }

#line default
#line hidden
                BeginContext(1939, 42, true);
                WriteLiteral("                <td>\r\n                    ");
                EndContext();
                BeginContext(1982, 137, false);
#line 59 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Edit", "EditQuestionnairePage", "Questionnaire"
                        , new {questionnaireId = item.QuestionnaireId}));

#line default
#line hidden
                EndContext();
                BeginContext(2119, 25, true);
                WriteLiteral(" | \r\n                    ");
                EndContext();
                BeginContext(2145, 141, false);
#line 61 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Delete", "DeleteQuestionnairePage", "Questionnaire"
                        , new {questionnaireId = item.QuestionnaireId}));

#line default
#line hidden
                EndContext();
                BeginContext(2286, 25, true);
                WriteLiteral("\r\n                </td>\r\n");
                EndContext();
#line 64 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
            }

#line default
#line hidden
                BeginContext(2326, 15, true);
                WriteLiteral("        </tr>\r\n");
                EndContext();
#line 66 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
        
    }

#line default
#line hidden
                BeginContext(2358, 18, true);
                WriteLiteral("</table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectAndQuestionnaires> Html { get; private set; }
    }
}
#pragma warning restore 1591
