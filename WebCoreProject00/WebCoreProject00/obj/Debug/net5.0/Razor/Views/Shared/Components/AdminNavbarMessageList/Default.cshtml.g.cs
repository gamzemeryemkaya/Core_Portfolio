#pragma checksum "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f8f438f98038778d8d2cdfc0f81be86e1c96d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNavbarMessageList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNavbarMessageList/Default.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8f438f98038778d8d2cdfc0f81be86e1c96d9e", @"/Views/Shared/Components/AdminNavbarMessageList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b726068bc9e981c0cb67ec8f004e6837a7593f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminNavbarMessageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Son Mesajlar</h6>\r\n");
#nullable restore
#line 6 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 339, "\"", 407, 2);
            WriteAttributeValue("", 346, "/AdminMessage/AdminWriterMessageDetails/", 346, 40, true);
#nullable restore
#line 9 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml"
WriteAttributeValue("", 386, item.WriterMessageID, 386, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""preview-thumbnail"">
            <img src=""https://i.hizliresim.com/iz4m80i.png"" alt=""image"" class=""rounded-circle profile-pic"">
        </div>
        <div class=""preview-item-content"">
            <p class=""preview-subject ellipsis mb-1"">");
#nullable restore
#line 14 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml"
                                                Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bir mesaj gönderdi</p>\r\n            <p class=\"text-muted mb-0\"> ");
#nullable restore
#line 15 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml"
                                    Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 18 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\AdminNavbarMessageList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <p class=\"p-3 mb-0 text-center\">3 yeni mesaj</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591