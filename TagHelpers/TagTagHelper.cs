using BlogApp.Entities;
using BlogApp.Repositories;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.TagHelpers
{
    [HtmlTargetElement("tag", Attributes = "text")]
    public class TagTagHelper:TagHelper
    {
        public string Tags { get; set; } 

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //<p style="text-align:center">${Content}</p>
            output.TagName = "tag";
            output.Attributes.Add("style", "text-align:center");
            output.Content.SetContent(Tags);
            base.Process(context, output);
        }
    }
}
