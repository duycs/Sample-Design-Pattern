using System;
using System.Collections.Generic;
using System.Linq;

namespace sample_design_pattern.BuilderPattern
{
    public class PostBuilder : IPostBuilder
    {
        private PostSetting _postSetting = new PostSetting();
        public PostBuilder()
        {
            _postSetting.Categories = new List<string>();
            _postSetting.Tags = new List<string>();
        }

        public PostBuilder AddAuthor(string author)
        {
            _postSetting.Author = author;
            return this;
        }

        public PostBuilder AddCategory(string category)
        {
            _postSetting.Categories.Add(category);
            return this;
        }

        public PostBuilder AddContent(string body)
        {
            _postSetting.Content = body;
            return this;
        }

        public PostBuilder AddDate(DateTime date)
        {
            _postSetting.Date = date;
            return this;
        }

        public PostBuilder AddMetadataDescription(string description)
        {
            _postSetting.MetaDescription = description;
            return this;
        }

        public PostBuilder AddMetadataTitle(string title)
        {
            _postSetting.Title = title;
            return this;
        }

        public PostBuilder AddTags(IEnumerable<string> tags)
        {
            _postSetting.Tags = tags.ToList();
            return this;
        }

        public PostBuilder AddTitle(string title)
        {
            _postSetting.Title = title;
            return this;
        }

        public PostSetting Build()
        {
            return _postSetting;
        }
    }
}