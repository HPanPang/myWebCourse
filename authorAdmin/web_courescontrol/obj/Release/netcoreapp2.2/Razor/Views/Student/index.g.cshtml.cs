#pragma checksum "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1b4924b08984754cdc631271dccaef04b8830f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_index), @"mvc.1.0.view", @"/Views/Student/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/index.cshtml", typeof(AspNetCore.Views_Student_index))]
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
#line 1 "D:\GitHub\web_courescontrol\web_courescontrol\Views\_ViewImports.cshtml"
using web_coursecontrol;

#line default
#line hidden
#line 2 "D:\GitHub\web_courescontrol\web_courescontrol\Views\_ViewImports.cshtml"
using web_coursecontrol.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1b4924b08984754cdc631271dccaef04b8830f", @"/Views/Student/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8cfc321d0be8e2dfa3fc1bb45d45d705eb3c08a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/lib/calendar2/semantic.ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/lib/calendar2/pignose.calendar.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lib/calendar-2/moment.latest.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lib/calendar-2/semantic.ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lib/calendar-2/prism.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lib/calendar-2/pignose.calendar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/lib/calendar-2/pignose.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\index.cshtml"
  
    Layout = "_StudentLayout";
    ViewData["Title"] = "主页";
    var student = Model;
    ViewData["StudentName"] = student.StuName;
    ViewData["StuId"] = student.StuId;

#line default
#line hidden
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de1b4924b08984754cdc631271dccaef04b8830f6589", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(260, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de1b4924b08984754cdc631271dccaef04b8830f7842", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(335, 59, true);
            WriteLiteral("\r\n\r\n<div class=\"alert alert-primary text-center\">\r\n    欢迎您，");
            EndContext();
            BeginContext(395, 15, false);
#line 14 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\index.cshtml"
   Write(student.StuName);

#line default
#line hidden
            EndContext();
            BeginContext(410, 5, true);
            WriteLiteral("  学号：");
            EndContext();
            BeginContext(416, 13, false);
#line 14 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\index.cshtml"
                        Write(student.StuId);

#line default
#line hidden
            EndContext();
            BeginContext(429, 6655, true);
            WriteLiteral(@"
</div>
<div class=""container-fluid"">
    <div class=""row justify-content-center"">
        <div class=""col-lg-6"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""year-calendar""><div class=""pignose-calendar pignose-calendar-blue pignose-calendar-default"">												
                        <div class=""pignose-calendar-top"">													
                        <a href=""#"" class=""pignose-calendar-top-nav pignose-calendar-top-prev"">														
                            <span class=""icon-arrow-left pignose-calendar-top-icon""></span>													
                            </a>													
                        <div class=""pignose-calendar-top-date"">														
                            <span class=""pignose-calendar-top-month"">April</span>														
                            <span class=""pignose-calendar-top-year"">2019</span>													
                            </div>													
                        <a href=""#"" cl");
            WriteLiteral(@"ass=""pignose-calendar-top-nav pignose-calendar-top-next"">														
                            <span class=""icon-arrow-right pignose-calendar-top-icon""></span>													
                            </a>												
                            </div>												
                        <div class=""pignose-calendar-header""><div class=""pignose-calendar-week pignose-calendar-week-sun"">SUN</div><div class=""pignose-calendar-week pignose-calendar-week-mon"">MON</div><div class=""pignose-calendar-week pignose-calendar-week-tue"">TUE</div><div class=""pignose-calendar-week pignose-calendar-week-wed"">WED</div><div class=""pignose-calendar-week pignose-calendar-week-thu"">THU</div><div class=""pignose-calendar-week pignose-calendar-week-fri"">FRI</div><div class=""pignose-calendar-week pignose-calendar-week-sat"">SAT</div></div>												<div class=""pignose-calendar-body""><div class=""pignose-calendar-row""><div class=""pignose-calendar-unit pignose-calendar-unit-sun""></div><div class=""pignose-calendar-unit pignose-cal");
            WriteLiteral(@"endar-unit-date pignose-calendar-unit-mon"" data-date=""2019-04-01""><a href=""#"">1</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-tue"" data-date=""2019-04-02""><a href=""#"">2</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-wed"" data-date=""2019-04-03""><a href=""#"">3</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-thu"" data-date=""2019-04-04""><a href=""#"">4</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-fri"" data-date=""2019-04-05""><a href=""#"">5</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sat"" data-date=""2019-04-06""><a href=""#"">6</a></div></div><div class=""pignose-calendar-row""><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sun"" data-date=""2019-04-07""><a href=""#"">7</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-mon"" dat");
            WriteLiteral(@"a-date=""2019-04-08""><a href=""#"">8</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-tue"" data-date=""2019-04-09""><a href=""#"">9</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-wed"" data-date=""2019-04-10""><a href=""#"">10</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-thu"" data-date=""2019-04-11""><a href=""#"">11</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-fri"" data-date=""2019-04-12""><a href=""#"">12</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sat"" data-date=""2019-04-13""><a href=""#"">13</a></div></div><div class=""pignose-calendar-row""><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sun"" data-date=""2019-04-14""><a href=""#"">14</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-mon"" data-date=""2019-04-15""><a href=""#"">15</a></d");
            WriteLiteral(@"iv><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-tue pignose-calendar-unit-active pignose-calendar-unit-first-active"" data-date=""2019-04-16""><a href=""#"">16</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-wed"" data-date=""2019-04-17""><a href=""#"">17</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-thu"" data-date=""2019-04-18""><a href=""#"">18</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-fri"" data-date=""2019-04-19""><a href=""#"">19</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sat"" data-date=""2019-04-20""><a href=""#"">20</a></div></div><div class=""pignose-calendar-row""><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sun"" data-date=""2019-04-21""><a href=""#"">21</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-mon"" data-date=""2019-04-");
            WriteLiteral(@"22""><a href=""#"">22</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-tue"" data-date=""2019-04-23""><a href=""#"">23</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-wed"" data-date=""2019-04-24""><a href=""#"">24</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-thu"" data-date=""2019-04-25""><a href=""#"">25</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-fri"" data-date=""2019-04-26""><a href=""#"">26</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sat"" data-date=""2019-04-27""><a href=""#"">27</a></div></div><div class=""pignose-calendar-row""><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-sun"" data-date=""2019-04-28""><a href=""#"">28</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-mon"" data-date=""2019-04-29""><a href=""#"">29</a></div><div class=");
            WriteLiteral(@"""pignose-calendar-unit pignose-calendar-unit-date pignose-calendar-unit-tue"" data-date=""2019-04-30""><a href=""#"">30</a></div><div class=""pignose-calendar-unit pignose-calendar-unit-wed""></div><div class=""pignose-calendar-unit pignose-calendar-unit-thu""></div><div class=""pignose-calendar-unit pignose-calendar-unit-fri""></div><div class=""pignose-calendar-unit pignose-calendar-unit-sat""></div></div></div>											</div></div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7101, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7107, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1b4924b08984754cdc631271dccaef04b8830f17092", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7171, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7177, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1b4924b08984754cdc631271dccaef04b8830f18348", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7239, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7245, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1b4924b08984754cdc631271dccaef04b8830f19604", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7301, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7307, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1b4924b08984754cdc631271dccaef04b8830f20860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7374, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7380, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1b4924b08984754cdc631271dccaef04b8830f22116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7439, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(7444, 2, true);
            WriteLiteral("\r\n");
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
