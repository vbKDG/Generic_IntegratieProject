#pragma checksum "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f760302614bf71ddaaa9a1530454888480a44ac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Ideations), @"mvc.1.0.view", @"/Views/Project/Ideations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Ideations.cshtml", typeof(AspNetCore.Views_Project_Ideations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f760302614bf71ddaaa9a1530454888480a44ac1", @"/Views/Project/Ideations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Ideations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Project>
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
            BeginContext(23, 1004, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f760302614bf71ddaaa9a1530454888480a44ac13242", async() => {
                BeginContext(29, 60, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n    \r\n\r\n<h2 class=\"text-center\"> ");
                EndContext();
                BeginContext(90, 10, false);
#line 6 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                    Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(100, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 7 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
     if (User.IsInRole("Admin") || User.IsInRole("SuperAdmin"))
    {
        

#line default
#line hidden
                BeginContext(188, 102, false);
#line 9 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
   Write(Html.ActionLink("Create Ideation", "CreateIdeationPage", "Project" , new {projectId=@Model.ProjectId}));

#line default
#line hidden
                EndContext();
#line 9 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                                                                                                               
    }

#line default
#line hidden
                BeginContext(299, 101, true);
                WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            Centrale vraag\r\n        </th>\r\n    </tr>\r\n");
                EndContext();
#line 17 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
     foreach (var item in Model.Ideations)
    {

#line default
#line hidden
                BeginContext(451, 32, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n");
                EndContext();
#line 21 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                 if (item.Questions.Count > 0)
                {
                    

#line default
#line hidden
                BeginContext(571, 35, false);
#line 23 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
               Write(item.Questions.ToList()[0].Question);

#line default
#line hidden
                EndContext();
#line 23 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
                                                        
                }

#line default
#line hidden
                BeginContext(627, 53, true);
                WriteLiteral("            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(681, 114, false);
#line 27 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
           Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
                    , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(795, 57, true);
                WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(853, 104, false);
#line 32 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
           Write(Html.ActionLink("Show ideas", "Ideas", "Idea"
                    , new {ideationId = item.IdeationId}));

#line default
#line hidden
                EndContext();
                BeginContext(957, 38, true);
                WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
                EndContext();
#line 37 "C:\Users\Lukas\Desktop\Cursussen 2018-2019\Integratieproject\Generic_IntegratieProject\UI.MVC\Views\Project\Ideations.cshtml"
    }

#line default
#line hidden
                BeginContext(1002, 18, true);
                WriteLiteral("</table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
