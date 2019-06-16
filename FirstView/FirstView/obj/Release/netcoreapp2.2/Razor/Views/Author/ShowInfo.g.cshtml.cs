#pragma checksum "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eadf8cc1ea7b0fa03c557eb8a4e1afe2fdcc80d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_ShowInfo), @"mvc.1.0.view", @"/Views/Author/ShowInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/ShowInfo.cshtml", typeof(AspNetCore.Views_Author_ShowInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eadf8cc1ea7b0fa03c557eb8a4e1afe2fdcc80d", @"/Views/Author/ShowInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cb80dffae8aa414820a12fbd5a89972e244f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_ShowInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
  
    Layout = "_AuthorLayout";
    ViewData["Title"] = "个人信息";
    var author = Model;
    ViewData["Name"] = author.Name;

#line default
#line hidden
            BeginContext(133, 285, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 responsive-md-100"">
        <div class=""card card-outline-primary"">
            <div class=""card-header"">
                <h4 class=""m-b-0 text-white"">个人信息</h4>
            </div>
            <div class=""card-body"">
                ");
            EndContext();
            BeginContext(418, 3214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eadf8cc1ea7b0fa03c557eb8a4e1afe2fdcc80d3808", async() => {
                BeginContext(424, 505, true);
                WriteLiteral(@"
                    <div class=""form-body"">
                        <h3 class=""box-title m-t-15"">作家基本信息</h3>
                        <hr class=""m-t-0 m-b-40"">
                        <div class=""row p-t-20"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""control-label"">姓名</label>
                                    <span type=""text"" id=""name"" class=""form-control form-control-label"">");
                EndContext();
                BeginContext(930, 11, false);
#line 23 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                                                                                   Write(author.Name);

#line default
#line hidden
                EndContext();
                BeginContext(941, 428, true);
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            <!--/span-->
                            <div class=""col-md-6"">
                                <div class=""form-group has-danger"">
                                    <label class=""control-label"">ID</label>
                                    <span type=""text"" id=""id"" class=""form-control form-control-danger"">");
                EndContext();
                BeginContext(1370, 9, false);
#line 30 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                                                                                  Write(author.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1379, 685, true);
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            
                            <!--/span-->
                        </div>
                        <h3 class=""box-title"">其他信息</h3>
                        <hr class=""m-t-0 m-b-40"">
                        <!--/row-->

                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group has-danger"">
                                    <label class=""control-label"">联系电话</label>
                                    <span type=""text"" id=""phone"" class=""form-control form-control-danger"">");
                EndContext();
                BeginContext(2065, 12, false);
#line 44 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                                                                                     Write(author.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(2077, 393, true);
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group has-danger"">
                                    <label class=""control-label"">联系地址</label>
                                    <span type=""text"" id=""address"" class=""form-control form-control-danger"">");
                EndContext();
                BeginContext(2471, 14, false);
#line 50 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                                                                                       Write(author.Address);

#line default
#line hidden
                EndContext();
                BeginContext(2485, 287, true);
                WriteLiteral(@"</span>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group has-danger"">
                                    <label class=""control-label"">是否签订合同</label>
");
                EndContext();
#line 56 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                      
                                        if (author.IsContact == "1")
                                        {

#line default
#line hidden
                BeginContext(2925, 128, true);
                WriteLiteral("                                            <span type=\"text\" id=\"isContact\" class=\"form-control form-control-danger\">是</span>\r\n");
                EndContext();
#line 60 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                        }

                                        if (author.IsContact == "0")
                                        {

#line default
#line hidden
                BeginContext(3211, 128, true);
                WriteLiteral("                                            <span type=\"text\" id=\"isContact\" class=\"form-control form-control-danger\">否</span>\r\n");
                EndContext();
#line 65 "D:\GitHub\FirstView\FirstView\Views\Author\ShowInfo.cshtml"
                                        }
                                                
                                    

#line default
#line hidden
                BeginContext(3471, 154, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3632, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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