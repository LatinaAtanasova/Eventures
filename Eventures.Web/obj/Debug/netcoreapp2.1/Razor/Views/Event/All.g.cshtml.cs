#pragma checksum "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "422e0f1a4886d1146f85c2a36b0de53ba9713efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_All), @"mvc.1.0.view", @"/Views/Event/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/All.cshtml", typeof(AspNetCore.Views_Event_All))]
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
#line 1 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
using Eventures.Web.ViewModels.Orders;

#line default
#line hidden
#line 4 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#line 5 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422e0f1a4886d1146f85c2a36b0de53ba9713efe", @"/Views/Event/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3428bdf125acf975ca773013d873ea22e5318a61", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Eventures.Web.ViewModels.Events.EventViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(226, 456, true);
            WriteLiteral(@"


<h2 style=""text-align: center; font-weight: bold"">All Events</h2>

<div class=""container"">
    <hr style=""height: 3px; background-color: #66ffff"" />
    <table class=""table table-hover"">

        <thead>
        <tr style=""font-weight: bold"">
            <th>#</th>
            <th>Name</th>
            <th>Start</th>
            <th>End</th>
            <th>Actions</th>
        </tr>
        </thead>
        <tbody>
            
");
            EndContext();
#line 31 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
          
            var counter = (int)ViewBag.OnePageOfEvents.PageSize * (int)ViewBag.OnePageOfEvents.PageNumber + 1 - (int)ViewBag.OnePageOfEvents.PageSize;
        

#line default
#line hidden
            BeginContext(857, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 34 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
         foreach (var item in ViewBag.OnePageOfEvents)
            {

#line default
#line hidden
            BeginContext(928, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(975, 7, false);
#line 37 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
                   Write(counter);

#line default
#line hidden
            EndContext();
            BeginContext(982, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1014, 9, false);
#line 38 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1055, 10, false);
#line 39 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
                   Write(item.Start);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1097, 8, false);
#line 40 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
                   Write(item.End);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1163, 179, false);
#line 42 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
                   Write(await Html.PartialAsync("_CreateOrderPartial", new CreateOrderViewModel
                        {
                            EventId = @item.EventId
                        }));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"

                counter++;
            }

#line default
#line hidden
            BeginContext(1439, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(1476, 96, false);
#line 53 "F:\Latina DOCs\CSharp\ASP.NET Core\2.EXERCISE FILTERS_MIDDLEWARE\Eventures.Web\Eventures.Web\Views\Event\All.cshtml"
Write(Html.PagedListPager((IPagedList) ViewBag.OnePageOfEvents, page => Url.Action("All", new {page})));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 73, true);
            WriteLiteral("\r\n\r\n    <hr style=\"height: 3px; background-color: #66ffff\" />\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Eventures.Web.ViewModels.Events.EventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591