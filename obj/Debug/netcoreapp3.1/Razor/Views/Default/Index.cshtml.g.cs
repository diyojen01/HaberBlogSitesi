#pragma checksum "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d17d09aec95c682c55c853f638e3a6964f874d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17d09aec95c682c55c853f638e3a6964f874d4b", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdfda37140f242469fb6a52ec9a6fc7ecb69a0bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HaberBlogSitesi.Models.BlogYorum>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_BlogLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--\r\nAuthor: W3layouts\r\nAuthor URL: http://w3layouts.com\r\nLicense: Creative Commons Attribution 3.0 Unported\r\nLicense URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n<!DOCTYPE HTML>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d17d09aec95c682c55c853f638e3a6964f874d4b3651", async() => {
                WriteLiteral(@"


    <div class=""header-banner"">
        <div class=""wrap"">
            <div class=""banner"">
                <div class=""indent"">
                    <h2 class=""indent-left margin-bot"" style=""margin-left:80px"">Haber Bloğum</h2>
                   
                    <div class=""header_bottom_right_images"">

                        <div class=""slider"" style=""width:650px; height:320px;"">
                            <ul class=""rslides"" id=""slider1"">

");
#nullable restore
#line 33 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
                                 foreach (var x in Model.Deger1)
                                {


                                    


#line default
#line hidden
#nullable disable
                WriteLiteral("                                   <li><a");
                BeginWriteAttribute("href", " href=\"", 1003, "\"", 1038, 2);
                WriteAttributeValue("", 1010, "/Default/BlogDetay/", 1010, 19, true);
#nullable restore
#line 39 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
WriteAttributeValue("", 1029, x.BlogID, 1029, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img");
                BeginWriteAttribute("src", " src=\"", 1044, "\"", 1062, 1);
#nullable restore
#line 39 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
WriteAttributeValue("", 1050, x.BlogImage, 1050, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1063, "\"", 1069, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"width:700px;height:330px\"><h5>");
#nullable restore
#line 39 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
                                                                                                                                             Write(x.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5><span>Kategorisi:");
#nullable restore
#line 39 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
                                                                                                                                                                               Write(x.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 40 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
                                   
                                    
                                    
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""clear""></div>
            </div>
            <div class=""clear""></div>
        </div>
    </div>
    <div class""content"">
        <div class=""wrap"">
            <div class=""wrapper"">
");
                WriteLiteral("                <br />\r\n                <br />\r\n\r\n               \r\n                ");
#nullable restore
#line 64 "C:\Users\user\source\repos\HaberBlogSitesi\HaberBlogSitesi\Views\Default\Index.cshtml"
           Write(await Html.PartialAsync("~/Views/Default/Partial1.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"grids\">\r\n                    <div class=\"box1\">\r\n\r\n                        <div class=\"clear\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HaberBlogSitesi.Models.BlogYorum> Html { get; private set; }
    }
}
#pragma warning restore 1591
