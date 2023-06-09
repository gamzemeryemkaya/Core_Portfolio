#pragma checksum "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2735b29b73e0621f27b10d3bd28e9137f8b448b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\_ViewImports.cshtml"
using WebCoreProject00;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\_ViewImports.cshtml"
using WebCoreProject00.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2735b29b73e0621f27b10d3bd28e9137f8b448b5", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b726068bc9e981c0cb67ec8f004e6837a7593f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Durumu</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th>Ana Görsel</th>
                                <th>Proje Adı</th>
                                <th>Fiyat</th>
                                <th>Tamamlanma Oranı </th>
                                <th>Durum</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 21 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach(var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 23 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 995, "\"", 1015, 1);
#nullable restore
#line 24 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1001, item.ImageUrl, 1001, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                <td>");
#nullable restore
#line 25 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1264, "\"", 1314, 3);
            WriteAttributeValue("", 1271, "/Portfolio/EditPortfolio/", 1271, 25, true);
#nullable restore
#line 29 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1296, item.PortfolioID, 1296, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1313, "/", 1313, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"badge badge-outline-success\">Detaylar</div>\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
