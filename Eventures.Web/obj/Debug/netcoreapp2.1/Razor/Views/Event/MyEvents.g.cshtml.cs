#pragma checksum "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef553dc3887b4ee87d84706a919da1811bd18d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_MyEvents), @"mvc.1.0.view", @"/Views/Event/MyEvents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/MyEvents.cshtml", typeof(AspNetCore.Views_Event_MyEvents))]
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
#line 1 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Web;

#line default
#line hidden
#line 2 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\_ViewImports.cshtml"
using Eventures.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef553dc3887b4ee87d84706a919da1811bd18d9d", @"/Views/Event/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3428bdf125acf975ca773013d873ea22e5318a61", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_MyEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventures.Web.ViewModels.Events.MyEventsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
  
    ViewData["Title"] = "My Events";

#line default
#line hidden
            BeginContext(106, 52, true);
            WriteLiteral("\r\n<h2 style=\"text-align: center; font-weight: bold\">");
            EndContext();
            BeginContext(159, 17, false);
#line 7 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
                                             Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(176, 394, true);
            WriteLiteral(@"</h2>

<div class=""container"">
    <hr style=""height: 3px; background-color: #66ffff"" />
    <table class=""table table-hover"">
        <thead>
        <tr style=""font-weight: bold"">
            <th>#</th>
            <th>Name</th>
            <th>Start</th>
            <th>End</th>
            <th>Tickets</th>
        </tr>
        </thead>
        <tbody>
        
        
");
            EndContext();
#line 24 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
          
            var counter = 1;

            foreach (var item in Model.MyEvents)
            {

#line default
#line hidden
            BeginContext(679, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(726, 7, false);
#line 30 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
                   Write(counter);

#line default
#line hidden
            EndContext();
            BeginContext(733, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(765, 9, false);
#line 31 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(774, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(806, 10, false);
#line 32 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
                   Write(item.Start);

#line default
#line hidden
            EndContext();
            BeginContext(816, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(848, 8, false);
#line 33 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
                   Write(item.End);

#line default
#line hidden
            EndContext();
            BeginContext(856, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(888, 11, false);
#line 34 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"
                   Write(item.Ticket);

#line default
#line hidden
            EndContext();
            BeginContext(899, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\MyEvents.cshtml"

                counter++;
            }
        

#line default
#line hidden
            BeginContext(985, 107, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <hr style=\"height: 3px; background-color: #66ffff\" />\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventures.Web.ViewModels.Events.MyEventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
