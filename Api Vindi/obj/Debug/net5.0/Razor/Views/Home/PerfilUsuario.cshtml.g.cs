#pragma checksum "Z:\Mundiware\Projeto Treino\Api Vindi\Api Vindi\Views\Home\PerfilUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0932af1e3b5def8df46086b46c84ad72ae878423"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PerfilUsuario), @"mvc.1.0.view", @"/Views/Home/PerfilUsuario.cshtml")]
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
#line 1 "Z:\Mundiware\Projeto Treino\Api Vindi\Api Vindi\Views\_ViewImports.cshtml"
using Api_Vindi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\Mundiware\Projeto Treino\Api Vindi\Api Vindi\Views\_ViewImports.cshtml"
using Api_Vindi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0932af1e3b5def8df46086b46c84ad72ae878423", @"/Views/Home/PerfilUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f7f74ff2a21cd0efe6348dff390e180597080f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_PerfilUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConcluirPlanoBasico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "Z:\Mundiware\Projeto Treino\Api Vindi\Api Vindi\Views\Home\PerfilUsuario.cshtml"
 if (TempData["UsuarioLogado"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"field-error mt-5\">\r\n\t\t<h2><strong>Seja bem vindo </strong></h2>\r\n\t\t<h3><strong>");
#nullable restore
#line 5 "Z:\Mundiware\Projeto Treino\Api Vindi\Api Vindi\Views\Home\PerfilUsuario.cshtml"
               Write(TempData["UsuarioLogado"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n\t\t<h5>\r\n\t\t\t<button class=\"btn btn-primary\"><strong>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0932af1e3b5def8df46086b46c84ad72ae8784235382", async() => {
                WriteLiteral("Logout session");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</strong></button>\r\n\t\t</h5>\r\n\t</div>\r\n");
#nullable restore
#line 10 "Z:\Mundiware\Projeto Treino\Api Vindi\Api Vindi\Views\Home\PerfilUsuario.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<h1>Contrate um plano hoje</h1>

<svg xmlns=""http://www.w3.org/2000/svg"" style=""display: none;"">
	<symbol id=""check"" viewBox=""0 0 16 16"">
		<title>Check</title>
		<path d=""M13.854 3.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3.5-3.5a.5.5 0 1 1 .708-.708L6.5 10.293l6.646-6.647a.5.5 0 0 1 .708 0z"" />
	</symbol>
</svg>

<div class=""container py-3"">
	<header>
		<div class=""pricing-header p-3 pb-md-4 mx-auto text-center"">
			<h1 class=""display-4 fw-normal"">Planos</h1>
			<p class=""fs-5 text-muted"">Faça seu cadastro e tenha acesso a beneficios incriveis e se quiser ainda mais beneficios considere assinar nossos planos</p>
		</div>
	</header>

	<main>
		<div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">
			<div class=""col"">
				<div class=""card mb-4 rounded-3 shadow-sm"">
					<div class=""card-header py-3"">
						<h4 class=""my-0 fw-normal"">Gratuito</h4>
					</div>
					<div class=""card-body"">
						<h1 class=""card-title pricing-card-title"">R$0<small class=""text-muted fw-l");
            WriteLiteral(@"ight"">/m</small></h1>
						<ul class=""list-unstyled mt-3 mb-4"">
							<li>Acesso a 1 materia extra</li>
							<li>Favoritar postagens</li>
							<li>Ajuda do suporte</li>
							<li>Comentarios em posts</li>
						</ul>
						<button type=""button"" class=""w-100 btn btn-lg btn-outline-primary"">Gratuito</button>
					</div>
				</div>
			</div>

			<div class=""col"">
				<div class=""card mb-4 rounded-3 shadow-sm"">
					<div class=""card-header py-3"">
						<h4 class=""my-0 fw-normal"">Digital Básico</h4>
					</div>
					<div class=""card-body"">
						<h1 class=""card-title pricing-card-title"">R$9,90<small class=""text-muted fw-light"">/m</small></h1>
						<ul class=""list-unstyled mt-3 mb-4"">
							<li>Todos beneficios gratuitos</li>
							<li>Ver postagens ilimitadas</li>
							<li>Prioridade do suporte</li>
							<li>Acesso ao centro de ajuda</li>
						</ul>
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0932af1e3b5def8df46086b46c84ad72ae8784238882", async() => {
                WriteLiteral("Assine Agora");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"	
						<!--<a class=""btn btn-primary btn-lg""   href=""ConcluirCadastro?plano=Premium""></a>
						-->
					</div>
				</div>
			</div>
			<div class=""col"">
				<div class=""card mb-4 rounded-3 shadow-sm border-primary"">
					<div class=""card-header py-3 text-white bg-primary border-primary"">
						<h4 class=""my-0 fw-normal"">Digital Plus</h4>
					</div>
					<div class=""card-body"">
						<h1 class=""card-title pricing-card-title"">R$29,90<small class=""text-muted fw-light"">/m</small></h1>
						<ul class=""list-unstyled mt-3 mb-4"">
							<li>Acesso postagens ilimitadas</li>
							<li>Clube assinante desbloqueado</li>
							<li>Ofertas exclusivas</li>
							<li>Suporte 24h</li>
						</ul>
						<button type=""button"" class=""w-100 btn btn-lg btn-primary"">Assine Agora</button>
					</div>
				</div>
			</div>
		</div>

		<h2 class=""display-6 text-center mb-4"">Compare os planos</h2>

		<div class=""table-responsive"">
			<table class=""table text-center"">
				<thead>
					<tr>
						<th ");
            WriteLiteral(@"style=""width: 34%;""></th>
						<th style=""width: 22%;"">Gratuito</th>
						<th style=""width: 22%;"">Digital Básico</th>
						<th style=""width: 22%;"">Digital Plus</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<th scope=""row"" class=""text-start"">Ajuda do suporte</th>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
					</tr>
					<tr>
						<th scope=""row"" class=""text-start"">Comentarios</th>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
					</tr>
				</tbody>

				<tbody>
					<tr>
						<th scope=""row"" class=""text-start"">Ver postagens ilimitadas</th>");
            WriteLiteral(@"
						<td></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
					</tr>
					<tr>
						<th scope=""row"" class=""text-start"">Suporte 24h</th>
						<td></td>
						<td></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
					</tr>
					<tr>
						<th scope=""row"" class=""text-start"">Clube dos assinantes</th>
						<td></td>
						<td></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
					</tr>
					<tr>
						<th scope=""row"" class=""text-start"">Ofertas exclusivas</th>
						<td></td>
						<td></td>
						<td><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#check"" /></svg></td>
					</tr>
				</tbody>
			</table>
		</div>
	</main>


</div>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
