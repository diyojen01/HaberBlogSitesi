#pragma checksum "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\KategoriGuncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d67c7f3812237c68dc01280c2d7e739cacb29aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_KategoriGuncelle), @"mvc.1.0.view", @"/Views/Category/KategoriGuncelle.cshtml")]
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
#line 1 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\_ViewImports.cshtml"
using HaberBlogSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\_ViewImports.cshtml"
using HaberBlogSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d67c7f3812237c68dc01280c2d7e739cacb29aa", @"/Views/Category/KategoriGuncelle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdfda37140f242469fb6a52ec9a6fc7ecb69a0bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_KategoriGuncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HaberBlogSitesi.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\KategoriGuncelle.cshtml"
  
    ViewData["Title"] = "KategoriGuncelle";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\KategoriGuncelle.cshtml"
 using (Html.BeginForm("KategoriGuncelle", "Category", FormMethod.Post))
{




#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Kategori ID</b>\r\n");
#nullable restore
#line 15 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\KategoriGuncelle.cshtml"
Write(Html.TextBoxFor(x =>x.CategoryID , new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <b>Kategori Adı</b>\r\n");
#nullable restore
#line 20 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\KategoriGuncelle.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\" style=\"background-color:#ff6a00\">Kategori Güncelle</button>\r\n");
#nullable restore
#line 23 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\KategoriGuncelle.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HaberBlogSitesi.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
