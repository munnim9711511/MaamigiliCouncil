#pragma checksum "D:\desk\count1\Views\Admin\UpdateNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc01cad3194d910fa5721743f5c953eed5c04131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateNews), @"mvc.1.0.view", @"/Views/Admin/UpdateNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UpdateNews.cshtml", typeof(AspNetCore.Views_Admin_UpdateNews))]
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
#line 1 "D:\desk\count1\Views\_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "D:\desk\count1\Views\_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc01cad3194d910fa5721743f5c953eed5c04131", @"/Views/Admin/UpdateNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\desk\count1\Views\Admin\UpdateNews.cshtml"
  
    Layout="~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(57, 77, true);
            WriteLiteral("\r\n<div ng-controller = \"updateNews\">\r\n     \r\n<ul style=\"font-size: large;\">\r\n");
            EndContext();
#line 8 "D:\desk\count1\Views\Admin\UpdateNews.cshtml"
     foreach (var item in ViewBag.news )
{

#line default
#line hidden
            BeginContext(179, 27, true);
            WriteLiteral("  <li class=\"dh\">\r\n      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 206, "\"", 262, 1);
#line 11 "D:\desk\count1\Views\Admin\UpdateNews.cshtml"
WriteAttributeValue("", 213, Url.Action("UpdateNew","Admin",new{id=@item.Id}), 213, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(263, 98, true);
            WriteLiteral(">\r\n           <span>\r\n <strong>\r\n          Title:\r\n\r\n      </strong>\r\n      </span>\r\n     \r\n      ");
            EndContext();
            BeginContext(362, 10, false);
#line 19 "D:\desk\count1\Views\Admin\UpdateNews.cshtml"
 Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(372, 103, true);
            WriteLiteral("\r\n\r\n\r\n           <span>\r\n <strong>\r\n          Date:\r\n          \r\n      </strong>\r\n      </span>\r\n      ");
            EndContext();
            BeginContext(476, 9, false);
#line 28 "D:\desk\count1\Views\Admin\UpdateNews.cshtml"
 Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(485, 30, true);
            WriteLiteral("\r\n      </a>\r\n     \r\n  </li>\r\n");
            EndContext();
#line 32 "D:\desk\count1\Views\Admin\UpdateNews.cshtml"
}

#line default
#line hidden
            BeginContext(518, 17, true);
            WriteLiteral("</ul>\r\n\r\n\r\n</div>");
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
