#pragma checksum "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4319d5af33b0ef671224e2ef13b034d5a93297d"
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
#line 1 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\_ViewImports.cshtml"
using theWall;

#line default
#line hidden
#line 2 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\_ViewImports.cshtml"
using theWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4319d5af33b0ef671224e2ef13b034d5a93297d", @"/Views/Home/newsFeedPartial.cshtml")]
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(18, 50, true);
            WriteLiteral("\r\n<div class=\"body\">\r\n    <div class=\"messages\">\r\n");
            EndContext();
#line 6 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
          
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
            BeginContext(346, 26, true);
            WriteLiteral("                    <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 372, "\"", 405, 2);
            WriteAttributeValue("", 379, "/account/", 379, 9, true);
#line 16 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
WriteAttributeValue("", 388, m.Creator.UserID, 388, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(406, 22, true);
            WriteLiteral("><span class=\"atSign\">");
            EndContext();
            BeginContext(429, 8, true);
            WriteLiteral("@</span>");
            EndContext();
            BeginContext(438, 18, false);
#line 16 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                                                                                      Write(m.Creator.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(456, 9, true);
            WriteLiteral(" </a>  - ");
            EndContext();
            BeginContext(466, 4, false);
#line 16 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                                                                                                                  Write(date);

#line default
#line hidden
            EndContext();
            BeginContext(470, 46, true);
            WriteLiteral("</h4>\r\n                    <p class=\"content\">");
            EndContext();
            BeginContext(517, 9, false);
#line 17 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                                  Write(m.Content);

#line default
#line hidden
            EndContext();
            BeginContext(526, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                    
        
                    if(@m.Comments != null)
                    {

#line default
#line hidden
            BeginContext(632, 62, true);
            WriteLiteral("                        <p class=\"comContent\">Comments: </p>\r\n");
            EndContext();
#line 23 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                        foreach(Comment c in m.Comments)
                        {
                            var commentDATE = c.CreatedAt.ToString("MMMM dd yyyy");

#line default
#line hidden
            BeginContext(864, 92, true);
            WriteLiteral("                            <div class=\"comContent\">\r\n                                <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 956, "\"", 981, 2);
            WriteAttributeValue("", 963, "/account/", 963, 9, true);
#line 27 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
WriteAttributeValue("", 972, c.UserID, 972, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(982, 22, true);
            WriteLiteral("><span class=\"atSign\">");
            EndContext();
            BeginContext(1005, 8, true);
            WriteLiteral("@</span>");
            EndContext();
            BeginContext(1014, 15, false);
#line 27 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                                                                                          Write(c.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 7, true);
            WriteLiteral("</a> - ");
            EndContext();
            BeginContext(1037, 11, false);
#line 27 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                                                                                                                 Write(commentDATE);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(1091, 12, false);
#line 28 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                              Write(c.comContent);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 30 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1195, 68, true);
            WriteLiteral("                    <div class=\"comments\">\r\n                        ");
            EndContext();
            BeginContext(1263, 662, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a87219b6be8346498bcb7b943036970b", async() => {
                BeginContext(1332, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1362, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fdada627f74e1e9c9913432179cf19", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 34 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
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
                BeginContext(1407, 114, true);
                WriteLiteral("\r\n                            <p><label for=\"comment\">Post a comment</label></p> \r\n                            <p>");
                EndContext();
                BeginContext(1521, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adf7a25ad7a6454ebf63d8b81d9243e8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 36 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
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
                BeginContext(1596, 34, true);
                WriteLiteral("</p>\r\n                            ");
                EndContext();
                BeginContext(1630, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba3b4c2684f347d98a41acef5d213f82", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MessageID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
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
                BeginContext(1692, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1722, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62816c0ad6554723ad014467d7924934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 38 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 38 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
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
                BeginContext(1796, 122, true);
                WriteLiteral("\r\n                            <input class=\"btn btn-success\" type=\"submit\" value=\"Post comment\">\r\n                        ");
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
            BeginContext(1925, 59, true);
            WriteLiteral("\r\n                    </div>   \r\n                    <hr>\r\n");
            EndContext();
#line 43 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\theWall\Views\Home\newsFeedPartial.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(2029, 22, true);
            WriteLiteral("        </div>\r\n</div>");
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
