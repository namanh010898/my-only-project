#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AddPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_AddPost), @"mvc.1.0.view", @"/Views/Post/AddPost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4fe3e329439f3a5011fa93e6032e2c4e73fb8de", @"/Views/Post/AddPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_AddPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AddPost.cshtml"
  
    ViewData["Title"] = "Bài viết";
    Layout = "_Layout - Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de4394", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>CKEditor</title>\r\n    <script src=\"https://cdn.ckeditor.com/ckeditor5/33.0.0/classic/ckeditor.js\"></script>\r\n    <script src=\"//cdn.jsdelivr.net/npm/sweetalert2@11\"></script>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de5589", async() => {
                WriteLiteral("\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 480, "\"", 488, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 489, "\"", 494, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""modal-dialog modal-lg novaticeditForm"">
            <div class=""modal-content"">
                <div class=""modal-header bg-gradient-info"">
                    <h4 class=""modal-title"">
                        <i class=""fa fa-edit""></i> <span id=""updateTitle"">Thêm bài viết</span>
                    </h4>
                </div>
                <div class=""modal-body"">
                    <div class=""container"">
                        <div>
                            <span>
                                <label for=""id"">ID</label><span style=""color:red"">*</span>
                                <input type=""text"" id=""id"" readonly />
                            </span>
                            <span>
                                <label for=""posttypeid"">Post Type</label><span style=""color:red"">*</span>
                                <select id=""posttypeid"">
                                </select>
                            </span>
                        </div");
                WriteLiteral(@">
                        <div>
                            <label for=""postcategoryid"">Post Category</label>
                            <div>
                                <select id=""postcategoryid"">
                                </select>
                            </div>
                        </div>
                        <label for=""postaccountid"">Author</label><span style=""color:red"">*</span>
                        <div><input type=""text"" id=""postaccountid"" readonly /></div>
                        <label for=""postlayoutid"">Post Layout</label><span style=""color:red"">*</span>
                        <div>
                            <select id=""postlayoutid"">
                            </select>
                        </div>
                        <label");
                BeginWriteAttribute("for", " for=\"", 2316, "\"", 2322, 0);
                EndWriteAttribute();
                WriteLiteral(">Post Publish</label><span style=\"color:red\">*</span>\r\n                        <div>\r\n                            <select id=\"postpublishid\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de8359", async() => {
                    WriteLiteral("Public");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de9614", async() => {
                    WriteLiteral("Private");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 2702, "\"", 2708, 0);
                EndWriteAttribute();
                WriteLiteral(">Post Comment</label><span style=\"color:red\">*</span>\r\n                        <div>\r\n                            <select id=\"postcommentstatusid\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de11284", async() => {
                    WriteLiteral("Public");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4fe3e329439f3a5011fa93e6032e2c4e73fb8de12540", async() => {
                    WriteLiteral("Private");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3094, "\"", 3100, 0);
                EndWriteAttribute();
                WriteLiteral(@">Url</label>
                        <div><input type=""text"" readonly /></div>
                        <label for=""Photo"">Photo</label>
                        <div><input type=""text"" id=""photo"" /></div>
                        <label for=""Video"">Video</label>
                        <div><input type=""text"" id=""video"" /></div>
                        <label for=""Name"">Name</label>
                        <div><input type=""text"" id=""name"" /></div>
                        <label for=""description"">Description</label>
                        <div><textarea id=""description""></textarea></div>
                        <label");
                BeginWriteAttribute("for", " for=\"", 3735, "\"", 3741, 0);
                EndWriteAttribute();
                WriteLiteral(">Content</label>\r\n                        <div id=\"editor\" class=\"Text\"></div>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 3852, "\"", 3858, 0);
                EndWriteAttribute();
                WriteLiteral(@">Published Time</label>
                        <div><input type=""datetime-local"" id=""publishtime"" /></div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" style=""display:none"" class=""btn btn-default"" data-dismiss=""modal"">
                        Close
                    </button>
                    <button type=""button"" class=""btn btn-primary"" id=""btnUpdateItem""
                            onclick=""Submit()"">
                        Save
                        changes
                    </button>
                </div>
            </div>
        </div>
    </div>
    <script>
        var posttext;
        ClassicEditor
            .create(document.querySelector('#editor'))
            .then(editor => {
                posttext = editor
            })
            .catch(error => {
                console.error(error);
            });

        function LoadDataPostCategory() {
            $.a");
                WriteLiteral(@"jax({
                url: ""https://localhost:5001/postcategory/api/list"",
                type: ""GET"",
                async: 'true',
                contentType: 'application/json',
                success: function (responseData) {
                    postcategorydata = JSON.parse(responseData);
                    $.each(postcategorydata, function (index, item) {
                        var data = {
                            id: item.Id,
                            text: item.Name
                        };
                        var newOption = new Option(data.text, data.id, false, false);
                        $(""#postcategoryid"").append(newOption).trigger('change');
                    });
                }
            })
        }
        function LoadDataPostType() {
            $.ajax({
                url: ""https://localhost:5001/posttype/api/list"",
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
             ");
                WriteLiteral(@"   success: function (responseData) {
                    postLayoutData = JSON.parse(responseData);
                    $.each(postLayoutData, function (index, item) {
                        var data = {
                            id: item.Id,
                            text: item.Name
                        };
                        var newOption = new Option(data.text, data.id, false, false);
                        $(""#posttypeid"").append(newOption).trigger('change');
                    });
                },
                error: function (e) {

                }
            });
        }
        function LoadDataPostLayout() {
            $.ajax({
                url: ""https://localhost:5001/postlayout/api/list"",
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
                success: function (responseData) {
                    postLayoutData = JSON.parse(responseData);
                    $.each(postLayoutData");
                WriteLiteral(@", function (index, item) {
                        var data = {
                            id: item.Id,
                            text: item.Name
                        };
                        var newOption = new Option(data.text, data.id, false, false);
                        $(""#postlayoutid"").append(newOption).trigger('change');
                    });
                },
                error: function (e) {

                }
            });
        }
        $(document).ready(function () {
            LoadDataPostType();
            LoadDataPostLayout();
            LoadDataPostCategory();
        });
        function Submit() {
            Swal.fire({
                type: 'question',
                title: 'Confirm?',
                text: 'Do you want to create new post ?',
                showCloseButton: true,
                showCancelButton: true
            }).then((result) => {
                if (result.isConfirmed) {
                    var pubtime = """";
  ");
                WriteLiteral(@"                  var data = posttext.getData();
                    if ($(""#publishtime"").val() != null) {
                        pubtime = $(""#publishtime"").val();
                    } else {
                        var currentdate = new Date();
                        var datetime = currentdate.getDate() + ""/""
                            + (currentdate.getMonth() + 1) + ""/""
                            + currentdate.getFullYear() + "" ""
                            + currentdate.getHours() + "":""
                            + currentdate.getMinutes() + "":""
                            + currentdate.getSeconds();
                        pubtime = datetime;
                    }
                    var obj = {
                        ""PostTypeID"": $(""#posttypeid"").val(),
                        ""PostAccountID"": 10001,
                        ""PostLayoutID"": $(""#postlayoutid"").val(),
                        ""PostPublishStatusID"": $(""#postpublishid"").val(),
                        ""PostCommentSt");
                WriteLiteral(@"atusID"": $(""#postcommentstatusid"").val(),
                        ""Active"": 1,
                        ""Url"": """",
                        ""Photo"": $(""#photo"").val(),
                        ""Video"": $(""#video"").val(),
                        ""Name"": $(""#name"").val(),
                        ""Description"": $(""#description"").val(),
                        ""Text"": data,
                        ""PublishedTime"": pubtime
                    }
                    $.ajax({
                        url: ""https://localhost:5001/post/api/add"",
                        type: ""POST"",
                        contentType: ""application/json"",
                        data: JSON.stringify(obj),
                        success: function (responseData) {
                            Swal.fire({
                                title: '<strong>Đã đăng bài viết!</strong>',
                                type: 'success',
                                showCloseButton: true,
                                focusCon");
                WriteLiteral(@"firm: false,
                            }).then(resultt => {
                                if (resultt.isConfirmed) {
                                    window.location.href = ""/post/admin/list"";
                                }
                            });
                        }
                    })
                } else if (result.isDenied) {

                }
            })
        }
    </script>
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
            WriteLiteral("\r\n</html>");
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
