using DbRelationshipMgmt.Models;

namespace DbRelationshipMgmt.Interface
{
    public interface ISubject
    {
        List<Subject> GetallSubjects();

        Subject AddSubject(Subject subject);

    }
}
