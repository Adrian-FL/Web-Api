#pragma checksum "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a026e1138e640159e509afbadd5f3294c0ccc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Games_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Games/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a026e1138e640159e509afbadd5f3294c0ccc2", @"/Areas/Admin/Views/Games/Details.cshtml")]
    public class Areas_Admin_Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Highscores.Data.Entities.Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UrlSlug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.UrlSlug));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1536, "\"", 1560, 1);
#nullable restore
#line 53 "C:\WorkSpace\ECUtbildning\Teme\AspNetCoreWebsite\Highscores\Areas\Admin\Views\Games\Details.cshtml"
WriteAttributeValue("", 1551, Model.Id, 1551, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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