#pragma checksum "D:\GitHub\FirstView\FirstView\Views\Author\fee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa6ec12f0dfe8516ef5a696a438fa73c32f7929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_fee), @"mvc.1.0.view", @"/Views/Author/fee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/fee.cshtml", typeof(AspNetCore.Views_Author_fee))]
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
#line 1 "D:\GitHub\FirstView\FirstView\Views\_ViewImports.cshtml"
using FirstView;

#line default
#line hidden
#line 2 "D:\GitHub\FirstView\FirstView\Views\_ViewImports.cshtml"
using FirstView.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caa6ec12f0dfe8516ef5a696a438fa73c32f7929", @"/Views/Author/fee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cb80dffae8aa414820a12fbd5a89972e244f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_fee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitHub\FirstView\FirstView\Views\Author\fee.cshtml"
  
    Layout = "_AuthorLayout";
    ViewData["Title"] = "稿费查询";
        var author = Model;
    ViewData["Name"] = author.Name;

#line default
#line hidden
            BeginContext(137, 2339, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-title"">
                    <h4>稿费明细 </h4>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>序号</th>
                                    <th>书名</th>
                                    <th>当前状态</th>
                                    <th>出版日期</th>
                                    <th>单价</th>
                                    <th>当前销售数量</th>
                                    <th>已获稿费</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th scope=""row"">1</th>
                                    <td>Kolor Tea Sh");
            WriteLiteral(@"irt For Man</td>
                                    <td><span class=""badge badge-primary"">Sale</span></td>
                                    <td>January 22</td>
                                    <td class=""color-primary"">$21.56</td>
                                </tr>
                                <tr>
                                    <th scope=""row"">2</th>
                                    <td>Kolor Tea Shirt For Women</td>
                                    <td><span class=""badge badge-success"">Tax</span></td>
                                    <td>January 30</td>
                                    <td class=""color-success"">$55.32</td>
                                </tr>
                                <tr>
                                    <th scope=""row"">3</th>
                                    <td>Blue Backpack For Baby</td>
                                    <td><span class=""badge badge-danger"">Extended</span></td>
                                    <td>January 2");
            WriteLiteral(@"5</td>
                                    <td class=""color-danger"">$14.85</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
