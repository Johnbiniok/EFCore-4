#pragma checksum "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85b14d34586375378c934ecfb17cee474b82c5d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Product.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(Northwind.Views.Home.Product.Views_Product_Index))]
namespace Northwind.Views.Home.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml"
using Northwind.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b14d34586375378c934ecfb17cee474b82c5d2", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc336443358a39bf31ac02f3d17194e98e1e1151", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 256, true);
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Product</th>
            <th scope=""col"" class=""text-right"">Price</th>
            <th scope=""col"" class=""text-right"">Stock</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 13 "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml"
         foreach (Product p in Model)
        {

#line default
#line hidden
            BeginContext(356, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(394, 13, false);
#line 16 "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml"
               Write(p.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(407, 45, true);
            WriteLiteral("</td>\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(453, 35, false);
#line 17 "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml"
                                  Write(string.Format("{0:c}", p.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(488, 45, true);
            WriteLiteral("</td>\n                <td class=\"text-right\">");
            EndContext();
            BeginContext(534, 14, false);
#line 18 "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml"
                                  Write(p.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(548, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 20 "/Users/johnbiniok/RiderProjects/NorthwindClass7-master/Views/Product/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(582, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591