#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d57d3ec1fcf9c552227a270e7faf417dc7295856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faq), @"mvc.1.0.view", @"/Views/Home/Faq.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Faq.cshtml", typeof(AspNetCore.Views_Home_Faq))]
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Faq.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Faq.cshtml"
using DAL.EF;

#line default
#line hidden
#line 3 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Faq.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d57d3ec1fcf9c552227a270e7faf417dc7295856", @"/Views/Home/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Domain.Faq>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/handleFaq.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Home\Faq.cshtml"
  
    var user = await UserManager.GetUserAsync(User);

#line default
#line hidden
            BeginContext(231, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(318, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d57d3ec1fcf9c552227a270e7faf417dc72958564961", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(382, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(386, 4450, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d57d3ec1fcf9c552227a270e7faf417dc72958566227", async() => {
                BeginContext(392, 4437, true);
                WriteLiteral(@"
<div class=""container"">
<h1 class=""text-center"">Frequently asked questions</h1>
<!-- ACCORDION -->
<div class=""py-5"" id=""accordion"">
    <div class=""card"">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse1"" data-toggle=""collapse"" data-parent=""#accordion"">
                   <h4> <i class=""fas fa-arrow-circle-down lg""></i> <b>How do i create an account?</b></h4>
                </div>
            </h5>
        </div>

        <div id=""collapse1"" class=""collapse"">
            <div class=""card-body"">
                By going to the register page and filling in your personal information!                      
            </div>
        </div>
    </div>

    <div class=""card"">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse2"" data-toggle=""collapse"" data-parent=""#accordion"">
                    <h4> <i class=""fas fa-arrow-circle-down lg""></i> <b>Is there an app available in the App Sto");
                WriteLiteral(@"re?</b></h4>
                </div>
            </h5>
        </div>

        <div id=""collapse2"" class=""collapse"">
            <div class=""card-body"">
                We're only available on the Android play store for now, but stay tuned!
            </div>
        </div>
    </div>

    <div class=""card"">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse3"" data-toggle=""collapse"" data-parent=""#accordion"">
                                   <h4> <i class=""fas fa-arrow-circle-down lg""></i> <b>Do i have to create an account?</b></h4>
                    </div>
            </h5>
        </div>
        <div id=""collapse3"" class=""collapse"">
            <div class=""card-body"">
                You don't have to create an account on this website to be able to use our services. 
                To make it easier for the users we added external logins like Facebook and Google!
            </div>
        </div>
    </div>
    <div class=""card""");
                WriteLiteral(@">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse4"" data-toggle=""collapse"" data-parent=""#accordion"">
                        
                    <h4> <i class=""fas fa-arrow-circle-down lg""></i> <b>How can i recover my lost account?</b></h4>
                </div>
            </h5>
        </div>
        <div id=""collapse4"" class=""collapse"">
            <div class=""card-body"">
                You can easily go to the Login page and request a password reset.
            </div>
        </div>
    </div>
    
    <div class=""card"">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse5"" data-toggle=""collapse"" data-parent=""#accordion"">
                            
                    <h4> <i class=""fas fa-arrow-circle-down lg""></i> <b>What can i do with the search option in the navigation bar?</b></h4>
                </div>
            </h5>
        </div>
        <div id=""collapse5"" class");
                WriteLiteral(@"=""collapse"">
            <div class=""card-body"">
                The search option allows you to search for projects.
            </div>
        </div>
    </div>
    
    <div class=""card"">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse6"" data-toggle=""collapse"" data-parent=""#accordion"">
                            
                    <h4> <i class=""fas fa-arrow-circle-down lg""></i> <b>What is a Questionnaire?</b></h4>
                </div>
            </h5>
        </div>
        <div id=""collapse6"" class=""collapse"">
            <div class=""card-body"">
                A series of questions to help us make decisions.
            </div>
        </div>
    </div>
    
    <div class=""card"">
        <div class=""card-header"">
            <h5 class=""mb-0"">
                <div href=""#collapse7"" data-toggle=""collapse"" data-parent=""#accordion"">
                            
                    <h4> <i class=""fas fa-arrow-circle-down l");
                WriteLiteral(@"g""></i> <b>Can i report people?</b></h4>
                </div>
            </h5>
        </div>
        <div id=""collapse7"" class=""collapse"">
            <div class=""card-body"">
                Yes of course, if you see offensive statements please report them.
            </div>
        </div>
    </div>
</div>
        </div>
");
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
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Domain.Faq>> Html { get; private set; }
    }
}
#pragma warning restore 1591
