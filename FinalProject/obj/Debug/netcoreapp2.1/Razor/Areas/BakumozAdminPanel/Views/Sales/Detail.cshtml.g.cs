#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2c67ef12426a4a77c21aa0d7b807d24ecbcb25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Sales_Detail), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Sales/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Sales/Detail.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Sales_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2c67ef12426a4a77c21aa0d7b807d24ecbcb25", @"/Areas/BakumozAdminPanel/Views/Sales/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Sales_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-1 btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteSale", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
  
	ViewData["Title"] = "Satışın detalları";

#line default
#line hidden
            BeginContext(63, 177, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n\t<h2 style=\"font-weight:bold;text-align:center\">Satışın detalları</h2>\r\n\r\n\t<div class=\"client-details\">\r\n\t\t<h4>\r\n\t\t\tMüştərinin məlumatları:\r\n\t\t</h4>\r\n");
            EndContext();
#line 13 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
         if (Model.AppUser.UserDetail.ImagePath != null)
		{

#line default
#line hidden
            BeginContext(297, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
            BeginContext(300, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04d81596da454dd1acd48ea92580a99c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 343, "~/image/usersphotos/", 343, 20, true);
#line 15 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
AddHtmlAttributeValue("", 363, Model.AppUser.UserDetail.ImagePath, 363, 35, false);

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
            BeginContext(402, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
		}

#line default
#line hidden
            BeginContext(409, 42, true);
            WriteLiteral("\t\t<a>\r\n\t\t\t<p>\r\n\t\t\t\t<strong>Adı: </strong> ");
            EndContext();
            BeginContext(452, 22, false);
#line 19 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                  Write(Model.AppUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(474, 61, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t</a>\r\n\t\t<p>\r\n\t\t\t<strong>Mobil nömrəsi:</strong> ");
            EndContext();
            BeginContext(536, 17, false);
#line 23 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(553, 188, true);
            WriteLiteral("\r\n\t\t</p>\r\n\t</div>\r\n\r\n\t<div class=\"mt-5 sale d-flex justify-content-between\">\r\n\t\t<div class=\"sale-details\">\r\n\t\t\t<h4>\r\n\t\t\t\tSatışın detalları:\r\n\t\t\t</h4>\r\n\t\t\t<p>\r\n\t\t\t\t<strong>Tarix: </strong> ");
            EndContext();
            BeginContext(742, 10, false);
#line 33 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                    Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(752, 57, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t\t<p>\r\n\t\t\t\t<strong>Çatdırılma növü: </strong>");
            EndContext();
            BeginContext(810, 18, false);
#line 36 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                             Write(Model.DeliveryType);

#line default
#line hidden
            EndContext();
            BeginContext(828, 47, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t\t<p>\r\n\t\t\t\t<strong>Adres: </strong>");
            EndContext();
            BeginContext(876, 22, false);
#line 39 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                   Write(Model.DeliveryLocation);

#line default
#line hidden
            EndContext();
            BeginContext(898, 48, true);
            WriteLiteral("\r\n\t\t\t</p>\r\n\t\t\t<p>\r\n\t\t\t\t<strong>Məbləğ: </strong>");
            EndContext();
            BeginContext(947, 11, false);
#line 42 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                    Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(958, 23, true);
            WriteLiteral(" ₼\r\n\t\t\t</p>\r\n\t\t</div>\r\n");
            EndContext();
#line 45 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
         if (Model.Completed)
		{

#line default
#line hidden
            BeginContext(1011, 206, true);
            WriteLiteral("\t\t\t<div class=\"completed\">\r\n\t\t\t\t<i style=\"color:lightgreen;font-size:22px\" class=\"mdi mdi-check\">\r\n\t\t\t\t</i>\r\n\t\t\t\t<span style=\"color:lightgreen;font-size:18px;font-weight:bold\">Tamamlandı</span>\r\n\t\t\t</div>\r\n");
            EndContext();
#line 52 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
		}
		else
		{

#line default
#line hidden
            BeginContext(1235, 14, true);
            WriteLiteral("\t\t\t<div>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1249, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ecc57fcf3f4791922d44568350d6db", async() => {
                BeginContext(1355, 67, true);
                WriteLiteral("\r\n\t\t\t\t\t<i class=\"mdi mdi-clipboard-check\"></i> Satışı tamamla\r\n\t\t\t\t");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                                                                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1426, 13, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n");
            EndContext();
#line 60 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
		}

#line default
#line hidden
            BeginContext(1444, 230, true);
            WriteLiteral("\r\n\t</div>\r\n\r\n\t<table class=\"table table-striped\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th class=\"image\">Kitab</th>\r\n\t\t\t\t<th>Adı</th>\r\n\t\t\t\t<th class=\"author\">Yazar</th>\r\n\t\t\t\t<th>Say</th>\r\n\t\t\t\t<th>Qiymət</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 75 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
             foreach (SaleBook saleBook in Model.SaleBooks)
			{

#line default
#line hidden
            BeginContext(1732, 41, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td class=\"image\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1773, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32b9b42c5db346e0a957de5dd6f4eb2a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1815, "~/image/", 1815, 8, true);
#line 79 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
AddHtmlAttributeValue("", 1823, saleBook.Book.ImagePath, 1823, 24, false);

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
            BeginContext(1851, 14, true);
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n");
            EndContext();
#line 81 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                     if (saleBook.Book.Name.Length >= 30)
					{

#line default
#line hidden
            BeginContext(1917, 10, true);
            WriteLiteral("\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1928, 46, false);
#line 83 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                       Write(saleBook.Book.Name.ToString().Substring(0, 30));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 10, true);
            WriteLiteral("...</td>\r\n");
            EndContext();
#line 84 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(2011, 10, true);
            WriteLiteral("\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2022, 18, false);
#line 87 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                       Write(saleBook.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2040, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 88 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
					}

#line default
#line hidden
            BeginContext(2055, 26, true);
            WriteLiteral("\t\t\t\t\t<td class=\"author\">\r\n");
            EndContext();
#line 90 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                         foreach (BookAuthor bookAuthor in saleBook.Book.BookAuthors)
						{

#line default
#line hidden
            BeginContext(2159, 20, true);
            WriteLiteral("\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(2180, 26, false);
#line 93 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                           Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2206, 15, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</p>\r\n");
            EndContext();
#line 95 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
						}

#line default
#line hidden
            BeginContext(2230, 21, true);
            WriteLiteral("\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2252, 14, false);
#line 97 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                   Write(saleBook.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2266, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2283, 14, false);
#line 98 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                   Write(saleBook.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2297, 20, true);
            WriteLiteral(" ₼</td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 100 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
			}

#line default
#line hidden
            BeginContext(2323, 26, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n\t");
            EndContext();
            BeginContext(2349, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5a2f68fbd654fcc869b57c14efffb56", async() => {
                BeginContext(2447, 117, true);
                WriteLiteral("\r\n\t\t<button type=\"submit\" class=\"ml-1 btn btn-danger\"><i class=\"mdi mdi-delete-forever\"></i> Sifarişi sil</button>\r\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 104 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2571, 14, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2602, 671, true);
                WriteLiteral(@"
	<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<script>
		$("".deleteForm"").submit(function (e) {
			e.preventDefault();
			swal({
				title: ""Sifariş"",
				text: ""Bu sifarişi silmək istədiyinizdən əminsiniz?"",
				icon: ""warning"",
				buttons: [""Bağla"", ""Sil""],
				dangerMode: true,
			})
				.then((willDelete) => {
					if (willDelete) {
						swal(""Sifariş silindi"", {
							icon: ""success"",
						}).then(function () {
							setTimeout(() => document.querySelector("".deleteForm"").submit(), 100);
						})
					} else {
						swal(""Sifariş silinmədi"");
						button: ""Bağla""
					}
				});
		});
	</script>
");
                EndContext();
            }
            );
            BeginContext(3276, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sale> Html { get; private set; }
    }
}
#pragma warning restore 1591
