#pragma checksum "G:\IRRIG\Irrigation\IRRIGATION\Views\Shared\EditorTemplates\Boolean.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68767bf3954f77d1a9828b1f4adfdc281a4222cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Boolean), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Boolean.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/Boolean.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_Boolean))]
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
#line 1 "G:\IRRIG\Irrigation\IRRIGATION\Views\_ViewImports.cshtml"
using IRRIGATION;

#line default
#line hidden
#line 2 "G:\IRRIG\Irrigation\IRRIGATION\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68767bf3954f77d1a9828b1f4adfdc281a4222cc", @"/Views/Shared/EditorTemplates/Boolean.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2817374e758fd5e31f3e83f0293a7e65f4f87c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Boolean : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(18, 32, false);
#line 3 "G:\IRRIG\Irrigation\IRRIGATION\Views\Shared\EditorTemplates\Boolean.cshtml"
Write(Html.Kendo().CheckBoxFor(m => m));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool?> Html { get; private set; }
    }
}
#pragma warning restore 1591
