#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa2b47352cc92ff449c10a7092e7e8dffc087738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DaihocFPTNews__Comment_NewDetail), @"mvc.1.0.view", @"/Views/Shared/DaihocFPTNews/_Comment_NewDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa2b47352cc92ff449c10a7092e7e8dffc087738", @"/Views/Shared/DaihocFPTNews/_Comment_NewDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DaihocFPTNews__Comment_NewDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("commentform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>  


     function commentSm() {
         debugger;
         
         
         
    }
</script>


<style>
    /* Comment Css */

    div.newCommentContainer {
        margin-bottom: 20px;
        margin-top: 0px;
        width: 100%;
    }

        div.newCommentContainer p.comment-form-author {
            position: relative;
            font-weight: 400 !important;
            color: #333 !important;
            line-height: 24px;
            font-size: 16px;
            margin-bottom: 15px;
        }

    p.comment-form-author > textarea {
        border-style: solid;
        border-color: #8c8b8b;
        border-width: 1px;
        border-radius: 10px;
        width: 100%;
        height: 150px;
        padding: 12px 20px;
        box-sizing: border-box;
        border: 1px solid #ccc;
        font-size: 16px;
        resize: none;
    }

</style>
<hr />
<h2>
    <i class=""far fa-comments"" aria-hidden=""true""></i> ");
#nullable restore
#line 52 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                                                  Write(ViewBag.lblTitleBinhLuan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<div class=\"newCommentContainer\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa2b47352cc92ff449c10a7092e7e8dffc0877385515", async() => {
                WriteLiteral("\r\n        <div class=\" form-comment\">\r\n            <p class=\"comment-form-author \">\r\n                <textarea cols=\"45\" rows=\"5\" aria-required=\"true\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1263, "\"", 1301, 1);
#nullable restore
#line 58 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
WriteAttributeValue("", 1277, ViewBag.lblWriteComment, 1277, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"commentContent\"");
                BeginWriteAttribute("required", " required=\"", 1322, "\"", 1333, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n            </p>\r\n        </div>\r\n        <p class=\"form-submit\" style=\"margin:0\">\r\n            <input class=\"btn btn-default submit\" onclick=\"commentmss()\" type=\"button\" id=\"submitComment\" value=\"Bình luận\" >\r\n        </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<style>
    /* Css for comment container */
.blog-comment::before,
.blog-comment::after,
.blog-comment-form::before,
.blog-comment-form::after{
    content: """";
	display: table;
	clear: both;
}
 

.blog-comment ul{
	list-style-type: none;
	padding: 0;
}

.blog-comment img{
	opacity: 1;
	filter: Alpha(opacity=100);
	-webkit-border-radius: 4px;
	   -moz-border-radius: 4px;
	  	 -o-border-radius: 4px;
			border-radius: 4px;
}

.blog-comment img.avatar {
	position: relative;
	float: left;
	margin-left: 0;
	margin-top: 0;
	width: 65px;
	height: 65px;
}

.blog-comment .post-comments{
	border: 1px solid #eee;
    margin-bottom: 20px;
    margin-left: 85px;
	margin-right: 0px;
    padding: 10px 20px;
    position: relative;
    -webkit-border-radius: 4px;
       -moz-border-radius: 4px;
       	 -o-border-radius: 4px;
    		border-radius: 4px;
	background: #fff;
	color: #6b6e80;
	position: relative;
}

.blog-comment .meta {
	font-size: 13px;
	color: #aa");
            WriteLiteral(@"aaaa;
	padding-bottom: 8px;
	margin-bottom: 10px !important;
	border-bottom: 1px solid #eee;
}

.blog-comment ul.comments ul{
	list-style-type: none;
	padding: 0;
	margin-left: 85px;
}

.blog-comment-form{
	padding-left: 15%;
	padding-right: 15%;
	padding-top: 40px;
}

.blog-comment h3,
.blog-comment-form h3{
	margin-bottom: 40px;
	font-size: 26px;
	line-height: 30px;
	font-weight: 800;
}
</style>

<!-- Xử lí in thông tin bình luận đã được duyệt (nếu có)-->
");
#nullable restore
#line 148 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
 if(ViewBag.ListAllCommentCount >0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"cmt-container-newdetails\">\r\n    <div class=\"bootstrap snippets bootdey\">\r\n    <div class=\"row\">\r\n\t\t<div class=\"col-md-12\">\r\n\t\t    <div class=\"blog-comment\">\r\n");
            WriteLiteral("                <hr/>\r\n\t\t\t\t<ul class=\"comments\">\r\n");
#nullable restore
#line 158 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                     for(var i= 0; i< ViewBag.ListAllCommentCount;i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"clearfix\">\r\n\t\t\t\t            <img src=\"https://www.w3schools.com/howto/img_avatar.png\" class=\"avatar\"");
            BeginWriteAttribute("alt", " alt=\"", 3640, "\"", 3646, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t            <div class=\"post-comments\">\r\n\t\t\t\t                <p class=\"meta\"> Bình luận ");
#nullable restore
#line 163 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                                                       Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(": <i class=\"pull-right\"><small style=\"color: #337ab7; text-decoration: none;\">");
#nullable restore
#line 163 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                                                                                                                                          Write(ViewBag.ListAllComment[i].CreatedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></i></p>\r\n\t\t\t\t                <p>\r\n\t\t\t\t                    ");
#nullable restore
#line 165 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                               Write(ViewBag.ListAllComment[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t                </p>\r\n\t\t\t\t            </div>\r\n\t\t\t\t        </li>\r\n");
#nullable restore
#line 169 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 177 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>   
     function commentmss()  {
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
#line 193 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                Write(ViewBag.CurrentUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n             email = \'");
#nullable restore
#line 194 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
                 Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n         }\r\n\r\n        var obj = {\r\n                \"id\": 0,\r\n                \"postID\": \'");
#nullable restore
#line 199 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Shared\DaihocFPTNews\_Comment_NewDetail.cshtml"
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
                        icon: 'success',
                        showCancelButton: false,
  ");
            WriteLiteral(@"                      confirmButtonText: 'OK'
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
</script>");
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