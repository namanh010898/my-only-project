#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Subcribe\AddSubcribe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27d6cffa4bbbea8bb99953d06bb64d1fee19246"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subcribe_AddSubcribe), @"mvc.1.0.view", @"/Views/Subcribe/AddSubcribe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27d6cffa4bbbea8bb99953d06bb64d1fee19246", @"/Views/Subcribe/AddSubcribe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Subcribe_AddSubcribe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 6 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Subcribe\AddSubcribe.cshtml"
  
    ViewData["Title"] = "T???o m???i Subscribe";
    Layout = "_Layout - Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27d6cffa4bbbea8bb99953d06bb64d1fee192464451", async() => {
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

        /* Giao di???n modal */
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27d6cffa4bbbea8bb99953d06bb64d1fee192466085", async() => {
                WriteLiteral("\r\n    <div");
                BeginWriteAttribute("class", " class=\"", 935, "\"", 943, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 944, "\"", 949, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <div class=""modal-dialog modal-lg novaticeditForm"">
            <div class=""modal-content"">
                <div class=""modal-header bg-gradient-info"">
                    <h4 class=""modal-title"">
                        <i class=""fa fa-edit""></i> <span id=""updateTitle"">Th??m menu m???i</span>
                    </h4>
                </div>
                <div class=""modal-body"">
                    <div class=""container"" style=""display: contents""> 
                
                    <h3>Menu</h3>
                    <i>L??u ?? ??i???n ?????y ????? c??c th??ng tin c?? d???u <span style=""color:red"">*</span></i>
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""menuId"">ID(T??? ?????ng)</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""menuId"" class=""fullwidth""  disabled />
                        </d");
                WriteLiteral(@"iv>
                    </div>

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""ParentID"">ParentID</label>
                        <p><i>gi?? tr??? m???c ?????nh : 0</i></p>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""ParentID"" class=""fullwidth"" />
                        </div>
                    </div>

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label");
                BeginWriteAttribute("for", " for=\"", 2594, "\"", 2600, 0);
                EndWriteAttribute();
                WriteLiteral(">Active</label><span style=\"color:red\">*</span> \r\n                        </div>\r\n                        <div class=\"col-md-9\">\r\n                            <select id=\"Active\" disabled>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27d6cffa4bbbea8bb99953d06bb64d1fee192468734", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27d6cffa4bbbea8bb99953d06bb64d1fee192469989", async() => {
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
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Name"">Name</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Name""  class=""fullwidth"" />
                        </div>
                    </div>  
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Url"">Url</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Url"" class=""fullwidth""  />
                        </div>
                    </div> 
                    <div class=""row modal-row-menu"">
                        <");
                WriteLiteral(@"div class=""col-md-3 "">
                        <label for=""Description"">Description</label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Description"" class=""fullwidth""   />
                        </div>
                    </div>
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""CreatedTime"">Published Time<span style=""color:red"">*</span></label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""datetime-local"" id=""CreatedTime"" />
                        </div>
                    </div> 
                      
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" style=""display:none"" class=""btn btn-default"" data-dismiss=""modal"">
                        Close
              ");
                WriteLiteral(@"      </button>
                    <button type=""button"" class=""btn btn-primary"" id=""btnUpdateItem""
                            onclick=""Submit()"">
                        T???o m???i
                    </button>
                </div>
            </div>
        </div>
    </div>
    <script>  
             
        function Submit() {
            debugger;
            var resultSubmit = true;

            if( $(""#ParentID"").val() == """" ||  $(""#ParentID"").val() == null) {
                $(""#ParentID"").val(""0"");
            }

            if( $(""#Name"").val() == """" ||  $(""#Name"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'C???n ??i???n ?????y ????? th??ng tin',
                text: 'Name kh??ng th??? b??? b??? tr???ng?',
                showCloseButton: true,
                showCancelButton: true
                });
            }

            if( $(""#Url"").val() == """" ||  $(""#Url"").val() == null) {
     ");
                WriteLiteral(@"           resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'C???n ??i???n ?????y ????? th??ng tin',
                text: 'Url kh??ng th??? b??? b??? tr???ng?',
                showCloseButton: true,
                showCancelButton: true
                });
            }
             
            if( $(""#CreatedTime"").val() == """" ||  $(""#CreatedTime"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'C???n ??i???n ?????y ????? th??ng tin',
                text: 'CreatedTime kh??ng th??? b??? b??? tr???ng?',
                showCloseButton: true,
                showCancelButton: true
                });
            }

            // check tho??? m??n c??c ??i???u ki???n tr?????c khi t???o
            if(resultSubmit) {
                Swal.fire({
                icon: 'question',
                title: 'Confirm?',
                text: 'B???n c?? mu???n t???o m???i menu '+ $(""#Name"").val() +' kh??ng?',");
                WriteLiteral(@"
                showCloseButton: true,
                showCancelButton: true
            }).then((result) => {
                if (result.isConfirmed) {
                    var pubtime = """"; 
                    //if ($(""#publishtime"").val() != null) {
                    //    pubtime = $(""#publishtime"").val();
                    //} else {
                    //    var currentdate = new Date();
                    //    var datetime = currentdate.getFullYear() + ""-""
                    //        + (currentdate.getMonth() + 1) + ""-""
                    //        + currentdate.getDate() + "" ""
                    //        + currentdate.getHours() + "":""
                    //        + currentdate.getMinutes() + "":""
                    //        + currentdate.getSeconds();
                    //    pubtime = datetime; 
                    //}

                    var obj = {
                        ""ParentId"": $(""#ParentID"").val(), 
                        ""Active"": $(""#Active"").val(),
");
                WriteLiteral(@"                        ""Name"": $(""#Name"").val(),
                        ""Url"": $(""#Url"").val(),
                        ""Priority"" : 100,   // set m???c ?????nh cho priority
                        ""GroupId"" : 1,  // set m???c ?????nh cho groupid
                        ""Description"": $(""#Description"").val(), 
                        ""CreatedTime"": $(""#CreatedTime"").val(),

                    }
                    debugger;
                    $.ajax({
                        url: ""/menu/api/add"",
                        type: ""POST"",
                        contentType: ""application/json"",
                        data: JSON.stringify(obj),
                        success: function (responseData) {
                            Swal.fire({
                                title: '<strong>???? t???o menu m???i th??nh c??ng!</strong>',
                                icon: 'success',
                                showCloseButton: true,
                                focusConfirm: false,
                   ");
                WriteLiteral(@"         }).then(resultt => {
                                if (resultt.isConfirmed) {
                                    window.location.href = ""/menu/admin/list"";
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
