#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3809c7837e3759010b3e1fb15faaff93fccb59"
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
#line 1 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using System.Collections.Immutable;

#line default
#line hidden
#line 3 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using System.Xml.Linq;

#line default
#line hidden
#line 4 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using D.UI.MVC.Models.Ideas;

#line default
#line hidden
#line 5 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using Domain;

#line default
#line hidden
#line 6 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3809c7837e3759010b3e1fb15faaff93fccb59", @"/Views/Idea/CreateIdeaPage.cshtml")]
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
            BeginContext(188, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 7275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3809c7837e3759010b3e1fb15faaff93fccb596481", async() => {
                BeginContext(196, 35, true);
                WriteLiteral("\r\n<div class=\"container\">\r\n    \r\n\r\n");
                EndContext();
#line 13 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
 foreach (var item in Model.ideationQuestion)
{

#line default
#line hidden
                BeginContext(281, 34, true);
                WriteLiteral("    <b><u><h1 class=\"text-center\">");
                EndContext();
                BeginContext(316, 4, false);
#line 15 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                             Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(320, 15, true);
                WriteLiteral("</h1></u></b>\r\n");
                EndContext();
#line 16 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
}

#line default
#line hidden
                BeginContext(338, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
                BeginContext(346, 7100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3809c7837e3759010b3e1fb15faaff93fccb597879", async() => {
                    BeginContext(456, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(462, 69, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e3809c7837e3759010b3e1fb15faaff93fccb598284", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ideationId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#line 22 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
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
                    BeginContext(531, 12, true);
                    WriteLiteral("\r\n    \r\n  \r\n");
                    EndContext();
#line 25 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
    if (@Model.TextFieldVms.Count != 0)
   {

#line default
#line hidden
                    BeginContext(590, 60, true);
                    WriteLiteral("       <h3>Upload Text</h3>\r\n       <div id=\"TextUploads\">\r\n");
                    EndContext();
#line 29 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
            for (int i = 0; i < @Model.TextFieldVms.Count; i++)
           {

               

#line default
#line hidden
                    BeginContext(747, 55, false);
#line 32 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
          Write(Html.EditorFor(x => x.TextFieldVms[i], new {index = i}));

#line default
#line hidden
                    EndContext();
#line 32 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                       
           }

#line default
#line hidden
                    BeginContext(818, 15, true);
                    WriteLiteral("       </div>\r\n");
                    EndContext();
#line 35 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
   }

#line default
#line hidden
                    BeginContext(839, 6, true);
                    WriteLiteral("    \r\n");
                    EndContext();
#line 37 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.ImageFieldVms.Count != 0){

#line default
#line hidden
                    BeginContext(889, 78, true);
                    WriteLiteral("        <h3>Upload Images</h3>\r\n        <div id=\"ImageUploads\" class=\"py-3\">\r\n");
                    EndContext();
#line 40 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.ImageFieldVms.Count; i++)
            {
                

#line default
#line hidden
                    BeginContext(1066, 59, false);
#line 42 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
           Write(Html.EditorFor(x => x.ImageFieldVms[i] , new { index = i} ));

#line default
#line hidden
                    EndContext();
#line 42 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                                
     
            }

#line default
#line hidden
                    BeginContext(1153, 29, true);
                    WriteLiteral("         \r\n\r\n        </div>\r\n");
                    EndContext();
#line 48 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
    }

#line default
#line hidden
                    BeginContext(1189, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 50 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.VideoFieldVms.Count != 0)
    {

#line default
#line hidden
                    BeginContext(1241, 77, true);
                    WriteLiteral("        <h3>Upload Videos</h3>\r\n        <div id=\"VideoUploads\"class=\"py-2\">\r\n");
                    EndContext();
#line 54 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.VideoFieldVms.Count; i++)
            {
                

#line default
#line hidden
                    BeginContext(1417, 59, false);
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
           Write(Html.EditorFor(x => x.VideoFieldVms[i] , new { index = i} ));

#line default
#line hidden
                    EndContext();
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                                
     
            }

#line default
#line hidden
                    BeginContext(1504, 19, true);
                    WriteLiteral("        </div>   \r\n");
                    EndContext();
#line 60 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"

    }

#line default
#line hidden
                    BeginContext(1532, 4, true);
                    WriteLiteral("    ");
                    EndContext();
#line 62 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.MapFieldVms.Count != 0)
    {

#line default
#line hidden
                    BeginContext(1580, 79, true);
                    WriteLiteral("        <h3 class=\"py-2\">Upload Locations</h3>\r\n        <div id=\"MapUploads\">\r\n");
                    EndContext();
#line 66 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.MapFieldVms.Count; i++)
            {
            

#line default
#line hidden
                    BeginContext(1752, 57, false);
#line 68 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
       Write(Html.EditorFor(x => x.MapFieldVms[i] , new { index = i} ));

#line default
#line hidden
                    EndContext();
#line 68 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                          
                
            }

#line default
#line hidden
                    BeginContext(1848, 19, true);
                    WriteLiteral("        </div>   \r\n");
                    EndContext();
#line 72 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"

    }

#line default
#line hidden
                    BeginContext(1876, 12, true);
                    WriteLiteral("    \r\n    \r\n");
                    EndContext();
#line 76 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
     if (@Model.QuestionFieldVms.Count != 0)
    {

#line default
#line hidden
                    BeginContext(1941, 268, true);
                    WriteLiteral(@"        <h2>Upload Questions</h2>
        <div class=""row"">
<div class=""dark-overlay"">
<div class=""container"">
<div class=""d-flex"" >
        <div class=""card bg-light text-center card-form"">
<div class=""card-body"" id=""card"">
        <div id=""QuestionUploads"">
");
                    EndContext();
#line 86 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
             for (int i = 0; i < @Model.QuestionFieldVms.Count; i++)
            {
                

#line default
#line hidden
                    BeginContext(2311, 65, false);
#line 88 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
           Write(Html.EditorFor(x => x.QuestionFieldVms[i] , new { index = i +1} ));

#line default
#line hidden
                    EndContext();
#line 88 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
                                                                                      
                    
            }

#line default
#line hidden
                    BeginContext(2419, 203, true);
                    WriteLiteral("            <div class=\"py-3\">\r\n                <input type=\"submit\" class=\"btn btn-success\" value=\"save\" onclick=\"disable()\" >   \r\n</div>\r\n</div> \r\n</div> \r\n</div> \r\n</div> \r\n</div> \r\n</div> \r\n</div> \r\n");
                    EndContext();
#line 101 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\CreateIdeaPage.cshtml"
        
}
   
   
    
    

#line default
#line hidden
                    BeginContext(5958, 1168, true);
                    WriteLiteral(@"     

   
  


                                       
    
        
     
   
    
    <script>
        function disable(parameters) {
            var images = document.getElementsByClassName(""ImageUpload"");
            var videos = document.getElementsByClassName(""VideoUpload"");

            

            for (var i = 0; i < videos.length; i++) {
                if(videos[i].files.length == 0)
                {
                    $(videos[i]).attr('disabled', true);

                }
            }
            
            for (var i = 0; i < images.length; i++) {
                if(images[i].files.length == 0)
                {
                    $(images[i]).attr('disabled', true);

                }
            }
            
          
        }

        function LastCheck(parameters) {
            
        }
        
        $(document).ready(function() {
            $(window).keydown(function(event){
                if(event.keyCode == 13) {
            ");
                    WriteLiteral("        event.preventDefault();\r\n                    return false;\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n    \r\n    \r\n");
                    EndContext();
                    BeginContext(7422, 17, true);
                    WriteLiteral("         \r\n    \r\n");
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
                BeginContext(7446, 12, true);
                WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Ideas.IdeaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
