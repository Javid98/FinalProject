#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b568e3c816a01c456049d3c6a8a19bff956f7b2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b568e3c816a01c456049d3c6a8a19bff956f7b2", @"/Areas/BakumozAdminPanel/Views/Sales/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Sales_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sale>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a164ede147014de79ddb17c9e39de66b", async() => {
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

#line default
#line hidden
            BeginContext(1222, 228, true);
            WriteLiteral("\t</div>\r\n\r\n\t<table class=\"table table-striped\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th class=\"image\">Kitab</th>\r\n\t\t\t\t<th>Adı</th>\r\n\t\t\t\t<th class=\"author\">Yazar</th>\r\n\t\t\t\t<th>Say</th>\r\n\t\t\t\t<th>Qiymət</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 66 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
             foreach (SaleBook saleBook in Model.SaleBooks)
			{

#line default
#line hidden
            BeginContext(1508, 41, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td class=\"image\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(1549, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2c5fcc7f60442fa8e302c721cf5a413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1591, "~/image/", 1591, 8, true);
#line 70 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
AddHtmlAttributeValue("", 1599, saleBook.Book.ImagePath, 1599, 24, false);

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
            BeginContext(1627, 14, true);
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n");
            EndContext();
#line 72 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                     if (saleBook.Book.Name.Length >= 30)
					{

#line default
#line hidden
            BeginContext(1693, 10, true);
            WriteLiteral("\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1704, 46, false);
#line 74 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                       Write(saleBook.Book.Name.ToString().Substring(0, 30));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 10, true);
            WriteLiteral("...</td>\r\n");
            EndContext();
#line 75 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(1787, 10, true);
            WriteLiteral("\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1798, 18, false);
#line 78 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                       Write(saleBook.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 79 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
					}

#line default
#line hidden
            BeginContext(1831, 26, true);
            WriteLiteral("\t\t\t\t\t<td class=\"author\">\r\n");
            EndContext();
#line 81 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                         foreach (BookAuthor bookAuthor in saleBook.Book.BookAuthors)
						{

#line default
#line hidden
            BeginContext(1935, 20, true);
            WriteLiteral("\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1956, 26, false);
#line 84 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                           Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1982, 21, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</p><br />\r\n");
            EndContext();
#line 86 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
						}

#line default
#line hidden
            BeginContext(2012, 21, true);
            WriteLiteral("\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2034, 14, false);
#line 88 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                   Write(saleBook.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(2065, 14, false);
#line 89 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
                   Write(saleBook.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2079, 20, true);
            WriteLiteral(" ₼</td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 91 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
			}

#line default
#line hidden
            BeginContext(2105, 26, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n\t");
            EndContext();
            BeginContext(2131, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdec124efbe44562a1e5427f3cd2d57b", async() => {
                BeginContext(2229, 117, true);
                WriteLiteral("\r\n\t\t<button type=\"submit\" class=\"ml-1 btn btn-danger\"><i class=\"mdi mdi-delete-forever\"></i> Sifarişi sil</button>\r\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\Detail.cshtml"
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
            BeginContext(2353, 14, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2384, 671, true);
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
            BeginContext(3058, 4, true);
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
