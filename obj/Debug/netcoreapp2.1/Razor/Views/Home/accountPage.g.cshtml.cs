#pragma checksum "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d647ff6632300171894527edad2d17fa8a5aa12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_accountPage), @"mvc.1.0.view", @"/Views/Home/accountPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/accountPage.cshtml", typeof(AspNetCore.Views_Home_accountPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d647ff6632300171894527edad2d17fa8a5aa12", @"/Views/Home/accountPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e85d71376e7dd4b508a579546d12afee24dbf16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_accountPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "headerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "newsFeedPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 278, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>

<div class=""wrapper"">
    ");
            EndContext();
            BeginContext(278, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "146645c9fe714e86ac21829a0fae4538", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(330, 207, true);
            WriteLiteral("\r\n\r\n    <div class=\"body\">\r\n        <div class=\"accountHeader\" >\r\n            <div class=\"pic\"></div>\r\n            <div class=\"userInfo\">\r\n                <div class=\"userNameEdit\">\r\n                    <h1>");
            EndContext();
            BeginContext(538, 1, true);
            WriteLiteral("@");
            EndContext();
            BeginContext(540, 28, false);
#line 13 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                     Write(ViewBag.CurrentUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(568, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 14 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                      
                        if(ViewBag.sessionID == ViewBag.CurrentUser.UserID) {

#line default
#line hidden
            BeginContext(678, 47, true);
            WriteLiteral("                            <a class=\"colorBtn\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 725, "\"", 774, 2);
            WriteAttributeValue("", 732, "/account/color/", 732, 15, true);
#line 16 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
WriteAttributeValue("", 747, ViewBag.CurrentUser.UserID, 747, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 65, true);
            WriteLiteral(">Change Color</a>\r\n                            <a class=\"editBtn\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 840, "\"", 888, 2);
            WriteAttributeValue("", 847, "/account/edit/", 847, 14, true);
#line 17 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
WriteAttributeValue("", 861, ViewBag.CurrentUser.UserID, 861, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(889, 11, true);
            WriteLiteral(">Edit</a>\r\n");
            EndContext();
#line 18 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(950, 77, true);
            WriteLiteral("                </div>\r\n                <h4>Name: </h4>\r\n                <h2>");
            EndContext();
            BeginContext(1028, 29, false);
#line 22 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
               Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1059, 28, false);
#line 22 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                                              Write(ViewBag.CurrentUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 58, true);
            WriteLiteral("</h2>\r\n                <h4>Bio: </h4>\r\n                <p>");
            EndContext();
            BeginContext(1146, 23, false);
#line 24 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
              Write(ViewBag.CurrentUser.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 51, true);
            WriteLiteral("</p>\r\n                <button class=\"btn button\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1220, "\"", 1267, 2);
            WriteAttributeValue("", 1227, "/connections/", 1227, 13, true);
#line 25 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
WriteAttributeValue("", 1240, ViewBag.CurrentUser.UserID, 1240, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1268, 31, true);
            WriteLiteral(">0 | Connections</a></button>\r\n");
            EndContext();
#line 26 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                  
                    if(ViewBag.sessionID != ViewBag.CurrentUser.UserID) {

#line default
#line hidden
            BeginContext(1394, 58, true);
            WriteLiteral("                        <button class=\"btn btn-success\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1520, 4);
            WriteAttributeValue("", 1459, "/addConnection/", 1459, 15, true);
#line 28 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
WriteAttributeValue("", 1474, ViewBag.sessionID, 1474, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1492, "/", 1492, 1, true);
#line 28 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
WriteAttributeValue("", 1493, ViewBag.CurrentUser.UserID, 1493, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1521, 24, true);
            WriteLiteral(">Connect!</a></button>\r\n");
            EndContext();
#line 29 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                        //added href, now button works
                    }
                

#line default
#line hidden
            BeginContext(1643, 113, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <!-- <h3 class=\"activity\">Activity</h3> -->\r\n        <hr>\r\n        ");
            EndContext();
            BeginContext(1756, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f090901849e4e4a8d3e5323fe78bfc5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 37 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1810, 57, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var currentUser = \'");
            EndContext();
            BeginContext(1869, 19, false);
#line 42 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                   Write(ViewBag.CurrentUser);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 24, true);
            WriteLiteral("\';\r\n    var colorRed = \'");
            EndContext();
            BeginContext(1915, 28, false);
#line 43 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                Write(ViewBag.CurrentUser.ColorRed);

#line default
#line hidden
            EndContext();
            BeginContext(1944, 26, true);
            WriteLiteral("\';\r\n    var colorGreen = \'");
            EndContext();
            BeginContext(1972, 30, false);
#line 44 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                  Write(ViewBag.CurrentUser.ColorGreen);

#line default
#line hidden
            EndContext();
            BeginContext(2003, 25, true);
            WriteLiteral("\';\r\n    var colorBlue = \'");
            EndContext();
            BeginContext(2030, 29, false);
#line 45 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\accountPage.cshtml"
                 Write(ViewBag.CurrentUser.ColorBlue);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 1189, true);
            WriteLiteral(@"';

    console.log(""currentUser: "", currentUser);
    console.log(""colorRed: "", colorRed);

    $(document).ready(function() {
        console.log(""on ready"");
        $('.accountHeader').css('background', 'rgb(' + colorRed + ', ' + colorGreen + ', ' + colorBlue + ')');
        $('.accountHeader').css('background', 'radial-gradient( at center, #dce5ff, rgb(' + colorRed + ', ' + colorGreen + ', ' + colorBlue + ')');

        $("".accountHeader"").mousemove(function(event) {
            console.log(""hitting mousemove"");

            var accountHeaderWidth = $("".accountHeader"").width();

            var accountHeaderHeight = $("".accountHeader"").height();

            var mouseXpercentage = Math.round(event.pageX / accountHeaderWidth * 100);
            console.log(""posX: "", event.pageX);
            var mouseYpercentage = Math.round(event.pageY / accountHeaderHeight * 100);
            console.log(""posY: "", event.pageY);
            $("".accountHeader"").css('background', 'radial-gradient(at ' ");
            WriteLiteral("+ mouseXpercentage + \'% \' + mouseYpercentage + \'%, #e2e2e2, rgb(\' + colorRed + \', \' + colorGreen + \', \' + colorBlue + \'))\');\r\n        })\r\n    })\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
