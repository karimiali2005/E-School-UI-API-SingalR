#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5493ac497437e807ad54a4607196eb060baabfb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_Teacher_Course), @"mvc.1.0.view", @"/Areas/Panel/Views/Teacher/Course.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5493ac497437e807ad54a4607196eb060baabfb3", @"/Areas/Panel/Views/Teacher/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec35194f4018e79d92c388c5c4744b42661dd8b", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_Teacher_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomProperties>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chPreviousColor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form textAlignCenter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
  
    Layout = "~/Areas/Panel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
  
    var degreeDefault = Model.Degrees.First() != null ? Model.Degrees.First().DegreeId : 0;

    int PageNumber = 1;
    int DegreeId = 0;
    int GradeId = 0;
    int StudyFieldId = 0;
    int CourseId = 0;    

    try { PageNumber = Convert.ToInt32(System.Web.MyHttpContext.Current.Request.Query["pagenumber"]); } catch { PageNumber = 1; }
    PageNumber = PageNumber <= 0 ? 1 : PageNumber;
    try { DegreeId = Convert.ToInt32(System.Web.MyHttpContext.Current.Request.Query["degree"]); } catch { DegreeId = 0; }
    try { GradeId = Convert.ToInt32(System.Web.MyHttpContext.Current.Request.Query["grade"]); } catch { GradeId = 0; }
    try { StudyFieldId = Convert.ToInt32(System.Web.MyHttpContext.Current.Request.Query["studyField"]); } catch { StudyFieldId = 0; }
    try { CourseId = Convert.ToInt32(System.Web.MyHttpContext.Current.Request.Query["course"]); } catch { CourseId = 0; }    

    degreeDefault = DegreeId > 0 ? DegreeId : degreeDefault;

    string displayNoneGrade = GradeId > 0 ? "" : "displayNone";
    string displayNoneStudyField = StudyFieldId > 0 ? "" : "displayNone";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
Write(await Html.PartialAsync("Message", new MessageModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"bigbox colorBackWhite colorBorderGray positionRelative\">\r\n\r\n    <img class=\"arrow rotate\" src=\"/imagepanel/icons/arrow_down.png\" onclick=\"openBigBox(this)\" />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb37812", async() => {
                WriteLiteral(@"

        <div id=""diverrors"" class=""errors textAlignRight"">
            <img src=""/imagesite/icons/error.png"" />
            <p id=""errormsg""></p>
            <input type=""text"" id=""focusable"" />
        </div>

        <div class=""step opacityOne"" id=""step1"">
            <div class=""row rowInline"">
                <label class=""lbl"">مقطع تحصیلی</label>
                <select id=""Degree"" class=""chPreviousColor"" onchange=""selectCh(this)"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb38569", async() => {
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
                WriteLiteral("\r\n");
#nullable restore
#line 49 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                     foreach (var degree in Model.Degrees)
                    {

                        bool selected = degree.DegreeId == DegreeId ? true : false;
                        string title = !degree.HasGrade ? "" : degree.DegreeId.ToString() + ",r";
                        if (selected)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb310303", async() => {
#nullable restore
#line 56 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                                                                           Write(degree.DegreeTitle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 56 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
AddHtmlAttributeValue("", 2378, title, 2378, 6, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                              WriteLiteral(degree.DegreeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 57 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb313097", async() => {
#nullable restore
#line 61 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                                                       Write(degree.DegreeTitle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 61 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
AddHtmlAttributeValue("", 2590, title, 2590, 6, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                              WriteLiteral(degree.DegreeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n\r\n            <div");
                BeginWriteAttribute("class", " class=\"", 2768, "\"", 2807, 3);
                WriteAttributeValue("", 2776, "row", 2776, 3, true);
                WriteAttributeValue(" ", 2779, "rowInline", 2780, 10, true);
#nullable restore
#line 67 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
WriteAttributeValue(" ", 2789, displayNoneGrade, 2790, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label class=\"lbl\">پایه تحصیلی</label>\r\n                <select id=\"Grade\" class=\"chPreviousColor\" onchange=\"selectCh(this)\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb316499", async() => {
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
                WriteLiteral("\r\n");
#nullable restore
#line 71 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                     foreach (var grade in Model.Grades)
                    {
                        string className = grade.DegreeId == degreeDefault ? "" : "displayNone";
                        bool selected = grade.GradeId == GradeId ? true : false;
                        string title = !grade.HasStudyField ? grade.DegreeId.ToString() : grade.DegreeId.ToString() + ",r";
                        if (selected)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb318351", async() => {
#nullable restore
#line 78 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                                                                                            Write(grade.GradeTitle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 78 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
AddHtmlAttributeValue("", 3498, title, 3498, 6, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                              WriteLiteral(grade.GradeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 78 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
AddHtmlAttributeValue("", 3536, className, 3536, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 79 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb321620", async() => {
#nullable restore
#line 82 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                                                                        Write(grade.GradeTitle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 82 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
AddHtmlAttributeValue("", 3723, title, 3723, 6, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                              WriteLiteral(grade.GradeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 82 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
AddHtmlAttributeValue("", 3761, className, 3761, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 83 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"

                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n\r\n            <div");
                BeginWriteAttribute("class", " class=\"", 3918, "\"", 3962, 3);
                WriteAttributeValue("", 3926, "row", 3926, 3, true);
                WriteAttributeValue(" ", 3929, "rowInline", 3930, 10, true);
#nullable restore
#line 89 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
WriteAttributeValue(" ", 3939, displayNoneStudyField, 3940, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label class=\"lbl\">رشته تحصیلی</label>\r\n                <select id=\"StudyField\" class=\"chPreviousColor\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb325483", async() => {
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
                WriteLiteral("\r\n");
#nullable restore
#line 93 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                     foreach (var studyfield in Model.StudyFields)
                    {
                        bool selected = studyfield.StudyFieldId == StudyFieldId ? true : false;
                        if (selected)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb327137", async() => {
#nullable restore
#line 98 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                                                                    Write(studyfield.StudyFieldTitle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                               WriteLiteral(studyfield.StudyFieldId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 99 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb329464", async() => {
#nullable restore
#line 102 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                                                                Write(studyfield.StudyFieldTitle);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                               WriteLiteral(studyfield.StudyFieldId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 103 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n\r\n            <div class=\"row rowInline\">\r\n                <label class=\"lbl\">نام درس</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5493ac497437e807ad54a4607196eb060baabfb331797", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 110 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Courses;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <input type=\"hidden\" id=\"returnUrl\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 5086, "\"", 5116, 1);
#nullable restore
#line 113 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
WriteAttributeValue("", 5094, ViewData["returnUrl"], 5094, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"id\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 5172, "\"", 5199, 1);
#nullable restore
#line 114 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
WriteAttributeValue("", 5180, ViewData["UserId"], 5180, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

            <div class=""row textAlignCenter"">
                <input type=""button"" class=""buttonSingle colorBackThirty"" value=""بازگشت"" onclick=""cancelCh()"" />
                <input type=""button"" class=""buttonSingle colorBackSeconday"" value=""ثبت شود"" onclick=""tcoursed()"" />
            </div>

        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""bigbox displayBlock textAlignRight"">    
    <input class=""buttonSingle buttonSingle4 displayInlineBlock colorBackRed"" style=""width :250px"" value=""حذف دروس انتخاب شده"" onclick=""tcoursedelete()"" />    
</div>

<div class=""bigbox displayBlock textAlignCenter colorBackWhite"" style=""overflow-x: auto; padding: 10px;"">
    <table cellspacing=""0"" class=""grid"">
        <tr>
            <th><input type=""checkbox"" id=""chkAll"" onclick=""chkAllGrid();"" /></th>
            <th>ردیف</th>            
            <th>مقطع تحصیلی</th>
            <th>پایه تحصیلی</th>
            <th>رشته تحصیلی</th>
            <th>نام درس</th>       
            <th>نام معلم</th>
        </tr>
");
#nullable restore
#line 140 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
          
            int i = 0;
            List<TeacherCourse> teacherCourses = (List<TeacherCourse>)ViewBag.TeacherCourses;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
         foreach (var item in teacherCourses)
        {
            string DegreeTitle = item.Degree != null ? item.Degree.DegreeTitle : "";
            string GradeTitle = item.Grade != null ? item.Grade.GradeTitle : "";
            string StudyFieldTitle = item.StudyField != null ? item.StudyField.StudyFieldTitle : "";
            string CourseTitle = item.Course != null ? item.Course.CourseTitle : "";


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><input type=\"checkbox\" class=\"chkGrid\"");
            BeginWriteAttribute("value", " value=\"", 6876, "\"", 6905, 1);
#nullable restore
#line 152 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
WriteAttributeValue("", 6884, item.TeacherCourseId, 6884, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td>");
#nullable restore
#line 153 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \r\n                <td>");
#nullable restore
#line 154 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
               Write(Html.Raw(DegreeTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 155 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
               Write(Html.Raw(GradeTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 156 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
               Write(Html.Raw(StudyFieldTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 157 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
               Write(Html.Raw(CourseTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \r\n                <td>");
#nullable restore
#line 158 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"
               Write(Html.Raw(ViewData["NickName"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 160 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\Teacher\Course.cshtml"

            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoomProperties> Html { get; private set; }
    }
}
#pragma warning restore 1591
