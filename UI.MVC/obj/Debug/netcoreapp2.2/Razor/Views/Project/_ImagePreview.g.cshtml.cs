#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\_ImagePreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae066e7d3267e30aab9e1495f04cbaeaf25f30a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project__ImagePreview), @"mvc.1.0.view", @"/Views/Project/_ImagePreview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/_ImagePreview.cshtml", typeof(AspNetCore.Views_Project__ImagePreview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae066e7d3267e30aab9e1495f04cbaeaf25f30a1", @"/Views/Project/_ImagePreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project__ImagePreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Domain.ImageField>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 27, true);
            WriteLiteral("\r\n<p>qsdflmqsdfqsdf</p>\r\n\r\n");
            EndContext();
#line 5 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\_ImagePreview.cshtml"
 foreach (var item in Model)
{
    var base64 = Convert.ToBase64String(item.imageData);
    var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
    

#line default
#line hidden
            BeginContext(233, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 241, "\"", 254, 1);
#line 10 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\_ImagePreview.cshtml"
WriteAttributeValue("", 247, imgSrc, 247, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(255, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 11 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\_ImagePreview.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Domain.ImageField>> Html { get; private set; }
    }
}
#pragma warning restore 1591
