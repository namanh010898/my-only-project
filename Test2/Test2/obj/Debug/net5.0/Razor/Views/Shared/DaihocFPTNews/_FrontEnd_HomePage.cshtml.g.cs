#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8191980a78a9b9513bfa45954a51bcbb04a667ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DaihocFPTNews__FrontEnd_HomePage), @"mvc.1.0.view", @"/Views/Shared/DaihocFPTNews/_FrontEnd_HomePage.cshtml")]
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
#line 1 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\_ViewImports.cshtml"
using Daihoc_FPT_News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\_ViewImports.cshtml"
using Daihoc_FPT_News.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8191980a78a9b9513bfa45954a51bcbb04a667ad", @"/Views/Shared/DaihocFPTNews/_FrontEnd_HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DaihocFPTNews__FrontEnd_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"main-slider\" class=\"dl-slider\">\r\n");
#nullable restore
#line 12 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
     for(var i=0;i<ViewBag.DataSlideViewModel.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slide\">\r\n        <div class=\"bg-img kenburns-top-right\"");
            BeginWriteAttribute("style", " style=\"", 351, "\"", 419, 4);
            WriteAttributeValue("", 359, "background-image:", 359, 17, true);
            WriteAttributeValue(" ", 376, "url(", 377, 5, true);
#nullable restore
#line 15 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
WriteAttributeValue("", 381, ViewBag.DataSlideViewModel[i].Image, 381, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 417, ");", 417, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div class=\"overlay\"></div>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 482, "\"", 576, 4);
            WriteAttributeValue("", 490, "slider-content-wrap", 490, 19, true);
            WriteAttributeValue(" ", 509, "d-flex", 510, 7, true);
            WriteAttributeValue(" ", 516, "align-items-center", 517, 19, true);
#nullable restore
#line 17 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
WriteAttributeValue(" ", 535, ViewBag.DataSlideViewModel[i].alignment, 536, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"container\">\r\n                    <div class=\"slider-content\">\r\n                    <div class=\"dl-caption medium\"><div class=\"inner-layer\"><div data-animation=\"fade-in-right\" data-delay=\"1s\">");
#nullable restore
#line 20 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
                                                                                                                           Write(ViewBag.DataSlideViewModel[i].tieude1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div></div>\r\n                    <div class=\"dl-caption big\"><div class=\"inner-layer\"><div data-animation=\"fade-in-left\" data-delay=\"2s\">");
#nullable restore
#line 21 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
                                                                                                                       Write(ViewBag.DataSlideViewModel[i].tieude2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"dl-caption small\"><div class=\"inner-layer\"><div data-animation=\"fade-in-left\" data-delay=\"3s\">");
#nullable restore
#line 24 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
                                                                                                                         Write(ViewBag.DataSlideViewModel[i].tieude3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></div></div>\r\n                    <div class=\"dl-btn-group\">\r\n                    <div class=\"inner-layer\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1534, "\"", 1581, 1);
#nullable restore
#line 27 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
WriteAttributeValue("", 1541, ViewBag.DataSlideViewModel[i].buttonUrl, 1541, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dl-btn\" data-animation=\"fade-in-left\" data-delay=\"3.5s\">");
#nullable restore
#line 27 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
                                                                                                                                 Write(ViewBag.DataSlideViewModel[i].buttonName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"arrow_right\"></i></a>\r\n                    </div>\r\n                    </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 34 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_FrontEnd_HomePage.cshtml"
    }  

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral(@"<section class=""counter-section padding"">
<div class=""container"">
<div class=""row counter-wrap"">
<div class=""col-lg-3 col-sm-6 padding-15"">
<div class=""counter-content wow fadeInUp"" data-wow-delay=""100ms"">
<div class=""counter""><span class=""odometer"" data-count=""100"">00</span></div>
<h4>M???t tr??m ph???n tr??m sinh vi??n t???t nghi???p c?? vi???c l??m</h4>
</div>
</div>
<div class=""col-lg-3 col-sm-6 padding-15"">
<div class=""counter-content wow fadeInUp"" data-wow-delay=""200ms"">
<div class=""counter""><span class=""odometer"" data-count=""325"">00</span></div>
<h4>H??ng tr??m c?? h???i li??n k???t du h???c m???i n??m</h4>
</div>
</div>
<div class=""col-lg-3 col-sm-6 padding-15"">
<div class=""counter-content wow fadeInUp"" data-wow-delay=""300ms"">
<div class=""counter""><span class=""odometer"" data-count=""10"">00</span></div>
<h4>V???i h??n ch???c n??m kinh nghi???m trong vi???c gi???ng d???y</h4>
</div>
</div>
<div class=""col-lg-3 col-sm-6 padding-15"">
<div class=""counter-content wow fadeInUp"" data-wow-delay=""400ms"">
<div class=""counter""><span");
            WriteLiteral(" class=\"odometer\" data-count=\"554\">00</span></div>\r\n<h4>???? nh???n ???????c r???t nhi???u gi???i th?????ng trong v?? ngo??i n?????c</h4>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n</section>\r\n");
            WriteLiteral("<section class=\"testimonial-section bg-grey padding\">\r\n<div class=\"dots\"></div>\r\n<div class=\"container\">\r\n<div class=\"section-heading text-center mb-40 wow fadeInUp\" data-wow-delay=\"100ms\">\r\n");
            WriteLiteral(@"<h2>What people says</h2>
</div>
<div id=""testimonial-carousel"" class=""testimonial-carousel box-shadow owl-carousel"">
<div class=""testi-item d-flex align-items-center"">
<img src=""img/testi-1.jpg"" alt=""img"">
<div class=""testi-content"">
<p>""Ch???t l?????ng ph???c v??? c???a tr?????ng FPT l?? r???t t???t""</p>
<h3>Valentina lucas</h3>
<ul class=""rattings"">
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
</ul>
<span>Ph??ng tuy???n sinh</span>
</div>
<i class=""fa fa-quote-right""></i>
</div>
<div class=""testi-item d-flex align-items-center"">
<img src=""img/testi-2.jpg"" alt=""img"">
<div class=""testi-content"">
<p>""Ch???t l?????ng ?????u ra ?????t chu???n qu???c t???""</p>
<h3>Valentin Lacoste</h3>
<ul class=""rattings"">
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
</ul");
            WriteLiteral(@">
<span>Ph??ng 102L</span>
</div>
<i class=""fa fa-quote-right""></i>
</div>
<div class=""testi-item d-flex align-items-center"">
<img src=""img/testi-3.jpg"" alt=""img"">
<div class=""testi-content"">
<p>""????nh gi?? tuy???t v???i 10/10""</p>
<h3>Jos?? Carpio</h3>
<ul class=""rattings"">
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
<li><i class=""fa fa-star""></i></li>
</ul>
<span>Sinh vi??n ??u t??</span>
</div>
<i class=""fa fa-quote-right""></i>
</div>
</div>
</div>
</section>

");
            WriteLiteral(@"
<div class=""sponsor-section bg-grey"">
<div class=""dots""></div>
<div class=""container"">
<div id=""sponsor-carousel"" class=""sponsor-carousel owl-carousel"">
<div class=""sponsor-item"">
<img src=""img/sponsor1.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor2.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor3.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor4.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor5.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor6.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor7.png"" alt=""sponsor"">
</div>
<div class=""sponsor-item"">
<img src=""img/sponsor8.png"" alt=""sponsor"">
</div>
</div>
</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
