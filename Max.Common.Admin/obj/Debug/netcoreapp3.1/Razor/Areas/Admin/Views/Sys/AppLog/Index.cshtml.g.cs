#pragma checksum "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcec0fc9ff7f997e4d8526da5ff83f1613c331af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sys_AppLog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Sys/AppLog/Index.cshtml")]
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
#line 1 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Entities.SysClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Service.SysClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using AppFormTag;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcec0fc9ff7f997e4d8526da5ff83f1613c331af", @"/Areas/Admin/Views/Sys/AppLog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986af3a92b9908fec85e16c7dc15a974d36d81ae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sys_AppLog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/libs/bootstrap-table-master/dist/bootstrap-table.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/libs/bootstrap-table-master/dist/bootstrap-table.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/libs/bootstrap-table-master/dist/locale/bootstrap-table-zh-CN.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/adminList.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid h-100 bg-bgcolor page page-tables page-content"" id=""app"">
    <div class=""row"">
        <!--高级检索部分-->
        <div class=""col-sm-12"" id=""panelSearch"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <h5 class=""card-title"">数据检索</h5>
                        </div>
                        <div class=""col-sm-12"">
                            <!--更多高级检索-->
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcec0fc9ff7f997e4d8526da5ff83f1613c331af7135", async() => {
                WriteLiteral(@"
                                <div action=""javascript:void(0)"" class=""form-row"">
                                    <div class=""col-sm-3"">
                                        <div class=""form-group"">
                                            <label>Api</label>
                                            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("name", " name=\"", 951, "\"", 990, 1);
#nullable restore
#line 18 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml"
WriteAttributeValue("", 958, nameof(Sys_AppLog.AppLog_Api), 958, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"请输入 Api\">\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-sm-12 text-right\">\r\n                            <button class=\"btn btn-primary\" ");
            WriteLiteral("@click=\"refresh()\">检索</button>&nbsp;&nbsp;\r\n                            <button class=\"btn btn-success\" ");
            WriteLiteral("@click=\"adminListObject.resetSearch()\">重置</button>&nbsp;&nbsp;\r\n                            <button class=\"btn btn-danger\" ");
            WriteLiteral(@"@click=""adminListObject.panelSearch()"">收起</button>&nbsp;&nbsp;
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <!--表格-->
        <div class=""col-sm-12"">
            <div class=""card"">
                <div class=""card-body p-0"">
                    <div class=""row"">
                        <div class=""col-sm-12"" id=""toolsButtons"">
                            <div class=""btn-group"" role=""group"" data-power=""Search"" name=""search"">
                                <button type=""button"" class=""btn btn-primary"" ");
            WriteLiteral("@click=\"adminListObject.panelSearch()\"><i class=\"fas fa-search\"></i>&nbsp;检索(收/展)</button>\r\n                            </div>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n");
            WriteLiteral("                                <button type=\"button\" class=\"btn btn-primary\" data-power=\"Edit\" name=\"edit\" ");
            WriteLiteral("@click=\"form(\'update\')\" style=\"display:none;\">查看</button>\r\n");
            WriteLiteral("                            </div>\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                <a class=\"btn btn-primary\" data-power=\"GetExcel\" name=\"getExcel\" ");
            WriteLiteral("@click=\"exportExcel\" target=\"_blank\">导出Excel</a>\r\n                                <a class=\"btn btn-primary\" data-power=\"Print\" name=\"print\" ");
            WriteLiteral(@"@click=""print"" target=""_blank"">打印</a>
                            </div>
                        </div>
                        <div class=""col-sm-12""><table id=""adminTable""></table></div>
                    </div>

                </div>
            </div>
        </div>
    </div>

</div>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <!--STYLE-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fcec0fc9ff7f997e4d8526da5ff83f1613c331af11910", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n    </style>\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!--SCRIPT-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcec0fc9ff7f997e4d8526da5ff83f1613c331af13280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcec0fc9ff7f997e4d8526da5ff83f1613c331af14380", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcec0fc9ff7f997e4d8526da5ff83f1613c331af15480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
    var app = new Vue({
        el: ""#app"",
        data: {
            adminListObject: {},
        },
        mounted: function () {//页面加载完成
            this.adminListObject = new adminList();
            this.load();
        },
        //函数集合
        methods: {
            load: function () {
                var loadUrl = """);
#nullable restore
#line 87 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml"
                          Write(Url.Action("GetDataSource"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                admin.ajax({
                    url: loadUrl,
                    data: { rows: 1 },
                    success: function (r) {
                        var _columns = r.column;
                        //表格加载
                        app.adminListObject.tableInit({
                            url: loadUrl,
                            columns: _columns
                        });
                    }
                });
            },
            //打开表单
            form: function (tag) {
                var rows = this.adminListObject.selectRows();
                var loadUrl = """);
#nullable restore
#line 104 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml"
                          Write(Url.Action("Info"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";

                if (tag == ""add"") {
                    loadUrl = loadUrl + ""?formKey="";
                } else {
                    loadUrl = loadUrl + ""?formKey="" + rows[0]._ukid;
                }

                this.adminListObject.form({
                    parentFrameName: window.location.pathname,
                    url: loadUrl,
                    width: ""600px"",
                    height: ""600px"",
                    btn: false,
                    end: function () {
                        app.refresh();
                        console.log('我被销毁了!');
                    }
                });
            },
            //删除数据
            remove: function () {
                var loadUrl = '");
#nullable restore
#line 126 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml"
                          Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                app.adminListObject.delete(loadUrl, function () {
                    app.refresh();
                    console.log(""删除完成!"");
                });
            },
            //刷新列表数据
            refresh: function (data) {
                app.adminListObject.refresh(data);
            },
            //导出excel
            exportExcel: function () {
                app.adminListObject.exportExcel('");
#nullable restore
#line 138 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml"
                                            Write(Url.Action("ExportExcel"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            },\r\n            //打印\r\n            print: function () {\r\n                app.adminListObject.print(\'");
#nullable restore
#line 142 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\AppLog\Index.cshtml"
                                      Write(Url.Action("Print"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            },\r\n        }\r\n    });\r\n    </script>\r\n");
            }
            );
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
