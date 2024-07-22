using System.ComponentModel.DataAnnotations;

namespace DbRelationshipMgmt.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId {  get; set; }

        public string SubjectName { get; set; }

        public List<SubjectTopic> subjectTopics { get; set; }

    }
}
