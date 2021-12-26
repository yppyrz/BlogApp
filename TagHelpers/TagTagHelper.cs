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
        private readonly TagRepository _tagRepository;
        public TagTagHelper(TagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public string Tags { get; set; }
        public List<Tag> TagList { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var x = "";
            var list = _tagRepository.GetAllTag();
            //<p style="text-align:center">${Content}</p>
            output.TagName = "tag";
            output.Attributes.Add("style", "text-align:center");
            output.Attributes.Add("text", list);
            
            foreach (var item in list)
            {
                x += item.TagName;
            }
            output.Content.SetHtmlContent($@"<tag>{x}<tag>");

            base.Process(context, output);
        }
    }
}
