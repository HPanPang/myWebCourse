#pragma checksum "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\Select.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac6c8e55204dd3e2a2f0e9cb5b01e401a4828777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Select), @"mvc.1.0.view", @"/Views/Student/Select.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Select.cshtml", typeof(AspNetCore.Views_Student_Select))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6c8e55204dd3e2a2f0e9cb5b01e401a4828777", @"/Views/Student/Select.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8cfc321d0be8e2dfa3fc1bb45d45d705eb3c08a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Select : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\Select.cshtml"
  
    Layout = "_StudentLayout";
    ViewData["Title"] = "选课界面";
    var student = Model;
    ViewData["StudentName"] = student.StuName;
    ViewData["StuId"] = student.StuId;

#line default
#line hidden
            BeginContext(186, 57, true);
            WriteLiteral("\r\n<div class=\"alert alert-primary text-center\">\r\n    现在是 ");
            EndContext();
            BeginContext(244, 12, false);
#line 10 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Student\Select.cshtml"
   Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(256, 18, true);
            WriteLiteral(" 不能选该类课程！！\r\n</div>");
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
