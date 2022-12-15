using System.Collections.Generic;

namespace SampleDesignPattern.BuilderPattern
{
    public class PostManager
    {
        public PostManager(){
            var postBuilder = new PostBuilder();
            postBuilder.AddAuthor("Duy Chu")
            .AddTitle("Code fiction")
            .AddCategory("Fiction")
            .AddContent("Body content ...")
            .AddDate(new System.DateTime())
            .AddMetadataDescription("Meta-Description...")
            .AddMetadataTitle("Meta-Title...")
            .AddTags(new List<string>(){"fiction"})
            .Build();
        }
    }
}