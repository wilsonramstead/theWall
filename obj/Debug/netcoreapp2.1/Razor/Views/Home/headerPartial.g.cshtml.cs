#pragma checksum "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\headerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662592453670b87f67194e45bdf35ee204a97259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_headerPartial), @"mvc.1.0.view", @"/Views/Home/headerPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/headerPartial.cshtml", typeof(AspNetCore.Views_Home_headerPartial))]
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
#line 1 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\_ViewImports.cshtml"
using theWall;

#line default
#line hidden
#line 2 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\_ViewImports.cshtml"
using theWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662592453670b87f67194e45bdf35ee204a97259", @"/Views/Home/headerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e85d71376e7dd4b508a579546d12afee24dbf16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_headerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 270, true);
            WriteLiteral(@"
<link href=""https://fonts.googleapis.com/css?family=Blinker|Montserrat|Red+Hat+Display|Roboto+Slab&display=swap"" rel=""stylesheet"">

<div class=""theWall"">
    <div class=""header"">
        <h1>The Wall</h1>
        <div class=""headright"">
            <h4>Welcome, ");
            EndContext();
            BeginContext(271, 29, false);
#line 8 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\headerPartial.cshtml"
                    Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(300, 183, true);
            WriteLiteral("</h4>\r\n            <a href=\"/logout\">Log Out</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<nav id=\"navbar\" class=\"navbar-dark\">\r\n    <div class=\"tags\">\r\n        <ul>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 483, "\"", 528, 2);
            WriteAttributeValue("", 490, "/dashboard/", 490, 11, true);
#line 17 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\headerPartial.cshtml"
WriteAttributeValue("", 501, ViewBag.CurrentUser.UserID, 501, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(529, 86, true);
            WriteLiteral(">News Feed</a></li>\r\n            <li><a href=\"\">Messaging</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 615, "\"", 658, 2);
            WriteAttributeValue("", 622, "/account/", 622, 9, true);
#line 19 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\headerPartial.cshtml"
WriteAttributeValue("", 631, ViewBag.CurrentUser.UserID, 631, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 51, true);
            WriteLiteral(">MyPage</a></li>\r\n        </ul>\r\n    </div>\r\n</nav>");
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
