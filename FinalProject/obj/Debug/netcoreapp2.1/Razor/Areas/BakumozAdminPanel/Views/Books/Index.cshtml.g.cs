#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2def83eee33b9c5ef2510c1d6db0ceb4fd88a1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Books_Index), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Books/Index.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Books_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2def83eee33b9c5ef2510c1d6db0ceb4fd88a1a1", @"/Areas/BakumozAdminPanel/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 mb-2 btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
  
	ViewData["Title"] = "Kitablar";

#line default
#line hidden
            BeginContext(67, 79, true);
            WriteLiteral("\r\n\r\n<h2 style=\"text-align:center;font-weight:bold\" class=\"mt-3\">Kitablar</h2>\r\n");
            EndContext();
            BeginContext(146, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c99bdeb6c58348adab65bef5e47f24ac", async() => {
                BeginContext(226, 64, true);
                WriteLiteral("\r\n\t<i class=\"mr-1 mdi mdi-table-large\"></i>Yeni kitab əlavə et\r\n");
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
            BeginContext(294, 212, true);
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th scope=\"col\">Kitab</th>\r\n\t\t\t<th scope=\"col\">Adı</th>\r\n\t\t\t<th scope=\"col\">Yazar</th>\r\n\t\t\t<th scope=\"col\">Detallar</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
            EndContext();
#line 21 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
         foreach (Book book in Model)
		{

#line default
#line hidden
            BeginContext(544, 24, true);
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(568, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a7267921d334f4cbfb8575e48428853", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 610, "~/image/", 610, 8, true);
#line 25 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
AddHtmlAttributeValue("", 618, book.ImagePath, 618, 15, false);

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
            BeginContext(637, 13, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n");
            EndContext();
#line 27 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                 if (book.Name.Length > 20)
				{

#line default
#line hidden
            BeginContext(690, 9, true);
            WriteLiteral("\t\t\t\t\t<td>");
            EndContext();
            BeginContext(700, 37, false);
#line 29 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                   Write(book.Name.ToString().Substring(0, 20));

#line default
#line hidden
            EndContext();
            BeginContext(737, 10, true);
            WriteLiteral("...</td>\r\n");
            EndContext();
#line 30 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(771, 9, true);
            WriteLiteral("\t\t\t\t\t<td>");
            EndContext();
            BeginContext(781, 9, false);
#line 33 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                   Write(book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(790, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 34 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
				}

#line default
#line hidden
            BeginContext(804, 11, true);
            WriteLiteral("\r\n\t\t\t<td>\r\n");
            EndContext();
#line 37 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                 foreach (BookAuthor bookAuthor in book.BookAuthors)
				{
					if (bookAuthor.Author.Fullname.Length > 20)
					{

#line default
#line hidden
            BeginContext(938, 12, true);
            WriteLiteral("\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(951, 43, false);
#line 41 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                         Write(bookAuthor.Author.Fullname.Substring(0, 20));

#line default
#line hidden
            EndContext();
            BeginContext(994, 18, true);
            WriteLiteral("...</span><br />\r\n");
            EndContext();
#line 42 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(1039, 12, true);
            WriteLiteral("\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(1052, 26, false);
#line 45 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                         Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 15, true);
            WriteLiteral("</span><br />\r\n");
            EndContext();
#line 46 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
					}
				}

#line default
#line hidden
            BeginContext(1108, 25, true);
            WriteLiteral("\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1133, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18d31b395f894574abb83acc8f2746de", async() => {
                BeginContext(1224, 48, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<i class=\"mdi mdi-clipboard\"></i>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                                                                                         WriteLiteral(book.Id);

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
            BeginContext(1276, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1283, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cee74cef8b0a4da8b40b841ce04f9e4e", async() => {
                BeginContext(1372, 45, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<i class=\"mdi mdi-pencil\"></i>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                                                                                       WriteLiteral(book.Id);

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
            BeginContext(1421, 7, true);
            WriteLiteral("\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1428, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c2c7fabe4c449f6a95e0c60b750047d", async() => {
                BeginContext(1521, 53, true);
                WriteLiteral("\r\n\t\t\t\t\t\t<i class=\"mdi mdi-delete-forever\"></i>\r\n\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                                                                                           WriteLiteral(book.Id);

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
            BeginContext(1578, 23, true);
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 61 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(1606, 109, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n<nav aria-label=\"...\" class=\"d-flex justify-content-center\">\r\n\t<ul class=\"pagination\">\r\n");
            EndContext();
#line 66 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
         if (ViewBag.Page == 1 && ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(1772, 188, true);
            WriteLiteral("\t\t\t<li class=\"page-item\" style=\"pointer-events:none;\">\r\n\t\t\t\t<a style=\"background-color:#236bdf;color:white\" class=\"page-link\" href=\"/BakumozAdminPanel/Books?page=1\">Birinci</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 71 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
		}
		else if (ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(2005, 114, true);
            WriteLiteral("\t\t\t<li class=\"page-item\">\r\n\t\t\t\t<a class=\"page-link\" href=\"/BakumozAdminPanel/Books?page=1\">Birinci</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 77 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(2124, 2, true);
            WriteLiteral("\t\t");
            EndContext();
#line 78 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
         if (Model.Count() != 0)
		{
			

#line default
#line hidden
#line 80 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
             for (int i = 1; i <= ViewBag.PageCount; i++)
			{

				if (i == ViewBag.Page)
				{

#line default
#line hidden
            BeginContext(2250, 129, true);
            WriteLiteral("\t\t\t\t\t<li class=\"page-item current\" style=\"pointer-events:none;\"><a class=\"page-link\" style=\"background-color:#236bdf;color:white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2379, "\"", 2418, 2);
            WriteAttributeValue("", 2386, "/BakumozAdminPanel/Books?page=", 2386, 30, true);
#line 85 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
WriteAttributeValue("", 2416, i, 2416, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2419, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2421, 1, false);
#line 85 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                                                                                                                                                                                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2422, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 86 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
				}
				else
				{

#line default
#line hidden
            BeginContext(2458, 55, true);
            WriteLiteral("\t\t\t\t\t<li class=\"page-item\">\r\n\t\t\t\t\t\t<a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2513, "\"", 2552, 2);
            WriteAttributeValue("", 2520, "/BakumozAdminPanel/Books?page=", 2520, 30, true);
#line 90 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
WriteAttributeValue("", 2550, i, 2550, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2553, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2555, 1, false);
#line 90 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
                                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2556, 18, true);
            WriteLiteral("</a>\r\n\t\t\t\t\t</li>\r\n");
            EndContext();
#line 92 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
				}
			}

#line default
#line hidden
#line 93 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
             
		}

#line default
#line hidden
            BeginContext(2592, 2, true);
            WriteLiteral("\t\t");
            EndContext();
#line 95 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
         if (ViewBag.Page == ViewBag.PageCount && ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(2665, 125, true);
            WriteLiteral("\t\t\t<li class=\"page-item\" style=\"pointer-events:none;\">\r\n\t\t\t\t<a style=\"background-color:#236bdf;color:white\" class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2790, "\"", 2845, 2);
            WriteAttributeValue("", 2797, "/BakumozAdminPanel/Books?page=", 2797, 30, true);
#line 98 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
WriteAttributeValue("", 2827, ViewBag.PageCount, 2827, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2846, 24, true);
            WriteLiteral(">Sonuncu</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 100 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
		}
		else if (ViewBag.PageCount > 1)
		{

#line default
#line hidden
            BeginContext(2915, 51, true);
            WriteLiteral("\t\t\t<li class=\"page-item\">\r\n\t\t\t\t<a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2966, "\"", 3021, 2);
            WriteAttributeValue("", 2973, "/BakumozAdminPanel/Books?page=", 2973, 30, true);
#line 104 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
WriteAttributeValue("", 3003, ViewBag.PageCount, 3003, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3022, 24, true);
            WriteLiteral(">Sonuncu</a>\r\n\t\t\t</li>\r\n");
            EndContext();
#line 106 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Books\Index.cshtml"
		}

#line default
#line hidden
            BeginContext(3051, 22, true);
            WriteLiteral("\r\n\t</ul>\r\n</nav>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3090, 447, true);
                WriteLiteral(@"
	<script>
		$("".pagination li"").not($("".pagination li.current"")).not($("".pagination li.current"").prev()).not($("".pagination li.current"").prev().prev()).not($("".pagination li.current"").prev().prev().prev()).not($("".pagination li.current"").next()).not($("".pagination li.current"").next().next()).not($("".pagination li.current"").next().next().next()).not($("".pagination li"").first()).not($("".pagination li"").last()).addClass(""d-none"")
	</script>
");
                EndContext();
            }
            );
            BeginContext(3540, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
