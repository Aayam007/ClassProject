#pragma checksum "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\_ViewImports.cshtml"
using ViewDatas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\_ViewImports.cshtml"
using ViewDatas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70de9204b812dc3518394302ec72499b4c921bd414400127d742eb09f170976c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RedirectToAnotherAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetJsonData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PlainText", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <h3>");
#nullable restore
#line 8 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h2>");
#nullable restore
#line 9 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
   Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h4>");
#nullable restore
#line 10 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
  Write(ViewData["Messages"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
  Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <b>");
#nullable restore
#line 13 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
  Write(TempData["Log"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n");
#nullable restore
#line 14 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
      
        var sum = 32 + 10;
        var greeting = "Hell0 World";
        var text = "";
        for (int i = 0; i < 3; i++)
        {
            text += greeting + "This result is: " + sum + "\n";
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
     for (int i = 0; i < 5; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Hello ");
#nullable restore
#line 26 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> <br>\r\n");
#nullable restore
#line 27 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2> Code Blocks</h2>\r\n    ");
#nullable restore
#line 29 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
Write(Html.Partial("_TestPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    Text : ");
#nullable restore
#line 30 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
      Write(text);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b8572", async() => {
                WriteLiteral("Redirect to Error Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b9777", async() => {
                WriteLiteral("Get Json Data");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b10973", async() => {
                WriteLiteral("Download File");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b12170", async() => {
                WriteLiteral("PlainText");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a626fae89a2ce0e582576f7c5207dc4f87c385108564efec107b22b06f9399b13364", async() => {
                WriteLiteral("Partial View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
#nullable restore
#line 36 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
Write(Html.Partial("_TestPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 38 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
      
        var name = "Bishow";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 41 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
     if (name =="Bishow")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Yes Name is correct</h1>\r\n");
#nullable restore
#line 46 "C:\Users\Bishow Shrestha\Desktop\6th-sem-2024-New-Summit\Assignment\Programs\ViewDatas\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
