#pragma checksum "C:\Users\theod\source\repos\CarPredictionWebUi\CarPredictionWebUi\Views\Home\CarsManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05add3495688e71fac88f9da314063c6922819fc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05add3495688e71fac88f9da314063c6922819fc", @"/Views/Home/CarsManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cbd1f8f2ed901272a2bd3547f60e52abf1b6f0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarsManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 692, true);
            WriteLiteral(@"<div class=""row"" id=""authorized"" hidden>
    <div class=""col-md-12"">
        <table class=""table table-striped table-bordered"" id=""cars"">
            <thead>
                <tr>
                    <th>Model</th>
                    <th>Year</th>
                    <th>Horse Power</th>
                    <th>Fuel</th>
                    <th>Mileage</th>
                    <th>Transmission</th>
                    <th>Price</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

<h1 id=""notEnoughRights"" hidden>You don't have the rights to access this page. Firstly you have to be logged in.</h1>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(734, 3329, true);
                WriteLiteral(@"

    <script>
        function getUser() {
            return window.localStorage.getItem(""UserAuth"") !== null;
        }

        if (getUser()) {
            document.getElementById(""authorized"").removeAttribute(""hidden"");
        } else {
            document.getElementById(""notEnoughRights"").removeAttribute(""hidden"");
        }
    </script>

    <script>

        $(document).ready(function () {
            var carsTable = $('#cars').DataTable({
                ajax: {
                    url: ""https://localhost:44391/api/cars"",
                    dataSrc: """"
                },
                columns: [
                    {
                        data: ""model"",
                        render: function (data) {
                            return ""<td>"" + data + ""</td>"";
                        }
                    },
                    {
                        data: ""year"",
                        render: function (data) {
                            return ""<td>"" + ");
                WriteLiteral(@"data + ""</td>"";
                        }
                    },
                    {
                        data: ""horsePower"",
                        render: function (data) {
                            return ""<td>"" + data + ""</td>"";
                        }
                    },
                    {
                        data: ""fuel"",
                        render: function (data) {
                            return ""<td>"" + data + ""</td>"";
                        }
                    },
                    {
                        data: ""mileage"",
                        render: function (data) {
                            return ""<td>"" + data + ""</td>"";
                        }
                    },
                    {
                        data: ""transmission"",
                        render: function (data) {
                            return ""<td>"" + data + ""</td>"";
                        }
                    },
                    {
                ");
                WriteLiteral(@"        data: ""price"",
                        render: function (data) {
                            return ""<td>"" + data + ""</td>"";
                        }
                    },
                    {
                        data: """",
                        render: function (data, type, car) {
                            return ""<button class='btn-link js-delete' data-car-id='"" + car.id + ""'>Delete</button>"";
                        }
                    }
                ]
            });
        $(""#cars"").on(""click"",
            "".js-delete"",
            function () {
                var button = $(this);
                bootbox.confirm(""Are you sure you want to delete this car?"",
                    function (result) {
                        if (result) {
                            $.ajax({
                                url: ""/api/cars/"" + button.attr(""data-car-id""),
                                method: ""DELETE"",
                                success: function () {
   ");
                WriteLiteral(@"                                 carsTable.rows(button.parents(""tr"")).remove().draw();
                                }
                            });
                        }
                    });
                });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
