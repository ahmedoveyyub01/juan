#pragma checksum "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619403e0d27898bf88a236516d2a02226a63523d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\_ViewImports.cshtml"
using JuanSelfEdu.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\_ViewImports.cshtml"
using JuanSelfEdu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619403e0d27898bf88a236516d2a02226a63523d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29135fb2b1df166e89e645a6064c5f7546f2222", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/scss/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619403e0d27898bf88a236516d2a02226a63523d4855", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
        integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
        integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "619403e0d27898bf88a236516d2a02226a63523d5823", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Juan</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619403e0d27898bf88a236516d2a02226a63523d7737", async() => {
                WriteLiteral(@"



    <header>

        <div class=""header-top theme-bg"">
            <div class=""row align-items-center"">
                <div class=""col-lg-6"">
                    <div class=""welcome-message"">
                        <p>Welcome to Juan online store</p>
                    </div>
                </div>
                <div class=""col-lg-6 text-right"">
                    <div class=""header-top-settings"">
                        <ul class=""nav align-items-center justify-content-end"">
                            <li class=""curreny-wrap"">
                                $ Dollar (US)
                            </li>

                            <li class=""language"">
                                English
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>



        <nav>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg");
                WriteLiteral("-2\">\r\n                        <div class=\"logo\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "619403e0d27898bf88a236516d2a02226a63523d9159", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1946, "~/images/", 1946, 9, true);
#nullable restore
#line 54 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 1955, Model.Setting.Logo, 1955, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-8\">\r\n                        <div class=\"menu\">\r\n                            <ul>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2205, "\"", 2212, 0);
                EndWriteAttribute();
                WriteLiteral(">HOME</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2267, "\"", 2274, 0);
                EndWriteAttribute();
                WriteLiteral(">PAGES</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2330, "\"", 2337, 0);
                EndWriteAttribute();
                WriteLiteral(">SHOP</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2392, "\"", 2399, 0);
                EndWriteAttribute();
                WriteLiteral(">BLOG</a></li>\r\n                                <li><a");
                BeginWriteAttribute("href", " href=\"", 2454, "\"", 2461, 0);
                EndWriteAttribute();
                WriteLiteral(@">CONTACT</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-2"">
                        <div class=""icons"">
                            <i class=""fa-solid fa-magnifying-glass""></i>
                            <i class=""fa-solid fa-gear""></i>
                            <i class=""fa-solid fa-basket-shopping""></i>
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    </header>
    <main>
        ");
#nullable restore
#line 80 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </main>\r\n <footer>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <h5>My Account</h5>\r\n                    <div class=\"account\">\r\n                        <p>");
#nullable restore
#line 89 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
                      Write(Model.Setting.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>Mail Us: ");
#nullable restore
#line 90 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
                               Write(Model.Setting.Mail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>Phone: ");
#nullable restore
#line 91 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
                             Write(Model.Setting.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <h5>
                        Categories
                    </h5>
                    <div class=""category"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 3686, "\"", 3693, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>\r\n                                Ecommerce\r\n                            </p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3863, "\"", 3870, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>\r\n                                Shopify\r\n                            </p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4038, "\"", 4045, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>\r\n                                Prestashop\r\n\r\n                            </p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4218, "\"", 4225, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>\r\n                                Opencart\r\n                            </p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4394, "\"", 4401, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>\r\n                                Magento\r\n                            </p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4569, "\"", 4576, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <p>
                                Jigoshop

                            </p>
                        </a>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <h5>
                        Information
                    </h5>
                    <div class=""information"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 4976, "\"", 4983, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Home</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5084, "\"", 5091, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>About Us</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5196, "\"", 5203, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Contact Us</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5310, "\"", 5317, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Returns & Exchanges</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5433, "\"", 5440, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Shipping & Delivery</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5556, "\"", 5563, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <p>Privacy Policy</p>
                        </a>
                    </div>
                </div>
                <div class=""col-lg-2"">
                    <h5>
                        Quick Links
                    </h5>
                    <div class=""quick"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 5897, "\"", 5904, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Quick Links</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6012, "\"", 6019, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Quick Links</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6127, "\"", 6134, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Quick Links</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6242, "\"", 6249, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Quick Links</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6357, "\"", 6364, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p>Quick Links</p>\r\n                        </a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6472, "\"", 6479, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <p>Quick Links</p>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row foote "">
            <div class=""footer-start col-md-6"">
                <p>Copyright 2019 <a href=""index.html"">Juan</a>. All Rights Reserved</p>
            </div>
            <div class=""footer-end col-md-6"">
                <a");
                BeginWriteAttribute("href", " href=\"", 6907, "\"", 6933, 1);
#nullable restore
#line 190 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6914, Model.Setting.Face, 6914, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 6996, "\"", 7025, 1);
#nullable restore
#line 191 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7003, Model.Setting.Twitter, 7003, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7087, "\"", 7117, 1);
#nullable restore
#line 192 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7094, Model.Setting.Linkedin, 7094, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-linkedin\"></i></a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 7180, "\"", 7207, 1);
#nullable restore
#line 193 "C:\Users\Elgun\Desktop\JuanSelfEdu\JuanSelfEdu\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7187, Model.Setting.Insta, 7187, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619403e0d27898bf88a236516d2a02226a63523d21942", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591