#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3851a3e9122b79a736a3f884e5fad389e21b93b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_PreRegistration_Index), @"mvc.1.0.view", @"/Areas/Panel/Views/PreRegistration/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3851a3e9122b79a736a3f884e5fad389e21b93b2", @"/Areas/Panel/Views/PreRegistration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ec35194f4018e79d92c388c5c4744b42661dd8b", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_PreRegistration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Es.DataLayerCore.Model.PreRegistration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
  
    Layout = "~/Areas/Panel/Views/Shared/_Layout.cshtml";
    var addressDownload = "https://hesabidownload.ir/hesabischoolfiles/" + SettingContext.PathStoreFiles.Instance.PreRegistrationPic;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""bigbox displayBlock textAlignCenter colorBackWhite"" style=""overflow-x: auto; padding: 10px;"">
    <table cellspacing=""0"" class=""grid"">
        <tr>
            <th>کلاس</th>
            <th>کدملی</th>
            <th>نام</th>
            <th>نام خانوادگی</th>
            <th>نام پدر</th>
            <th>همراه پدر</th>
            <th>نام ونام خانوادگی مادر</th>
            <th>همراه مادر</th>
            <th>فیش</th>
            <th>عملیات</th>
        </tr>
");
#nullable restore
#line 22 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
          
            int i = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 28 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.ClassRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.Irnational));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.FatherNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.MotherFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
       Write(Html.Raw(item.MotherNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n");
#nullable restore
#line 37 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
             if (!string.IsNullOrEmpty(item.Pic))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"operate\" title=\"فیش\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1366, "\"", 1398, 2);
#nullable restore
#line 39 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
WriteAttributeValue("", 1373, addressDownload, 1373, 16, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
WriteAttributeValue("", 1389, item.Pic, 1389, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download>\r\n");
            WriteLiteral("                    دانلود\r\n                </a>\r\n");
#nullable restore
#line 43 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n        <td>\r\n            <a class=\"operate\" href=\"#\" title=\"آرشیو\">\r\n                <img class=\"icon\" src=\"/imagepanel/icons/archive.png\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1713, "\"", 1770, 3);
            WriteAttributeValue("", 1723, "preRegistrationArchive(", 1723, 23, true);
#nullable restore
#line 47 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"
WriteAttributeValue("", 1746, item.PreRegistrationId, 1746, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1769, ")", 1769, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </a>\r\n           \r\n        </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 53 "E:\E-School\EschoolHesabiNew\ESchool\Areas\Panel\Views\PreRegistration\Index.cshtml"

            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Es.DataLayerCore.Model.PreRegistration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
