#pragma checksum "C:\New folder\count1\Views\Link\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f9b500d2f6abaf12a8e791341fb6e34d678cbbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Link_History), @"mvc.1.0.view", @"/Views/Link/History.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Link/History.cshtml", typeof(AspNetCore.Views_Link_History))]
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
#line 1 "C:\New folder\count1\Views\_ViewImports.cshtml"
using Coun;

#line default
#line hidden
#line 2 "C:\New folder\count1\Views\_ViewImports.cshtml"
using Coun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9b500d2f6abaf12a8e791341fb6e34d678cbbc", @"/Views/Link/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb40e82151cc29a1199b74b7e9689e83beeb3b02", @"/Views/_ViewImports.cshtml")]
    public class Views_Link_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center-align"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 238, true);
            WriteLiteral("<div class=\"card\">\r\n<div class=\"container center-align\">\r\n    <br>\r\n    <h5 class=\"dh right-align\">މާމިގިލީ ގައި ހުރި މުހިންމު ތަންތަނުގެ މަޢުލޫމާތު</h5>\r\n\r\n<hr>\r\n        <div class=\"row\">\r\n            <div class=\"col s12 center-align\">\r\n");
            EndContext();
#line 9 "C:\New folder\count1\Views\Link\History.cshtml"
                      foreach (var item in  ViewBag.history)
        {

#line default
#line hidden
            BeginContext(311, 58, true);
            WriteLiteral("            <h6 class=\" dh right-align\">\r\n                ");
            EndContext();
            BeginContext(370, 10, false);
#line 12 "C:\New folder\count1\Views\Link\History.cshtml"
           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(380, 33, true);
            WriteLiteral("\r\n            </h6>\r\n            ");
            EndContext();
            BeginContext(413, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea31ed19c328497abf1eafcc5292995a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 423, "~/LinkPic/", 423, 10, true);
#line 14 "C:\New folder\count1\Views\Link\History.cshtml"
AddHtmlAttributeValue("", 433, item.ImgUrl, 433, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(469, 102, true);
            WriteLiteral("\r\n            <p class=\"dh right-align\" style=\"direction: rtl;text-align: justify;\">\r\n                ");
            EndContext();
            BeginContext(572, 9, false);
#line 16 "C:\New folder\count1\Views\Link\History.cshtml"
           Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(581, 56, true);
            WriteLiteral("\r\n            </p>\r\n            <br>\r\n            <hr>\r\n");
            EndContext();
#line 20 "C:\New folder\count1\Views\Link\History.cshtml"
           
        }

#line default
#line hidden
            BeginContext(661, 57, true);
            WriteLiteral("            </div>\r\n   \r\n        </div>\r\n\r\n</div>\r\n</div>");
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
