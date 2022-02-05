#pragma checksum "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Highscores\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2bb6d6e851d6e6d5b2f7c180a9e707979a73f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Highscores_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Highscores/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2bb6d6e851d6e6d5b2f7c180a9e707979a73f9", @"/Areas/Admin/Views/Highscores/Create.cshtml")]
    public class Areas_Admin_Views_Highscores_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Highscores.Data.Entities.Highscore>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Highscores\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Highscore</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""GameId"" class=""control-label""></label>
                <select asp-for=""GameId"" class =""form-control"" asp-items=""ViewBag.GameId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""PlayerId"" class=""control-label""></label>
                <select asp-for=""PlayerId"" class =""form-control"" asp-items=""ViewBag.PlayerId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Score"" class=""control-label""></label>
                <input asp-for=""Score"" class=""form-control"" />
                <span asp-validation-for=""Score"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Dat");
            WriteLiteral(@"e"" class=""control-label""></label>
                <input asp-for=""Date"" class=""form-control"" />
                <span asp-validation-for=""Date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Highscores\Create.cshtml"
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