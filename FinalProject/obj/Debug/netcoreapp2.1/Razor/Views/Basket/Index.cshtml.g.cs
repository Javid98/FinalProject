#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42acc55283b12cda358c28f12e2d585b23268843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basket/Index.cshtml", typeof(AspNetCore.Views_Basket_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42acc55283b12cda358c28f12e2d585b23268843", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("phoneInput form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("phoneError text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Metro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Şəhər daxili", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Rayon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20 Yanvar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "28 May", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Xətai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Sale"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
  
	ViewData["Title"] = "Səbət";

#line default
#line hidden
            BeginContext(55, 25, true);
            WriteLiteral("\r\n\r\n<!-- Cart Start -->\r\n");
            EndContext();
#line 8 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
 if (Model.BookInCarts.Count() == 0)
{

#line default
#line hidden
            BeginContext(121, 65, true);
            WriteLiteral("\t<section id=\"EmptyCart\">\r\n\t\t<h1>Səbət Boşdur</h1>\r\n\t</section>\r\n");
            EndContext();
#line 13 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(198, 52, true);
            WriteLiteral("\t<section id=\"Cart\">\r\n\t\t<div class=\"container\">\r\n\t\t\t");
            EndContext();
            BeginContext(250, 3123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3895f93a024c349068867f55941add", async() => {
                BeginContext(280, 359, true);
                WriteLiteral(@"
				<table class=""table table-striped"">
					<thead>
						<tr>
							<th scope=""col"" class=""bookImg"">Kitabın şəkli</th>
							<th scope=""col"">Adı</th>
							<th scope=""col"">Sayı</th>
							<th scope=""col"" class=""author"">Yazar</th>
							<th scope=""col"">Qiymət</th>
							<th scope=""col"">Silmək</th>
						</tr>
					</thead>
					<tbody>
");
                EndContext();
#line 31 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
                         foreach (BookInCart book in Model.BookInCarts)
						{

#line default
#line hidden
                BeginContext(703, 83, true);
                WriteLiteral("\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t<td class=\"bookImg\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"image\">\r\n\t\t\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(786, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0cf847c473844cdaabd95b1804fdffd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 796, "~/image/", 796, 8, true);
#line 36 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
AddHtmlAttributeValue("", 804, book.Book.ImagePath, 804, 20, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(833, 46, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>");
                EndContext();
                BeginContext(880, 14, false);
#line 39 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
                               Write(book.Book.Name);

#line default
#line hidden
                EndContext();
                BeginContext(894, 111, true);
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<div class=\"count\">\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"number\" min=\"1\" name=\"Count\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1005, "\"", 1024, 1);
#line 42 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1013, book.Count, 1013, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1025, 97, true);
                WriteLiteral(" class=\"bookCount form-control\" />\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td class=\"author\">\r\n");
                EndContext();
#line 46 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
                                     foreach (BookAuthor author in Model.BookAuthors.Where(ba => ba.BookId == book.BookId))
									{

#line default
#line hidden
                BeginContext(1232, 43, true);
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<p style=\"margin:0\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(1276, 22, false);
#line 49 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
                                       Write(author.Author.Fullname);

#line default
#line hidden
                EndContext();
                BeginContext(1298, 18, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</p>\r\n");
                EndContext();
#line 51 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
									}

#line default
#line hidden
                BeginContext(1328, 77, true);
                WriteLiteral("\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t<input style=\"width:60px\" type=\"number\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1405, "\"", 1429, 1);
#line 54 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1413, book.Book.Price, 1413, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1430, 95, true);
                WriteLiteral(" class=\"d-none bPrice\" />\r\n\t\t\t\t\t\t\t\t\t<input style=\"width:60px\" disabled type=\"text\" name=\"Price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1525, "\"", 1549, 1);
#line 55 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
WriteAttributeValue("", 1533, book.Book.Price, 1533, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1550, 74, true);
                WriteLiteral(" class=\"bookPrice form-control\" />\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t");
                EndContext();
                BeginContext(1624, 156, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73898cccdb6147b786250c1469dc990e", async() => {
                    BeginContext(1718, 58, true);
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-minus-circle\"></i>\r\n\t\t\t\t\t\t\t\t\t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 58 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
                                                                                         WriteLiteral(book.BookId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1780, 31, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t</tr>\r\n");
                EndContext();
#line 63 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
						}

#line default
#line hidden
                BeginContext(1820, 166, true);
                WriteLiteral("\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t\t<h5 class=\"mb-2 total\" style=\"text-align:end;font-weight:bold\">Total: </h5>\r\n\t\t\t\t<span><strong>Telefon nömrəsi:</strong></span>\r\n\t\t\t\t");
                EndContext();
                BeginContext(1986, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7de2d5826544abb83ea4acf32eadd10", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 68 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2061, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(2067, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "448fdaceb9b54d1bbb57e29b8f122c16", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 69 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

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
                BeginContext(2144, 145, true);
                WriteLiteral("<br />\r\n\t\t\t\t<span class=\"dtype mt-3\"><strong>Çatdırılma növü:</strong></span>\r\n\t\t\t\t<select name=\"Type\" id=\"delivery\" class=\"form-control\">\r\n\t\t\t\t\t");
                EndContext();
                BeginContext(2289, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef702e601e6a41449c7075ab468df04d", async() => {
                    BeginContext(2311, 5, true);
                    WriteLiteral("Metro");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2325, 7, true);
                WriteLiteral("\r\n\t\t\t\t\t");
                EndContext();
                BeginContext(2332, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9801fb5d76946b5823d16b821c44a90", async() => {
                    BeginContext(2361, 12, true);
                    WriteLiteral("Şəhər daxili");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2382, 7, true);
                WriteLiteral("\r\n\t\t\t\t\t");
                EndContext();
                BeginContext(2389, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e8383b3b7ee43c9a925fa79b0751ac4", async() => {
                    BeginContext(2411, 5, true);
                    WriteLiteral("Rayon");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2425, 224, true);
                WriteLiteral("\r\n\t\t\t\t</select>\r\n\t\t\t\t<div class=\"metros mt-3\">\r\n\t\t\t\t\t<span><strong>Metrolar (Metrodaxili):</strong></span><br />\r\n\t\t\t\t\t<span>Çatdırılma ödənişsizdir</span>\r\n\t\t\t\t\t<select name=\"Metro\" id=\"metro\" class=\"form-control \">\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(2649, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d7a630e895141d0b3563bf277f7641a", async() => {
                    BeginContext(2675, 9, true);
                    WriteLiteral("20 Yanvar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2693, 8, true);
                WriteLiteral("\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(2701, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19d2e08cbd540f9a5b30bd9342052f9", async() => {
                    BeginContext(2724, 6, true);
                    WriteLiteral("28 May");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2739, 8, true);
                WriteLiteral("\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(2747, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1a09d2e2d454bcd8eeb02b9669ca328", async() => {
                    BeginContext(2769, 5, true);
                    WriteLiteral("Xətai");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2783, 583, true);
                WriteLiteral(@"
					</select>
				</div>
				<div class=""city mt-3 d-none"">
					<span><Strong>Şəhər daxili adres:</Strong></span><br />
					<span>Çatdırılma: 2 AZN</span>
					<input name=""City"" type=""text"" class=""form-control"">
				</div>
				<div class=""region mt-3 d-none"">
					<span><strong>Rayon və adres (3-5 gün ərzində):</strong></span><br />
					<span>Çatdırılma: 2 AZN</span>
					<input name=""Region"" type=""text"" class=""form-control"">
				</div>
				<div class=""bTn mt-3"">
					<button type=""submit"" class=""btn btn-outline-primary"">Sifariş et</button>
				</div>
			");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3373, 25, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</section>\r\n");
            EndContext();
#line 101 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Basket\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3401, 27, true);
            WriteLiteral("\r\n\r\n\r\n<!-- Cart End -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3445, 3149, true);
                WriteLiteral(@"
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.2/jquery.validate.min.js""></script>
	<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js""></script>
	<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<script>
		let prevTotal = 0;
		let i = 0;
		let prevPrices = document.querySelectorAll("".bookPrice"");
		let prevCounts = document.querySelectorAll("".bookCount"");
		for (price of prevPrices) {
			prevTotal += price.value * prevCounts[i].value;
			i++
		}
		let prevTotalText = `Total: ${prevTotal} ₼`
		$(""#Cart #Sale h5.total"").text(prevTotalText);

		$(""#Cart tbody .bookCount"").keyup(function () {
			//let count = $(this).val();
			//let price = $(this).parent().parent().next().next().find("".bPrice"").val()
			//price = count * price;
			//$(this).parent().parent().next().next().find("".bookPrice"").val(price);
			let total = 0;
			let prices = document.querySelectorAll(""");
                WriteLiteral(@".bookPrice"");
			let j = 0;
			let counts = document.querySelectorAll("".bookCount"");
			for (price of prices) {
				total += price.value * counts[j].value;
				j++
			}
			let totalText = `Total: ${total} ₼`
			$(""#Cart #Sale h5.total"").text(totalText);
		})
		$(""#Cart tbody .bookCount"").change(function () {
			//let count = $(this).val();
			//let price = $(this).parent().parent().next().next().find("".bPrice"").val()
			//price = count * price;
			//$(this).parent().parent().next().next().find("".bookPrice"").val(price)
			let total = 0;
			let prices = document.querySelectorAll("".bookPrice"");
			let j = 0;
			let counts = document.querySelectorAll("".bookCount"");
			for (price of prices) {
				total += price.value * counts[j].value;
				j++
			}
			let totalText = `Total: ${total} ₼`
			$(""#Cart #Sale h5.total"").text(totalText);
		})
		$(""#Cart #Sale"").submit(function (e) {
			e.preventDefault();
			let text = $(""#Cart #Sale .phoneInput"").val()
			let error = $(""#Cart #Sale .phoneEr");
                WriteLiteral(@"ror"").text()
			let total = 0;
			let prices = document.querySelectorAll("".bookPrice"");
			let j = 0;
			let counts = document.querySelectorAll("".bookCount"");
			for (price of prices) {
				total += price.value * counts[j].value;
				j++
			}

			let bookCount = false;
			counts.forEach(function (count) {
				if (count.value < 1 == true) {
					bookCount = true;
					return;
				}
			})
			if (text.toString().trim() != """" && error.toString().trim() == """" && bookCount == false) {
				swal({
					title: ""Sifariş"",
					text: `Cəmi məbləğ ${total} ₼ (Çatdırılma nəzərə alınmır)`,
					icon: ""info"",
					buttons: [""Ləğv et"", ""Sifarişi ver""],
				})
					.then((willDelete) => {
						if (willDelete) {
							swal(""Sifarişiniz uğurla həyata keçirildi"", {
								icon: ""success"",
								button: ""Bağla""
							}).then(function () {
								setTimeout(() => document.querySelector(""#Sale"").submit(), 100);
							})
						} else {
							swal({
								text: ""Sifariş ləğv olundu"",
				");
                WriteLiteral("\t\t\t\tbutton: \"Bağla\"\r\n\t\t\t\t\t\t\t});\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t});\r\n\t\t\t}\r\n\t\t});\r\n\t</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
