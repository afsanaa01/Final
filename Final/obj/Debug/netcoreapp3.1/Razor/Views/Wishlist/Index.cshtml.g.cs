#pragma checksum "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc07c12a07be0905db069dc12e4b2e3afa5b29fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wishlist_Index), @"mvc.1.0.view", @"/Views/Wishlist/Index.cshtml")]
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
#line 1 "C:\Users\HP\Documents\Final\Final\Views\_ViewImports.cshtml"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\Final\Final\Views\_ViewImports.cshtml"
using Final.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\Final\Final\Views\_ViewImports.cshtml"
using Final.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc07c12a07be0905db069dc12e4b2e3afa5b29fe", @"/Views/Wishlist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03927bbc465e09d59c2465a5fe64ad9b297e3856", @"/Views/_ViewImports.cshtml")]
    public class Views_Wishlist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 30%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"wishlist\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                 <div class=""col-md-5 m-auto text-center"">
            <h1 class=""pb-3"" style= ""font-family: 'Italiana', serif;"">Wishlist</h1>
            <p class=""pb-4"">There are no products on the wishlist!</p>
            <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 146 160"" width=""146"" class=""vamtam-empty-wishlist-icon""><path d=""M118.9 0a4.9 4.9 0 0 1 4.895 4.682l.005.218v110.91a.9.9 0 0 1-1.793.112l-.007-.113V4.9a3.1 3.1 0 0 0-2.924-3.095L118.9 1.8H4.9a3.1 3.1 0 0 0-3.095 2.924L1.8 4.9v136.045C1.8 150.363 9.431 158 18.841 158h.004l.1-.01.44-.063.507-.086c.495-.09 1.033-.203 1.604-.345 2.04-.505 4.078-1.254 5.973-2.288 5.355-2.922 8.531-7.49 8.531-14.165V135.9a2.9 2.9 0 0 1 2.9-2.9h104a2.9 2.9 0 0 1 2.9 2.9v5.143c0 10.36-8.465 18.757-18.9 18.757H18.841C8.55 159.8.184 151.54.003 141.284L0 140.945V4.9A4.9 4.9 0 0 1 4.682.005L4.9 0h114Zm24 134.8h-104a1.1 1.1 0 0 0-1.1 1.1v5.143c0 7.388-3.574 12.529-9.469 15.745-.743.405-1.503.77-2.276 1.094l-.292.118H126.9c9.336 0 16.924-7.422 17.097-16.635l.003-");
            WriteLiteral(@".322V135.9a1.1 1.1 0 0 0-1.1-1.1ZM94.9 93a.9.9 0 0 1 .113 1.793l-.113.007h-65a.9.9 0 0 1-.113-1.793L29.9 93h65Zm0-28a.9.9 0 0 1 .113 1.793l-.113.007h-65a.9.9 0 0 1-.113-1.793L29.9 65h65ZM62.587 27.434a7.661 7.661 0 0 1 7.606-2.167c3.318.897 5.618 3.886 5.607 7.294a7.442 7.442 0 0 1-2.494 5.553L63.041 48.532a.9.9 0 0 1-1.281 0L51.168 37.826a7.49 7.49 0 0 1-1.694-7.89c1.02-2.73 3.536-4.633 6.462-4.893a7.654 7.654 0 0 1 6.415 2.55l.046.054Zm7.136-.43c-2.536-.685-5.221.396-6.55 2.634a.9.9 0 0 1-1.546.002 5.837 5.837 0 0 0-5.532-2.805c-2.237.198-4.158 1.652-4.935 3.731a5.69 5.69 0 0 0 1.289 5.994l9.949 10.059 9.672-9.812a5.688 5.688 0 0 0 1.923-3.98l.007-.27c.008-2.591-1.743-4.868-4.277-5.553ZM93.9 36.5a.9.9 0 0 1 .113 1.793l-.113.007h-14a.9.9 0 0 1-.113-1.793l.113-.007h14Zm-50-1a.9.9 0 0 1 .113 1.793l-.113.007h-14a.9.9 0 0 1-.113-1.793l.113-.007h14Z"" fill=""#111"" fill-rule=""nonzero""></path>
            </svg>
            <p class=""pt-5"">Look for the heart to save favorites while you shop.</p>
            <a cla");
            WriteLiteral("ss=\"shop-btn btn btn-outline-dark\" href=\"/category/index\" type=\"button\">START SHOPPING</a>\r\n        </div> \r\n");
#nullable restore
#line 15 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-8 col-11 m-auto\">\r\n                    <h1 class=\"pb-5 text-center\" style=\"font-family: \'Italiana\', serif;\">Wishlist</h1>\r\n");
#nullable restore
#line 20 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-lg-2 col-md-2 col-1 m-auto\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2726, "\"", 2765, 2);
            WriteAttributeValue("", 2733, "/wishlist/delete/", 2733, 17, true);
#nullable restore
#line 24 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 2750, item.ProductId, 2750, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\"><i class=\"bi bi-x-lg x-icon\"></i></a>\r\n                        </div>\r\n                        <div class=\"col-lg-2 col-md-2 col-1 m-auto\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc07c12a07be0905db069dc12e4b2e3afa5b29fe8227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2960, "~/image/", 2960, 8, true);
#nullable restore
#line 27 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
AddHtmlAttributeValue("", 2968, item.Image, 2968, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-lg-5 col-md-4 col-5 m-auto\">\r\n                            <p>");
#nullable restore
#line 30 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>$");
#nullable restore
#line 31 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-lg-3 col-md-4 col-12 m-auto responsive-btn\">\r\n                            <a class=\"shop-btn btn btn-outline-dark addtocartBtn\"");
            BeginWriteAttribute("href", " href=\"", 3430, "\"", 3468, 2);
            WriteAttributeValue("", 3437, "/product/select/", 3437, 16, true);
#nullable restore
#line 34 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
WriteAttributeValue("", 3453, item.ProductId, 3453, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" style=\"margin-top: 0px!important;\">ADD TO CART</a>\r\n                        </div>\r\n                    </div>\r\n                    <hr class=\"mt-5 mb-5\">\r\n");
#nullable restore
#line 38 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 40 "C:\Users\HP\Documents\Final\Final\Views\Wishlist\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
