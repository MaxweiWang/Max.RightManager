#pragma checksum "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7411c88858b3e581ad5879cead3b133b61a50b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sys_Role_Info), @"mvc.1.0.view", @"/Areas/Admin/Views/Sys/Role/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7411c88858b3e581ad5879cead3b133b61a50b", @"/Areas/Admin/Views/Sys/Role/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986af3a92b9908fec85e16c7dc15a974d36d81ae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sys_Role_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/adminForm.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container-fluid adminForm\" id=\"app\">\r\n\r\n    <div class=\"row\">\r\n        <!--表单控件-->\r\n        ");
#nullable restore
#line 5 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
    Write(UI.Input<Sys_Role>(w => w.Role_Num, 12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 6 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
    Write(UI.Input<Sys_Role>(w => w.Role_Name, 12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
          
            var _Select_Role_IsDelete = UI.Select<Sys_Role>(w => w.Role_IsDelete, () =>
            {
                var _Options = string.Empty;
                _Options += $"<option value='1'>是</option>";
                _Options += $"<option value='2'>否</option>";
                return _Options;
            }, 12);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 16 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
   Write(_Select_Role_IsDelete);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
    Write(UI.Textarea<Sys_Role>(w => w.Role_Remark, 12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n    <!--按钮组start-->\r\n    <div class=\"formToolbar\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\"></div>\r\n            <div class=\"col-sm-6 text-right\">\r\n                <button class=\"btn btn-primary\" ");
            WriteLiteral("@click=\"formKey=\'\'\" v-show=\"formKey\">添加</button>\r\n                <button class=\"btn btn-success\" ");
            WriteLiteral("@click=\"save\">保存</button>\r\n                <button class=\"btn btn-danger\" ");
            WriteLiteral("@click=\"adminFormObject.closeWindow()\">关闭</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!--按钮组end-->\r\n</div>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <!--STYLE-->\r\n    <style type=\"text/css\">\r\n    </style>\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!--SCRIPT-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f7411c88858b3e581ad5879cead3b133b61a50b7050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    var app = new Vue({\r\n        el: \"#app\",\r\n        data: {\r\n            formKey:\'");
#nullable restore
#line 47 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
                Write(ViewBag.FormKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',//表单主键\r\n            adminFormObject: {},\r\n            ");
#nullable restore
#line 49 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
        Write(UI.CreateViewModel(new Sys_Role()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        },
        watch: {
            formKey: function (newV, oldV) {
                this.load();
            }
        },
        mounted: function () {//页面加载完成
            this.adminFormObject = new adminForm(this,[""adminFormObject""]);
            this.load();
        },
        //函数集合
        methods: {
            load: function () {
                var loadUrl = """);
#nullable restore
#line 63 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
                          Write(Url.Action("LoadForm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                //初始化页面数据
                this.adminFormObject.init({
                    formKey: this.formKey,
                    url: loadUrl,
                    callBack: function (r) { console.log(r); }
                });
            },
            //保存
            save: function () {
                var loadUrl = """);
#nullable restore
#line 73 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\Role\Info.cshtml"
                          Write(Url.Action("Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                console.log(1);
                //
                this.adminFormObject.save({
                    url: loadUrl,
                });
            },
            //查找带回
            findBack: function (row, tag) {

            },
        }
    });
    </script>
");
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
