#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc3ee528e27aef4f6e15985eea1a1ed4142406d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Sales_CompletedSales), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Sales/CompletedSales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Sales/CompletedSales.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Sales_CompletedSales))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc3ee528e27aef4f6e15985eea1a1ed4142406d", @"/Areas/BakumozAdminPanel/Views/Sales/CompletedSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Sales_CompletedSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
  
	ViewData["Title"] = "Tamamlanmışlar";

#line default
#line hidden
            BeginContext(73, 332, true);
            WriteLiteral(@"
<h2 style=""text-align:center;font-weight:bold"" class=""mt-3"">Tamamlanmış sifarişlər</h2>
<table class=""table table-striped"">
	<thead>
		<tr>
			<th scope=""col"">Müştəri</th>
			<th scope=""col"" class=""saledate"">Satışın tarixi</th>
			<th scope=""col"">Məbləğ</th>
			<th scope=""col"">Detallar</th>
		</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 17 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
         foreach (Sale sale in Model)
		{

#line default
#line hidden
            BeginContext(443, 17, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(461, 21, false);
#line 20 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
               Write(sale.AppUser.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(482, 32, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td class=\"saledate\">");
            EndContext();
            BeginContext(515, 9, false);
#line 21 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
                                Write(sale.Date);

#line default
#line hidden
            EndContext();
            BeginContext(524, 15, true);
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(540, 10, false);
#line 22 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
               Write(sale.Total);

#line default
#line hidden
            EndContext();
            BeginContext(550, 24, true);
            WriteLiteral(" ₼</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(574, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56fe2c62f3dd491eb61ad7ab31db783c", async() => {
                BeginContext(665, 84, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<i style=\"color:white; font-size:22px\" class=\"mdi mdi-clipboard\"></i>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
                                                                                         WriteLiteral(sale.Id);

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
            BeginContext(753, 23, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 29 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
		}

#line default
#line hidden
            BeginContext(781, 109, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n<nav aria-label=\"...\" class=\"d-flex justify-content-center\">\r\n\t<ul class=\"pagination\">\r\n");
            EndContext();
#line 34 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
         if (ViewBag.Page == 1 && ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(947, 211, true);
            WriteLiteral("\t\t\t<li class=\"page-item current\" style=\"pointer-events:none;\">\r\n\t\t\t\t<a style=\"background-color:#236bdf;color:white\" class=\"page-link\" href=\"/BakumozAdminPanel/Sales/CompletedSales?page=1\">Birinci</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 39 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
		}
		else if (ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(1203, 129, true);
            WriteLiteral("\t\t\t<li class=\"page-item\">\r\n\t\t\t\t<a class=\"page-link\" href=\"/BakumozAdminPanel/Sales/CompletedSales?page=1\">Birinci</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 45 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
		}

#line default
#line hidden
            BeginContext(1337, 2, true);
            WriteLiteral("\t\t");
            EndContext();
#line 46 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
         for (int i = 1; i <= ViewBag.PageCount; i++)
		{

			if (i == ViewBag.Page)
			{

#line default
#line hidden
            BeginContext(1426, 128, true);
            WriteLiteral("\t\t\t\t<li class=\"page-item current\" style=\"pointer-events:none;\"><a class=\"page-link\" style=\"background-color:#236bdf;color:white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1554, "\"", 1608, 2);
            WriteAttributeValue("", 1561, "/BakumozAdminPanel/Sales/CompletedSales?page=", 1561, 45, true);
#line 51 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
WriteAttributeValue("", 1606, i, 1606, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1609, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1611, 1, false);
#line 51 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
                                                                                                                                                                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 52 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
			}
			else
			{

#line default
#line hidden
            BeginContext(1645, 53, true);
            WriteLiteral("\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t<a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1698, "\"", 1752, 2);
            WriteAttributeValue("", 1705, "/BakumozAdminPanel/Sales/CompletedSales?page=", 1705, 45, true);
#line 56 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
WriteAttributeValue("", 1750, i, 1750, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1753, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1755, 1, false);
#line 56 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
                                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1756, 17, true);
            WriteLiteral("</a>\r\n\t\t\t\t</li>\r\n");
            EndContext();
#line 58 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
			}
		}

#line default
#line hidden
            BeginContext(1784, 2, true);
            WriteLiteral("\t\t");
            EndContext();
#line 60 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
         if (ViewBag.Page == ViewBag.PageCount && ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(1857, 133, true);
            WriteLiteral("\t\t\t<li class=\"page-item current\" style=\"pointer-events:none;\">\r\n\t\t\t\t<a style=\"background-color:#236bdf;color:white\" class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1990, "\"", 2060, 2);
            WriteAttributeValue("", 1997, "/BakumozAdminPanel/Sales/CompletedSales?page=", 1997, 45, true);
#line 63 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
WriteAttributeValue("", 2042, ViewBag.PageCount, 2042, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2061, 24, true);
            WriteLiteral(">Sonuncu</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 65 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
		}
		else if (ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(2130, 51, true);
            WriteLiteral("\t\t\t<li class=\"page-item\">\r\n\t\t\t\t<a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2181, "\"", 2251, 2);
            WriteAttributeValue("", 2188, "/BakumozAdminPanel/Sales/CompletedSales?page=", 2188, 45, true);
#line 69 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
WriteAttributeValue("", 2233, ViewBag.PageCount, 2233, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2252, 24, true);
            WriteLiteral(">Sonuncu</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 71 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Sales\CompletedSales.cshtml"
		}

#line default
#line hidden
            BeginContext(2281, 22, true);
            WriteLiteral("\r\n\t</ul>\r\n</nav>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2320, 447, true);
                WriteLiteral(@"
	<script>
		$("".pagination li"").not($("".pagination li.current"")).not($("".pagination li.current"").prev()).not($("".pagination li.current"").prev().prev()).not($("".pagination li.current"").prev().prev().prev()).not($("".pagination li.current"").next()).not($("".pagination li.current"").next().next()).not($("".pagination li.current"").next().next().next()).not($("".pagination li"").first()).not($("".pagination li"").last()).addClass(""d-none"")
	</script>
");
                EndContext();
            }
            );
            BeginContext(2770, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
