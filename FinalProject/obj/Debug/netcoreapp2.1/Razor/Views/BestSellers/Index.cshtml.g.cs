#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cd1111786ad131185c670abe0d8f398f8f7895b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BestSellers_Index), @"mvc.1.0.view", @"/Views/BestSellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BestSellers/Index.cshtml", typeof(AspNetCore.Views_BestSellers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd1111786ad131185c670abe0d8f398f8f7895b", @"/Views/BestSellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_BestSellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewBooksVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animate__animated animate__fadeInRight"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/kampanya.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NewBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(60, 1399, true);
            WriteLiteral(@"

<section id=""saleBooks"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""content animate__animated animate__fadeInLeft col-lg-7 col-xs-12 col-12"">
                <div class=""title"">
                    <h3>Endless Possibilities in a Single Theme!</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eos esse, ex, natus nesciunt reiciendis fugit numquam velit quod </p>
                </div>
                <div class=""options"">
                    <div class=""option"">
                        <ul>
                            <li>Easy and fun to work with</li>
                            <li>Very customizable</li>
                            <li>Clean and secure code</li>
                            <li> New features added all the time</li>
                        </ul>
                    </div>
                    <div class=""option"">
                        <ul>
                            <li>Always ");
            WriteLiteral(@"up to date</li>
                            <li>Amazing demo templates</li>
                            <li>Responsive and mobile ready</li>
                            <li>Parallax support</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""image col-lg-5 col-xs-7 col-7"">
                ");
            EndContext();
            BeginContext(1459, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09f452bf8bfa4dafab94709b4ce32f42", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1545, 652, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>

<!-- Best Sellers Start -->

<section id=""newBooks"">
    <div class=""container"">
        <div class=""col title"">
            <h2>Çox satılanlar</h2>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-lg-9 col-sm-12 book-section"">
                <div class=""container"">
                    <div class=""col-12 col-sm-12 row bScount books-count"">

                        <p style=""text-align: center;"" class=""col-12 col-sm-12"">100 kitabdan 1-16 arası göstərilir</p>
                    </div>
                    <div class=""books"">
");
            EndContext();
#line 56 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                         foreach (Book book in Model.Books)
                        {

#line default
#line hidden
            BeginContext(2285, 177, true);
            WriteLiteral("                            <div class=\"row bestSellers book\">\r\n                                <div class=\"col-md-2 col-sm-4 col-4 image\">\r\n                                    ");
            EndContext();
            BeginContext(2462, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c9778a4fbe4fd4a297e00db7db32fc", async() => {
                BeginContext(2539, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9e9a8496dbc48d596439da227041922", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2549, "~/image/", 2549, 8, true);
#line 60 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
AddHtmlAttributeValue("", 2557, book.ImagePath, 2557, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-slug", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                                                                         WriteLiteral(book.Slug);

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
            BeginContext(2585, 217, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-10 col-sm-12 col-12 content\">\r\n                                    <h4>\r\n                                        <a href=\"\">");
            EndContext();
            BeginContext(2803, 9, false);
#line 64 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                              Write(book.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2812, 117, true);
            WriteLiteral("</a>\r\n                                    </h4>\r\n                                    <div class=\"author-publisher\">\r\n");
            EndContext();
#line 67 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                         foreach (BookAuthor bookAuthor in Model.BookAuthors.Where(ba => ba.BookId == book.Id))
                                        {

#line default
#line hidden
            BeginContext(3101, 108, true);
            WriteLiteral("                                            <p>\r\n                                                <a href=\"\">");
            EndContext();
            BeginContext(3210, 26, false);
#line 70 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                                      Write(bookAuthor.Author.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(3236, 56, true);
            WriteLiteral("</a>\r\n                                            </p>\r\n");
            EndContext();
#line 72 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3335, 95, true);
            WriteLiteral("                                    <span>\r\n                                        <a href=\"\">");
            EndContext();
            BeginContext(3431, 67, false);
#line 74 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                              Write(Model.Publishers.FirstOrDefault(p => p.Id == book.PublisherId).Name);

#line default
#line hidden
            EndContext();
            BeginContext(3498, 203, true);
            WriteLiteral("</a>\r\n                                    </span>\r\n                                    </div>\r\n                                    <div class=\"mt-3 price\">\r\n                                        <span>");
            EndContext();
            BeginContext(3702, 10, false);
#line 78 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                                         Write(book.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3712, 535, true);
            WriteLiteral(@" ₼</span>
                                    </div>
                                    <div class=""book-buttons"">

                                        <a href="""" class=""btn mt-2 shopBtn btn-info""><i class=""mr-1 fas fa-shopping-basket""></i>Səbətə əlavə et</a>
                                        <a href="""" class=""mt-2 fBtn btn btn-secondary""><i class=""mr-1 fas fa-plus""></i>Favoritlərə əlavə et</a>
                                    </div>
                                </div>
                            </div>
");
            EndContext();
#line 87 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\BestSellers\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4274, 896, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
        <nav class=""pagination mt-4 row justify-content-center"" aria-label=""..."">
            <ul class=""pagination"">
                <li class=""page-item disabled"">
                    <a class=""page-link"" href=""#"" tabindex=""-1"">Əvvəlki</a>
                </li>
                <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                <li class=""page-item"">
                    <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                <li class=""page-item"">
                    <a class=""page-link"" href=""#"">Sonrakı</a>
                </li>
            </ul>
        </nav>
    </div>
</section>

<!-- Best Seller End -->
");
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
