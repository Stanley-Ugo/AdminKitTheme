#pragma checksum "C:\Projects\AdminKitTheme\Views\MapGoogle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de9245993e7127d71776c1b2c326922991d6ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MapGoogle_Index), @"mvc.1.0.view", @"/Views/MapGoogle/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Projects\AdminKitTheme\Views\_ViewImports.cshtml"
using AdminKitTheme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\AdminKitTheme\Views\_ViewImports.cshtml"
using AdminKitTheme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de9245993e7127d71776c1b2c326922991d6ce5", @"/Views/MapGoogle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf78afa288df2d30451e0b556f6858613a690663", @"/Views/_ViewImports.cshtml")]
    public class Views_MapGoogle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\AdminKitTheme\Views\MapGoogle\Index.cshtml"
  
    ViewData["Title"] = "Map-Google";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid p-0"">

    <h1 class=""h3 mb-3"">Google Maps</h1>

    <div class=""row"">
        <div class=""col-12 col-lg-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5 class=""card-title"">Default Map</h5>
                    <h6 class=""card-subtitle text-muted"">Displays the default road map view.</h6>
                </div>
                <div class=""card-body"">
                    <div class=""content"" id=""default_map"" style=""height: 300px;""></div>
                </div>
            </div>
        </div>
        <div class=""col-12 col-lg-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5 class=""card-title"">Hybrid Map</h5>
                    <h6 class=""card-subtitle text-muted"">Displays a mixture of normal and satellite views.</h6>
                </div>
                <div class=""card-body"">
                    <div class=""content"" id=""hybrid_map"" style=""height: 300p");
            WriteLiteral("x;\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
