#pragma checksum "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Maptest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59ace811ff2b372b48c495f1fb94488025e3622e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Maptest), @"mvc.1.0.view", @"/Views/Project/Maptest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Maptest.cshtml", typeof(AspNetCore.Views_Project_Maptest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ace811ff2b372b48c495f1fb94488025e3622e", @"/Views/Project/Maptest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Maptest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1534, true);
            WriteLiteral(@"<h2 style=""background-color: Yellow;color: Blue; text-align: center; font-style: oblique"">Satyaprakash's Bhubaneswar Google Map Using MVC and BOOTSTRAP</h2>  
<fieldset>  
    <legend style=""font-family: Arial Black; color: blue; font-size: large;"">Check Bhubaneswar City</legend>  
    <meta charset=""utf-8"">  
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">  
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">  
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>  
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>  
  
    <div id=""googleMap"" style=""height:400px;width:100%;""></div>  
    <script>  
        function myMap() {  
            var myCenter = new google.maps.LatLng(51.2171918, 4.4212529);  
            var mapProp = { center: myCenter, zoom: 15, scrollwheel: false, draggable: true, mapTypeId: google.maps.MapTypeId.ROADMAP }");
            WriteLiteral(@";  
            var map = new google.maps.Map(document.getElementById(""googleMap""), mapProp);  
            var marker = new google.maps.Marker({ position: myCenter });  
            marker.setMap(map);  
        }  
    </script>  
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBpGkcxEKiXUYAvr2HPj9bhYvs0uZsllW4&callback=myMap""></script>  
</fieldset>  
<footer>  
    <p style=""background-color: Yellow; font-weight: bold; color:blue; text-align: center; font-style: oblique"">© ");
            EndContext();
            BeginContext(1535, 26, false);
#line 23 "D:\OneDrive\Documenten\Generic_IntegratieProject\UI.MVC\Views\Project\Maptest.cshtml"
                                                                                                             Write(DateTime.Now.ToLocalTime());

#line default
#line hidden
            EndContext();
            BeginContext(1561, 5, true);
            WriteLiteral("</p> ");
            EndContext();
            BeginContext(1583, 15, true);
            WriteLiteral("  \r\n</footer>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591