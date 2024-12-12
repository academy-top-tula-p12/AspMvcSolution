using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace AspMvcHtmlHelpersApp.HtmlHelpers
{
    public static class UnorderListHelper
    {
        public static HtmlString Create(this IHtmlHelper htmlHelper, string title, IEnumerable<string> items, bool order = false)
        {

            //string result = $"<h2>{title}</h2>";
            //result += order ? "<ol>" : "<ul>";
            //foreach (var item in items)
            //    result += $"<li>{item}</li>";
            //result += order ? "</ol>" : "</ul>";

            TagBuilder result = new("div");

            TagBuilder h2 = new("h2");
            h2.InnerHtml.Append(title);
            result.InnerHtml.AppendHtml(h2);

            TagBuilder ul = new("ul");
            foreach (var item in items)
            {
                TagBuilder li = new TagBuilder("li");
                //li.Attributes.Add("class", "red-text");
                li.AddCssClass("red-text");
                li.InnerHtml.Append(item);
                ul.InnerHtml.AppendHtml(li);
            }
            result.InnerHtml.AppendHtml(ul);

            StringWriter writer = new();
            result.WriteTo(writer, HtmlEncoder.Default);

            return new HtmlString(writer.ToString());
        }
    }
}
