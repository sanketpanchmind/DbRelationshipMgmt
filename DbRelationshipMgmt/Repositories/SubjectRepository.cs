using DbRelationshipMgmt.Data;
using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;

namespace DbRelationshipMgmt.Repositories
{
    public class SubjectRepository : ISubject
    {
        private readonly MyAppDbContext _myAppDbContext;

        public SubjectRepository(MyAppDbContext myAppDbContext)
        {
            _myAppDbContext = myAppDbContext;
        }

       

        public List<Subject> GetallSubjects()
        {
            return _myAppDbContext.Subjects.ToList();
        }


        public Subject AddSubject(Subject subject)
        {
            _myAppDbContext.Subjects.Add(subject);
            _myAppDbContext.SaveChanges();
            return subject;
        }


    }
}
