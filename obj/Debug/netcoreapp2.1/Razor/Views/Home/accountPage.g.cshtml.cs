#pragma checksum "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c18990f25bde0ceb79277dacf923c870c3d3377"
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
#line 1 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/_ViewImports.cshtml"
using theWall;

#line default
#line hidden
#line 2 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/_ViewImports.cshtml"
using theWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c18990f25bde0ceb79277dacf923c870c3d3377", @"/Views/Home/accountPage.cshtml")]
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
            BeginContext(0, 273, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>

<div class=""wrapper"">
    ");
            EndContext();
            BeginContext(273, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "669cce554b2847ebaba4a5df22650a87", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
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
            BeginContext(325, 199, true);
            WriteLiteral("\n\n    <div class=\"body\">\n        <div class=\"accountHeader\">\n            <div class=\"pic\"></div>\n            <div class=\"userInfo\">\n                <div class=\"userNameEdit\">\n                    <h1>");
            EndContext();
            BeginContext(525, 1, true);
            WriteLiteral("@");
            EndContext();
            BeginContext(527, 28, false);
#line 13 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
                     Write(ViewBag.CurrentUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(555, 6, true);
            WriteLiteral("</h1>\n");
            EndContext();
#line 14 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
                      
                        if(ViewBag.sessionID == ViewBag.CurrentUser.UserID) {

#line default
#line hidden
            BeginContext(662, 46, true);
            WriteLiteral("                            <a class=\"editBtn\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 708, "\"", 756, 2);
            WriteAttributeValue("", 715, "/account/edit/", 715, 14, true);
#line 16 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
WriteAttributeValue("", 729, ViewBag.CurrentUser.UserID, 729, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(757, 10, true);
            WriteLiteral(">Edit</a>\n");
            EndContext();
#line 17 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(815, 75, true);
            WriteLiteral("                </div>\n                <h4>Name: </h4>\n                <h2>");
            EndContext();
            BeginContext(891, 29, false);
#line 21 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
               Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(920, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(922, 28, false);
#line 21 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
                                              Write(ViewBag.CurrentUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(950, 56, true);
            WriteLiteral("</h2>\n                <h4>Bio: </h4>\n                <p>");
            EndContext();
            BeginContext(1007, 23, false);
#line 23 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
              Write(ViewBag.CurrentUser.Bio);

#line default
#line hidden
            EndContext();
            BeginContext(1030, 50, true);
            WriteLiteral("</p>\n                <button class=\"btn button\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1127, 2);
            WriteAttributeValue("", 1087, "/connections/", 1087, 13, true);
#line 24 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
WriteAttributeValue("", 1100, ViewBag.CurrentUser.UserID, 1100, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1128, 30, true);
            WriteLiteral(">0 | Connections</a></button>\n");
            EndContext();
#line 25 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
                  
                    if(ViewBag.sessionID != ViewBag.CurrentUser.UserID) {

#line default
#line hidden
            BeginContext(1251, 89, true);
            WriteLiteral("                        <button class=\"btn btn-success\"><a href=\"\">Connect!</a></button>\n");
            EndContext();
#line 28 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(1380, 108, true);
            WriteLiteral("            </div>\n        </div>\n\n        <!-- <h3 class=\"activity\">Activity</h3> -->\n        <hr>\n        ");
            EndContext();
            BeginContext(1488, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a85d31e321a4a6bb98cd273b62bcdaa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 35 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/accountPage.cshtml"
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
            BeginContext(1542, 848, true);
            WriteLiteral(@"
    </div>
</div>

<script>
    $(document).ready(function() {
        console.log(""on ready"");

        $("".accountHeader"").mousemove(function(event) {
            console.log(""hitting mousemove"");

            var accountHeaderWidth = $("".accountHeader"").width();

            var accountHeaderHeight = $("".accountHeader"").height();

            var mouseXpercentage = Math.round(event.pageX / accountHeaderWidth * 100);
            console.log(""posX: "", event.pageX);
            var mouseYpercentage = Math.round(event.pageY / accountHeaderHeight * 100);
            console.log(""posY: "", event.pageY);
            $("".accountHeader"").css('background', 'radial-gradient(at ' + mouseXpercentage + '% ' + mouseYpercentage + '%, #e2e2e2, #4f7eff)');
            // $("".accountHeader"").replaceWith(""<p>Bitch</p>"");
        })
    })
</script>




");
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
