using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace DbRelationshipMgmt.Models
{
    public class SubjectTopic
    {
        [Key]
        public int SubjectTopicId {  get; set; }

        public string SubjectTopicName { get; set; }

        public string SubjectTopicDescription { get; set; }

        [Display(Name = "Choose the appropriate photo for topic")]
        [Required]
        public byte[] Subjectphoto { get; set; }


        //relationship

        public int SubjectId {  get; set; } //F.K.

        public Subject Subject { get; set; } // R.F. navigation props
    }
}
