#pragma checksum "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5842e58e3120c29cc7b5e6a07d4aa829b565fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarsManagement), @"mvc.1.0.view", @"/Views/Home/CarsManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CarsManagement.cshtml", typeof(AspNetCore.Views_Home_CarsManagement))]
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
#line 1 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\_ViewImports.cshtml"
using CarPredictionWebUi;

#line default
#line hidden
#line 2 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\_ViewImports.cshtml"
using CarPredictionWebUi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5842e58e3120c29cc7b5e6a07d4aa829b565fe5", @"/Views/Home/CarsManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cbd1f8f2ed901272a2bd3547f60e52abf1b6f0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarsManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PredictionRequest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
   var loggedIn = true; 

#line default
#line hidden
#line 3 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
 if (loggedIn)
{

#line default
#line hidden
            BeginContext(85, 477, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <table class=""table"">
                <thead>
                <tr>
                    <th>Model</th>
                    <th>Year</th>
                    <th>Horse Power</th>
                    <th>Fuel</th>
                    <th>Mileage</th>
                    <th>Transmission</th>
                    <th>Price</th>
                </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 20 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(635, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(698, 10, false);
#line 23 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                           Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(708, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(748, 9, false);
#line 24 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                           Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(757, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(797, 15, false);
#line 25 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                           Write(item.HorsePower);

#line default
#line hidden
            EndContext();
            BeginContext(812, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(852, 9, false);
#line 26 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                           Write(item.Fuel);

#line default
#line hidden
            EndContext();
            BeginContext(861, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(901, 12, false);
#line 27 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                           Write(item.Mileage);

#line default
#line hidden
            EndContext();
            BeginContext(913, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(953, 17, false);
#line 28 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                           Write(item.Transmission);

#line default
#line hidden
            EndContext();
            BeginContext(970, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
                    }

#line default
#line hidden
            BeginContext(1031, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 35 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1119, 95, true);
            WriteLiteral("    <h1>You don\'t have the rights to access this page. Firstly you have to be logged in.</h1>\r\n");
            EndContext();
#line 39 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
}

#line default
#line hidden
            BeginContext(1217, 18, true);
            WriteLiteral("\r\n\r\n<script>\r\n    ");
            EndContext();
            BeginContext(1236, 8, false);
#line 43 "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml"
Write(loggedIn);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 59, true);
            WriteLiteral(" = window.localStorage.getItem(\'Auth\') !== null;\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PredictionRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591