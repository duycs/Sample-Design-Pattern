using System;
using System.Collections.Generic;
namespace sample_design_pattern.BuilderPattern
{
    public class PostSetting
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public IList<string> Categories { get; set; }
        public IList<string> Tags { get; set; }
        public string MetaDescription { get; set; }
        public string MetadataTitle { get; set; }
    }
}