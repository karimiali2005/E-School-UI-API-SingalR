#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf3144b9d49d230f1172ae26a75673d3e95d891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_SessionShow), @"mvc.1.0.view", @"/Views/Class/SessionShow.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\E-School\EschoolHesabiNew\ESchool\Views\_ViewImports.cshtml"
using ESchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\E-School\EschoolHesabiNew\ESchool\Views\_ViewImports.cshtml"
using ESchool.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Views\_ViewImports.cshtml"
using ESchool.Need;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\E-School\EschoolHesabiNew\ESchool\Views\_ViewImports.cshtml"
using DatabaseLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\E-School\EschoolHesabiNew\ESchool\Views\_ViewImports.cshtml"
using DatabaseLayer.Access;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\E-School\EschoolHesabiNew\ESchool\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf3144b9d49d230f1172ae26a75673d3e95d891", @"/Views/Class/SessionShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27fe79aadfc202295453e0150d93b2d924692028", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_SessionShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoomDetail>>
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
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";
    int count = 0;
    RoomDetailOp roomDetailOp = new RoomDetailOp();

    int RoomTypeId = 1;
    int UserId_Model = 0;
    if (Model.Count() > 0)
    {
        RoomTypeId = Model.First().Room.RoomTypeId;
        UserId_Model = Model.First().UserId == null ? 0 : Model.First().UserId.Value;
    }

    var UserId = Convert.ToInt32(this.User.FindFirst("UserId").Value);
    var UserTypeId = Convert.ToInt32(this.User.FindFirst("UserTypeId").Value);

    List<Calendar> calendars = (List<Calendar>)ViewBag.Holidays;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"bigbox colorBackWhite colorBorderGray positionRelative\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccf3144b9d49d230f1172ae26a75673d3e95d8915059", async() => {
                WriteLiteral("\r\n\r\n        <p id=\"formTitle\" class=\"titr textAlignRight\">");
#nullable restore
#line 25 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                                                 Write(Html.Raw(ViewData["Title"]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

        <div id=""diverrors"" class=""errors textAlignRight"">
            <img src=""/imagesite/icons/error.png"" />
            <p id=""errormsg""></p>
            <input type=""text"" id=""focusable"" />
        </div>

        <div class=""row textAlignLeft"">
            <input type=""button"" class=""buttonSingle colorBackThirty displayInlineBlock colorBackBlue2"" value=""بازگشت"" onclick=""cancelCh()"" />
            
        </div>

    ");
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
            WriteLiteral(@"
</div>


<div class=""bigbox displayBlock textAlignCenter colorBackWhite"" style=""overflow-x: auto; padding: 10px;"">
    <table cellspacing=""0"" class=""grid"">
        <tr>
            <th>ردیف</th>
            <th>تاریخ</th>
            <th>روز</th>
            <th>ساعت شروع</th>
            <th>ساعت پایان</th>
");
#nullable restore
#line 50 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
             if (RoomTypeId == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>درس</th>\r\n                <th>معلم</th>\r\n");
#nullable restore
#line 54 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>توضیحات</th>\r\n");
#nullable restore
#line 56 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
             if (UserTypeId == 4 && UserId_Model == UserId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <th>عملیات</th>\r\n");
#nullable restore
#line 59 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 62 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
          
            int i = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
         foreach (RoomDetail roomDetail in Model)
        {
            string classHoliday = calendars.Any(p => p.CalendarDate.Date == roomDetail.RoomDetailDate.Date) || roomDetail.RoomDetailDate.DayOfWeek == DayOfWeek.Friday ? "colorBackRed2" : "";

            string PersianDate = roomDetail.RoomDetailDate != null ? Codes.getPersianDate(roomDetail.RoomDetailDate) : "";
            string PersianDay = roomDetail.RoomDetailDate != null ? Codes.getPersianDay(roomDetail.RoomDetailDate) : "";
            string CourseTitle = roomDetail.Course != null ? roomDetail.Course.CourseTitle : "";
            string TeacherName = roomDetail.User != null ? roomDetail.User.FirstName + " " + roomDetail.User.LastName : "";


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 2681, "\"", 2702, 1);
#nullable restore
#line 74 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue("", 2689, classHoliday, 2689, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 75 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 76 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
               Write(PersianDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 77 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
               Write(PersianDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 78 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
               Write(Html.Raw(roomDetail.RoomDetailTimeStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 79 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
               Write(Html.Raw(roomDetail.RoomDetailTimeFinish));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 80 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                 if (RoomTypeId == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 82 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                   Write(CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                   Write(TeacherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 84 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 85 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
               Write(Html.Raw(roomDetail.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 86 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                 if (UserTypeId == 4 && UserId_Model == UserId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td");
            BeginWriteAttribute("class", " class=\"", 3281, "\"", 3289, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"operate displayInlineBlock\" href=\"#\">\r\n                            <img class=\"icon\" src=\"/imagepanel/icons/edit.png\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3444, "\"", 3514, 5);
            WriteAttributeValue("", 3454, "classedit(", 3454, 10, true);
#nullable restore
#line 90 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue("", 3464, roomDetail.RoomDetailId, 3464, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3488, ",", 3488, 1, true);
#nullable restore
#line 90 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue(" ", 3489, roomDetail.Room.RoomId, 3490, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3513, ")", 3513, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </a>\r\n                        <a class=\"operate displayNone\" href=\"#\" title=\"اتاق چت\">\r\n                            <img class=\"icon displayBlock\" src=\"/imagesuser/icons/chat.png\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3723, "\"", 3812, 7);
            WriteAttributeValue("", 3733, "chatroom(", 3733, 9, true);
#nullable restore
#line 93 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue("", 3742, roomDetail.Room.RoomId, 3742, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3765, ",", 3765, 1, true);
#nullable restore
#line 93 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue(" ", 3766, roomDetail.UserId, 3767, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3785, ",", 3785, 1, true);
#nullable restore
#line 93 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue(" ", 3786, roomDetail.RoomDetailId, 3787, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3811, ")", 3811, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </a>\r\n                    </td>                \r\n");
#nullable restore
#line 96 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                          \r\n            </tr>\r\n");
#nullable restore
#line 99 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"

            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n    <input type=\"hidden\" id=\"returnUrl\"");
            BeginWriteAttribute("value", " value=\"", 4045, "\"", 4075, 1);
#nullable restore
#line 105 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue("", 4053, ViewData["returnUrl"], 4053, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"id\"");
            BeginWriteAttribute("value", " value=\"", 4113, "\"", 4140, 1);
#nullable restore
#line 106 "E:\E-School\EschoolHesabiNew\ESchool\Views\Class\SessionShow.cshtml"
WriteAttributeValue("", 4121, ViewData["RoomId"], 4121, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n</div>\r\n");
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
