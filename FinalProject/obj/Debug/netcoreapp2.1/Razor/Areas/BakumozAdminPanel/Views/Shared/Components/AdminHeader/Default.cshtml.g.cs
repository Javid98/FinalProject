#pragma checksum "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf8d572763f8be8f6db1ece49511d29e60cf50fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Shared_Components_AdminHeader_Default), @"mvc.1.0.view", @"/Areas/BakumozAdminPanel/Views/Shared/Components/AdminHeader/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/BakumozAdminPanel/Views/Shared/Components/AdminHeader/Default.cshtml", typeof(AspNetCore.Areas_BakumozAdminPanel_Views_Shared_Components_AdminHeader_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf8d572763f8be8f6db1ece49511d29e60cf50fd", @"/Areas/BakumozAdminPanel/Views/Shared/Components/AdminHeader/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61980f71bc99729850df61b47f933129b8b9ef4c", @"/Areas/BakumozAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_BakumozAdminPanel_Views_Shared_Components_AdminHeader_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/images/faces/face1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 1239, true);
            WriteLiteral(@"<header class=""mdc-top-app-bar"">
	<div class=""mdc-top-app-bar__row"">
		<div class=""mdc-top-app-bar__section mdc-top-app-bar__section--align-start"">
			<button class=""material-icons mdc-top-app-bar__navigation-icon mdc-icon-button sidebar-toggler"">menu</button>
			<span class=""mdc-top-app-bar__title""><strong>Bakumoz</strong></span>
			<div class=""mdc-text-field mdc-text-field--outlined mdc-text-field--with-leading-icon search-text-field d-none d-md-flex"">
				<i class=""material-icons mdc-text-field__icon"">search</i>
				<input class=""mdc-text-field__input"" id=""text-field-hero-input"">
				<div class=""mdc-notched-outline"">
					<div class=""mdc-notched-outline__leading""></div>
					<div class=""mdc-notched-outline__notch"">
						<label for=""text-field-hero-input"" class=""mdc-floating-label"">Search..</label>
					</div>
					<div class=""mdc-notched-outline__trailing""></div>
				</div>
			</div>
		</div>
		<div class=""mdc-top-app-bar__section mdc-top-app-bar__section--align-end mdc-top-app-bar__secti");
            WriteLiteral("on-right\">\r\n\t\t\t<div class=\"menu-button-container menu-profile d-none d-md-block\">\r\n\t\t\t\t<button class=\"mdc-button mdc-menu-button\">\r\n\t\t\t\t\t<span class=\"d-flex align-items-center\">\r\n\t\t\t\t\t\t<span class=\"figure\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1255, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eab584bbac1c4e03a9d6d73ab38c9603", async() => {
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
            BeginContext(1321, 1630, true);
            WriteLiteral(@"
						</span>
						<span class=""user-name"">Clyde Miles</span>
					</span>
				</button>
			</div>
			<div class=""divider d-none d-md-block""></div>
			<div class=""menu-button-container d-none d-md-block"">
				<button class=""mdc-button mdc-menu-button"">
					<i class=""mdi mdi-settings""></i>
				</button>
				<div class=""mdc-menu mdc-menu-surface"" tabindex=""-1"">
					<ul class=""mdc-list"" role=""menu"" aria-hidden=""true"" aria-orientation=""vertical"">
						<li class=""mdc-list-item"" role=""menuitem"">
							<div class=""item-thumbnail item-thumbnail-icon-only"">
								<i class=""mdi mdi-account-edit-outline text-primary""></i>
							</div>
							<div class=""item-content d-flex align-items-start flex-column justify-content-center"">
								<h6 class=""item-subject font-weight-normal"">Profil</h6>
							</div>
						</li>
						<li class=""mdc-list-item"" role=""menuitem"">
							<div class=""item-thumbnail item-thumbnail-icon-only"">
								<i class=""mdi mdi-logout-variant text-primary""></i>
					");
            WriteLiteral(@"		</div>
							<div class=""item-content d-flex align-items-start flex-column justify-content-center"">
								<h6 class=""item-subject font-weight-normal"">Çıxış</h6>
							</div>
						</li>
					</ul>
				</div>
			</div>
			<div class=""menu-button-container"">
				<button class=""mdc-button mdc-menu-button"">
					<i class=""mdi mdi-bell""></i>
				</button>
				<div class=""mdc-menu mdc-menu-surface"" tabindex=""-1"">
					<h6 class=""title""> <i class=""mdi mdi-bell-outline mr-2 tx-16""></i> Sifarişlər</h6>
					<ul class=""mdc-list"" role=""menu"" aria-hidden=""true"" aria-orientation=""vertical"">
");
            EndContext();
#line 63 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                         foreach (Sale sale in Model.Sales.Take(4))
						{

#line default
#line hidden
            BeginContext(3011, 59, true);
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"mdc-list-item\" role=\"menuitem\">\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(3070, 528, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "521c0f1e074a4dbea4d425357f2cad87", async() => {
                BeginContext(3181, 278, true);
                WriteLiteral(@"
									<div class=""item-thumbnail item-thumbnail-icon"">
										<i class=""mdi mdi-email-outline""></i>
									</div>
									<div class=""item-content d-flex align-items-start flex-column justify-content-center"">
										<h6 class=""item-subject font-weight-normal"">");
                EndContext();
                BeginContext(3460, 21, false);
#line 71 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                                                               Write(sale.AppUser.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(3481, 44, true);
                WriteLiteral("</h6>\r\n\t\t\t\t\t\t\t\t\t\t<small class=\"text-muted\"> ");
                EndContext();
                BeginContext(3526, 32, false);
#line 72 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                                              Write(sale.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(3558, 36, true);
                WriteLiteral(" </small>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
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
            BeginContext(3598, 16, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n");
            EndContext();
#line 76 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
						}

#line default
#line hidden
            BeginContext(3623, 160, true);
            WriteLiteral("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"menu-button-container\">\r\n\t\t\t\t<button class=\"mdc-button mdc-menu-button\">\r\n\t\t\t\t\t<i class=\"mdi mdi-email\"></i>\r\n");
            EndContext();
#line 83 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                     if (Model.Contacts.Count() < 9)
					{

#line default
#line hidden
            BeginContext(3830, 65, true);
            WriteLiteral("\t\t\t\t\t\t<span class=\"count-indicator\">\r\n\t\t\t\t\t\t\t<span class=\"count\">");
            EndContext();
            BeginContext(3896, 22, false);
#line 86 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                           Write(Model.Contacts.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3918, 24, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t\t</span>\r\n");
            EndContext();
#line 88 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(3969, 91, true);
            WriteLiteral("\t\t\t\t\t\t<span class=\"count-indicator\">\r\n\t\t\t\t\t\t\t<span class=\"count\">9+</span>\r\n\t\t\t\t\t\t</span>\r\n");
            EndContext();
#line 94 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
					}

#line default
#line hidden
            BeginContext(4068, 248, true);
            WriteLiteral("\t\t\t\t</button>\r\n\t\t\t\t<div class=\"mdc-menu mdc-menu-surface\" tabindex=\"-1\">\r\n\t\t\t\t\t<h6 class=\"title\"><i class=\"mdi mdi-email-outline mr-2 tx-16\"></i> Mesajlar</h6>\r\n\t\t\t\t\t<ul class=\"mdc-list\" role=\"menu\" aria-hidden=\"true\" aria-orientation=\"vertical\">\r\n");
            EndContext();
#line 99 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                         foreach (Contact contact in Model.Contacts.Take(3))
						{

#line default
#line hidden
            BeginContext(4385, 210, true);
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"mdc-list-item\" role=\"menuitem\">\r\n\t\t\t\t\t\t\t\t<a href=\"\" style=\"text-decoration:none;color:black\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"item-content d-flex align-items-start flex-column justify-content-center\">\r\n");
            EndContext();
#line 104 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                         if (contact.Message.Length <= 30)
										{

#line default
#line hidden
            BeginContext(4654, 55, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<h6 class=\"item-subject font-weight-normal\">");
            EndContext();
            BeginContext(4710, 15, false);
#line 106 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                                                                   Write(contact.Message);

#line default
#line hidden
            EndContext();
            BeginContext(4725, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 107 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
										}
										else
										{

#line default
#line hidden
            BeginContext(4774, 55, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<h6 class=\"item-subject font-weight-normal\">");
            EndContext();
            BeginContext(4830, 32, false);
#line 110 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                                                                   Write(contact.Message.Substring(0, 30));

#line default
#line hidden
            EndContext();
            BeginContext(4862, 10, true);
            WriteLiteral("...</h6>\r\n");
            EndContext();
#line 111 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
										}

#line default
#line hidden
            BeginContext(4885, 37, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<small class=\"text-muted\"> ");
            EndContext();
            BeginContext(4923, 35, false);
#line 112 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
                                                              Write(contact.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4958, 56, true);
            WriteLiteral(" </small>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</li>\r\n");
            EndContext();
#line 116 "C:\Users\nijat\source\repos\FinalProject\FinalProject\Areas\BakumozAdminPanel\Views\Shared\Components\AdminHeader\Default.cshtml"
						}

#line default
#line hidden
            BeginContext(5023, 63, true);
            WriteLiteral("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminVM> Html { get; private set; }
    }
}
#pragma warning restore 1591