#pragma checksum "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dba6e1394f1b6e78cf749e1e990563286aa27c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dba6e1394f1b6e78cf749e1e990563286aa27c6", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdfda37140f242469fb6a52ec9a6fc7ecb69a0bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<HaberBlogSitesi.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
           Write(x.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
           Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 727, 2);
            WriteAttributeValue("", 692, "/Category/KategoriSil/", 692, 22, true);
#nullable restore
#line 30 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
WriteAttributeValue("", 714, x.CategoryID, 714, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediğine emin misin?\');\" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 843, "\"", 890, 2);
            WriteAttributeValue("", 850, "/Category/KategoriGuncelle/", 850, 27, true);
#nullable restore
#line 31 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
WriteAttributeValue("", 877, x.CategoryID, 877, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 39 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a href=\"/Category/Yenikategori/\" class=\"btn btn-primary\">Yeni Kategori Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<HaberBlogSitesi.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
