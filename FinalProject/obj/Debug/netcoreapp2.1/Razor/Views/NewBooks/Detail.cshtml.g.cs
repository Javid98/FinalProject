#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be64a476b412dcd7bd4a1e5890082489619f1d70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewBooks_Detail), @"mvc.1.0.view", @"/Views/NewBooks/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewBooks/Detail.cshtml", typeof(AspNetCore.Views_NewBooks_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be64a476b412dcd7bd4a1e5890082489619f1d70", @"/Views/NewBooks/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_NewBooks_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewBooksVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NewBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
  
	ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(58, 199, true);
            WriteLiteral("\r\n\r\n<!-- Book Detail Start -->\r\n\r\n<section id=\"bookDetail\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row book justify-content-center\">\r\n\t\t\t<div class=\"col-lg-3 col-sm-4 col-4 image\">\r\n\t\t\t\t<a href=\"\">");
            EndContext();
            BeginContext(257, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f752cb4dc45f4ef0aa69d3439b0faf3f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 267, "~/image/", 267, 8, true);
#line 13 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
AddHtmlAttributeValue("", 275, Model.Book.ImagePath, 275, 21, false);

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
            BeginContext(305, 95, true);
            WriteLiteral("</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-lg-8 col-sm-12 col-12 content\">\r\n\t\t\t\t<h3>\r\n\t\t\t\t\t<a href=\"\">");
            EndContext();
            BeginContext(401, 15, false);
#line 17 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                          Write(Model.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(416, 53, true);
            WriteLiteral("</a>\r\n\t\t\t\t</h3>\r\n\t\t\t\t<div class=\"author-publisher\">\r\n");
            EndContext();
#line 20 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                     foreach (BookAuthor bookAuthor in Model.BookAuthors)
					{

#line default
#line hidden
            BeginContext(537, 29, true);
            WriteLiteral("\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t<a href=\"\">");
            EndContext();
            BeginContext(567, 26, false);
#line 23 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                  Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(593, 18, true);
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</p>\r\n");
            EndContext();
#line 25 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
					}

#line default
#line hidden
            BeginContext(619, 30, true);
            WriteLiteral("\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<a href=\"\">");
            EndContext();
            BeginContext(650, 20, false);
#line 27 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                              Write(Model.Publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(670, 73, true);
            WriteLiteral("</a>\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"mt-3 price\">\r\n\t\t\t\t\t<span>");
            EndContext();
            BeginContext(744, 16, false);
#line 31 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                     Write(Model.Book.Price);

#line default
#line hidden
            EndContext();
            BeginContext(760, 46, true);
            WriteLiteral(" ₼</span>\r\n\t\t\t\t\t<div class=\"stock\">\r\n\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(807, 16, false);
#line 33 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                      Write(Model.Book.Count);

#line default
#line hidden
            EndContext();
            BeginContext(823, 580, true);
            WriteLiteral(@" adet stoklarımızda</p>
					</div>
				</div>
				<div class=""book-buttons"">

					<a href="""" class=""btn mt-2 shopBtn btn-info""><i class=""mr-1 fas fa-shopping-basket""></i>Səbətə əlavə et</a>
					<a href="""" class=""mt-2 fBtn btn btn-secondary""><i class=""mr-1 fas fa-plus""></i>Favoritlərə əlavə et</a>
				</div>
				<div class=""book-details"">
					<div class=""menu"">
						<div data-id=""1"" class=""selected"">Açıqlama</div>
						<div data-id=""2"">Detallar</div>
					</div>
					<div class=""details"">
						<div data-id=""1"" class=""option opened"">
							<p>
								");
            EndContext();
            BeginContext(1404, 22, false);
#line 49 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                           Write(Model.Book.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 258, true);
            WriteLiteral(@"
							</p>
						</div>
						<div data-id=""2"" class=""option"">
							<div class=""row"">
								<div class=""col-sm-4 col-4"">
									<div class=""properties"">
										<h6>Kitabın özəllikləri</h6>
										<ul>
											<li>Nəşriyyat tarixi : ");
            EndContext();
            BeginContext(1685, 55, false);
#line 58 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                                              Write(Model.BookFeature.PublishingDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 39, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t<li>Nəşriyyat yeri : ");
            EndContext();
            BeginContext(1780, 33, false);
#line 59 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                                            Write(Model.BookFeature.PublishingPlace);

#line default
#line hidden
            EndContext();
            BeginContext(1813, 39, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t<li>Nəşriyyat dili : ");
            EndContext();
            BeginContext(1853, 36, false);
#line 60 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                                            Write(Model.BookFeature.PublishingLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 38, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t<li>Original dili : ");
            EndContext();
            BeginContext(1928, 34, false);
#line 61 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                                           Write(Model.BookFeature.OriginalLanguage);

#line default
#line hidden
            EndContext();
            BeginContext(1962, 173, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4 col-4\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"categories\">\r\n\t\t\t\t\t\t\t\t\t\t<h6>Kitabın kateqoriyaları</h6>\r\n");
            EndContext();
#line 68 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                         foreach (BookCategory bookCategory in Model.BookCategories)
										{

#line default
#line hidden
            BeginContext(2220, 17, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(2238, 26, false);
#line 70 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                             Write(bookCategory.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2264, 15, true);
            WriteLiteral("</span><br />\r\n");
            EndContext();
#line 71 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
										}

#line default
#line hidden
            BeginContext(2292, 147, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4 col-4\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"support\">\r\n\t\t\t\t\t\t\t\t\t\t<p>Tərcüməçi</p>\r\n\t\t\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(2440, 28, false);
#line 77 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                         Write(Model.BookFeature.Translator);

#line default
#line hidden
            EndContext();
            BeginContext(2468, 197, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n<!-- Book Detail End -->\r\n<!-- Owl Carousel Start -->\r\n\r\n");
            EndContext();
#line 92 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
 if (Model.rBookCategories.Count != 0)
{

#line default
#line hidden
            BeginContext(2708, 163, true);
            WriteLiteral("\t<section id=\"OwlCarousel\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"title\">\r\n\t\t\t\t\t<h3>Bənzər Kitablar</h3>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"owl-carousel owl-theme\">\r\n");
            EndContext();
#line 100 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                 foreach (BookCategory rBookCategory in Model.rBookCategories.Take(12))
				{

#line default
#line hidden
            BeginContext(2955, 31, true);
            WriteLiteral("\t\t\t\t\t<div class=\"item\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(2986, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df7daf96441e44a6be1b667d30262733", async() => {
                BeginContext(3077, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8c4fe1fc3f5464883563a2307db62c2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3087, "~/image/", 3087, 8, true);
#line 103 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
AddHtmlAttributeValue("", 3095, rBookCategory.Book.ImagePath, 3095, 29, false);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 103 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                                                                             WriteLiteral(rBookCategory.Book.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3137, 39, true);
            WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"name\">\r\n\t\t\t\t\t\t\t<h6>");
            EndContext();
            BeginContext(3177, 23, false);
#line 105 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                           Write(rBookCategory.Book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3200, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 106 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                             foreach (BookAuthor bookAuthor in Model.rBookAuthors.Where(rb=>rb.BookId==rBookCategory.Book.Id))
							{

#line default
#line hidden
            BeginContext(3324, 11, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<p>");
            EndContext();
            BeginContext(3336, 26, false);
#line 108 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
                              Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(3362, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 109 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
							}

#line default
#line hidden
            BeginContext(3378, 27, true);
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 112 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
				}

#line default
#line hidden
            BeginContext(3412, 34, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n");
            EndContext();
#line 116 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\NewBooks\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(3449, 31, true);
            WriteLiteral("\r\n<!-- Owl Carousel Start -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewBooksVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
