#pragma checksum "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\Connections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bac47d5bad1aeb618439f79630b1b06a9dd5eb2"
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
#line 1 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\_ViewImports.cshtml"
using theWall;

#line default
#line hidden
#line 2 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\_ViewImports.cshtml"
using theWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bac47d5bad1aeb618439f79630b1b06a9dd5eb2", @"/Views/Home/Connections.cshtml")]
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
            BeginContext(19, 141, true);
            WriteLiteral("\r\n<!-- This code is for an individual user viewing their connections, and eventually sending/recieving messages to/from them -->\r\n<div>\r\n    ");
            EndContext();
            BeginContext(160, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "449b9d49238041f8982706a51f151444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 5 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\Connections.cshtml"
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
            BeginContext(212, 34, true);
            WriteLiteral("\r\n    <h2>Your Connections</h2> \r\n");
            EndContext();
#line 7 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\Connections.cshtml"
      
        foreach(User user in ViewBag.allConn)
        {

#line default
#line hidden
            BeginContext(312, 27, true);
            WriteLiteral("            <h4><a href=\"\">");
            EndContext();
            BeginContext(340, 14, false);
#line 10 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\Connections.cshtml"
                      Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(354, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(356, 13, false);
#line 10 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\Connections.cshtml"
                                      Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(369, 15, true);
            WriteLiteral("</a></h4><br>\r\n");
            EndContext();
#line 11 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\Connections.cshtml"
        }
    

#line default
#line hidden
            BeginContext(402, 6, true);
            WriteLiteral("</div>");
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
