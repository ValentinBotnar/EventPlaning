#pragma checksum "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\Meeting\GetAllMeeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "731a5857fa706f2be299b9a3a3463f29f8756edb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meeting_GetAllMeeting), @"mvc.1.0.view", @"/Views/Meeting/GetAllMeeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Meeting/GetAllMeeting.cshtml", typeof(AspNetCore.Views_Meeting_GetAllMeeting))]
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
#line 1 "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\_ViewImports.cshtml"
using RolesApp;

#line default
#line hidden
#line 2 "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\_ViewImports.cshtml"
using RolesApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"731a5857fa706f2be299b9a3a3463f29f8756edb", @"/Views/Meeting/GetAllMeeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7869fd08a8deb97f50f6a26a558e0159639b341", @"/Views/_ViewImports.cshtml")]
    public class Views_Meeting_GetAllMeeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RolesApp.Models.NameMeetingEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\Meeting\GetAllMeeting.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("<h3>Список мероприятий</h3>\r\n");
            EndContext();
#line 6 "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\Meeting\GetAllMeeting.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(148, 8, true);
            WriteLiteral("    <p> ");
            EndContext();
            BeginContext(157, 98, false);
#line 8 "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\Meeting\GetAllMeeting.cshtml"
   Write(Html.ActionLink(item.NameEvent, "GetInfoAboutMeeting", "Meeting", new { EventId = item.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(255, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "C:\Users\Valentin\Desktop\RolesApp\RolesApp\RolesApp\Views\Meeting\GetAllMeeting.cshtml"

}

#line default
#line hidden
            BeginContext(266, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RolesApp.Models.NameMeetingEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591