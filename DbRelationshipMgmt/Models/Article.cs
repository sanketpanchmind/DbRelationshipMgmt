namespace DbRelationshipMgmt.Models
{
    public class Article
    {
        public int aId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleDescription { get; set; }

        // setup relationship with tutorial model

        public int Id { get; set; } // FK

        public Tutorial Tutorial { get; set; } //RF navigation property
    }
}
