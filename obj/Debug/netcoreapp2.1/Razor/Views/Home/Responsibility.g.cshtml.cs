#pragma checksum "/home/munnim/Desktop/Maa/Views/Home/Responsibility.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d49a6a09b0585c4505e721afe838f2086c8b2db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Responsibility), @"mvc.1.0.view", @"/Views/Home/Responsibility.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Responsibility.cshtml", typeof(AspNetCore.Views_Home_Responsibility))]
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
#line 1 "/home/munnim/Desktop/Maa/Views/_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "/home/munnim/Desktop/Maa/Views/_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d49a6a09b0585c4505e721afe838f2086c8b2db", @"/Views/Home/Responsibility.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Responsibility : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 219, true);
            WriteLiteral("<div class=\"card\">\n<div class=\"container\">\n    <br>\n    <h5 class=\"dh right-align\">ކައުންސިލް އިދާރާގެ ޒިމްމާތައް</h5>\n    <hr>\n    <div class=\"row\">\n                <div class=\"col s12 right-align\">\n                  \n");
            EndContext();
#line 9 "/home/munnim/Desktop/Maa/Views/Home/Responsibility.cshtml"
                             foreach (var item in  ViewBag.responsibility)
        {
           
                     

#line default
#line hidden
            BeginContext(338, 77, true);
            WriteLiteral("                <h5 class=\"dh \" style=\"direction: rtl;\">\n                    ");
            EndContext();
            BeginContext(416, 10, false);
#line 14 "/home/munnim/Desktop/Maa/Views/Home/Responsibility.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(426, 142, true);
            WriteLiteral("\n                </h5>\n                <hr>\n                <p class=\"dh\" style=\"direction: rtl; overflow-wrap: break-word;\">\n                ");
            EndContext();
            BeginContext(569, 9, false);
#line 18 "/home/munnim/Desktop/Maa/Views/Home/Responsibility.cshtml"
           Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(578, 22, true);
            WriteLiteral("\n                </p>\n");
            EndContext();
#line 20 "/home/munnim/Desktop/Maa/Views/Home/Responsibility.cshtml"
                   
                        
                     

                      
                      
        }

#line default
#line hidden
            BeginContext(724, 66, true);
            WriteLiteral("                  \n                </div>\n    </div>\n</div>\n</div>");
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
