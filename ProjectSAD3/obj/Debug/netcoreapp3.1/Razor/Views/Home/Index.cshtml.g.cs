#pragma checksum "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43e3ba169f71972a9bba9ea5c0fb8ddedb87376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\_ViewImports.cshtml"
using ProjectSAD3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43e3ba169f71972a9bba9ea5c0fb8ddedb87376", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"875d2c0465e14c84effbc39d7e067bc4855652f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Computer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"conatiner\">\r\n    <div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 7 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
         foreach (Computer item in Model)
        {
            
            var x = @item.ImgPath.Split("\\");

        

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4 col-sm-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                 \r\n                    \r\n                    <div class=\"text-center\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 491, "\"", 510, 2);
            WriteAttributeValue("", 497, "/images/", 497, 8, true);
#nullable restore
#line 18 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
WriteAttributeValue("", 505, x[9], 505, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" )\" width=\"200\" height=\"200\" />\r\n                        <h3>");
#nullable restore
#line 19 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
                       Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
                                       Write(item.Models);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h5>");
#nullable restore
#line 20 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>Price : ");
#nullable restore
#line 21 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
                              Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      \r\n                        ");
#nullable restore
#line 23 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
                   Write(Html.ActionLink("Buy", "GetItem", "Home", new { id=item.Id},new {@class="btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                      \r\n                    </div>\r\n                  \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\jaral\source\repos\ProjectSAD3\ProjectSAD3\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Computer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
