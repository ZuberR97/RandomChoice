#pragma checksum "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\randomGame\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04b1c7903f4fe178036c9bf74683198e82e5eef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\randomGame\Views\_ViewImports.cshtml"
using randomGame;

#line default
#line hidden
#line 2 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\randomGame\Views\_ViewImports.cshtml"
using randomGame.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04b1c7903f4fe178036c9bf74683198e82e5eef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baf9329283b5cd92dfe53e22f81467d154c32fcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("process"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 280, true);
            WriteLiteral(@"<div class=""wrapper"">
    <div class=""title"">
        <h1>Random choice maker</h1>
        <h2>Works for games, shows, books, etc.</h2>
    </div>
    <div class=""form"">
        <h3>Please enter at least 3 activities of any category that you would like to do.</h3>
        ");
            EndContext();
            BeginContext(280, 2105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a92f11177db84d33b9965fe78416d592", async() => {
                BeginContext(317, 2061, true);
                WriteLiteral(@"
            <div class=""formside"">
                <label for=""choice1"">Possible Outcome #1: </label>
                <input type=""text"" name=""choice1""><br>
                <label for=""choice2"">Possible Outcome #2: </label>
                <input type=""text"" name=""choice2""><br>
                <label for=""choice3"">Possible Outcome #3: </label>
                <input type=""text"" name=""choice3""><br>
                <label for=""choice4"">Possible Outcome #4: </label>
                <input type=""text"" name=""choice4""><br>
                <label for=""choice5"">Possible Outcome #5: </label>
                <input type=""text"" name=""choice5""><br>
                <label for=""choice6"">Possible Outcome #6: </label>
                <input type=""text"" name=""choice6""><br>
                <label for=""choice7"">Possible Outcome #7: </label>
                <input type=""text"" name=""choice7""><br>
                <label for=""choice8"">Possible Outcome #8: </label>
                <input type=""text"" name=""choice8"">");
                WriteLiteral(@"<br>
            </div>
            <div class=""formside"">
                <label for=""choice9"">Possible Outcome #9: </label>
                <input type=""text"" name=""choice9""><br>
                <label for=""choice10"">Possible Outcome #10: </label>
                <input type=""text"" name=""choice10""><br>
                <label for=""choice11"">Possible Outcome #11: </label>
                <input type=""text"" name=""choice11""><br>
                <label for=""choice12"">Possible Outcome #12: </label>
                <input type=""text"" name=""choice12""><br>
                <label for=""choice13"">Possible Outcome #13: </label>
                <input type=""text"" name=""choice13""><br>
                <label for=""choice14"">Possible Outcome #14: </label>
                <input type=""text"" name=""choice14""><br>
                <label for=""choice15"">Possible Outcome #15: </label>
                <input type=""text"" name=""choice15""><br>
                <input type=""submit"" value=""Make a Choice"">
            </d");
                WriteLiteral("iv>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2385, 71, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"decision\"> \r\n        <h2>Your choice is: ");
            EndContext();
            BeginContext(2457, 14, false);
#line 47 "C:\Users\ryan\Desktop\CodingDojo\PersonalProjects\randomGame\Views\Home\Index.cshtml"
                       Write(ViewBag.Choice);

#line default
#line hidden
            EndContext();
            BeginContext(2471, 25, true);
            WriteLiteral("</h2>\r\n    </div>\r\n</div>");
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
