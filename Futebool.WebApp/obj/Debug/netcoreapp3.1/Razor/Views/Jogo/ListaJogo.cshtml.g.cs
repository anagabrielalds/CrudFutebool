#pragma checksum "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e248a8e2edc9a5523b3d13813e3decedd555b5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogo_ListaJogo), @"mvc.1.0.view", @"/Views/Jogo/ListaJogo.cshtml")]
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
#line 1 "C:\Alura\Futebol\Futebool.WebApp\Views\_ViewImports.cshtml"
using Futebool.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Alura\Futebol\Futebool.WebApp\Views\_ViewImports.cshtml"
using Futebool.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Alura\Futebol\Futebool.WebApp\Views\_ViewImports.cshtml"
using Futebool.WebApp.Models.dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e248a8e2edc9a5523b3d13813e3decedd555b5b", @"/Views/Jogo/ListaJogo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410ee03d4b33bc68c484f186edd4b4b8ec7eac1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Jogo_ListaJogo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Jogo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateJogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteJogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
   ViewData["Title"] = "Lista de Jogos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3 style=\"margin:40px; text-align:center\">Lista de todos os Jogos</h3>\r\n\r\n\r\n<div style=\"display: flex; flex-wrap:wrap\">\r\n");
#nullable restore
#line 10 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div style=""        
        background: lightgreen;
        margin: 10px;
        color: black;
        border: solid 2px black;
        display: flex;
        flex-direction: column;
        width: 46%;
        height: auto;
        padding-left: 30px;
        padding-top: 30px;"">

            <h4 style=""text-align:center"">  ");
#nullable restore
#line 24 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                                       Write(item.TimeCasa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/> X <br/> ");
#nullable restore
#line 24 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                                                                         Write(item.TimeVisitante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n            <p>Campo:  ");
#nullable restore
#line 25 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                  Write(item.Campo.NomeGramado);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>Data e Hora do Jogo:  ");
#nullable restore
#line 26 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                                Write(item.DataHoraJogo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>Acrescimo: ");
#nullable restore
#line 27 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                     Write(item.Acrescimo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Placar Casa: ");
#nullable restore
#line 28 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                       Write(item.PlacarCasa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Placar Visitante: ");
#nullable restore
#line 29 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                            Write(item.PlacarVisitante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n            <br/>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e248a8e2edc9a5523b3d13813e3decedd555b5b7088", async() => {
                WriteLiteral("\r\n                    Update Jogo\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e248a8e2edc9a5523b3d13813e3decedd555b5b9396", async() => {
                WriteLiteral("\r\n                    Deletar Jogo\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Alura\Futebol\Futebool.WebApp\Views\Jogo\ListaJogo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Jogo>> Html { get; private set; }
    }
}
#pragma warning restore 1591