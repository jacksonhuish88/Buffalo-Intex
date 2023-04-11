using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Buffalo_Intex.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PaginationTagHelper : TagHelper 
    {
    }
}
