#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bf990dbf88712f8d39d14f615ba3f039984ca33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
#line 1 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bf990dbf88712f8d39d14f615ba3f039984ca33", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formContact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formBox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
  
	ViewData["Title"] = "Əlaqə";

#line default
#line hidden
            BeginContext(56, 358, true);
            WriteLiteral(@"

<!-- Contact Start -->

<section id=""Contact"">
	<div class=""contact-info animate__animated animate__fadeInLeft"">
		<i class=""right fas fa-angle-right""></i>
		<i class=""left fas fa-angle-left""></i>
		<div>
			<h2>Əlaqə</h2>
			<ul class=""info"">
				<li>
					<span>
						<i class=""fas fa-map-marker-alt""></i>
					</span>
					<span>
						");
            EndContext();
            BeginContext(415, 17, false);
#line 21 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                   Write(Model.Bio.Country);

#line default
#line hidden
            EndContext();
            BeginContext(432, 13, true);
            WriteLiteral(" <br>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(446, 14, false);
#line 22 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                   Write(Model.Bio.City);

#line default
#line hidden
            EndContext();
            BeginContext(460, 13, true);
            WriteLiteral(" <br>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(474, 16, false);
#line 23 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                   Write(Model.Bio.Street);

#line default
#line hidden
            EndContext();
            BeginContext(490, 111, true);
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"fas fa-envelope-open-text\"></i>\r\n\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(602, 15, false);
#line 29 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                         Write(Model.Bio.Gmail);

#line default
#line hidden
            EndContext();
            BeginContext(617, 105, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li>\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"fas fa-phone\"></i>\r\n\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(723, 21, false);
#line 35 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                         Write(Model.Bio.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(744, 115, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</li>\r\n\t\t\t</ul>\r\n\t\t\t<div class=\"social\">\r\n\t\t\t\t<ul class=\"socialUl\">\r\n\t\t\t\t\t<li>\r\n\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 859, "\"", 889, 1);
#line 42 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 866, Model.Bio.FacebookLink, 866, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(890, 189, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t<span><i class=\"fab fa-facebook-f\"></i></span>\r\n\t\t\t\t\t\t</a>\r\n\t\t\t\t\t</li>\r\n\t\t\t\t\t<li>\r\n\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1110, 1);
#line 51 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1086, Model.Bio.InstagramLink, 1086, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1111, 503, true);
            WriteLiteral(@">
							<span></span>
							<span></span>
							<span></span>
							<span></span>
							<span><i class=""fab fa-instagram""></i></span>
						</a>
					</li>
				</ul>
			</div>
		</div>
	</div>
	<div class=""container"">
		<div class=""info-message"">
			<div class=""contactInfo animate__animated animate__fadeInLeft"">
				<div>
					<h2>Əlaqə</h2>
					<ul class=""info"">
						<li>
							<span>
								<i class=""fas fa-map-marker-alt""></i>
							</span>
							<span>
								");
            EndContext();
            BeginContext(1615, 17, false);
#line 74 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                           Write(Model.Bio.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1632, 15, true);
            WriteLiteral(" <br>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1648, 14, false);
#line 75 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                           Write(Model.Bio.City);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 15, true);
            WriteLiteral(" <br>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1678, 16, false);
#line 76 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                           Write(Model.Bio.Street);

#line default
#line hidden
            EndContext();
            BeginContext(1694, 123, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-envelope-open-text\"></i>\r\n\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(1818, 15, false);
#line 82 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                 Write(Model.Bio.Gmail);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 117, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-phone\"></i>\r\n\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(1951, 21, false);
#line 88 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
                                 Write(Model.Bio.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1972, 145, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t\t<div class=\"social\">\r\n\t\t\t\t\t\t<ul class=\"socialUl\">\r\n\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t<a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2117, "\"", 2147, 1);
#line 95 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2124, Model.Bio.FacebookLink, 2124, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2148, 223, true);
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t\t\t<span></span>\r\n\t\t\t\t\t\t\t\t\t<span><i class=\"fab fa-facebook-f\"></i></span>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t<a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2371, "\"", 2402, 1);
#line 104 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2378, Model.Bio.InstagramLink, 2378, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2403, 332, true);
            WriteLiteral(@">
									<span></span>
									<span></span>
									<span></span>
									<span></span>
									<span><i class=""fab fa-instagram""></i></span>
								</a>
							</li>
						</ul>
					</div>
				</div>
			</div>
			<div class=""contactForm animate__animated animate__fadeInRight"">
				<h2>Mesaj Göndər</h2>
				");
            EndContext();
            BeginContext(2735, 1307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4aac4ce8f8cf41e9a2327bf0cd217d12", async() => {
                BeginContext(2788, 55, true);
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"inputBox w50\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(2843, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "74462954e3fa4514bd520df1cad7f9c8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 121 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2874, 59, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"span\">Ad</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(2933, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7810d5454f604d77a3d3c200c42dfcb2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 124 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2992, 68, true);
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"inputBox w50\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(3060, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3d160cace1c475e92d587a2ac2db7c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 128 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Surname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3094, 62, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"span\">Soyad</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(3156, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "955fd9f2302c468aa5e1dac436d30689", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 131 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Surname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3218, 68, true);
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"inputBox w50\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(3286, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6da6e3fe775d42cba01199e975129d8a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 135 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3318, 62, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"span\">Email</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(3380, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cabb8ecd1a24819afdf3717ca21ea2f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 138 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3440, 68, true);
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"inputBox w50\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(3508, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c16bf2dfa3cd4cc6bfdab4fb8747fa6f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 142 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3546, 68, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"span\">Mobil nömrə</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(3614, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "930effa8db644fada58eeb417acb070b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 145 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3680, 69, true);
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"inputBox w100\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(3749, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d85a89cfffc4e37be30900f558c3a7b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 149 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3797, 76, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"span\">Mesajınızı yazın...</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(3873, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fad81f21274131b8cc50eab366cc51", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 152 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3935, 100, true);
                WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<button type=\"submit\" class=\"mt-3 btn btn-outline-primary\">Göndər</button>\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(4042, 70, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n<!-- Contact End -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4129, 1556, true);
                WriteLiteral(@"
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.2/jquery.validate.min.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js""></script>
	<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<script>
		$(""#formContact"").submit(function (e) {
			e.preventDefault();
			let name = $(""#Name"").val();
			let surname = $(""#Surname"").val();
			let email = $(""#Email"").val();
			let phonenumber = $(""#PhoneNumber"").val();
			let message = $(""#Message"").val();
			let nameError = """";
			let surnameError = """";
			let emailError = """";
			let phonenumberError = """";
			let messageError = """";
			setTimeout(() => {
				nameError = $(""#Name"").parent().next().text()
				surnameError = $(""#Surname"").parent().next().text()
				emailError = $(""#Email"").parent().next().text()
				phonenumberError = $(""#PhoneNumber"").parent().next().text()
				messageError = $(""#Message"").parent().");
                WriteLiteral(@"next().text()
			}, 1)
			setTimeout(() => {
				if (name.trim() != """" && surname.trim() != """" && email.trim() != """" && phonenumber.trim() != """" && message.trim() != """" && nameError.trim() == """" && surnameError.trim() == """" && emailError.trim() == """" && phonenumberError.trim() == """" && messageError.trim() == """") {
					swal(""Mesaj"", ""Mesaj uğurla göndərildi"", ""success"")
						.then(function () {
							setTimeout(() => document.querySelector(""#formContact"").submit(), 100);
						})
				}
			}, 50)
		});
	</script>
");
                EndContext();
            }
            );
            BeginContext(5688, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
