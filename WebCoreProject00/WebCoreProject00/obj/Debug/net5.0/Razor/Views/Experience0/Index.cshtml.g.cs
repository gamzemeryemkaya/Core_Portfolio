#pragma checksum "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Experience0\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3340705d49f3b425019cea5741b8e22c8a83342c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience0_Index), @"mvc.1.0.view", @"/Views/Experience0/Index.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Experience0\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3340705d49f3b425019cea5741b8e22c8a83342c", @"/Views/Experience0/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b726068bc9e981c0cb67ec8f004e6837a7593f", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience0_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\gamze\source\repos\WebCoreProject00\WebCoreProject00\Views\Experience0\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btngetlistall"" class=""btn btn-outline-primary"">Verileri Getir</button>
        <button type=""button"" id=""btnadd"" class=""btn btn-outline-info"">Kaydet</button>
        <button type=""button"" id=""btnid"" class=""btn btn-outline-warning"">Id ile Getir</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-outline-danger"">Sil</button>
        <button type=""button"" id=""btnupdate"" class=""btn btn-outline-success"">Güncelle</button>
    </div>
</div>

<h4 class=""text-center"">Deneyim  Listesi</h4>
<div class=""p-2"" id=""listexperience"">

</div>
<br />
<div class=""p-2"" id=""listbyidexperience"">

</div>

<br />
<div class=""col-md-12"">
    <h5>Deneyim Ekleme</h5>
    <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Başlık"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Tarih"" />
    <br />

</div>

<br />
<div class=""col-md-12"">
    <h5>Id'ye Göre Getirme");
            WriteLiteral(@"</h5>
    <input type=""text"" class=""form-control"" id=""inpid"" placeholder=""ID Giriniz"" />
</div>
<br />
<div class=""col-md-12"">
    <h5>Silme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpexpid"" placeholder=""ID Giriniz"" />
</div>
<br />

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlistall"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience0/ListExperience/"",

                success: function (funk) {
                    let values = jQuery.parseJSON(funk);
                    console.log(values);

                    let htmlst = ""<table class=table table-bordered> <tr> <th> ID </th> <th> Başlık </th> <th> Tarih </th> </tr>"";
                    $.each(values, (index, value) => {
                        htmlst += `<tr> <td>${value.ExperienceID}</td> <td>${value.Name}</td> <td>${value.Date}</td> </tr>`
                    });
                    htmlst += ""</table>"";
                    $(""#listexperience"").html(htmlst);
                }
            });
        });
        $(""#btnadd"").click(function () {
            let values = {
                Name: $(""#inpname"").val(),
                Date");
                WriteLiteral(@": $(""#inpdate"").val()
            };

            $.ajax({
                type: ""Post"",
                url: ""/Experience0/AddExperience/"",
                data: values,
                success: function (funk1) {
                    let result = jQuery.parseJSON(funk1);
                    alert(""Başarılı bir şekilde eklendi"");
                }
            });
        });

        $(""#btnid"").click(x => {
            let id = $(""#inpid"").val();

            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience0/GetById/"",
                data: { ExprerienceID: id },
                success: function (funk2) {
                    let result = jQuery.parseJSON(funk2);
                    console.log(result);
                    let htmlstr = `<table class=table table-hover> <tr> <th>Deneyim ID</th> <td>${result.ExperienceID}</td></tr> <tr> <th> Deneyim Başlığı </th> <td> ${result.Nam");
                WriteLiteral(@"e}</td> </tr> </table>`;
                    $(""#listbyidexperience"").html(htmlstr);
                }
            });

        });

        $(""#btndelete"").click(x => {
            let id = $(""#inpexpid"").val();
            $.ajax({
                url: ""/Experience/DeleteExperience/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (funk3) {
                    loadData();
                }
            });
        });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3340705d49f3b425019cea5741b8e22c8a83342c8325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
