#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebc33cde815b92423c40f5b02a5873ab5c93eb17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Books_Delete), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Books/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Books/Delete.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Books_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc33cde815b92423c40f5b02a5873ab5c93eb17", @"/Areas/BakumozAdminPanel/Views/Books/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Books_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:140px;height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteBook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
  
	ViewData["Title"] = "Kitabı sil";

#line default
#line hidden
            BeginContext(56, 100, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"mt-3 d-flex justify-content-between align-items-center\">\r\n\t\t");
            EndContext();
            BeginContext(156, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fef32f3e645407eb5b37c86375d75be", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 208, "~/image/", 208, 8, true);
#line 8 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
AddHtmlAttributeValue("", 216, Model.ImagePath, 216, 16, false);

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
            BeginContext(236, 4, true);
            WriteLiteral("\r\n\t\t");
            EndContext();
            BeginContext(240, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07fb2e4c02c3475a90b18d092c3ac0c0", async() => {
                BeginContext(276, 104, true);
                WriteLiteral("\r\n\t\t\t<button type=\"submit\" class=\"btn btn-danger\"><i class=\"mdi mdi-delete-forever\"></i>Sil</button>\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(387, 97, true);
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Kitabın adı:</strong></span><br />\r\n\t\t<span>\r\n\t\t\t");
            EndContext();
            BeginContext(485, 10, false);
#line 16 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(495, 98, true);
            WriteLiteral("\r\n\t\t</span>\r\n\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Kitabın yazarı:</strong></span><br />\r\n");
            EndContext();
#line 21 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
         foreach (BookAuthor bookAuthor in Model.BookAuthors)
		{

#line default
#line hidden
            BeginContext(655, 15, true);
            WriteLiteral("\t\t\t<span>\r\n\t\t\t\t");
            EndContext();
            BeginContext(671, 26, false);
#line 24 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
           Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(697, 20, true);
            WriteLiteral("\r\n\t\t\t</span><br />\r\n");
            EndContext();
#line 26 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
		}

#line default
#line hidden
            BeginContext(722, 81, true);
            WriteLiteral("\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Kateqoriya:</strong></span><br />\r\n");
            EndContext();
#line 30 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
         foreach (BookCategory bookCategory in Model.BookCategories)
		{

#line default
#line hidden
            BeginContext(872, 15, true);
            WriteLiteral("\t\t\t<span>\r\n\t\t\t\t");
            EndContext();
            BeginContext(888, 26, false);
#line 33 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
           Write(bookCategory.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(914, 20, true);
            WriteLiteral("\r\n\t\t\t</span><br />\r\n");
            EndContext();
#line 35 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
		}

#line default
#line hidden
            BeginContext(939, 162, true);
            WriteLiteral("\t</div>\r\n\t<div style=\"text-align:center\" class=\"mt-3 d-flex justify-content-between\">\r\n\t\t<div>\r\n\t\t\t<span><strong>Kitabın qiyməti:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1102, 11, false);
#line 40 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 90, true);
            WriteLiteral(" ₼</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Yayın evi:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1204, 20, false);
#line 44 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.Publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 91, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Kitabın sayı:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1316, 11, false);
#line 48 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 99, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Kitabın satılma sayı:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1427, 15, false);
#line 52 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.SaleCount);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 108, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"mt-3\">\r\n\t\t<span><strong>Haqqında:</strong></span><br />\r\n\t\t<p>\r\n\t\t\t");
            EndContext();
            BeginContext(1551, 17, false);
#line 58 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 179, true);
            WriteLiteral("\r\n\t\t</p>\r\n\t</div>\r\n\t<div style=\"text-align:center\" class=\"mt-4 mb-3 d-flex justify-content-between\">\r\n\t\t<div>\r\n\t\t\t<span><strong>Yayınlanma tarixi:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1748, 55, false);
#line 64 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.BookFeature.PublishingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 95, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Yayınlandığı dil:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(1899, 36, false);
#line 68 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.BookFeature.PublishingLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(1935, 92, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Orijinal dili:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(2028, 34, false);
#line 72 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.BookFeature.OriginalLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(2062, 88, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<span><strong>Tərcüməçi:</strong></span><br />\r\n\t\t\t<span>");
            EndContext();
            BeginContext(2151, 28, false);
#line 76 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Delete.cshtml"
             Write(Model.BookFeature.Translator);

#line default
#line hidden
            EndContext();
            BeginContext(2179, 36, true);
            WriteLiteral("</span>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2232, 663, true);
                WriteLiteral(@"
	<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<script>
		$(""#deleteBook"").submit(function (e) {
			e.preventDefault();
			swal({
				title: ""Kitab"",
				text: ""Bu kitabı silmək istədiyinizdən əminsiniz?"",
				icon: ""warning"",
				buttons: [""Bağla"", ""Sil""],
				dangerMode: true,
			})
				.then((willDelete) => {
					if (willDelete) {
						swal(""Kitab silindi"", {
							icon: ""success"",
						}).then(function () {
							setTimeout(() => document.querySelector(""#deleteBook"").submit(), 100);
						})
					} else {
						swal(""Kitab silinmədi"");
						button: ""Bağla""
					}
				});
		});
	</script>
");
                EndContext();
            }
            );
            BeginContext(2898, 2, true);
            WriteLiteral("\r\n");
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
