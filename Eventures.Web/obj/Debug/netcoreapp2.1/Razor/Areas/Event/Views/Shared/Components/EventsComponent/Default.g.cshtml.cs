#pragma checksum "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac526665fc85591328acb7ce0b6db47f0674804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Event_Views_Shared_Components_EventsComponent_Default), @"mvc.1.0.view", @"/Areas/Event/Views/Shared/Components/EventsComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Event/Views/Shared/Components/EventsComponent/Default.cshtml", typeof(AspNetCore.Areas_Event_Views_Shared_Components_EventsComponent_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac526665fc85591328acb7ce0b6db47f0674804", @"/Areas/Event/Views/Shared/Components/EventsComponent/Default.cshtml")]
    public class Areas_Event_Views_Shared_Components_EventsComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventures.Web.Areas.Event.ViewModels.EventureEventViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
 foreach (var eventureEvent in Model)
{

#line default
#line hidden
            BeginContext(134, 35, true);
            WriteLiteral("    <div class=\"row\">\r\n        <h3>");
            EndContext();
            BeginContext(170, 18, false);
#line 9 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
       Write(eventureEvent.Name);

#line default
#line hidden
            EndContext();
            BeginContext(188, 19, true);
            WriteLiteral("</h3>\r\n        <h3>");
            EndContext();
            BeginContext(208, 19, false);
#line 10 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
       Write(eventureEvent.Place);

#line default
#line hidden
            EndContext();
            BeginContext(227, 19, true);
            WriteLiteral("</h3>\r\n    </div>\r\n");
            EndContext();
#line 12 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
}

#line default
#line hidden
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
