#pragma checksum "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4151806556b9b226f1917ae390a4a0bfb6ea820b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BlogGuncelle), @"mvc.1.0.view", @"/Views/Admin/BlogGuncelle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4151806556b9b226f1917ae390a4a0bfb6ea820b", @"/Views/Admin/BlogGuncelle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdfda37140f242469fb6a52ec9a6fc7ecb69a0bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_BlogGuncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HaberBlogSitesi.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
  
    ViewData["Title"] = "BlogGetir";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog Düzenleme Sayfası</h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 12 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
 using (Html.BeginForm("BlogGuncelle", "Admin", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.TextBoxFor(x => x.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 32 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Admin\BlogGuncelle.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HaberBlogSitesi.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
