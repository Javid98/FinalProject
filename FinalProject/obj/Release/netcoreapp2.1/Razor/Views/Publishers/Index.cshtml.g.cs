#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2be001aebe438f0c2c35dcc0bffaff55501ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Index), @"mvc.1.0.view", @"/Views/Publishers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Publishers/Index.cshtml", typeof(AspNetCore.Views_Publishers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2be001aebe438f0c2c35dcc0bffaff55501ce1", @"/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/parallax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
  
	ViewData["Title"] = "Nəşriyyat evləri";

	char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'h', 'x', 'İ', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };

#line default
#line hidden
            BeginContext(256, 258, true);
            WriteLiteral(@"

<!-- Publisher Start -->

<section id=""Publisher"">
	<div class=""cover-photo parallax-window"" data-parallax=""scroll"" data-image-src=""image/parallaxBooks.jpg"">
		<h1>Nəşriyyat evləri</h1>
	</div>
	<div class=""publishers"">
		<div class=""container"">
");
            EndContext();
#line 17 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
             foreach (char letter in alphabet)
			{
				if (Model.Where(p => p.Name.ToLower().StartsWith(letter.ToString().ToLower())).Count() != 0)
				{

#line default
#line hidden
            BeginContext(664, 64, true);
            WriteLiteral("\t\t\t\t\t<div class=\"publishers-letter\">\r\n\t\t\t\t\t\t<div class=\"letter\">");
            EndContext();
            BeginContext(729, 27, false);
#line 22 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
                                       Write(letter.ToString().ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(756, 49, true);
            WriteLiteral("</div>\r\n\t\t\t\t\t\t<div class=\"publisher-wrapper\">\r\n\r\n");
            EndContext();
#line 25 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
                             foreach (Publisher publisher in Model.Where(p => p.Name.ToLower().StartsWith(letter.ToString().ToLower())))
							{

#line default
#line hidden
            BeginContext(932, 87, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"col-lg-3 col-md-4 col-md-4 col-sm-6 col-10 publisher\">\r\n\t\t\t\t\t\t\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1019, "\"", 1058, 2);
            WriteAttributeValue("", 1026, "/NewBooks/?pslug=", 1026, 17, true);
#line 28 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 1043, publisher.Slug, 1043, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1059, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1061, 14, false);
#line 28 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
                                                                          Write(publisher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 29 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
                                     if (publisher.Discount != 0)
									{

#line default
#line hidden
            BeginContext(1133, 87, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-tags\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t<span>");
            EndContext();
            BeginContext(1221, 18, false);
#line 33 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
                                             Write(publisher.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 28, true);
            WriteLiteral("%</span>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 35 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
									}

#line default
#line hidden
            BeginContext(1279, 16, true);
            WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n");
            EndContext();
#line 37 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
							}

#line default
#line hidden
            BeginContext(1305, 27, true);
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
#line 40 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Views\Publishers\Index.cshtml"
				}
			}

#line default
#line hidden
            BeginContext(1345, 59, true);
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n<!-- Publisher End -->\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1421, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(1424, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5311963407074dd991145e1d625012ac", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1468, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
