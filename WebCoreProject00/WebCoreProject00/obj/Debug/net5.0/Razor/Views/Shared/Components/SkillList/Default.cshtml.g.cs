#pragma checksum "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79bea5afb8e095675aaa4cd0e56d2549d627831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b79bea5afb8e095675aaa4cd0e56d2549d627831", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b726068bc9e981c0cb67ec8f004e6837a7593f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Yeteneklerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Bildiğim programlama dilleri ve kullandığım teknolojiler </p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
                <div class=""col-md-12"">
");
#nullable restore
#line 14 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml"
                     foreach(var s in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"py-1\">\r\n                        <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 16 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                  Write(s.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 16 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                       Write(s.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                        <div class=""progress my-1"">
                            <div class=""progress-bar bg-primary"" role=""progressbar"" data-aos=""zoom-in-right"" data-aos-delay=""400""
                        data-aos-anchor="".skills-section""");
            BeginWriteAttribute("style", " style=\"", 1000, "\"", 1024, 3);
            WriteAttributeValue("", 1008, "width:", 1008, 6, true);
#nullable restore
#line 19 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1014, s.Value, 1015, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1023, "%", 1023, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuenow=\"70\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 22 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
