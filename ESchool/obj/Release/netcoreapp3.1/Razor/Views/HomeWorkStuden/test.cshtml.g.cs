#pragma checksum "E:\E-School\EschoolHesabiNew\ESchool\Views\HomeWorkStuden\test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e064ea000e7ae1341bcd7441d9be0ce488cc28f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeWorkStuden_test), @"mvc.1.0.view", @"/Views/HomeWorkStuden/test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e064ea000e7ae1341bcd7441d9be0ce488cc28f", @"/Views/HomeWorkStuden/test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27fe79aadfc202295453e0150d93b2d924692028", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeWorkStuden_test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\E-School\EschoolHesabiNew\ESchool\Views\HomeWorkStuden\test.cshtml"
  
    ViewData["Title"] = "test";
    Layout = "~/Views/Shared/_LayoutMember.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<meta charset=""utf-8"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

<title>jQuery Ajax File Uploader Widget</title>

<!-- Bootstrap core CSS -->
<link href=""/uploadfile/css/styles.css"" rel=""stylesheet"" />
<link href=""/uploadfile/css/jquery.dm-uploader.min.css"" rel=""stylesheet"" />
");
            WriteLiteral(@"<main role=""main"" class=""container"">

    <div class=""row"">
        <div class=""col-md-6 col-sm-12"">

            <!-- Our markup, the important part here! -->
            <div id=""drag-and-drop-zone"" class=""dm-uploader p-5"">
                <h3 class=""mb-5 mt-5 text-muted"">Drag &amp; drop files here</h3>

                <div class=""btn btn-primary btn-block mb-5"">
                    <span>Open the file Browser</span>
                    <input type=""file"" title=""Click to add Files""");
            BeginWriteAttribute("multiple", " multiple=\"", 946, "\"", 957, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div><!-- /uploader -->

        </div>
        <div class=""col-md-6 col-sm-12"">
            <div class=""card h-100"">
                <div class=""card-header"">
                    File List
                </div>

                <ul class=""list-unstyled p-2 d-flex flex-column col"" id=""files"">
                    <li class=""text-muted text-center empty"">No files uploaded.</li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card h-100"">
                <div class=""card-header"">
                    Debug Messages
                </div>

                <ul class=""list-group list-group-flush"" id=""debug"">
                    <li class=""list-group-item text-muted empty"">Loading plugin....</li>
                </ul>
            </div>
        </div>
    </div> <!-- /debug -->

</main> <!-- /container -->




<!-- File item template -->
<script type");
            WriteLiteral(@"=""text/html"" id=""files-template"">
    <li class=""media"">
        <div class=""media-body mb-1"">
            <p class=""mb-2"">
                <strong>%%filename%%</strong> - وضعیت: <span class=""text-muted"">صبر کنید</span>

                <img src=""/imagesuser/icons/remove_file.png"" />
            </p>
            <div class=""progress mb-2"">
                <div class=""progress-bar progress-bar-striped progress-bar-animated bg-primary""
                     role=""progressbar""
                     style=""width: 0%""
                     aria-valuenow=""0"" aria-valuemin=""0"" aria-valuemax=""100"">
                </div>
            </div>
            <hr class=""mt-1 mb-1"" />
        </div>
    </li>
</script>

<!-- Debug item template -->
");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/html"" id=""debug-template"">
        <li class=""list-group-item text-%%color%%""><strong>%%date%%</strong>: %%message%%</li>
    </script>

    <script src=""/uploadfile/js/demo-config.js""></script>
    <script src=""/uploadfile/js/demo-ui.js""></script>
    <script src=""/uploadfile/js/jquery.dm-uploader.min.js""></script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
