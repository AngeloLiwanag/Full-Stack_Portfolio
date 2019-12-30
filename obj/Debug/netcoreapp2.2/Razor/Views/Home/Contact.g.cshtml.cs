#pragma checksum "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb9adeff933ad14f9ee6f5efd64d56ed936f1c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/_ViewImports.cshtml"
using FullStack_portfolio;

#line default
#line hidden
#line 2 "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/_ViewImports.cshtml"
using FullStack_portfolio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb9adeff933ad14f9ee6f5efd64d56ed936f1c24", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c77d6adac4e6777286af25733c8b8be1f6314711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/Home/Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(40, 4141, true);
            WriteLiteral(@"<div class=""container bg-white"">
    <div class=""m-5"">
        <h3>Get in touch</h3>
        <div class=""row"">
            <div class=""col"">
                <div class=""mt-3 pt-3"">
                    <h5><i class=""far fa-envelope text-success text-size""></i>Email</h5>
                    <a class=""d-inline-block text-size"">angeloliwanag75@gmail.com</a>
                </div>
                <div class=""mt-3 pt-3"">
                    <h5><i class=""fab fa-github-square text-success""></i>Github</h5>
                        <a class=""d-inline-block text-secondary text-size"" target=""_blank"" href=""https://github.com/AngeloLiwanag\"">github.com/AngeloLiwanag</a>
                </div>
                <div class=""mt-3 pt-3"">
                    <h5><i class=""fab fa-linkedin text-success""></i>LinkedIn</h5>
                        <a class=""d-inline-block text-secondary text-size"" target=""_blank"" href=""https://www.linkedin.com/in/angelo-liwanag/"">linkedin.com/in/angelo-liwanag</a>
                </div>
              ");
            WriteLiteral(@"  <div class=""mt-3 pt-3"">
                    <h5><i class=""fas fa-map-marker-alt text-success text-size""></i>Location</h5>
                    <a class=""d-inline-block text-size"">Long Beach, CA</a>
                </div>
            </div>
            <div class=""col img-div"">
                <div id=""map""></div>
            </div>
        </div>
    </div>
</div>
<script>
    function initMap() {
    // Styles a map in night mode.
    var map = new google.maps.Map(document.getElementById('map'), {
        center: {lat: 33.7701, lng: -118.1937},
        zoom: 12,
        styles: [
        {elementType: 'geometry', stylers: [{color: '#242f3e'}]},
        {elementType: 'labels.text.stroke', stylers: [{color: '#242f3e'}]},
        {elementType: 'labels.text.fill', stylers: [{color: '#746855'}]},
        {
            featureType: 'administrative.locality',
            elementType: 'labels.text.fill',
            stylers: [{color: '#d59563'}]
        },
        {
            featureType: 'poi',
            eleme");
            WriteLiteral(@"ntType: 'labels.text.fill',
            stylers: [{color: '#d59563'}]
        },
        {
            featureType: 'poi.park',
            elementType: 'geometry',
            stylers: [{color: '#263c3f'}]
        },
        {
            featureType: 'poi.park',
            elementType: 'labels.text.fill',
            stylers: [{color: '#6b9a76'}]
        },
        {
            featureType: 'road',
            elementType: 'geometry',
            stylers: [{color: '#38414e'}]
        },
        {
            featureType: 'road',
            elementType: 'geometry.stroke',
            stylers: [{color: '#212a37'}]
        },
        {
            featureType: 'road',
            elementType: 'labels.text.fill',
            stylers: [{color: '#9ca5b3'}]
        },
        {
            featureType: 'road.highway',
            elementType: 'geometry',
            stylers: [{color: '#746855'}]
        },
        {
            featureType: 'road.highway',
            elementType: 'geometry.stroke',
           ");
            WriteLiteral(@" stylers: [{color: '#1f2835'}]
        },
        {
            featureType: 'road.highway',
            elementType: 'labels.text.fill',
            stylers: [{color: '#f3d19c'}]
        },
        {
            featureType: 'transit',
            elementType: 'geometry',
            stylers: [{color: '#2f3948'}]
        },
        {
            featureType: 'transit.station',
            elementType: 'labels.text.fill',
            stylers: [{color: '#d59563'}]
        },
        {
            featureType: 'water',
            elementType: 'geometry',
            stylers: [{color: '#17263c'}]
        },
        {
            featureType: 'water',
            elementType: 'labels.text.fill',
            stylers: [{color: '#515c6d'}]
        },
        {
            featureType: 'water',
            elementType: 'labels.text.stroke',
            stylers: [{color: '#17263c'}]
        }
        ]
    });
    }
</script>
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyADO3yb-vlw0JywwS1Gu7Yw9f-53_A");
            WriteLiteral("tmJI&callback=initMap\"\nasync defer></script>\n");
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
