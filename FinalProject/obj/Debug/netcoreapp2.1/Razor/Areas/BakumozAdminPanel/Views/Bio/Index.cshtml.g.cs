#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3c80b4aea2db53e3c5ab10fb2bf4bac032390b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Bio_Index), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Bio/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Bio/Index.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Bio_Index))]
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
#line 1 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a3c80b4aea2db53e3c5ab10fb2bf4bac032390b", @"/Areas/BakumozAdminPanel/Views/Bio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Bio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:120px;height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
  
	ViewData["Title"] = "Bio";

#line default
#line hidden
            BeginContext(48, 137, true);
            WriteLiteral("\r\n\t<div class=\"container\">\r\n\t\t<div class=\"logo-edit mt-3 d-flex justify-content-between align-items-center\">\r\n\t\t\t<div class=\"logo\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(185, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "621ff88dd83b4f3cbe146499aad8083b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 227, "~/image/", 227, 8, true);
#line 9 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
AddHtmlAttributeValue("", 235, Model.Logo, 235, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 40, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"edit\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(290, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3abe5e9c0c549fb80f43e2b69bab623", async() => {
                BeginContext(356, 49, true);
                WriteLiteral("\r\n\t\t\t\t\t<i class=\"mdi mdi-pencil\"></i> Dəyiş\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(409, 78, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<h6 class=\"mt-5\">\r\n\t\t\tTelefon nömrəsi\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(488, 17, false);
#line 20 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(505, 57, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tFacebook adres\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(563, 18, false);
#line 25 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.FacebookLink);

#line default
#line hidden
            EndContext();
            BeginContext(581, 58, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tInstagram adres\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(640, 19, false);
#line 30 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.InstagramLink);

#line default
#line hidden
            EndContext();
            BeginContext(659, 54, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tGmail adres\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(714, 11, false);
#line 35 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.Gmail);

#line default
#line hidden
            EndContext();
            BeginContext(725, 47, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tÖlkə\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(773, 13, false);
#line 40 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(786, 48, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tŞəhər\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(835, 10, false);
#line 45 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(845, 47, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tKüçə\r\n\t\t</h6>\r\n\t\t<p>");
            EndContext();
            BeginContext(893, 12, false);
#line 50 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
      Write(Model.Street);

#line default
#line hidden
            EndContext();
            BeginContext(905, 63, true);
            WriteLiteral("</p>\r\n\t\t<hr />\r\n\t\t<h6>\r\n\t\t\tMəzənnə\r\n\t\t</h6>\r\n\t\t<p class=\"mb-4\">");
            EndContext();
            BeginContext(969, 14, false);
#line 55 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Bio\Index.cshtml"
                   Write(Model.Currency);

#line default
#line hidden
            EndContext();
            BeginContext(983, 17, true);
            WriteLiteral("</p>\r\n\t</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
