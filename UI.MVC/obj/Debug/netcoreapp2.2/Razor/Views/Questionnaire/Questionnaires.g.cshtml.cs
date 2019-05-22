#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa9424f7adb1a86824aa88e72cd3469f48199c05"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa9424f7adb1a86824aa88e72cd3469f48199c05", @"/Views/Questionnaire/Questionnaires.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaires : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Questionnaire>>
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
            BeginContext(42, 1679, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa9424f7adb1a86824aa88e72cd3469f48199c053224", async() => {
                BeginContext(48, 72, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n<h1 class=\"text-center\">Questionnaires</h1>\r\n");
                EndContext();
#line 5 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
 if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
{
    

#line default
#line hidden
                BeginContext(190, 39, true);
                WriteLiteral("    <div class=\"text-center\">\r\n        ");
                EndContext();
                BeginContext(230, 157, false);
#line 9 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
   Write(Html.ActionLink("Create a new questionnaire", "CreateQuestionnairePage",
            "Questionnaire", new {projectId = Model.ToList()[0].project.projectId}));

#line default
#line hidden
                EndContext();
                BeginContext(387, 15, true);
                WriteLiteral("\r\n    </div> \r\n");
                EndContext();
#line 12 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
}

#line default
#line hidden
                BeginContext(405, 169, true);
                WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>name</p>\r\n        </th>\r\n        <th>\r\n            <p>Amount of questions</p>\r\n        </th>\r\n    </tr>\r\n");
                EndContext();
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
     foreach (var item in Model)
    {    

#line default
#line hidden
                BeginContext(619, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(668, 39, false);
#line 27 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
                EndContext();
                BeginContext(707, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(763, 49, false);
#line 30 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.DisplayFor(modelItem => item.questionAmount));

#line default
#line hidden
                EndContext();
                BeginContext(812, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(868, 130, false);
#line 33 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
           Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                    , new { questionnaireId=item.id }));

#line default
#line hidden
                EndContext();
                BeginContext(998, 21, true);
                WriteLiteral("\r\n            </td>\r\n");
                EndContext();
#line 36 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
             if (User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
            {

#line default
#line hidden
                BeginContext(1107, 42, true);
                WriteLiteral("                <td>\r\n                    ");
                EndContext();
                BeginContext(1150, 128, false);
#line 39 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Show results", "ShowResultsPage", "Questionnaire"
                        , new { questionnaireId = item.id }));

#line default
#line hidden
                EndContext();
                BeginContext(1278, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1346, 124, false);
#line 43 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Edit", "EditQuestionnairePage", "Questionnaire"
                        , new {questionnaireId = item.id}));

#line default
#line hidden
                EndContext();
                BeginContext(1470, 25, true);
                WriteLiteral(" | \r\n                    ");
                EndContext();
                BeginContext(1496, 128, false);
#line 45 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Delete", "DeleteQuestionnairePage", "Questionnaire"
                        , new {questionnaireId = item.id}));

#line default
#line hidden
                EndContext();
                BeginContext(1624, 25, true);
                WriteLiteral("\r\n                </td>\r\n");
                EndContext();
#line 48 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
            }

#line default
#line hidden
                BeginContext(1664, 15, true);
                WriteLiteral("        </tr>\r\n");
                EndContext();
#line 50 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
        
    }

#line default
#line hidden
                BeginContext(1696, 18, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Questionnaire>> Html { get; private set; }
    }
}
#pragma warning restore 1591
