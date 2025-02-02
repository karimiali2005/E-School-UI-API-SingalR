#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f819de70ee15153ad9750b58ff23ac113d2ed071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_RoomDetail_RoomDetailDelete), @"mvc.1.0.view", @"/Areas/Panel/Views/RoomDetail/RoomDetailDelete.cshtml")]
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
#line 1 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\_ViewImports.cshtml"
using ESchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\_ViewImports.cshtml"
using ESchool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\_ViewImports.cshtml"
using ESchool.Need;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\_ViewImports.cshtml"
using DatabaseLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\_ViewImports.cshtml"
using DatabaseLayer.Access;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f819de70ee15153ad9750b58ff23ac113d2ed071", @"/Areas/Panel/Views/RoomDetail/RoomDetailDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec35194f4018e79d92c388c5c4744b42661dd8b", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_RoomDetail_RoomDetailDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoomDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form textAlignCenter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
  
    Layout = "~/Areas/Panel/Views/Shared/_Layout.cshtml";
    int count = 0;
    RoomDetailOp roomDetailOp = new RoomDetailOp();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bigbox colorBackWhite colorBorderGray\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f819de70ee15153ad9750b58ff23ac113d2ed0714657", async() => {
                WriteLiteral(@"

        <div id=""diverrors"" class=""errors textAlignRight"">
            <img src=""/imagesite/icons/error.png"" />
            <p id=""errormsg""></p>
            <input type=""text"" id=""focusable"" />
        </div>

        <p id=""formTitle"" class=""titr textAlignRight"">حذف برنامه های انتخاب شده به شرح ذیل است</p>

        <div class=""step opacityOne"" id=""step1"">
            <div class=""row rowInline"">
");
#nullable restore
#line 22 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
                 foreach (RoomDetail roomDetail in Model)
                {
                    string PersianDay = Codes.getPersianDay(roomDetail.RoomDetailDate);
                    string PersianDate = Codes.getPersianDate(roomDetail.RoomDetailDate);

                    string text = "حذف برنامه " + roomDetail.Room.RoomType.RoomTypeTitle + " در روز " + PersianDay + " مورخ " + PersianDate;
                    if(roomDetail.Room.RoomTypeId == 1)
                    {
                        text += " برای درس " + roomDetail.Course.CourseTitle + " با معلم " + roomDetail.User.FirstName + " " + roomDetail.User.LastName;
                    }


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <label");
                BeginWriteAttribute("title", " title=\"", 1368, "\"", 1400, 1);
#nullable restore
#line 33 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
WriteAttributeValue("", 1376, roomDetail.RoomDetailId, 1376, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"lbl colorPrimary\"> ");
#nullable restore
#line 33 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
                                                                                 Write(Html.Raw(text));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                    <br />\r\n");
#nullable restore
#line 35 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n            <input type=\"hidden\" id=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1570, "\"", 1600, 1);
#nullable restore
#line 38 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
WriteAttributeValue("", 1578, ViewData["returnUrl"], 1578, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <div class=\"row rowInline textAlignLeft\">\r\n");
#nullable restore
#line 41 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"button\" class=\"buttonSingle buttonSingle3 colorBackRed\" value=\"حذف شوند\" onclick=\"rddeleted();\" />\r\n");
#nullable restore
#line 44 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\RoomDetail\RoomDetailDelete.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"button\" class=\"buttonSingle buttonSingle3 colorBackBlue2\" value=\"برگشت\" onclick=\"cancelCh()\" />\r\n            </div>\r\n\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoomDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
