using System;
using System.Collections.Generic;

namespace sample_design_pattern.BuilderPattern
{
    public interface IPostBuilder
    {
        PostBuilder AddTitle(string title);
        PostBuilder AddContent(string body);
        PostBuilder AddAuthor(string author);
        PostBuilder AddDate(DateTime date);
        PostBuilder AddCategory(string category);
        PostBuilder AddTags(IEnumerable<string> tags);
        PostBuilder AddMetadataTitle(string title);
        PostBuilder AddMetadataDescription(string description);
        PostSetting Build();
    }
}