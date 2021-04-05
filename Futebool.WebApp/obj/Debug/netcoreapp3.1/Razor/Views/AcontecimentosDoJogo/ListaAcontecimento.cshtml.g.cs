#pragma checksum "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e088f2dd6c2102875cb89bd995086a3d4b5e7f09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcontecimentosDoJogo_ListaAcontecimento), @"mvc.1.0.view", @"/Views/AcontecimentosDoJogo/ListaAcontecimento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e088f2dd6c2102875cb89bd995086a3d4b5e7f09", @"/Views/AcontecimentosDoJogo/ListaAcontecimento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"410ee03d4b33bc68c484f186edd4b4b8ec7eac1c", @"/Views/_ViewImports.cshtml")]
    public class Views_AcontecimentosDoJogo_ListaAcontecimento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AcontecimentosDoJogo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAcontecimento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAcontecimento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
   ViewData["Title"] = "Lista de Acontecimentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3 style=\"margin:40px; text-align:center\">Lista de todos os Acontecimentos</h3>\r\n\r\n\r\n<div style=\"display: flex; flex-wrap:wrap\">\r\n");
#nullable restore
#line 9 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div style=""       
        background-color: lightgreen;
        margin: 10px;
        color: black;
        border: solid 2px black;
        display: flex;
        flex-direction: column;
        width: 45%;
        height: auto;
        padding-left: 30px;
        padding-top: 30px;"">
        <h4>ID(");
#nullable restore
#line 22 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(") - Nome do Jogador:  ");
#nullable restore
#line 22 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
                                        Write(item.Jogador.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n        <p>Jogo:  ");
#nullable restore
#line 23 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
             Write(item.Jogo.TimeCasa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 23 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
                                        Write(item.Jogo.TimeVisitante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p>Time do Jogador:  ");
#nullable restore
#line 24 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
                        Write(item.Time.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p>Tempo do Ocorrido:  ");
#nullable restore
#line 25 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
                          Write(item.TempoDoOcorrido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p>Ação Ocorrida: ");
#nullable restore
#line 26 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
                     Write(item.AcaoOcorrida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n        <br />\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e088f2dd6c2102875cb89bd995086a3d4b5e7f097300", async() => {
                WriteLiteral("\r\n                Update Acontecimento\r\n            ");
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
#line 30 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e088f2dd6c2102875cb89bd995086a3d4b5e7f099635", async() => {
                WriteLiteral("\r\n                Deletar Acontecimento\r\n            ");
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
#line 33 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Alura\Futebol\Futebool.WebApp\Views\AcontecimentosDoJogo\ListaAcontecimento.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AcontecimentosDoJogo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
