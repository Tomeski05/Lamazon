#pragma checksum "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52905e1078e8242e09ce524595b4a6dbef4418e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Products), @"mvc.1.0.view", @"/Views/Product/Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Products.cshtml", typeof(AspNetCore.Views_Product_Products))]
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
#line 1 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\_ViewImports.cshtml"
using Lamazon;

#line default
#line hidden
#line 2 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\_ViewImports.cshtml"
using Lamazon.Models;

#line default
#line hidden
#line 3 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\_ViewImports.cshtml"
using Lamazon.WebModels.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\_ViewImports.cshtml"
using Lamazon.WebModels.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52905e1078e8242e09ce524595b4a6dbef4418e1", @"/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ef5b970780a6df7b2a1e14e8e94175bbdf384dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 49, true);
            WriteLiteral("\r\n\r\n<h1>Products</h1>\r\n\r\n<div class=\"products\">\r\n");
            EndContext();
#line 7 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(124, 88, true);
            WriteLiteral("        <div class=\"thumbnail\">\r\n            <div class=\"caption\">\r\n                <h3>");
            EndContext();
            BeginContext(213, 12, false);
#line 11 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(225, 27, true);
            WriteLiteral("</h3>\r\n                <h4>");
            EndContext();
            BeginContext(253, 19, false);
#line 12 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml"
               Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(272, 27, true);
            WriteLiteral("</h4>\r\n                <h5>");
            EndContext();
            BeginContext(300, 13, false);
#line 13 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml"
               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(313, 57, true);
            WriteLiteral(" $</h5>\r\n                <p>\r\n                    <button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 370, "\"", 389, 1);
#line 15 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml"
WriteAttributeValue("", 378, product.Id, 378, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(390, 117, true);
            WriteLiteral(" class=\"btn btn-primary productItem\">Add to cart</button>\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\Filip\Desktop\Programming Course G3\Lamazon\Lamazon\Lamazon\Lamazon\Views\Product\Products.cshtml"
    }

#line default
#line hidden
            BeginContext(514, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
