#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ef53fa5b3a97e646a21188138c5309341b5d3eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderChatRight), @"mvc.1.0.view", @"/Views/Shared/HeaderChatRight.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef53fa5b3a97e646a21188138c5309341b5d3eb", @"/Views/Shared/HeaderChatRight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27fe79aadfc202295453e0150d93b2d924692028", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderChatRight : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Es.DataLayerCore.DTOs.RoomChat.RoomLiveViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagemember/menu.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <div class=\" header d-flex justify-content-between\">\r\n        <!-- start change6 -->\r\n        <!-- start change23 -->\r\n        <div id=\"SearchRoomChatGroup\" class=\" search-open displayNone\">\r\n            <div >\r\n                <label");
            BeginWriteAttribute("for", " for=\"", 301, "\"", 307, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\" position-absolute\"><img onclick=\"SearchRoomChatGroupHide()\" src=\"/imagemember/arrow.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 405, "\"", 411, 0);
            EndWriteAttribute();
            WriteLiteral(@"></label>
                <input id=""boxRoomChatGroup"" type=""text"" placeholder=""جستجو..."" class=""rtl"">
            </div>
        </div>
        <!-- end change23 -->
        <!-- start change21 -->
        <div class="" contact-option-drop d-flex align-items-center"">
            <div class="" mx-2 d-sm-flex big-scre"">
                <img onclick=""SearchRoomChatGroupShow()"" src=""/imagemember/search.svg""");
            BeginWriteAttribute("alt", " alt=\"", 825, "\"", 831, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\" mx-1\">\r\n                <img onclick=\"openContact()\" class=\"add-chat  mx-1\" src=\"/imagemember/add.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 943, "\"", 949, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n");
#nullable restore
#line 18 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
             if (Model != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""dropdown div-option-massage "">
                    <button class=""d-flex btn shadow-none dropdown-toggle p-0 div-menu-img"" type=""button""
                            id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true""
                            aria-expanded=""false"">
                        <img src=""/imagemember/live-streaming.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1403, "\"", 1409, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </button>\r\n                    <div class=\"dropdown-menu option-chat p-0\" aria-labelledby=\"dropdownMenuButton\"");
            BeginWriteAttribute("style", "\r\n                         style=\"", 1545, "\"", 1579, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 29 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                             if (item.LiveType == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 1785, "\"", 1871, 7);
            WriteAttributeValue("", 1795, "OpenLinkAdobe(\'", 1795, 15, true);
#nullable restore
#line 33 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
WriteAttributeValue("", 1810, item.LiveAddress, 1810, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1827, "\',\'", 1827, 3, true);
#nullable restore
#line 33 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
WriteAttributeValue("", 1830, item.LiveUsername, 1830, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1848, "\',\'", 1848, 3, true);
#nullable restore
#line 33 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
WriteAttributeValue("", 1851, item.LivePassword, 1851, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1869, "\')", 1869, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\" dropdown-item p-0\">\r\n                                    <button type=\"button\">\r\n                                        <span class=\" mr-1\">");
#nullable restore
#line 35 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                                                       Write(item.RoomChatGroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span><img src=\"/imagemember/liveb.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2134, "\"", 2140, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </button>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 40 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                             if (item.LiveType == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2392, "\"", 2457, 5);
            WriteAttributeValue("", 2402, "OpenLinkJitsi(\'", 2402, 15, true);
#nullable restore
#line 43 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
WriteAttributeValue("", 2417, item.LiveAddress, 2417, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2434, "\',\'", 2434, 3, true);
#nullable restore
#line 43 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
WriteAttributeValue("", 2437, item.LivePassword, 2437, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2455, "\')", 2455, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\" dropdown-item p-0\">\r\n                                    <button type=\"button\">\r\n                                        <span class=\" mr-1\">");
#nullable restore
#line 45 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                                                       Write(item.RoomChatGroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span><img src=\"/imagemember/gitsib.png\"");
            BeginWriteAttribute("alt", " alt=\"", 2721, "\"", 2727, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </button>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 50 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                             if (item.LiveType == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("onclick", " onclick=\"", 2979, "\"", 3022, 3);
            WriteAttributeValue("", 2989, "OpenLinkZoom(\'", 2989, 14, true);
#nullable restore
#line 53 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
WriteAttributeValue("", 3003, item.LiveAddress, 3003, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3020, "\')", 3020, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\" dropdown-item p-0\">\r\n                                    <button type=\"button\">\r\n                                        <span class=\" mr-1\">");
#nullable restore
#line 55 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                                                       Write(item.RoomChatGroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span><img src=\"/imagemember/zoom.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3284, "\"", 3290, 0);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                    </button>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 60 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 64 "E:\E-School\EschoolHesabiNew\ESchool\Views\Shared\HeaderChatRight.cshtml"
            }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <!-- end change21 -->
        <div class=""name-pro d-sm-none"">حسابی</div>
        <div class="" d-flex align-items-center"">
            <div class=""name-pro d-none d-sm-block"">حسابی</div>
            <div onclick=""openCart()"" class=""menu-open-cart"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ef53fa5b3a97e646a21188138c5309341b5d3eb14321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <!-- end change6 -->\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Es.DataLayerCore.DTOs.RoomChat.RoomLiveViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
