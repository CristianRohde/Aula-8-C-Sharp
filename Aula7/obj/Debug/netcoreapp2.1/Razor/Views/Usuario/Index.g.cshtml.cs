#pragma checksum "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f10d9f374f3def5358190847d21105d37b8e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
#line 1 "G:\C#\Aula08\Aula7\Views\_ViewImports.cshtml"
using Aula7;

#line default
#line hidden
#line 2 "G:\C#\Aula08\Aula7\Views\_ViewImports.cshtml"
using Aula7.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f10d9f374f3def5358190847d21105d37b8e7e", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ebf63b3090ccd454a20349d8bbf8e04a295bc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aula7.Models.UsuarioModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(120, 51, false);
#line 10 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
Write(Html.ActionLink("Criar Usuário", "AdicionaUsuario"));

#line default
#line hidden
            EndContext();
            BeginContext(171, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 40, false);
#line 16 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 45, false);
#line 19 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(461, 44, false);
#line 22 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(561, 41, false);
#line 25 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(602, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(658, 46, false);
#line 28 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(704, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(822, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(871, 39, false);
#line 37 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(910, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(966, 44, false);
#line 40 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1066, 43, false);
#line 43 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1165, 40, false);
#line 46 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1261, 45, false);
#line 49 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1362, 65, false);
#line 52 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1448, 71, false);
#line 53 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1540, 69, false);
#line 54 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1609, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 57 "G:\C#\Aula08\Aula7\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1648, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aula7.Models.UsuarioModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591