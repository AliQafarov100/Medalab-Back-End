#pragma checksum "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e319356618d2afe2827a93d299be110fff21e6b"
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
#line 1 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\_ViewImports.cshtml"
using MedaLab_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\_ViewImports.cshtml"
using MedaLab_Back_End.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e319356618d2afe2827a93d299be110fff21e6b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6212f18db9a2448d48e63790cf13e3c227455214", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e319356618d2afe2827a93d299be110fff21e6b3317", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""/assets/scss/css/style.css"">
    <title>Document</title>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e319356618d2afe2827a93d299be110fff21e6b5101", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""topbar"">
            <div class=""container"">
                <div class=""row "">
                    <div class=""col-lg-6 col-md-12 col-sm-12 col-12 contacts"">
                        <ul class=""d-flex justify-content-start align-items-center"">
                            <li>
                                <span><a");
                BeginWriteAttribute("href", " href=\"", 1204, "\"", 1211, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-envelope\"></i></a></span><span>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1306, "\"", 1313, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                       class=\"ms-2\">contact@example.com</a>\r\n                                </span>\r\n                            </li>\r\n                            <li>\r\n                                <span><a");
                BeginWriteAttribute("href", " href=\"", 1543, "\"", 1550, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-solid fa-mobile-button\"></i></a></span><span>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1650, "\"", 1657, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                       class=""ms-2"">+994 5589 55488</a>
                                </span>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-lg-6 medias"">
                        <ul class=""d-flex justify-content-end"">
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2018, "\"", 2025, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2108, "\"", 2115, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-facebook\"></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2199, "\"", 2206, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-instagram\"></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 2291, "\"", 2298, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa-brands fa-invision\"></i></a></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <div>\r\n        ");
#nullable restore
#line 51 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <footer>\r\n        <section id=\"footer-section\" class=\"py-5\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"footer-part col-lg-2 col-md-6 col-sm-6\">\r\n                        <h3>");
#nullable restore
#line 58 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
                       Write(layout.GetDatas().Result.FirstOrDefault(i => i.Key == "FooterLogo").Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                        <p>
                            A108 Adam Street
                            New York, NY 535022
                            United States
                        </p>
                        <p><span style=""font-weight: bold;"">Phone:</span><span>+1 5589 55488 55</span></p>
                        <p><span style=""font-weight: bold;"">Email:</span><span>info@example.com</span></p>
                    </div>
                    <div class=""footer-part col-lg-2 col-md-6 col-sm-6"">
                        <strong>Useful Links</strong>
                        <ul>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 3626, "\"", 3633, 0);
                EndWriteAttribute();
                WriteLiteral(@">Home</a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 3898, "\"", 3905, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        About
                                        us
                                    </a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 4295, "\"", 4302, 0);
                EndWriteAttribute();
                WriteLiteral(@">Services</a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 4571, "\"", 4578, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        Terms
                                        of service
                                    </a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 4976, "\"", 4983, 0);
                EndWriteAttribute();
                WriteLiteral(@">Privacy policy</a>
                                </span>
                            </li>
                        </ul>
                    </div>
                    <div class=""footer-part col-lg-2 col-md-6 col-sm-6"">
                        <strong>Our Services</strong>
                        <ul>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 5476, "\"", 5483, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        Web
                                        Design
                                    </a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 5875, "\"", 5882, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        Web
                                        Development
                                    </a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 6279, "\"", 6286, 0);
                EndWriteAttribute();
                WriteLiteral(@">Product Management</a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 6565, "\"", 6572, 0);
                EndWriteAttribute();
                WriteLiteral(@">Marketing</a>
                                </span>
                            </li>
                            <li>
                                <span><i class=""fa-solid fa-angle-right""></i></span><span class=""ms-2"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 6842, "\"", 6849, 0);
                EndWriteAttribute();
                WriteLiteral(@">Graphic Design</a>
                                </span>
                            </li>
                        </ul>
                    </div>
                    <div class=""footer-part col-lg-2"">

                    </div>
                    <div class=""footer-part col-lg-3 col-md-6 col-sm-6"">
                        <strong>Join Our Newsletter</strong>
                        <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
                        <div class=""subscribe d-flex justify-content-end"">
                            <input type=""text"">
                            <a");
                BeginWriteAttribute("href", " href=\"", 7485, "\"", 7492, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-primary"">Subscribe</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""endl-section"" class=""py-4"">
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12"">
                        <span>
                            ?? Copyright Medilab. All Rights Reserved <br>
                            <p>Designed by <a");
                BeginWriteAttribute("href", " href=\"", 8020, "\"", 8027, 0);
                EndWriteAttribute();
                WriteLiteral(@">BootstrapMade</a></p>
                        </span>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12 d-flex justify-content-end"">
                        <ul class=""d-flex"">
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8289, "\"", 8365, 1);
#nullable restore
#line 164 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8296, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Twitter").Url, 8296, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 8369, "\"", 8448, 1);
#nullable restore
#line 164 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8377, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Twitter").Value, 8377, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8499, "\"", 8576, 1);
#nullable restore
#line 165 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8506, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Facebook").Url, 8506, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 8580, "\"", 8660, 1);
#nullable restore
#line 165 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8588, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Facebook").Value, 8588, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8711, "\"", 8789, 1);
#nullable restore
#line 166 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8718, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Instagram").Url, 8718, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 8793, "\"", 8874, 1);
#nullable restore
#line 166 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8801, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Instagram").Value, 8801, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8925, "\"", 9002, 1);
#nullable restore
#line 167 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8932, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Invision").Url, 8932, 70, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 9006, "\"", 9086, 1);
#nullable restore
#line 167 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9014, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Invision").Value, 9014, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i></a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 9137, "\"", 9211, 1);
#nullable restore
#line 168 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9144, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Skype").Url, 9144, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i");
                BeginWriteAttribute("class", " class=\"", 9215, "\"", 9292, 1);
#nullable restore
#line 168 "C:\Users\M S I\source\repos\MedaLab Back-End\MedaLab Back-End\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 9223, layout.GetDatas().Result.FirstOrDefault(i => i.Key == "Skype").Value, 9223, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></i></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>
    </footer>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2""
            crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MedaLab_Back_End.Service.LayoutService layout { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
