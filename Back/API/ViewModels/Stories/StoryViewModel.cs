using System.Collections.Generic;

namespace ViewModels
{
    public class StoryViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public long PublishTime { get; set; }
        public string OwnerUsername { get; set; }
    }
}