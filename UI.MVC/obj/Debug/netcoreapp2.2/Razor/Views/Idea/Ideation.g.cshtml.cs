#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e03580bec75c329e96c1fe6b3879e36a2254aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_Ideation), @"mvc.1.0.view", @"/Views/Idea/Ideation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/Ideation.cshtml", typeof(AspNetCore.Views_Idea_Ideation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e03580bec75c329e96c1fe6b3879e36a2254aa", @"/Views/Idea/Ideation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_Ideation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UI.MVC.Models.Ideations.IdeationPageVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 9, true);
            WriteLiteral("\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 56, "\"", 114, 1);
#line 3 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
WriteAttributeValue("", 62, Url.Content("~/Scripts/jquery.unobtrusive-ajax.js"), 62, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(115, 39, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n\r\n");
            EndContext();
            BeginContext(155, 100, false);
#line 6 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
    , new { ideationId=@Model.IdeationId }));

#line default
#line hidden
            EndContext();
            BeginContext(255, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
 foreach (var item in @Model.IdeationQuestions)
{

#line default
#line hidden
            BeginContext(309, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(318, 4, false);
#line 10 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
   Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(322, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 11 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
}

#line default
#line hidden
            BeginContext(852, 37, true);
            WriteLiteral("\r\n<div id=\"rowPictures\"class=\"row\">\r\n");
            EndContext();
#line 37 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
 foreach (var item in @Model.IdeaListItemVms)
{

    {

#line default
#line hidden
            BeginContext(948, 106, true);
            WriteLiteral("        <div class=\"column text-center text-black openProjects\" data-target=\"#MyModal\" data-toggle=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1054, "\"", 1086, 3);
            WriteAttributeValue("", 1064, "OpenIdea(", 1064, 9, true);
#line 41 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
WriteAttributeValue("", 1073, item.IdeaId, 1073, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1085, ")", 1085, 1, true);
            EndWriteAttribute();
            BeginContext(1087, 167, true);
            WriteLiteral(">\r\n                                                                                             \r\n            <h4 id=\"titleindex\" class=\"text-black\">\r\n                ");
            EndContext();
            BeginContext(1255, 13, false);
#line 44 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
           Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(1289, 107, false);
#line 46 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
           Write(Html.ActionLink(@item.IdeaTitle, "ProjectDetailPage", "Project"
                    , new {projectId = 1}));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 37, true);
            WriteLiteral("\r\n            </h4>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1433, "\"", 1456, 1);
#line 49 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
WriteAttributeValue("", 1439, item.Base64Image, 1439, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1457, 100, true);
            WriteLiteral(" width=\"365\" height=\"200\"/>\r\n           \r\n            <div>\r\n                <p class=\"text-dark\">\r\n");
            EndContext();
            BeginContext(1679, 49, true);
            WriteLiteral("                    <i class=\"far fa-heart\"></i> ");
            EndContext();
            BeginContext(1729, 14, false);
#line 56 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
                                            Write(item.LikeCount);

#line default
#line hidden
            EndContext();
            BeginContext(1743, 54, true);
            WriteLiteral("\r\n                    <i class=\"far fa-comments\"></i> ");
            EndContext();
            BeginContext(1798, 18, false);
#line 57 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
                                               Write(item.ReactionCount);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 60, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 61 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Idea\Ideation.cshtml"
    }

}  

#line default
#line hidden
            BeginContext(1890, 33, true);
            WriteLiteral("</div>\r\n<div class=\"container\">\r\n");
            EndContext();
            BeginContext(2063, 390, true);
            WriteLiteral(@"    <div class=""modal"" id=""MyModal"" role=""dialog"">
        <div id=""content"" class=""modal-dialog modal-lg"">
       
        
        </div>
       
    
    </div>
</div> 
<script>
    $(document).ready(function(input) {
    });

    function OpenIdea(input) {
        console.log(""test2"");
        $(""#content"").load(""/Idea/Idea"",{ideaId : input});

    }
    
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UI.MVC.Models.Ideations.IdeationPageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
