using DbRelationshipMgmt.Models;

namespace DbRelationshipMgmt.Interface
{
    public interface ISubjectTopic
    {
        List<SubjectTopic> GetallsubjectTpoic();

        List<SubjectTopic> GetsubjecttopicsbyId(int id);

        SubjectTopic AddTopic(SubjectTopic subjecttopic);

        List<SubjectTopic> SearchsubjectTopic(string search);
    }
}
