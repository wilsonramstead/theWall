#pragma checksum "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7405d86e4b44f3ded8bd5bf533b26402e454fa83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Connections), @"mvc.1.0.view", @"/Views/Home/Connections.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Connections.cshtml", typeof(AspNetCore.Views_Home_Connections))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7405d86e4b44f3ded8bd5bf533b26402e454fa83", @"/Views/Home/Connections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e85d71376e7dd4b508a579546d12afee24dbf16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Connections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "headerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(18, 154, true);
            WriteLiteral("\n<!-- This code is for an individual user viewing their connections, and eventually sending/recieving messages to/from them -->\n<div class=\"wrapper\">\n    ");
            EndContext();
            BeginContext(172, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3d98694015844adb325ab628060cd78", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 5 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
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
            BeginContext(224, 65, true);
            WriteLiteral("\n    <div class=\"connectBox\">\n        <h2>Your Connections</h2> \n");
            EndContext();
#line 8 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
          
            if(ViewBag.CurrentUser.MyConnections != null)
            {
                foreach(User user in ViewBag.CurrentUser.MyConnections)
                {

#line default
#line hidden
            BeginContext(462, 35, true);
            WriteLiteral("                    <h4><a href=\"\">");
            EndContext();
            BeginContext(498, 14, false);
#line 13 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
                              Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(512, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(514, 13, false);
#line 13 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
                                              Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(527, 10, true);
            WriteLiteral("</a></h4>\n");
            EndContext();
#line 14 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(600, 47, true);
            WriteLiteral("                <h4>Add some connections!</h4>\n");
            EndContext();
#line 19 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
            }
        

#line default
#line hidden
            BeginContext(671, 90, true);
            WriteLiteral("    </div>\n\n    <div class=\"connectBox\">\n        <h2>People You Are Not Connected To</h2>\n");
            EndContext();
#line 25 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
          
            if(ViewBag.notConn != null)
            {
                foreach(User person in ViewBag.notConn)
                {

#line default
#line hidden
            BeginContext(900, 35, true);
            WriteLiteral("                    <h4><a href=\"\">");
            EndContext();
            BeginContext(936, 16, false);
#line 30 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
                              Write(person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(952, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(954, 15, false);
#line 30 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
                                                Write(person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(969, 66, true);
            WriteLiteral("</a></h4>\n                    <button>Add Connection</button><br>\n");
            EndContext();
#line 32 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
                }
            }
            else
            {

#line default
#line hidden
            BeginContext(1098, 50, true);
            WriteLiteral("                <h4>You have added everyone!</h4>\n");
            EndContext();
#line 37 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/Connections.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1172, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
