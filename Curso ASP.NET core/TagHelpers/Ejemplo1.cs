
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Curso_ASP.NET_core.TagHelpers
{
    [HtmlTargetElement("ejemplo1",TagStructure = TagStructure.NormalOrSelfClosing)]
    public class Ejemplo1 : TagHelper
    {
        public override void Process(TagHelperContext contexto, TagHelperOutput salida) {
            salida.TagName = "";
            salida.Content.SetHtmlContent("<h3>Hola Pepe</h3>");
        }
    }
}
