#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectImageDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d040318a1991320b6d1c9bd4dff7da7ee09b3150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ProjectImageDisplay), @"mvc.1.0.view", @"/Views/Project/ProjectImageDisplay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/ProjectImageDisplay.cshtml", typeof(AspNetCore.Views_Project_ProjectImageDisplay))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d040318a1991320b6d1c9bd4dff7da7ee09b3150", @"/Views/Project/ProjectImageDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_ProjectImageDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Project>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 6, true);
            WriteLiteral("\n\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 28, "\"", 68, 1);
#line 4 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\Generic_IntegratieProject\UI.MVC\Views\Project\ProjectImageDisplay.cshtml"
WriteAttributeValue("", 34, Model.imageField.GetImageString(), 34, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(69, 27, true);
            WriteLiteral(" width=\"200\" height=\"200\"/>");
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