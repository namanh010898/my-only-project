#pragma checksum "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a5c49f3071afd7c3f66c1e3124f44015f578ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_AdminListEvents), @"mvc.1.0.view", @"/Views/Post/AdminListEvents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a5c49f3071afd7c3f66c1e3124f44015f578ab", @"/Views/Post/AdminListEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0920572bf03d2705c1affc844da3453f7db91f", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_AdminListEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 6 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
  
    ViewData["Title"] = "Sự kiện";
    Layout = "_Layout - Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab5039", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <!-- Latest compiled and minified JS -->\r\n");
                WriteLiteral(@" 
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script src=""https://cdn.ckeditor.com/ckeditor5/33.0.0/classic/ckeditor.js""></script>
    <title>Document</title>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab7187", async() => {
                WriteLiteral(@"
    <button onclick=""window.location.href='/post/add/postEvents'"" style=""width:100px;height:40px;background-color:lightgreen;border-color:white;float:right;margin-bottom:1%;"">Add</button>
    <table id=""example"" class=""display"" style=""width:100%;"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Tên</th>
                <th>Mô tả</th>
                <th>Bắt đầu</th>
                <th>Kết thúc</th>
                <th>Địa điểm</th>
                <th>Chi tiết</th>
                <th>Xóa</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 75 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
             for (int i = 0; i < ViewBag.PostCount; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 78 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
                   Write(ViewBag.Posts[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 79 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
                   Write(ViewBag.Posts[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> \r\n                    <td>");
#nullable restore
#line 80 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
                   Write(ViewBag.Posts[i].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
                   Write(ViewBag.Posts[i].OpenTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
                   Write(ViewBag.Posts[i].ClosedTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
                   Write(ViewBag.Posts[i].EventAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2531, "\"", 2567, 3);
                WriteAttributeValue("", 2541, "Edit(", 2541, 5, true);
#nullable restore
#line 84 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
WriteAttributeValue("", 2546, ViewBag.Posts[i].Id, 2546, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2566, ")", 2566, 1, true);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#modal-id\">Sửa</button></td>\r\n                    <td><button");
                BeginWriteAttribute("onclick", " onclick=\"", 2663, "\"", 2705, 3);
                WriteAttributeValue("", 2673, "DeleteItem(", 2673, 11, true);
#nullable restore
#line 85 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
WriteAttributeValue("", 2684, ViewBag.Posts[i].Id, 2684, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2704, ")", 2704, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Xóa</button></td>\r\n                </tr>\r\n");
#nullable restore
#line 87 "C:\Users\naman\Downloads\Compressed\namanh108-nguyen-nam-anh-7b2b4cbf6975\my-only-project\Test2\Test2\Views\Post\AdminListEvents.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <th>ID</th>
                <th>Tên</th>
                <th>Mô tả</th>
                <th>Bắt đầu</th>
                <th>Kết thúc</th>
                <th>Địa điểm</th>
                <th>Chi tiết</th>
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
                    <h3>Sự kiện</h3>
                    <i>Lưu ý điền đầy đủ các thông tin có dấu <span style=""color:red"">*</span></i>
                    <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""ID"">ID(Tự động)</label><span style=""color:red"">*</span>
                        </div>
                        <div class");
                WriteLiteral(@"=""col-md-9"">
                            <input type=""text"" id=""ID"" class=""fullwidth""  disabled />
                        </div>
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
                        <label for=""Url"">Url(Tự động)</label><span style=""color:red"">*</span>
                        </div>
                        <div class=""col-md-9"">
                            <input type=""text"" id=""Url"" class=""fullwidth""  disabled />
                        </div>
                    </div>

                   ");
                WriteLiteral(@" <div class=""row modal-row-menu"">
                        <div class=""col-md-3 "">
                        <label for=""PostCategoryID"">Category(Tự động)</label><span style=""color:red"">*</span> 
                        </div>
                        <div class=""col-md-9"">
                            <select id=""PostCategoryID"" disabled>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab14630", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab15887", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab17152", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab19189", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab20445", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab22186", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a5c49f3071afd7c3f66c1e3124f44015f578ab23442", async() => {
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
                        <label for=""Content"">Content</label>
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
                        <div class=""col-md-9"">");
                WriteLiteral(@"
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
                    </div> 
                </div>");
                WriteLiteral(@"
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default""
                            data-dismiss=""modal"" style=""    display: contents"">
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
    async function DeleteItem(id) {
        debugger;
        Swal.fire({
            icon: 'question',
            title: 'Bạn có muốn xóa item này?',
            showCancelButton: true,
            showCloseButton: true
        }).then((result) => {
            if (result.isConfirmed) {
                //var obj = await GetDetailItem(id);
                $.ajax({
                    url: ""/post/api/delete"",
                    type: 'POST',
                    contentType: 'application/JSON',
                    data: JSON.stringify({ ""id"": id }),
                    success: function (responseData) { 
                        
                        Swal.fire({
                            icon: 'success',
                            title: '<strong>Item đã xóa thành công!</strong>',
                            showCloseButton: true,
                            focusConfirm: false,
                        }).then(resultt => {
                                if (r");
            WriteLiteral(@"esultt.isConfirmed) {
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

         
    
     function Submit() {
         var resultSubmit = true; 
             
            if( $(""#Name"").val().trim() == """" ||  $(""#Name"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                text: 'Name không thể bị bỏ trống',
                showCloseButton: true
                });
            }  

            if( $(""#PublishedTime"").val() =");
            WriteLiteral(@"= """" ||  $(""#PublishedTime"").val() == null) {
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
                text: 'Open Time không thể bị bỏ trống',
                showCloseButton: true
                });
            }

            if( $(""#ClosedTime"").val() == """" ||  $(""#ClosedTime"").val() == null) {
                resultSubmit = false;
                Swal.fire({
                icon: 'warning',
                title: 'Cần điền đầy đủ thông tin!',
                text: 'Closed Time không thể bị bỏ trống',
          ");
            WriteLiteral(@"      showCloseButton: true
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

            if(resultSubmit) {
                    Swal.fire({
                icon: 'question',
                title: 'Confirm?',
                text: 'Bạn có muốn sửa event ?',
                showCloseButton: true,
                showCancelButton: true
            }).then((result) => {
                if (result.isConfirmed) { 
                    var data = posttext.getData();
                    debugger;
                    var obj = {
                        ""ID"" : $(""#ID"").val(),  
                        ""PostTypeID"": 1,
              ");
            WriteLiteral(@"          ""PostAccountID"": 10001,
                        ""PostCategoryID"" :  $(""#PostCategoryID"").val(),  
                        ""PostLayoutID"": 1,
                        ""PostPublishStatusID"": 1,
                        ""PostCommentStatusID"": $(""#PostCommentStatusID"").val(),             
                        ""Active"":  $(""#Active"").val(),      
                        ""Url"":  $(""#Url"").val(),
                        ""Photo"": $(""#Photo"").val(),     
                        ""Video"": """",
                        ""Name"": $(""#Name"").val(),       
                        ""Description"": $(""#Description"").val(),     
                        ""Text"": data,       
                        ""PublishedTime"": $(""#PublishedTime"").val(),        
                        ""OpenTime"": $(""#OpenTime"").val(),        
                        ""ClosedTime"": $(""#ClosedTime"").val(),        
                        ""EventAddress"": $(""#EventAddress"").val(),  
                    }
                    $.ajax({
      ");
            WriteLiteral(@"                  url: ""/post/api/edit"",
                        type: ""POST"",
                        contentType: ""application/json"",
                        data: JSON.stringify(obj),
                        success: function (responseData) {
                       
                            Swal.fire({
                                icon: 'success',
                                title: '<strong>Đã chỉnh sửa Event!</strong>',
                                showCloseButton: true,
                                focusConfirm: false,
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

    async functi");
            WriteLiteral(@"on GetDetailItem(id) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: ""https://localhost:5001/post/api/detail/"" + id,
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
                success: function (responseData) {
                    Item = JSON.parse(responseData);
                    resolve(Item)
                },
                error: function (e) {
                    reject(e);
                }
            });
        })
    }

    async function Edit(id) {
        $(""#modal-id"").show();
        let obj = await getItemByID(id);
        debugger;
        $(""#ID"").val(obj[0].Id);
		$(""#Name"").val(obj[0].Name);
		$(""#Url"").val(obj[0].Url); 
		$(""#PostCommentStatusID"").val(obj[0].PostCommentStatusId);
		$(""#Photo"").val(obj[0].Photo); 
		$(""#Description"").val(obj[0].Description);
		 
        posttext.setData(obj[0].Text);

		$(""#PublishedTime"").val(obj[0].PublishedTim");
            WriteLiteral(@"e);
		$(""#OpenTime"").val(obj[0].OpenTime);
		$(""#ClosedTime"").val(obj[0].ClosedTime);
		$(""#EventAddress"").val(obj[0].EventAddress);
         
    }

    async function getItemByID(id) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: ""/post/api/detail/"" + id ,
                type: ""GET"",
                async: 'true',
                contentType: ""application/json"",
                success: function (responseData) { 
                    Item = JSON.parse(responseData);
                    resolve(Item);
                },
                error: function (e) {
                    reject(e);
                }
            });
        })
        }

</script>
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