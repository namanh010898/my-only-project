#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AddPostEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e726cdc45a9c563ce5678c37a66a2286bc49ab00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_AddPostEvents), @"mvc.1.0.view", @"/Views/Post/AddPostEvents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e726cdc45a9c563ce5678c37a66a2286bc49ab00", @"/Views/Post/AddPostEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_AddPostEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AddPostEvents.cshtml"
  
    ViewData["Title"] = "Tạo mới sự kiện";
    Layout = "_Layout - Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab005019", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>CKEditor</title>
    <script src=""https://cdn.ckeditor.com/ckeditor5/33.0.0/classic/ckeditor.js""></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
        <style>
        .modal-footer .btn + .btn {
            margin-bottom: 10px;
        }

        #example_wrapper {
            display : block;
        }

        /* Giao diện modal */
        input.fullwidth {
            width : 100%;
        }

        #closing-modal-black:hover {
            color :#333 !important;
        }

        .modal-row-menu {
            margin-top : 13px;
        }
    </style>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab006653", async() => {
                WriteLiteral("\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 933, "\"", 941, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 942, "\"", 947, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""modal-dialog modal-lg novaticeditForm"">
            <div class=""modal-content"">
                <div class=""modal-header bg-gradient-info"">
                    <h4 class=""modal-title"">
                        <i class=""fa fa-edit""></i> <span id=""updateTitle"">Thêm sự kiện mới</span>
                    </h4>
                </div>
                <div class=""modal-body"">
                    <div class=""container"" style=""display: contents""> 
                
                    <h3>Sự kiện</h3>
                    <i>Lưu ý điền đầy đủ các thông tin có dấu <span style=""color:red"">*</span></i>
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""ID"">ID(Tự động)</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""ID"" class=""fullwidth""  disabled />
                        </div");
                WriteLiteral(@">
                    </div>

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Name"">Name</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Name"" class=""fullwidth""   />
                        </div>
                    </div>

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""PostCategoryID"">Category(Tự động)</label><span style=""color:red"">*</span> 
                        </div>
                        <div class=""col-md-9"">
                            <select id=""PostCategoryID"" disabled>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab009148", async() => {
                    WriteLiteral("Tin tức");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab0010404", async() => {
                    WriteLiteral("Tin tức hợp tác");
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
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab0011669", async() => {
                    WriteLiteral("Sự kiện");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div> 

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Active"">Active(Tự động)</label><span style=""color:red"">*</span> 
                        </div>
                        <div class=""col-md-9"">
                            <select id=""Active"" disabled>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab0013706", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab0014962", async() => {
                    WriteLiteral("Private");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""PostCommentStatusID"">Comment</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <select id=""PostCommentStatusID"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab0016703", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e726cdc45a9c563ce5678c37a66a2286bc49ab0017959", async() => {
                    WriteLiteral("Private");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>  
                     
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Photo"">Photo</label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Photo"" class=""fullwidth""  />
                        </div>
                    </div> 

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Description"">Description</label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Description"" class=""fullwidth""   />
                        </div>
                    </div>
                    
                    <div class=""row modal-row-menu"">
                        <div class=""");
                WriteLiteral(@"col-md-3 "">
                        <label for=""Content"">Content<span style=""color:red"">*</span></label>
                        </div>
                        <div class=""col-md-9"">
                            <div id=""Content"" class=""Text""></div>
                        </div>
                    </div> 
                        


                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""PublishedTime"">Published Time<span style=""color:red"">*</span></label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""datetime-local"" id=""PublishedTime"" />
                        </div>
                    </div> 

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""OpenTime"">Open Time<span style=""color:red"">*</span></label>
                        </div>
              ");
                WriteLiteral(@"          <div class=""col-md-9"">
                            <input type=""datetime-local"" id=""OpenTime"" />
                        </div>
                    </div> 

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""ClosedTime"">Closed Time<span style=""color:red"">*</span></label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""datetime-local"" id=""ClosedTime"" />
                        </div>
                    </div> 

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""EventAddress"">Event Address<span style=""color:red"">*</span></label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""EventAddress"" class=""fullwidth""   />
                        </div>
                   ");
                WriteLiteral(@" </div> 
                      
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" style=""display:none"" class=""btn btn-default"" data-dismiss=""modal"">
                        Close
                    </button>
                    <button type=""button"" class=""btn btn-primary"" id=""btnUpdateItem""
                            onclick=""Submit()"">
                        Tạo mới
                    </button>
                </div>
            </div>
        </div>
    </div>
    <script>
        // js for description editor 
        var posttext;
        ClassicEditor
            .create(document.querySelector('#Content'))
            .then(editor => {
                posttext = editor
            })
            .catch(error => {
                console.error(error);
            });
    </script>
    <script>  
             
        function Submit() { 

            var resultSubmit = true; 
         ");
                WriteLiteral(@"    
            if( $(""#Name"").val().trim() == """" ||  $(""#Name"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                text: 'Name không thể bị bỏ trống',
                showCloseButton: true
                });
            }
             

            if( $(""#PublishedTime"").val() == """" ||  $(""#PublishedTime"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                text: 'Published Time không thể bị bỏ trống',
                showCloseButton: true
                });
            }

            if( $(""#OpenTime"").val() == """" ||  $(""#OpenTime"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                ");
                WriteLiteral(@"text: 'Open Time không thể bị bỏ trống',
                showCloseButton: true
                });
            }

            if( $(""#ClosedTime"").val() == """" ||  $(""#ClosedTime"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                text: 'Closed Time không thể bị bỏ trống',
                showCloseButton: true
                });
            }

            if( $(""#EventAddress"").val().trim() == """" ||  $(""#EventAddress"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                text: 'Event Address không thể bị bỏ trống',
                showCloseButton: true
                });
            }

            // check thoả mãn các điều kiện trước khi tạo
            if(resultSubmit) {
                Swal.fire({
                ic");
                WriteLiteral(@"on: 'question',
                title: 'Confirm?',
                text: 'Bạn có muốn tạo mới sự kiện '+ $(""#Name"").val() +' không?',
                showCloseButton: true,
                showCancelButton: true
            }).then((result) => {
                if (result.isConfirmed) {
                    var data = posttext.getData();
                    var pubtime = """";  
                    debugger;
                    var obj = {
                        ""PostTypeID"": 1,
                        ""PostAccountID"": 10001,
                        ""PostCategoryID"" :  $(""#PostCategoryID"").val(),  
                        ""PostLayoutID"": 1,
                        ""PostPublishStatusID"": 1,
                        ""PostCommentStatusID"": $(""#PostCommentStatusID"").val(),             
                        ""Active"":  $(""#Active"").val(),      
                        ""Url"": """",
                        ""Photo"": $(""#Photo"").val(),     
                        ""Video"": """",
                       ");
                WriteLiteral(@" ""Name"": $(""#Name"").val(),       
                        ""Description"": $(""#Description"").val(),     
                        ""Text"": data,       
                        ""PublishedTime"": $(""#PublishedTime"").val(),        
                        ""OpenTime"": $(""#OpenTime"").val(),        
                        ""ClosedTime"": $(""#ClosedTime"").val(),        
                        ""EventAddress"": $(""#EventAddress"").val(),        

                    } 
                    $.ajax({
                        url: ""/post/api/add"",
                        type: ""POST"",
                        contentType: ""application/json"",
                        data: JSON.stringify(obj),
                        success: function (responseData) {
                            Swal.fire({
                                title: '<strong>Đã tạo sự kiện mới thành công!</strong>',
                                icon: 'success',
                                showCloseButton: true,
                                f");
                WriteLiteral(@"ocusConfirm: false,
                            }).then(resultt => {
                                if (resultt.isConfirmed) {
                                    window.location.href = ""/post/admin/listevents"";
                                }
                            });
                        }
                    })
                } else if (result.isDenied) {
                    
                    print(e);
                }
            })
            }
            
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
