#pragma checksum "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Highscores\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82c1005695c3c2dc28bd4a3f7a334c0e3ed8d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Highscores_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Highscores/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82c1005695c3c2dc28bd4a3f7a334c0e3ed8d04", @"/Areas/Admin/Views/Highscores/Edit.cshtml")]
    public class Areas_Admin_Views_Highscores_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Highscores.Data.Entities.Highscore>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Highscores\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Highscore</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""GameId"" />
            <input type=""hidden"" asp-for=""PlayerId"" />
            <div class=""form-group"">
                <label asp-for=""Score"" class=""control-label""></label>
                <input asp-for=""Score"" class=""form-control"" />
                <span asp-validation-for=""Score"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Date"" class=""control-label""></label>
                <input asp-for=""Date"" class=""form-control"" />
                <span asp-validation-for=""Date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</");
            WriteLiteral("div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Highscores\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Highscores.Data.Entities.Highscore> Html { get; private set; }
    }
}
#pragma warning restore 1591
