#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152998d2f1613f15f8e215e5205cb6bbe418cfbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_AdminList), @"mvc.1.0.view", @"/Views/Comment/AdminList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"152998d2f1613f15f8e215e5205cb6bbe418cfbd", @"/Views/Comment/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
  
    ViewData["Title"] = "Comment";
    Layout = "../Shared/_Layout - Admin"; 
    //Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "152998d2f1613f15f8e215e5205cb6bbe418cfbd4472", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <!-- Latest compiled and minified JS -->\r\n");
                WriteLiteral(@" 
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script src=""https://cdn.ckeditor.com/ckeditor5/33.0.0/classic/ckeditor.js""></script>
    

    <script>
        $(document).ready(function () {
            $('#example').DataTable({
                aLengthMenu: [
                [3, 5, 10, 20, 50, -1],
                [3, 5, 10, 20, 50, 'Tất cả']
            ]
            });
        });
    </script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "152998d2f1613f15f8e215e5205cb6bbe418cfbd6593", async() => {
                WriteLiteral(@"
    <button onclick=""window.location.href='/comment/add/comment'"" style=""width:100px;height:40px;background-color:lightgreen;border-color:white;float:right;margin-bottom:1%;"">Add</button>
    <table id=""example"" class=""display"" style=""width:100%;"">
        <thead>
            <tr>
                <th>ID</th>
                <th>PostID</th> 
                <th>Name</th>
                <th>Description</th>
                <th>Text</th> 
                <th>Sửa</th>
                <th>Xóa</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 70 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
             for (int i = 0; i < ViewBag.CommentCount; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
                   Write(ViewBag.listComment[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 74 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
                   Write(ViewBag.listComment[i].PostId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 75 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
                   Write(ViewBag.listComment[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 76 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
                   Write(ViewBag.listComment[i].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> \r\n                    <td>");
#nullable restore
#line 77 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
                   Write(ViewBag.listComment[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>  \r\n                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2337, "\"", 2379, 3);
                WriteAttributeValue("", 2347, "Edit(", 2347, 5, true);
#nullable restore
#line 78 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
WriteAttributeValue("", 2352, ViewBag.listComment[i].Id, 2352, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2378, ")", 2378, 1, true);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#modal-id\">Sửa</button></td>\r\n                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2475, "\"", 2523, 3);
                WriteAttributeValue("", 2485, "DeleteItem(", 2485, 11, true);
#nullable restore
#line 79 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
WriteAttributeValue("", 2496, ViewBag.listComment[i].Id, 2496, 26, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2522, ")", 2522, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Xóa</button></td>\r\n                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Comment\AdminList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <th>ID</th>
                <th>PostID</th> 
                <th>Name</th>
                <th>Description</th>
                <th>Text</th> 
                <th>Sửa</th>
                <th>Xóa</th>
            </tr>
        </tfoot>
    </table>


    <div class=""modal fade"" id=""modal-id"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header bg-gradient-info"">
                </div>
                <div class=""modal-body"">
                    <h3>Chi tiết Comment</h3>
                    <i>Lưu ý điền đầy đủ các thông tin có dấu <span style=""color:red"">*</span></i>
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""Id"">ID</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                     ");
                WriteLiteral(@"       <input type=""text"" id=""Id"" class=""fullwidth""  disabled />
                        </div>
                    </div>

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""PostID"">PostID</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""PostID"" class=""fullwidth"" />
                        </div>
                    </div>

                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label");
                BeginWriteAttribute("for", " for=\"", 4285, "\"", 4291, 0);
                EndWriteAttribute();
                WriteLiteral(">Active</label><span style=\"color:red\">*</span> \r\n                        </div>\r\n                        <div class=\"col-md-9\">\r\n                            <select id=\"Active\" disabled>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "152998d2f1613f15f8e215e5205cb6bbe418cfbd13274", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "152998d2f1613f15f8e215e5205cb6bbe418cfbd14530", async() => {
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
                        <label for=""Text"">Text</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Text"" class=""fullwidth""  />
                        </div>
                    </div> 
                    <div class=""row modal-row-menu"">
                      ");
                WriteLiteral(@"  <div class=""col-md-3 "">
                        <label for=""Description"">Description</label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Description"" class=""fullwidth""   />
                        </div>
                    </div>
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label");
                BeginWriteAttribute("for", " for=\"", 6096, "\"", 6102, 0);
                EndWriteAttribute();
                WriteLiteral(@">Created Time<span style=""color:red"">*</span></label>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""datetime-local"" id=""CreatedTime"" />
                        </div>
                    </div> 
                     
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" id=""closing-modal-black""
                            data-dismiss=""modal"" style=""display : contents"">
                        Close
                    </button>
                    <button type=""button"" class=""btn btn-primary"" id=""btnUpdateItem"" onclick=""Submit()"">
                        Save
                        changes
                    </button>
                </div>
            </div>
        </div>
    </div>
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
            WriteLiteral(@"

</html>
<script>
    
    async function Edit(id) {  
        // show modal details and load data by id
        $(""#modal-id"").show();
        let obj = await getItemByID(id);
        debugger;
		 $(""#Id"").val(obj[0].Id);
		 $(""#PostID"").val(obj[0].PostId);
		 $(""#Active"").val(obj[0].Active);
		 $(""#Name"").val(obj[0].Name);
		 $(""#Text"").val(obj[0].Text);
		 $(""#Description"").val(obj[0].Description);
		 $(""#CreatedTime"").val(obj[0].CreatedTime);
    }

    async function getItemByID(id) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: ""/comment/api/detail/"" + id ,
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
                success: function (responseData) {
                    debugger;
                    Item = JSON.parse(responseData);
                    resolve(Item)
                },
                error: function (e) {
                    reject(e);
        ");
            WriteLiteral(@"        }
            });
        })
         
        }


        async function DeleteItem(id) {
        //debugger;
        Swal.fire({
            icon: 'question',
            title: 'Bạn có muốn xóa item này?',
            showCancelButton: true,
            showCloseButton: true
        }).then((result) => {
            if (result.isConfirmed) {
                //var obj = await GetDetailItem(id);
                $.ajax({
                    url: ""/comment/api/delete"",
                    type: 'POST',
                    contentType: 'application/JSON',
                    data: JSON.stringify({ ""id"": id }),
                    success: function (responseData) { 
                        
                        Swal.fire({
                            icon: 'success',
                            title: '<strong>Item đã xóa thành công!</strong>',
                            showCloseButton: true,
                            focusConfirm: false,
                        }).the");
            WriteLiteral(@"n(resultt => {
                                if (resultt.isConfirmed) {
                                    location.reload();
                                }
                            });

                    }
                })
            }
        })
    }
</script>
<script> 
    
    function Submit() {
        // verify thỏa mãn điều kiện trước khi tạo 
            var resultSubmit = true;

            // mặc định nếu k điền thì parentid sẽ mang giá trị 0
            //if( $(""#ParentID"").val().trim() == """" ||  $(""#ParentID"").val().trim() == null) {
            //    $(""#ParentID"").val(""0"");
            //} 

            if(resultSubmit) { 
                Swal.fire({
                icon: 'question',
                title: 'Confirm?',
                text: 'Bạn có muốn sửa comment ?',
                showCloseButton: true,
                showCancelButton: true
            }).then((result) => {
                if (result.isConfirmed) { 
                    debugger");
            WriteLiteral(@";
                    var obj = {
                        ""ID"": $(""#Id"").val(), 
                        ""PostID"": $(""#PostID"").val(), 
                        ""Active"": $(""#Active"").val(),
                        ""Name"": $(""#Name"").val(),
                        ""Description"": $(""#Description"").val(), 
                        ""Text"": $(""#Text"").val(), 
                        ""CreatedTime"": $(""#CreatedTime"").val(),
                    }
                    $.ajax({
                        url: ""/comment/api/edit"",
                        type: ""POST"",
                        contentType: ""application/json"",
                        data: JSON.stringify(obj),
                        success: function (responseData) {
                       
                            Swal.fire({
                                icon: 'success',
                                title: '<strong>Đã chỉnh sửa comment!</strong>',
                                showCloseButton: true,
                            ");
            WriteLiteral(@"    focusConfirm: false,
                            }).then(resultt => {
                                    if (resultt.isConfirmed) {
                                        location.reload();
                                    }
                                });
                        
                        }
                    })
                } else if (result.isDenied) {

                }
            })
            }

        
    }

    async function GetDetailItem(id) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: ""/menu/api/detail/"" + id,
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
                success: function (responseData) {
                    var Item = JSON.parse(responseData);
                    resolve(Item)
                },
                error: function (e) {
                    reject(e);
                }
            });
      ");
            WriteLiteral("  })\r\n    }\r\n</script>\r\n");
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
