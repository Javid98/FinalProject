#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Author\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97615b8e4ef2c2dd1d33c19a9ea91c78bbe3286"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Author_Create), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Author/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Author/Create.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Author_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97615b8e4ef2c2dd1d33c19a9ea91c78bbe3286", @"/Areas/BakumozAdminPanel/Views/Author/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Author_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Author>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-type", new global::Microsoft.AspNetCore.Html.HtmlString("slug-source"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-type", new global::Microsoft.AspNetCore.Html.HtmlString("slug-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none mt-2 form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Author\Create.cshtml"
  
	ViewData["Title"] = "Yazıçı əlavə et";

#line default
#line hidden
            BeginContext(63, 111, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<h2 style=\"text-align:center;font-weight:bold\" class=\"mt-3\">Yazıçı əlavə et</h2>\r\n\t");
            EndContext();
            BeginContext(174, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be7ba1b05ab64fb79683c161ec0a6621", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 8 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Author\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 3, true);
            WriteLiteral("\r\n\t");
            EndContext();
            BeginContext(244, 409, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e956112cf33b47bb80ab25ec8f75f4fe", async() => {
                BeginContext(277, 51, true);
                WriteLiteral("\r\n\t\t<span><strong>Adı və soyadı</strong></span>\r\n\t\t");
                EndContext();
                BeginContext(328, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2c8be2891444d4781def5db51afe050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 11 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Author\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fullname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(420, 4, true);
                WriteLiteral("\r\n\t\t");
                EndContext();
                BeginContext(424, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0999dd510e0447b868eb93021c3a22a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 12 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Author\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fullname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(487, 4, true);
                WriteLiteral("\r\n\t\t");
                EndContext();
                BeginContext(491, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3601573b8797431a94882fdb87718fe9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 13 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Author\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Slug);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(571, 75, true);
                WriteLiteral("\r\n\t\t<button type=\"submit\" class=\"mt-2 btn btn-success\">Əlavə et</button>\r\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(653, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(682, 1908, true);
                WriteLiteral(@"
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.2/jquery.validate.min.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js""></script>
	<script>
		String.prototype.removeAcento = function () {
			var text = this.toLowerCase();
			text = text.replace(new RegExp('[ÁÀÂÃ]', 'gi'), 'a');
			text = text.replace(new RegExp('[ÉÈÊ]', 'gi'), 'e');
			text = text.replace(new RegExp('[ÍÌÎ]', 'gi'), 'i');
			text = text.replace(new RegExp('[ÓÒÔÕ]', 'gi'), 'o');
			text = text.replace(new RegExp('[ÚÙÛÜ]', 'gi'), 'u');
			text = text.replace(new RegExp('[Ç]', 'gi'), 'c');
			text = text.replace(new RegExp('[ç]', 'gi'), 'c');
			text = text.replace(new RegExp('[Ə]', 'gi'), 'e');
			text = text.replace(new RegExp('[ə]', 'gi'), 'e');
			text = text.replace(new RegExp('[Ö]', 'gi'), 'o');
			text = text.replace(new RegExp('[ö]', 'gi'), 'o');
			text = text.replace(new RegExp('[I]', 'gi'), 'i');
			tex");
                WriteLiteral(@"t = text.replace(new RegExp('[ı]', 'gi'), 'i');
			text = text.replace(new RegExp('[Ğ]', 'gi'), 'g');
			text = text.replace(new RegExp('[ğ]', 'gi'), 'g');
			text = text.replace(new RegExp('[Ş]', 'gi'), 'sh');
			text = text.replace(new RegExp('[ş]', 'gi'), 'sh');
			return text;
		};
		String.prototype.slugify = function () {
			return this.toString().toLowerCase().removeAcento().trim()
				.replace(/\s+/g, '-')           // Replace spaces with -
				.replace(/[^\w\-]+/g, '')       // Remove all non-word chars
				.replace(/\-\-+/g, '-')         // Replace multiple - with single -
				.replace(/^-+/, '')             // Trim - from start of text
				.replace(/-+$/, '');            // Trim - from end of text
		};
		$(""input[data-type='slug-source']"").blur(function () {
			$(""input[data-type='slug-input']"").val($(this).val().slugify());
		});
	</script>
");
                EndContext();
            }
            );
            BeginContext(2593, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
