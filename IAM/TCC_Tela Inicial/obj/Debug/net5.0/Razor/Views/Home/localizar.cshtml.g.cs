#pragma checksum "C:\Users\bia_e\Desktop\IAM\IAM\TCC_Tela Inicial\Views\Home\localizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "871eb7a181a619498d803f7735144956391c8905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_localizar), @"mvc.1.0.view", @"/Views/Home/localizar.cshtml")]
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
#line 1 "C:\Users\bia_e\Desktop\IAM\IAM\TCC_Tela Inicial\Views\_ViewImports.cshtml"
using TCC_Tela_Inicial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bia_e\Desktop\IAM\IAM\TCC_Tela Inicial\Views\_ViewImports.cshtml"
using TCC_Tela_Inicial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"871eb7a181a619498d803f7735144956391c8905", @"/Views/Home/localizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe19a92af01279d2a3bdbaacdc680279c874d020", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_localizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row justify-content-center modal-dialog-centered"">
        <div class=""col-md-4 bg-white"" id=""card-localizar"">
            <div class=""col-md-12"">
                <p><b>Precisamos localizar sua reserva:</b></p>
            </div>
            <div class=""col-md-12"">
                <input type=""email"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""Nº Protocolo"">
            </div><div class=""row justify-content-center mt-4"">
                <div class=""col-md-12"">
                    <a type=""submit"" class=""btn-continuar-protocolo""");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 781, 1);
#nullable restore
#line 16 "C:\Users\bia_e\Desktop\IAM\IAM\TCC_Tela Inicial\Views\Home\localizar.cshtml"
WriteAttributeValue("", 746, Url.Action("dadosReserva", "Home"), 746, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continuar ></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
