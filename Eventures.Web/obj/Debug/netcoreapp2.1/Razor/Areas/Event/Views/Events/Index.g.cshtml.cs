#pragma checksum "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e646a97c93cc159d34a8e09b4b22bf9f16fcb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Event_Views_Events_Index), @"mvc.1.0.view", @"/Areas/Event/Views/Events/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Event/Views/Events/Index.cshtml", typeof(AspNetCore.Areas_Event_Views_Events_Index))]
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
#line 1 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Events\Index.cshtml"
using Eventures.Web.Areas.Event.Components;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e646a97c93cc159d34a8e09b4b22bf9f16fcb2", @"/Areas/Event/Views/Events/Index.cshtml")]
    public class Areas_Event_Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventures.Web.Areas.Event.ViewModels.EventureEventViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(135, 31, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(167, 52, false);
#line 8 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Events\Index.cshtml"
Write(await Component.InvokeAsync(typeof(EventsComponent)));

#line default
#line hidden
            EndContext();
            BeginContext(219, 9, true);
            WriteLiteral(";\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eventures.Web.Areas.Event.ViewModels.EventureEventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
