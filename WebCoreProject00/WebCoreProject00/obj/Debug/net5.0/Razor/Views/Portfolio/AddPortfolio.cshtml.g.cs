#pragma checksum "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51514caf352640fba793d3187536fcf506669026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51514caf352640fba793d3187536fcf506669026", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b726068bc9e981c0cb67ec8f004e6837a7593f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Proje Ekleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 13 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\"> Yeni Proje Ekleme Paneli </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51514caf352640fba793d3187536fcf5066690264582", async() => {
                WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 21 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Görsel 1</label>\r\n                    ");
#nullable restore
#line 26 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Görsel 2</label>\r\n                    ");
#nullable restore
#line 30 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.ImageUrl2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Proje URL</label>\r\n                    ");
#nullable restore
#line 34 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.ProjectUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Tamamlanma Oranı</label>\r\n                    ");
#nullable restore
#line 38 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Value));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Fiyat</label>\r\n                    ");
#nullable restore
#line 42 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <button class=\"btn btn-success\">Kaydet</button>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Portfolio\AddPortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591
