#pragma checksum "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3387e1d65fd400c66c41e02e08f46fd13b055323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Option_GetAllForTask), @"mvc.1.0.view", @"/Views/Option/GetAllForTask.cshtml")]
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
#line 1 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\_ViewImports.cshtml"
using Check_n_Cheer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\_ViewImports.cshtml"
using Check_n_Cheer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3387e1d65fd400c66c41e02e08f46fd13b055323", @"/Views/Option/GetAllForTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"043111b0a253fe5d6b8ca17107fbc3066f2666cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Option_GetAllForTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Check_n_Cheer.Models.Option>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
  
    ViewData["Title"] = "GetAllForTask";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Options For Task</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
           Write(Html.DisplayNameFor(model => model.IsCorrect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsCorrect));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\smoli\Source\Repos\Check-n-Cheer\Check-n-Cheer\Views\Option\GetAllForTask.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Check_n_Cheer.Models.Option>> Html { get; private set; }
    }
}
#pragma warning restore 1591
