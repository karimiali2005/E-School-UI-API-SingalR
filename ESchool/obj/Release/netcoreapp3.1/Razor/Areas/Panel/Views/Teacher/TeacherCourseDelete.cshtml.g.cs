#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea075748ebda3d4dcef4b149db6d222720da0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_Teacher_TeacherCourseDelete), @"mvc.1.0.view", @"/Areas/Panel/Views/Teacher/TeacherCourseDelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea075748ebda3d4dcef4b149db6d222720da0ca", @"/Areas/Panel/Views/Teacher/TeacherCourseDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec35194f4018e79d92c388c5c4744b42661dd8b", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_Teacher_TeacherCourseDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeacherCourse>>
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
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
  
    Layout = "~/Areas/Panel/Views/Shared/_Layout.cshtml";
    int count = 0;
    UserOp userOp = new UserOp();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bigbox colorBackWhite colorBorderGray\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ea075748ebda3d4dcef4b149db6d222720da0ca4642", async() => {
                WriteLiteral(@"

        <div id=""diverrors"" class=""errors textAlignRight"">
            <img src=""/imagesite/icons/error.png"" />
            <p id=""errormsg""></p>
            <input type=""text"" id=""focusable"" />
        </div>

        <p id=""formTitle"" class=""titr textAlignRight"">دروس انتخاب شده برای حذف به شرح ذیل است</p>

        <div class=""step opacityOne"" id=""step1"">
            <div class=""row rowInline"">
");
#nullable restore
#line 22 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
                 foreach (TeacherCourse item in Model)
                {
                    string DegreeTitle = item.Degree != null ? item.Degree.DegreeTitle : "";
                    string GradeTitle = item.Grade != null ? item.Grade.GradeTitle : "";
                    string StudyFieldTitle = item.StudyField != null ? item.StudyField.StudyFieldTitle : "";
                    string CourseTitle = item.Course != null ? item.Course.CourseTitle : "";
                    string Nickname = item.User != null ? item.User.FirstName + " " + item.User.LastName : "";

                    string Text = "درس " + CourseTitle + " برای معلم " + Nickname;
                    if(!string.IsNullOrEmpty(DegreeTitle))
                    {
                        Text += " با مقطع تحصیلی " + DegreeTitle;
                        if (!string.IsNullOrEmpty(GradeTitle))
                        {
                            Text += " با پایه تحصیلی " + GradeTitle;
                            if (!string.IsNullOrEmpty(StudyFieldTitle))
                            {
                                Text += " با رشته تحصیلی " + StudyFieldTitle;
                            }
                        }
                    }

                    count++;


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <label");
                BeginWriteAttribute("title", " title=\"", 1961, "\"", 1990, 1);
#nullable restore
#line 46 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
WriteAttributeValue("", 1969, item.TeacherCourseId, 1969, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"lbl colorPrimary\">");
#nullable restore
#line 46 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
                                                                             Write(Html.Raw(Text));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <br /><br />\r\n");
#nullable restore
#line 48 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n            <input type=\"hidden\" id=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 2164, "\"", 2194, 1);
#nullable restore
#line 51 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
WriteAttributeValue("", 2172, ViewData["returnUrl"], 2172, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />            \r\n\r\n            <div class=\"row rowInline textAlignLeft\">\r\n");
#nullable restore
#line 54 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
                 if (count > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"button\" class=\"buttonSingle buttonSingle3 colorBackRed\" value=\"حذف شوند\" onclick=\"tcoursedeleted();\" />\r\n");
#nullable restore
#line 57 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\TeacherCourseDelete.cshtml"
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeacherCourse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
