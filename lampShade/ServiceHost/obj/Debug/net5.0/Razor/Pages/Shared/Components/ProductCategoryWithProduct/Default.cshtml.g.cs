#pragma checksum "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf135463b68cd05848d2de30655b857c0bf6f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct.Pages_Shared_Components_ProductCategoryWithProduct_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategoryWithProduct
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
#line 1 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf135463b68cd05848d2de30655b857c0bf6f8b", @"/Pages/Shared/Components/ProductCategoryWithProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategoryWithProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_LampShadeQuery.Contract.ProductCategory.ProductCategoryQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<div class=""single-row-slider-tab-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  section title  =======-->
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">محصولات ما</h2>
                    <p class=""section-subtitle"">
                        نمایش محصولات برا اساس گروه. با انتخاب گروه مورد نظر از محصولات ما دیدن بفرمایید.
                    </p>
                </div>
                <!--=======  End of section title  =======-->
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  tab slider wrapper  =======-->

                <div class=""tab-slider-wrapper"">
                    <!--=======  tab product navigation  =======-->

                    <div class=""tab-product-navigation"">
                        <div class=""nav nav-tabs justif");
            WriteLiteral("y-content-center\" id=\"nav-tab2\" role=\"tablist\">\r\n");
#nullable restore
#line 27 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                             foreach (var category in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("class", " class=\"", 1284, "\"", 1353, 3);
            WriteAttributeValue("", 1292, "nav-item", 1292, 8, true);
            WriteAttributeValue(" ", 1300, "nav-link", 1301, 9, true);
#nullable restore
#line 29 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 1309, Model.First()== category ? "active" : "", 1310, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1354, "\"", 1383, 2);
            WriteAttributeValue("", 1359, "product-tab-", 1359, 12, true);
#nullable restore
#line 29 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1371, category.Id, 1371, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", "\r\n                                   href=\"", 1402, "\"", 1474, 3);
            WriteAttributeValue("", 1445, "#product-series-", 1445, 16, true);
#nullable restore
#line 30 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 1461, category.Id, 1461, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1473, "", 1474, 1, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
#nullable restore
#line 30 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                                                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 31 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n                               \r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n\r\n                    <!--=======  End of tab product navigation  =======-->\r\n                    <!--=======  tab product content  =======-->\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 48 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                         foreach (var category in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2585, "\"", 2655, 4);
            WriteAttributeValue("", 2593, "tab-pane", 2593, 8, true);
            WriteAttributeValue(" ", 2601, "fade", 2602, 5, true);
            WriteAttributeValue(" ", 2606, "show", 2607, 5, true);
#nullable restore
#line 50 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue(" ", 2611, Model.First()== category ? "active" : "", 2612, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2656, "\"", 2688, 2);
            WriteAttributeValue("", 2661, "product-series-", 2661, 15, true);
#nullable restore
#line 50 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
WriteAttributeValue("", 2676, category.Id, 2676, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel""
                         aria-labelledby=""product-tab-1"">
                    <!--=======  single row slider wrapper  =======-->
                    <div class=""single-row-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                                    ""slidesToShow"": 4,
                                    ""slidesToScroll"": 1,
                                    ""arrows"": true,
                                    ""autoplay"": false,
                                    ""autoplaySpeed"": 5000,
                                    ""speed"": 1000,
                                    ""infinite"": true,
                                    ""rtl"": true,
                                    ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                                    ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                                }' data-slick-responsive='[
           ");
            WriteLiteral(@"                         {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                                    {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                                    {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                                    {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                    {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                                ]'>
                    
");
#nullable restore
#line 74 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                     foreach (var product in category.Products)
                    {




#line default
#line hidden
#nullable disable
            WriteLiteral("                         <div class=\"col\">\r\n                            <!--=======  single grid product  =======-->\r\n                            <div class=\"single-grid-product\">\r\n                                <div class=\"single-grid-product__image\">\r\n");
#nullable restore
#line 83 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                     if (product.HasDiscount)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"single-grid-product__label\">\r\n                                        <span class=\"sale\">-");
#nullable restore
#line 86 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                       Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("٪</span>\r\n                                    </div>  \r\n");
#nullable restore
#line 88 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                    <a href=\"single-product.html\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cf135463b68cd05848d2de30655b857c0bf6f8b12919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5254, "~/Theme/assets/img/", 5254, 19, true);
#nullable restore
#line 91 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5273, product.Picture, 5273, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 92 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5360, product.PictureAlt, 5360, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 92 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
AddHtmlAttributeValue("", 5388, product.PictureTitle, 5388, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>

                                    
                                </div>
                                <div class=""single-grid-product__content"">
                                    <div class=""single-grid-product__category-rating"">
                                        <span class=""category"">
                                            <a href=""shop-left-sidebar.html"">");
#nullable restore
#line 100 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                        Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </span>
                                        <span class=""rating"">
                                            <i class=""ion-android-star active""></i>
                                            <i class=""ion-android-star active""></i>
                                            <i class=""ion-android-star active""></i>
                                            <i class=""ion-android-star active""></i>
                                            <i class=""ion-android-star-outline""></i>
                                        </span>
                                    </div>

                                    <h3 class=""single-grid-product__title"">
                                        <a href=""#"">
                                            ");
#nullable restore
#line 113 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </h3>\r\n                                    <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 117 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                         if (product.HasDiscount)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"discounted-price\">");
#nullable restore
#line 119 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                      Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <span class=\"main-price discounted\" >");
#nullable restore
#line 120 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 121 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"main-price\">");
#nullable restore
#line 124 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 125 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                            <!--=======  End of single grid product  =======-->\r\n                        </div>\r\n");
            WriteLiteral("                        <!--=======  End of single row slider wrapper  =======-->\r\n");
#nullable restore
#line 137 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                               
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    </div>\r\n                    </div>\r\n");
#nullable restore
#line 142 "C:\Users\FoRuD\Desktop\LampShade\LampShade\ServiceHost\Pages\Shared\Components\ProductCategoryWithProduct\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                    <!--=======  End of tab product content  =======-->\r\n                </div>\r\n\r\n                <!--=======  End of tab slider wrapper  =======-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_LampShadeQuery.Contract.ProductCategory.ProductCategoryQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
