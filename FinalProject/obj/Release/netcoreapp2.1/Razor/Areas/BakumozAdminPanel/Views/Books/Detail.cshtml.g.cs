#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45154c2e1277ac84a6a79985392fada60dd82528"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Books_Detail), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Books/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Books/Detail.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Books_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45154c2e1277ac84a6a79985392fada60dd82528", @"/Areas/BakumozAdminPanel/Views/Books/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Books_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:140px;height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
  
	ViewData["Title"] = "Kitab detalları";

#line default
#line hidden
            BeginContext(61, 28, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t");
            EndContext();
            BeginContext(89, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9a93030aaab5469689ad247a16b2ba7f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 145, "~/image/", 145, 8, true);
#line 7 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
AddHtmlAttributeValue("", 153, Model.ImagePath, 153, 16, false);

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
            BeginContext(173, 88, true);
            WriteLiteral("\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Kitabın adı:</strong></span><br />\r\n\t\t<span>\r\n\t\t\t");
            EndContext();
            BeginContext(262, 10, false);
#line 11 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(272, 98, true);
            WriteLiteral("\r\n\t\t</span>\r\n\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Kitabın yazarı:</strong></span><br />\r\n");
            EndContext();
#line 16 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
         foreach (BookAuthor bookAuthor in Model.BookAuthors)
		{

#line default
#line hidden
            BeginContext(432, 15, true);
            WriteLiteral("\t\t\t<span>\r\n\t\t\t\t");
            EndContext();
            BeginContext(448, 26, false);
#line 19 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
           Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(474, 20, true);
            WriteLiteral("\r\n\t\t\t</span><br />\r\n");
            EndContext();
#line 21 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
		}

#line default
#line hidden
            BeginContext(499, 81, true);
            WriteLiteral("\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Kateqoriya:</strong></span><br />\r\n");
            EndContext();
#line 25 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
         foreach (BookCategory bookCategory in Model.BookCategories)
		{

#line default
#line hidden
            BeginContext(649, 15, true);
            WriteLiteral("\t\t\t<span>\r\n\t\t\t\t");
            EndContext();
            BeginContext(665, 26, false);
#line 28 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
           Write(bookCategory.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(691, 20, true);
            WriteLiteral("\r\n\t\t\t</span><br />\r\n");
            EndContext();
#line 30 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
		}

#line default
#line hidden
            BeginContext(716, 166, true);
            WriteLiteral("\t</div>\r\n\t<div style=\"text-align:center\" class=\"mt-3 d-flex justify-content-between\">\r\n\t\t<div>\r\n\t\t\t<span><strong>Kitabın qiyməti(TL):</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(883, 11, false);
#line 35 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(894, 94, true);
            WriteLiteral(" ₺</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Nəşriyyat evi:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(989, 20, false);
#line 39 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.Publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 91, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Kitabın sayı:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1101, 11, false);
#line 43 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 99, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Kitabın satılma sayı:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1212, 15, false);
#line 47 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.SaleCount);

#line default
#line hidden
            EndContext();
            BeginContext(1227, 108, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Haqqında:</strong></span><br />\r\n\t\t<p>\r\n\t\t\t");
            EndContext();
            BeginContext(1336, 17, false);
#line 53 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 180, true);
            WriteLiteral("\r\n\t\t</p>\r\n\t</div>\r\n\t<div style=\"text-align:center\" class=\"mt-4 mb-3 d-flex justify-content-between\">\r\n\t\t<div>\r\n\t\t\t<span><strong>Nəşr olunma tarixi:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1534, 55, false);
#line 59 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.BookFeature.PublishingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 96, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Nəşr olunduğu dil:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1686, 36, false);
#line 63 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.BookFeature.PublishingLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(1722, 92, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Orijinal dili:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1815, 34, false);
#line 67 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.BookFeature.OriginalLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(1849, 88, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Tərcüməçi:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1938, 28, false);
#line 71 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Detail.cshtml"
             Write(Model.BookFeature.Translator);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 34, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
