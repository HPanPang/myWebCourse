#pragma checksum "D:\GitHub\web_courescontrol\web_courescontrol\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93635af4e974e557e886d49bc1e534f89dc28350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Index.cshtml", typeof(AspNetCore.Views_Teacher_Index))]
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
#line 1 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Teacher\Index.cshtml"
using CourseDomain.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93635af4e974e557e886d49bc1e534f89dc28350", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8cfc321d0be8e2dfa3fc1bb45d45d705eb3c08a", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitHub\web_courescontrol\web_courescontrol\Views\Teacher\Index.cshtml"
  
    Layout = "_TeacherLayout";
    ViewData["Title"] = "主页";
    var Teacher = Model;
    ViewData["TeacherName"] = Teacher.TeacherName;


#line default
#line hidden
            BeginContext(181, 3509, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 col-lg-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Default Tab</h4>
                <!-- Nav tabs -->
                <ul class=""nav nav-tabs"" role=""tablist"">
                    <li class=""nav-item""> <a class=""nav-link active"" data-toggle=""tab"" href=""#home"" role=""tab""><span class=""hidden-sm-up""><i class=""ti-home""></i></span> <span class=""hidden-xs-down"">Home</span></a> </li>
                    <li class=""nav-item""> <a class=""nav-link"" data-toggle=""tab"" href=""#profile"" role=""tab""><span class=""hidden-sm-up""><i class=""ti-user""></i></span> <span class=""hidden-xs-down"">Profile</span></a> </li>
                    <li class=""nav-item""> <a class=""nav-link"" data-toggle=""tab"" href=""#messages"" role=""tab""><span class=""hidden-sm-up""><i class=""ti-email""></i></span> <span class=""hidden-xs-down"">Messages</span></a> </li>
                </ul>
                <!-- Tab panes -->
                <div class=");
            WriteLiteral(@"""tab-content tabcontent-border"">
                    <div class=""tab-pane active"" id=""home"" role=""tabpanel"">
                        <div class=""p-20"">
                            <h5>Best Clean Tab ever</h5>
                            <h6>you can use it with the small code</h6>
                            <p>Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a.</p>
                        </div>
                    </div>
                    <div class=""tab-pane  p-20"" id=""profile"" role=""tabpanel"">2</div>
                    <div class=""tab-pane p-20"" id=""messages"" role=""tabpanel"">3</div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-12 col-lg-6"">
        <div class=""card"">
            <div class=""card-body p-b-0"">
                <h4 class=""card-title"">Customtab Tab</h4>
                <!-- Nav tabs -->
                <ul class=""nav nav-tabs customtab"" role=""tablist"">
                   ");
            WriteLiteral(@" <li class=""nav-item""> <a class=""nav-link active"" data-toggle=""tab"" href=""#home2"" role=""tab""><span class=""hidden-sm-up""><i class=""ti-home""></i></span> <span class=""hidden-xs-down"">Home</span></a> </li>
                    <li class=""nav-item""> <a class=""nav-link"" data-toggle=""tab"" href=""#profile2"" role=""tab""><span class=""hidden-sm-up""><i class=""ti-user""></i></span> <span class=""hidden-xs-down"">Profile</span></a> </li>
                    <li class=""nav-item""> <a class=""nav-link"" data-toggle=""tab"" href=""#messages2"" role=""tab""><span class=""hidden-sm-up""><i class=""ti-email""></i></span> <span class=""hidden-xs-down"">Messages</span></a> </li>
                </ul>
                <!-- Tab panes -->
                <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""home2"" role=""tabpanel"">
                        <div class=""p-20"">
                            <h5>Best Clean Tab ever</h5>
                            <h6>you can use it with the small code</h6>
                     ");
            WriteLiteral(@"       <p>Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a.</p>
                        </div>
                    </div>
                    <div class=""tab-pane  p-20"" id=""profile2"" role=""tabpanel"">2</div>
                    <div class=""tab-pane p-20"" id=""messages2"" role=""tabpanel"">3</div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
