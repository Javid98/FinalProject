#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17f342bd23dc56f827fd22991585716d39335ad1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Publishers_Index), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Publishers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Publishers/Index.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Publishers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17f342bd23dc56f827fd22991585716d39335ad1", @"/Areas/BakumozAdminPanel/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 mb-2 btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Publishers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-1 btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
  
	ViewData["Title"] = "Nəşriyyat evləri";

#line default
#line hidden
            BeginContext(80, 114, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n\t<h2 style=\"text-align:center;font-weight:bold\" class=\"mt-3\">Nəşriyyat evləri</h2>\r\n\t");
            EndContext();
            BeginContext(194, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a70c5f25005e4eb39adb646da92014e5", async() => {
                BeginContext(279, 70, true);
                WriteLiteral("\r\n\t\t<i class=\"mr-1 mdi mdi-new-box\"></i>Yeni nəşriyyat evi əlavə et\r\n\t");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(353, 205, true);
            WriteLiteral("\r\n\t<table class=\"table table-striped\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th scope=\"col\">Nəşriyyat evi</th>\r\n\t\t\t\t<th scope=\"col\">Kitab sayı</th>\r\n\t\t\t\t<th scope=\"col\">Detallar</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
            EndContext();
#line 21 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
             foreach (Publisher publisher in Model)
			{

#line default
#line hidden
            BeginContext(608, 19, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(628, 14, false);
#line 24 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
                   Write(publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(642, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(659, 19, false);
#line 25 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
                   Write(publisher.BookCount);

#line default
#line hidden
            EndContext();
            BeginContext(678, 24, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(702, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "194f7d1a21ba430a84045a93da1fa588", async() => {
                BeginContext(801, 47, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<i class=\"mdi mdi-pencil\"></i>\r\n\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
                                                                                                WriteLiteral(publisher.Id);

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
            BeginContext(852, 8, true);
            WriteLiteral("\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(860, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "180d34ab21dc4e6b991eab10cf5694ec", async() => {
                BeginContext(968, 55, true);
                WriteLiteral("\r\n\t\t\t\t\t\t\t<i class=\"mdi mdi-delete-forever\"></i>\r\n\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
                                                                                                         WriteLiteral(publisher.Id);

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
            BeginContext(1027, 25, true);
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 35 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(1058, 115, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n\t<nav aria-label=\"...\" class=\"d-flex justify-content-center\">\r\n\t\t<ul class=\"pagination\">\r\n");
            EndContext();
#line 41 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
             if (ViewBag.Page == 1 && ViewBag.PageCount > 1)
			{

#line default
#line hidden
            BeginContext(1232, 192, true);
            WriteLiteral("\t\t\t\t<li class=\"page-item\" style=\"pointer-events:none;\">\r\n\t\t\t\t\t<a style=\"background-color:#236bdf;color:white\" class=\"page-link\" href=\"/BakumozAdminPanel/Author?page=1\">Birinci</a>\r\n\t\t\t\t</li>\r\n");
            EndContext();
#line 46 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
			}
			else if (ViewBag.PageCount > 1)
			{

#line default
#line hidden
            BeginContext(1472, 118, true);
            WriteLiteral("\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t<a class=\"page-link\" href=\"/BakumozAdminPanel/Author?page=1\">Birinci</a>\r\n\t\t\t\t</li>\r\n");
            EndContext();
#line 52 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(1596, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
#line 53 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
             for (int i = 1; i <= ViewBag.PageCount; i++)
			{

				if (i == ViewBag.Page)
				{

#line default
#line hidden
            BeginContext(1689, 129, true);
            WriteLiteral("\t\t\t\t\t<li class=\"page-item current\" style=\"pointer-events:none;\"><a class=\"page-link\" style=\"background-color:#236bdf;color:white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1818, "\"", 1858, 2);
            WriteAttributeValue("", 1825, "/BakumozAdminPanel/Author?page=", 1825, 31, true);
#line 58 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 1856, i, 1856, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1859, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1861, 1, false);
#line 58 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
                                                                                                                                                                                     Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1862, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 59 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(1898, 55, true);
            WriteLiteral("\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t<a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1953, "\"", 1993, 2);
            WriteAttributeValue("", 1960, "/BakumozAdminPanel/Author?page=", 1960, 31, true);
#line 63 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 1991, i, 1991, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1994, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1996, 1, false);
#line 63 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
                                                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1997, 18, true);
            WriteLiteral("</a>\r\n\t\t\t\t\t</li>\r\n");
            EndContext();
#line 65 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
				}
			}

#line default
#line hidden
            BeginContext(2028, 3, true);
            WriteLiteral("\t\t\t");
            EndContext();
#line 67 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
             if (ViewBag.Page == ViewBag.PageCount && ViewBag.PageCount > 1)
			{

#line default
#line hidden
            BeginContext(2103, 127, true);
            WriteLiteral("\t\t\t\t<li class=\"page-item\" style=\"pointer-events:none;\">\r\n\t\t\t\t\t<a style=\"background-color:#236bdf;color:white\" class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2230, "\"", 2286, 2);
            WriteAttributeValue("", 2237, "/BakumozAdminPanel/Author?page=", 2237, 31, true);
#line 70 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 2268, ViewBag.PageCount, 2268, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2287, 25, true);
            WriteLiteral(">Sonuncu</a>\r\n\t\t\t\t</li>\r\n");
            EndContext();
#line 72 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
			}
			else if (ViewBag.PageCount > 1)
			{

#line default
#line hidden
            BeginContext(2360, 53, true);
            WriteLiteral("\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t<a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2413, "\"", 2469, 2);
            WriteAttributeValue("", 2420, "/BakumozAdminPanel/Author?page=", 2420, 31, true);
#line 76 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 2451, ViewBag.PageCount, 2451, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2470, 25, true);
            WriteLiteral(">Sonuncu</a>\r\n\t\t\t\t</li>\r\n");
            EndContext();
#line 78 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Publishers\Index.cshtml"
			}

#line default
#line hidden
            BeginContext(2501, 30, true);
            WriteLiteral("\r\n\t\t</ul>\r\n\t</nav>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2548, 447, true);
                WriteLiteral(@"
	<script>
		$("".pagination li"").not($("".pagination li.current"")).not($("".pagination li.current"").prev()).not($("".pagination li.current"").prev().prev()).not($("".pagination li.current"").prev().prev().prev()).not($("".pagination li.current"").next()).not($("".pagination li.current"").next().next()).not($("".pagination li.current"").next().next().next()).not($("".pagination li"").first()).not($("".pagination li"").last()).addClass(""d-none"")
	</script>
");
                EndContext();
            }
            );
            BeginContext(2998, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
