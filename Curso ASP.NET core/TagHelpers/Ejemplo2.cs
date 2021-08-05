using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Curso_ASP.NET_core.TagHelpers
{
    [HtmlTargetElement("ejemplo2", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class Ejemplo2 : TagHelper
    {
        [HtmlAttributeName("a")]
        public int a { get; set; }
        [HtmlAttributeName("b")]
        public int b { get; set; }
        public override void Process(TagHelperContext contexto, TagHelperOutput salida)
        {
            salida.TagName = "";
            salida.Content.SetHtmlContent("<h3>" +(a+b).ToString()+ "</h3>");
        }
    }
}
