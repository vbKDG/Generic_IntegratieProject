#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "076b5c92c768a7e37a69d560fd93a0ee9fa50f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_MapFieldVM), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/MapFieldVM.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/MapFieldVM.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_MapFieldVM))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076b5c92c768a7e37a69d560fd93a0ee9fa50f3c", @"/Views/Shared/EditorTemplates/MapFieldVM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_MapFieldVM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Fields.MapFieldVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/maps2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemtype", new global::Microsoft.AspNetCore.Html.HtmlString("double"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml"
 if (ViewBag.index == 0)
{

#line default
#line hidden
            BeginContext(88, 251, true);
            WriteLiteral("    <fieldset>  \r\n        <meta charset=\"utf-8\">  \r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">  \r\n        <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\"> \r\n        ");
            EndContext();
            BeginContext(339, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "076b5c92c768a7e37a69d560fd93a0ee9fa50f3c5637", async() => {
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
            BeginContext(385, 18, true);
            WriteLiteral(" \r\n        <script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 403, "\"", 437, 1);
#line 11 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml"
WriteAttributeValue("", 409, Url.Content("~/js/Maps.js"), 409, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(438, 8251, true);
            WriteLiteral(@"></script>


       
  
      
        <div class=""row"">
        <div class=""card bg-light text-center card-form"">
        <div class=""card-body"" id=""card"">
        
        <input id=""pac-input"" class=""controls py-2"" type=""text"" placeholder=""Search Box"">
            <input id=""search-Button"" type=""button"" class=""btn btn-success btn-sm"" value=""Add""/>
            <table>
                <tr>
                    <td>
                        <div id=""map"" style=""height: 360px; width: 720px;""> </div> </td>
<div class=""col-md-4"">
<td>
    <div id=""locationRows"">
        <hr/>
    </div>
    <hr/>
</td>
</div>
                </tr>
            </table>
        </div>
        </div>

      </div>
      
        <script>
            
            
            var LocationIndex = 0;
            var locationTracker = [];
            $(document).ready(function() {
                console.log('test');
                var locationCount = (document.getElementsByClassName('location')).le");
            WriteLiteral(@"ngth;
                console.log('locationcount: ' + locationCount);
                
                // locationTracker = [locationCount];
                for (var i = 0; i < locationCount; i++) {
                    locationTracker[i] = true;
                }
                console.log(locationTracker);
            });            
           
        function initAutocomplete() {
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 13,
            center: {lat: 51.2171918, lng: 4.4212529},
            mapTypeControl: false,
            fullscreenControl : false
        });
        var geocoder = new google.maps.Geocoder();
        // Create the search box and link it to the UI element.
        var input = document.getElementById('pac-input');
        var button = document.getElementById('search-Button');
        var searchBox = new google.maps.places.SearchBox(input);
        map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);
      ");
            WriteLiteral(@"  map.controls[google.maps.ControlPosition.TOP_LEFT].push(button);


        // Bias the SearchBox results towards current map's viewport.
        map.addListener('bounds_changed', function() {
            searchBox.setBounds(map.getBounds());
        });

        var markers = [];
        // Listen for the event fired when the user selects a prediction and retrieve
        // more details for that place.
        button.addEventListener(""click"", function() {
            var places = searchBox.getPlaces();
            console.log(locationTracker);
            var x = true;
            var teller = 0;
            while (x) {
                if (locationTracker[teller]) {
                    LocationIndex = teller;
                    x = false;
                } else {
                    teller++;

                }
                if ( teller > document.getElementsByClassName('location').length) {
                    x = false;
                }
            }
            LocationIn");
            WriteLiteral(@"dex = teller;
          //  console.log(teller);
          //  console.log(LocationIndex);
          //  console.log(document.getElementsByClassName('location').length);
            if (LocationIndex < document.getElementsByClassName('location').length) {

                var address = document.getElementById('pac-input').value;
                geocoder.geocode({ 'address': address },
                    function(results, status) {
                        if (status === 'OK') {


                            var lat = results[0].geometry.location.lat().toString().replace('.', ',');
                            var lng = results[0].geometry.location.lng().toString().replace('.', ',');

                            var latitude = '#MapFieldVms_' + LocationIndex + '__latitude';
                            var longitude = '#MapFieldVms_' + LocationIndex + '__longitude';
                            $(latitude).attr('value', lat);
                            $(longitude).attr('value', lng);
        ");
            WriteLiteral(@"                    locationTracker[teller] = false;

                            AddLocation(results[0].formatted_address, LocationIndex);


                            console.log(latitude);
                            console.log(longitude);

                            $('#pac-input').val('');
                        }

                    });
                if (places.length == 0) {
                    return;
                }

                // Clear out the old markers.
                markers.forEach(function(marker) {
                    marker.setMap(null);
                });
                markers = [];

                // For each place, get the icon, name and location.
                var bounds = new google.maps.LatLngBounds();
                places.forEach(function(place) {
                    if (!place.geometry) {
                        console.log(""Returned place contains no geometry"");
                        return;
                    }
                ");
            WriteLiteral(@"    var icon = {
                        url: place.icon,
                        size: new google.maps.Size(71, 71),
                        origin: new google.maps.Point(0, 0),
                        anchor: new google.maps.Point(17, 34),
                        scaledSize: new google.maps.Size(25, 25)
                    };

                    // Create a marker for each place.
                    markers.push(new google.maps.Marker({
                        map: map,
                        icon: icon,
                        title: place.name,
                        position: place.geometry.location
                    }));

                    if (place.geometry.viewport) {
                        // Only geocodes have viewport.
                        bounds.union(place.geometry.viewport);
                    } else {
                        bounds.extend(place.geometry.location);
                    }
                });
                map.fitBounds(bounds);

            }");
            WriteLiteral(@" else {
                alert(""Max Locations"");
            }
        });
    }
            
       
           function AddLocation (input,index) {

                var rowCount = $('.locationRow').length;
                var inputString = """";

                inputString += '<p class=""locationText"" >Location '+ index  + '</p>';        
                inputString += '<p>' + input +' <a href=""javascript:void(0);"" class=""remRow"">Remove</a> </p>';        
                $(""#locationRows"").append('<div id=""locationRow'+ index  +'"" class=""locationRow"">' + inputString + '</div>');

                var locationtexts = document.getElementsByClassName('locationText');
                for (var i = 0; i < locationtexts.length; i++) {
                    locationtexts[i].innerText = 'Location ' + (i + 1);
                }
            };
            

            $(""#locationRows"").on('click', '.remRow', function () {
     
   
               // var max = document.getElementsByClassName('loca");
            WriteLiteral(@"tion');
               // var max = max.length;
                var rowIndex = (this).closest("".locationRow"").id;
                 rowIndex = rowIndex.charAt(rowIndex.length - 1) ;
                
                var latitude = '#MapFieldVms_' + rowIndex + '__latitude';
                var longitude = '#MapFieldVms_' + rowIndex + '__longitude';
                $(latitude).attr('value',0);
                $(longitude).attr('value',0);
                locationTracker[rowIndex] = true;
               
               (this).closest("".locationRow"").remove();

               var locationtexts = document.getElementsByClassName('locationText');
               for (var i = 0; i < locationtexts.length; i++) {
                   locationtexts[i].innerText = 'Location ' + (i + 1);
               }


   
        
            });
        </script>
        <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBpGkcxEKiXUYAvr2HPj9bhYvs0uZsllW4&libraries=places&callback=initAutocomplete""
    ");
            WriteLiteral("            async defer></script>\r\n    \r\n    </fieldset> \r\n");
            EndContext();
#line 226 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml"
}

#line default
#line hidden
            BeginContext(8692, 30, true);
            WriteLiteral("\r\n<div class=\"location\">\r\n    ");
            EndContext();
            BeginContext(8722, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "076b5c92c768a7e37a69d560fd93a0ee9fa50f3c16229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 229 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.latitude);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8784, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(8790, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "076b5c92c768a7e37a69d560fd93a0ee9fa50f3c18098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 230 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\Generic_Repo\UI.MVC\Views\Shared\EditorTemplates\MapFieldVM.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.longitude);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8833, 18, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Fields.MapFieldVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
