#pragma checksum "/home/munnim/Desktop/Maa/Views/Home/Target.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f242dd66e0e8f776f7eca3286fb48e50a1523dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Target), @"mvc.1.0.view", @"/Views/Home/Target.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Target.cshtml", typeof(AspNetCore.Views_Home_Target))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f242dd66e0e8f776f7eca3286fb48e50a1523dfa", @"/Views/Home/Target.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Target : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 124, true);
            WriteLiteral("<div class=\"card\">\n<div class=\"container\">\n    <br>\n    <h5 class=\" dh right-align\">މިސަން އަދި ވިޝަން</h5>\n    <hr>\n<div>\n\n");
            EndContext();
#line 8 "/home/munnim/Desktop/Maa/Views/Home/Target.cshtml"
 foreach (var item in ViewBag.mission)
{

#line default
#line hidden
            BeginContext(165, 55, true);
            WriteLiteral("    <h5 class=\"dh right-align\" style=\"direction: rtl;\">");
            EndContext();
            BeginContext(221, 10, false);
#line 10 "/home/munnim/Desktop/Maa/Views/Home/Target.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(231, 72, true);
            WriteLiteral("</h5>\n    <p class=\"dh right-align overflow-wrap: break-word;\">\n        ");
            EndContext();
            BeginContext(304, 9, false);
#line 12 "/home/munnim/Desktop/Maa/Views/Home/Target.cshtml"
   Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(313, 10, true);
            WriteLiteral("\n    </p>\n");
            EndContext();
#line 14 "/home/munnim/Desktop/Maa/Views/Home/Target.cshtml"
}

#line default
#line hidden
            BeginContext(325, 28, true);
            WriteLiteral("\n\n\n<br>\n</div>\n</div>\n</div>");
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
