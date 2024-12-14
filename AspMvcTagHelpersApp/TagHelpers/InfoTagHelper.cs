using AspMvcTagHelpersApp.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspMvcTagHelpersApp.TagHelpers
{
    public class DateTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h3";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", "red-text");
            output.Content.SetContent($"Date: {DateTime.Now.ToLongDateString()}");
        }
    }

    public class TimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h3";
            output.Content.SetContent($"Time: {DateTime.Now.ToShortTimeString()}");
        }
    }

    public class ListTagHelper : TagHelper
    {
        public IEnumerable<string>? Items { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.TagMode = TagMode.StartTagAndEndTag;

            if(Items is not null)
            {
                var itemsContent = "";
                foreach (var item in Items)
                    itemsContent += $"<li>{item}</li>";
                output.Content.SetHtmlContent(itemsContent);
            }
        }

    }
    public class InfoTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var childs = await output.GetChildContentAsync();
            var inner = "<h3>Info</h3>" + childs.GetContent();

            output.Content.SetHtmlContent(inner);
        }
    }

    public class EmployeeTagHelper : TagHelper
    {
        public Employee? Employee { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Employee is null) return;

            output.TagName = "div";
            output.TagMode= TagMode.StartTagAndEndTag;

            string employeeContent = "<h2>Employee info:</h2>";
            employeeContent += $"<h3>Name: {Employee.Name}</h3>";
            employeeContent += $"<h3>Age: {Employee.Age}</h3>";

            output.Content.SetHtmlContent(employeeContent);
        }
    }
}

