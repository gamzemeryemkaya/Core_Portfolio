#pragma checksum "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8087845b35cb7fd2a2f79f60995d656d59ffac3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMediaList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8087845b35cb7fd2a2f79f60995d656d59ffac3a", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b726068bc9e981c0cb67ec8f004e6837a7593f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SocialMediaList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"social-nav\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n    <nav role=\"navigation\">\r\n        <ul class=\"nav justify-content-left\">\r\n");
#nullable restore
#line 6 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
             foreach (var f in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 307, "\"", 320, 1);
#nullable restore
#line 8 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 314, f.Url, 314, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 321, "\"", 336, 1);
#nullable restore
#line 8 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 329, f.Name, 329, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 340, "\"", 355, 1);
#nullable restore
#line 8 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 348, f.Icon, 348, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span class=\"menu-title sr-only\">");
#nullable restore
#line 8 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
                                                                                                                                          Write(f.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 9 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SocialMediaList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n    </nav>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591