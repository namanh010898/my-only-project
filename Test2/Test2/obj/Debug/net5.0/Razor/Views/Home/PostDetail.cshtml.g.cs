#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c98924e3977f68dfed8f612cb6d41bd5726fab25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PostDetail), @"mvc.1.0.view", @"/Views/Home/PostDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98924e3977f68dfed8f612cb6d41bd5726fab25", @"/Views/Home/PostDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PostDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/DaihocFPTNews/_Comment_NewDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
  
    ViewData["Title"] = "Chi tiết";

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n<script>\r\n    $( document ).ready(function() { \r\n    if(");
#nullable restore
#line 10 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
  Write(ViewBag.Post[0].PostCategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" == 3)\r\n        {\r\n            const g1_today = new Date();\r\n             var g2_open_time = new Date(\'");
#nullable restore
#line 13 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                     Write(ViewBag.Post[0].OpenTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \');\r\n             var g3_close_time = new Date(\'");
#nullable restore
#line 14 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                      Write(ViewBag.Post[0].ClosedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ');
         
             //sắp diễn ra
             if (g1_today.getTime() < g2_open_time.getTime()) {
                $('#event-button-click-1').show();
                //$('#event-button-click-1').show();
             } 
             // đã kết thúc
             else if(g1_today.getTime() > g3_close_time.getTime() ) {
                 $('#event-button-click-end').show();
             } 
             // đang diễn ra
             else {
                 $('#event-button-click-ongoing').show();
             } 
        } 
    }); 
</script>
<script>  
    function joinEvent() {
        Swal.fire({
                icon: 'question',
                title: 'Bạn có muốn đăng kí sự kiện?',
                text: 'Hãy nhập email của bạn',
                 input: 'email',
                showCloseButton: true,
                showCancelButton: true
            }).then((result) =>{
                if (result.isConfirmed) { 
                    
                    debugger;
             ");
            WriteLiteral(@"       $.ajax({
                        type: ""POST"",
                        url: ""EventRequest/receiveData"",
                        dataType: ""json"",
                        data: {
                            o: ""namanhnguyen108@gmail.com""
                        },
                        success: function (data) {
                           alert('Success');

                        },
                        error: function () {
                         alert('Error');
                        }
                    });


                }
            });
    }


    function addNewRequest() {
        debugger;
        var obj = {
        ""PostId"": '");
#nullable restore
#line 70 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
              Write(ViewBag.Post[0].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \r\n        \"AccountId\": 2,\r\n        \"Active\": 1,\r\n        \"EventRequestStatusId\": 1, \r\n        \"Name\": \'");
#nullable restore
#line 74 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
            Write(ViewBag.Post[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        \"Email\": $(\'.swal2-input\').val(),\r\n        \"Phone\" : \"8411\",   \r\n        \"Description\" : \'");
#nullable restore
#line 77 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                    Write(ViewBag.Post[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',  \r\n        \"CreatedTime\": \'");
#nullable restore
#line 78 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                   Write(ViewBag.Post[0].CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', 
        ""Account"" : """",
        ""EventRequestStatus"" : """",
        ""Post"" : """",

    }
    //$.ajax({
    //    url: ""/EventRequest/api/add"",
    //    type: ""POST"",
    //    contentType: ""application/json"",
    //    data: JSON.stringify(obj),
    //    success: function (responseData) {
    //        Swal.fire({
    //            title: '<strong>Đăng kí tham gia thành công!</strong>',
    //            icon: 'success',
    //            showCloseButton: true, 
    //        });
    //    }
    //});
    $.ajax({
        url: ""https://localhost:5001/EventRequest/api/add"",
        type: ""POST"",
        contentType: ""application/json"",
        data: JSON.stringify(obj),
        success: function (responseData) {
            Swal.fire({
                title: '<strong>Đã tạo menu mới thành công!</strong>',
                icon: 'success',
                showCloseButton: true,
                focusConfirm: false,
            }).then(resultt => {
                if (resultt.is");
            WriteLiteral(@"Confirmed) {
                    window.location.href = ""/menu/admin/list"";
                }
            });
        }
        });
    }

</script>
<script>  


     function commentSm() {
         debugger;
         if($(""#commentContent"").val().trim() != """" ) {
             
             var dt = new Date();
         var name = """";
         var email = """";
         // set all name = Annomymous
         if (true) {
              name = ""Annomymous"";
              email = """";
         } 
         else {
             name = '");
#nullable restore
#line 134 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                Write(ViewBag.CurrentUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n             email = \'");
#nullable restore
#line 135 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                 Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n         }\r\n\r\n        var obj = {\r\n                \"id\": 0,\r\n                \"postID\": \'");
#nullable restore
#line 140 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                      Write(ViewBag.Post[0].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                ""accountID"":""10018"",
                ""active"": 1,
                ""approve"": 0,
                ""name"": name,
                ""description"": """",
                ""email"": email,
                ""text"": $(""#commentContent"").val(),
                ""website"": """",
                ""createdTime"": dt,
         };
        $.ajax({
            type: ""POST"",
            contentType: ""application/json"",
            url: ""/Comment/api/Add"",
            data: JSON.stringify(obj),
            success: function (responseData) {
                //debugger;
                //responseData = JSON.parse(responseData)
                if (responseData.status == 201 && responseData.message === ""CREATED"") {
                    localStorage.setItem(""currentLoggedInUser"", JSON.stringify(responseData.data[0]));
                    Swal.fire({
                        title: 'Gửi bình luận thành công!',
                        footer : 'Bình luận của bạn đã được gửi lên phía quản trị xét duyệt'
 ");
            WriteLiteral(@"                       type: 'success',
                        showCancelButton: false,
                        confirmButtonText: 'OK'
                    }).then((result) => {
                        $(""#commentContent"").val("""");
                        window.location.href = """";
                    })

                }
            },
            error: function (e) {
                //console.log(e.message);
                //Swal.fire(
                //    'Bình luận thất bại',
                //    'Vui lòng điền đầy đủ thông tin!',
                //    'error'
                //);
                console.log(e);
            }
        });

         } else {
             Swal.fire(
                    'Bình luận thất bại',
                    'Vui lòng điền nội dung bình luận!',
                    'error'
                );
         }
         
         
    }
</script>
 
    <div>

        <div class=""container"">
            <div class=""col-xs-12 col-sm-12 col-md-");
            WriteLiteral("12 col-lg-12\"> \r\n                <h1 id=\"title-name\">");
#nullable restore
#line 201 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                               Write(ViewBag.Post[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n                <p>");
#nullable restore
#line 204 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
              Write(ViewBag.Post[0].CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 206 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
             if(@ViewBag.Post[0].PostCategoryId == 3)
            {
                
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-xs-12 col-sm-12 col-md-8 col-lg-8 thoigian-sukien"" style=""margin-bottom:22px"">
                                <p style=""text-align: left; font-size : 18px;""><i class=""fas fa-calendar-day"" style=""font-size : 18px;""></i> Thời gian diễn ra:<span id='openTimeId'>");
#nullable restore
#line 214 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                                                                                                                                                                Write(ViewBag.Post[0].OpenTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>   -   <span id=\"closeTimeId\">");
#nullable restore
#line 214 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                                                                                                                                                                                                                              Write(ViewBag.Post[0].ClosedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></p>\r\n\r\n                                <p id=\"name-location\" style=\"text-align: left; font-size : 18px;\"><i class=\"fas fa-map-marker-alt\" style=\"font-size : 18px;\"></i> Địa điểm diễn ra: ");
#nullable restore
#line 216 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                                                                                                                                                               Write(ViewBag.Post[0].EventAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
            WriteLiteral(@"                            <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
                                <span style=""float:right; "">
                                    <button id=""event-button-click-1"" onClick=""joinEvent()"" class=""btn btn-primary button-76 buttonCategoryOfNews button-join-event"" style=""display : none"">Đăng ký tham gia sự kiện</button>
                                    <button id=""event-button-click-3"" class=""btn btn-primary button-76 buttonCategoryOfNews"" style=""display : none;"">Bạn đã đăng ký tham gia sự kiện</button>
                                    <button id=""event-button-click-ongoing"" class=""btn btn-primary button-76 buttonCategoryOfNews button-on-going-event""  style=""display : none"">Sự kiện đang diễn ra</button>
                                    <button id=""event-button-click-end"" class=""btn btn-primary button-76 buttonCategoryOfNews button-can-not-join-event""  style=""display : none"">Sự kiện đã kết thúc</button>
                                </span>

         ");
            WriteLiteral("                   </div>\r\n");
#nullable restore
#line 230 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                  
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n\r\n\r\n        <div class=\"container\">\r\n            <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n                <p style=\"font-style:italic;font-weight:bold\">");
#nullable restore
#line 238 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
                                                         Write(ViewBag.Post[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-xs-12 col-sm-12 col-md-12 col-lg-12\">\r\n                <p>");
#nullable restore
#line 241 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
              Write(Html.Raw(ViewBag.Post[0].Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n");
#nullable restore
#line 244 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
         if(ViewBag.Post[0].PostCommentStatusId != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c98924e3977f68dfed8f612cb6d41bd5726fab2518965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 247 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Home\PostDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           


        </div>


    </div>
     

<!-- script 1-->

    <style>
        /* Video infomation below : Start */
        .spanDayReleaseBlue {
            float: left;
            line-height: 15px;
            font-size: 12px;
            color: #265178;
        }

        .buttonCategoryOfNews {
            border-radius: 5;
            border: 0px solid transparent;
            padding: 1rem 2rem !important;
            line-height: 1rem !important;
        }

        .button-join-event {
            background-color: #fb8557 !important;
            background-image: linear-gradient(to bottom right, #efcd90, #ff9752c7, #e37c19d2) !important;
        }

        .button-can-not-join-event {
            background-color: gray !important;
            background-image: linear-gradient(to bottom right, #8d8d8d, #a19999c7, #6a6060) !important;
        }
        /* Video infomation below : End */


        /*  Button 'Đang Diễn Ra' : Start */
        .button-on-go");
            WriteLiteral(@"ing-event {
            background-color: yellow;
            background-image: linear-gradient(to bottom right, #c5f3e5, #41d3a7c7, #008104);
        }

        .button-end-event {
            background-color: gray;
            background-image: linear-gradient(to bottom right, #e9f4f5, #a19999c7, #6a6060);
        }

        .button-will-event {
            background-color: #ffd86c;
            ;
            background-image: linear-gradient(to bottom right, #efcd90, #ff9752c7, #e37c19d2)
        }

        .button-76 {
            border: 0;
            box-sizing: border-box;
            color: #fff;
            cursor: pointer;
            font-size: 1.125rem;
            /* 18px */
            font-weight: 600;
            line-height: 1.75rem;
            /* 28px */
            padding: 1rem 1.25rem;
            text-align: center;
            user-select: none;
            -webkit-user-select: none;
            touch-action: manipulation;
        }
         

      ");
            WriteLiteral("  ");
            WriteLiteral(@"@media (min-width: 1024px) {
            .button-76 {
                font-size: 1.5rem;
                /* 24px */
                padding: 1rem 3rem;
                line-height: 0.5rem;
                /* 32px */
            }
        }


        /*  Button 'Đang Diễn Ra' : End */



        /* Responsive start */
        ");
            WriteLiteral("@media(max-width : 1600px) and (min-width : 1200px) {\r\n            /* chỉnh title */\r\n            .event-container {\r\n                width: 933px;\r\n            }\r\n        }\r\n\r\n        ");
            WriteLiteral("@media (max-width : 1030px) and (min-width : 991px) {\r\n            /* chỉnh title */\r\n            .container-event-details-1 {\r\n                padding-right: 0px\r\n            }\r\n        }\r\n\r\n        ");
            WriteLiteral(@"@media (max-width : 1078px) {
            /* chỉnh title */
            .container-event-details-wrapper-1 {
                background-size: auto !important;
            }

            .container-event-details-1 #title-name {
                font-size: 25px !important;
            }
        }

        ");
            WriteLiteral(@"@media (max-width : 515px) {
            /* chỉnh title */
            .container-event-details-1 #title-name {
                font-size: 16px !important;
                margin-bottom: 5% !important;
            }

            #event-button-1, #event-button-2, #event-button-3 {
                margin: auto auto 5% !important;
            }

            .thoigian-sukien {
                right: 0 !important;
            }
        }

        ");
            WriteLiteral(@"@media (max-width : 760px) {
            /* chinh video */
            .event-container {
                padding-left: 20px !important;
                padding-right: 20px !important;
            }
            /*chinh content */
            #noidungchitiet-sukien {
                font-size: 23px !important;
            }
        }

        /* Responsive end */
    </style>
");
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
