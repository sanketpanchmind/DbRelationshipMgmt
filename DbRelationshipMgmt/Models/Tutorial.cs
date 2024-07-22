namespace DbRelationshipMgmt.Models
{
    public class Tutorial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        // Relationship 

        public List<Article> Articles { get; set; }
    }
}
