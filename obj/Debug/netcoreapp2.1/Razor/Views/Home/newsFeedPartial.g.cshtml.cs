#pragma checksum "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ae2541219fd9973d43d5f58ebe40e327d014b34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_newsFeedPartial), @"mvc.1.0.view", @"/Views/Home/newsFeedPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/newsFeedPartial.cshtml", typeof(AspNetCore.Views_Home_newsFeedPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae2541219fd9973d43d5f58ebe40e327d014b34", @"/Views/Home/newsFeedPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e85d71376e7dd4b508a579546d12afee24dbf16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_newsFeedPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(16, 47, true);
            WriteLiteral("\n<div class=\"body\">\n    <div class=\"messages\">\n");
            EndContext();
#line 6 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
          
            if(ViewBag.allMessages == null)
            {
        
            }
            else
            {
                foreach(Message m in ViewBag.allMessages)
                {
                    var date = m.CreatedAt.ToString("MMMM dd yyyy");

#line default
#line hidden
            BeginContext(331, 26, true);
            WriteLiteral("                    <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 357, "\"", 390, 2);
            WriteAttributeValue("", 364, "/account/", 364, 9, true);
#line 16 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
WriteAttributeValue("", 373, m.Creator.UserID, 373, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(391, 22, true);
            WriteLiteral("><span class=\"atSign\">");
            EndContext();
            BeginContext(414, 8, true);
            WriteLiteral("@</span>");
            EndContext();
            BeginContext(423, 18, false);
#line 16 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                                                                      Write(m.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(441, 9, true);
            WriteLiteral(" </a>  - ");
            EndContext();
            BeginContext(451, 4, false);
#line 16 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                                                                                                  Write(date);

#line default
#line hidden
            EndContext();
            BeginContext(455, 45, true);
            WriteLiteral("</h4>\n                    <p class=\"content\">");
            EndContext();
            BeginContext(501, 9, false);
#line 17 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                  Write(m.Content);

#line default
#line hidden
            EndContext();
            BeginContext(510, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 18 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                    
        
                    if(@m.Comments != null)
                    {

#line default
#line hidden
            BeginContext(611, 61, true);
            WriteLiteral("                        <p class=\"comContent\">Comments: </p>\n");
            EndContext();
#line 23 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                        foreach(Comment c in m.Comments)
                        {
                            var commentDATE = c.CreatedAt.ToString("MMMM dd yyyy");

#line default
#line hidden
            BeginContext(839, 89, true);
            WriteLiteral("                            <div class=\"comContent\">\n                                <h4>");
            EndContext();
            BeginContext(929, 16, false);
#line 27 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                               Write(c.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(945, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(947, 15, false);
#line 27 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                                 Write(c.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(962, 2, true);
            WriteLiteral("- ");
            EndContext();
            BeginContext(965, 11, false);
#line 27 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                                                   Write(commentDATE);

#line default
#line hidden
            EndContext();
            BeginContext(976, 41, true);
            WriteLiteral("</h4>\n                                <p>");
            EndContext();
            BeginContext(1018, 12, false);
#line 28 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                              Write(c.comContent);

#line default
#line hidden
            EndContext();
            BeginContext(1030, 40, true);
            WriteLiteral("</p>\n                            </div>\n");
            EndContext();
#line 30 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1118, 67, true);
            WriteLiteral("                    <div class=\"comments\">\n                        ");
            EndContext();
            BeginContext(1185, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03e23d3a24a4f9ba66b6268fb5f8968", async() => {
                BeginContext(1254, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1283, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cc786f0bae0420aa16621f4bdf9fe59", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 34 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.comContent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1328, 112, true);
                WriteLiteral("\n                            <p><label for=\"comment\">Post a comment</label></p> \n                            <p>");
                EndContext();
                BeginContext(1440, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47545f3b92bc414389c6cbdef2b643c9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 36 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.comContent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1515, 33, true);
                WriteLiteral("</p>\n                            ");
                EndContext();
                BeginContext(1548, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41678bdf150648e692a2f195425891a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MessageID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 37 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                                  WriteLiteral(m.MessageID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1610, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1639, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "225d41a159a74a918cabe417c8b911e7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 38 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 38 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                                               WriteLiteral(ViewBag.CurrentUser.UserID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1713, 120, true);
                WriteLiteral("\n                            <input class=\"btn btn-success\" type=\"submit\" value=\"Post comment\">\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1840, 56, true);
            WriteLiteral("\n                    </div>   \n                    <hr>\n");
            EndContext();
#line 43 "/Users/wilsonramstead/Desktop/CodingDojo/stacks/C#/ORMs/belt_prep/theWall/Views/Home/newsFeedPartial.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(1938, 21, true);
            WriteLiteral("        </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
