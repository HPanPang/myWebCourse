#pragma checksum "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd2b12a63d5951e6aee12ff912596c8cd5cd993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Information), @"mvc.1.0.view", @"/Views/Customer/Information.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Information.cshtml", typeof(AspNetCore.Views_Customer_Information))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd2b12a63d5951e6aee12ff912596c8cd5cd993", @"/Views/Customer/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cb80dffae8aa414820a12fbd5a89972e244f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
  
    Layout = "_CustomerLayout";
    ViewData["Title"] = "个人信息";
    var customer = Model;
    ViewData["Name"] = customer.Name;

#line default
#line hidden
            BeginContext(139, 226, true);
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"col-md-2 \"> </div>\r\n            <div class=\"col-md-10 \">\r\n                <div class=\"panel-body\">\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(365, 1761, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dd2b12a63d5951e6aee12ff912596c8cd5cd9934440", async() => {
                BeginContext(433, 200, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>姓名</label>\r\n                                <input class=\"form-control\" name=\"name\" id=\"name\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 633, "\"", 655, 1);
#line 15 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
WriteAttributeValue("", 641, customer.Name, 641, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(656, 235, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>性别</label>\r\n                                <input class=\"form-control\" name=\"sex\" id=\"sex\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 891, "\"", 912, 1);
#line 19 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
WriteAttributeValue("", 899, customer.Sex, 899, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(913, 235, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>年龄</label>\r\n                                <input class=\"form-control\" name=\"age\" id=\"age\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1148, "\"", 1169, 1);
#line 23 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
WriteAttributeValue("", 1156, customer.Age, 1156, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1170, 243, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>联系方式</label>\r\n                                <input class=\"form-control\" name=\"number\" id=\"number\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", "value=\"", 1413, "\"", 1435, 1);
#line 27 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
WriteAttributeValue("", 1420, customer.Phone, 1420, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1436, 243, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>E-Mail</label>\r\n                                <input class=\"form-control\" name=\"email\" id=\"eamil\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", "value=\"", 1679, "\"", 1700, 1);
#line 31 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
WriteAttributeValue("", 1686, customer.Mail, 1686, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1701, 243, true);
                WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>地址</label>\r\n                                <input class=\"form-control\" name=\"address\" id=\"address\" type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", "value=\"", 1944, "\"", 1968, 1);
#line 35 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
WriteAttributeValue("", 1951, customer.Address, 1951, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1969, 150, true);
                WriteLiteral(" >\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-info\">保存修改</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 12 "D:\GitHub\FirstView\FirstView\Views\Customer\Information.cshtml"
AddHtmlAttributeValue("", 391, Url.Action("ModifyJudge"), 391, 26, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2126, 94, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
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