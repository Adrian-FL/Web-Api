#pragma checksum "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e97d06ee21447674e16e08906ea85f3d92fbda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Games_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Games/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e97d06ee21447674e16e08906ea85f3d92fbda", @"/Areas/Admin/Views/Games/Delete.cshtml")]
    public class Areas_Admin_Views_Games_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Highscores.Data.Entities.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UrlSlug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UrlSlug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Highscores.Data.Entities.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
