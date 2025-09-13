using MenuRecommenderApp.Domain.Enums;

namespace MenuRecommenderApp.Domain.Entities
{
    public class Recipe
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public int DurationMin { get; set; }
        public Difficulty Difficulty { get; set; }
        public List<string> Required { get; set; }
        public List<string> Missing { get; set; }
        public List<string> Steps { get; set; }
        public List<string> Tips { get; set; }
        public List<string> Tags { get; set; }
    }
}
