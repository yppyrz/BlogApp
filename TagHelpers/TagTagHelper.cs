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
            output.TagName = "p";
            output.Attributes.Add("style", "text-align:center");
            output.Attributes.Add("text", list);
            
            foreach (var item in list)
            {
                x += $"<a href ='{item.TagID}'> {item.TagName} </a >";
            }
            output.Content.AppendHtml($@"<div class='sidebar'><div class='row'><div class='col-lg-12'><div class='sidebar-item tags'><div class='sidebar-heading'><h2>Tag Clouds</h2></div><div class='content'><ul><li>{x}</li ></ul ></div ></div ></div ></div ></div >");

            base.Process(context, output);
        }
    }
}
