using DbRelationshipMgmt.Data;
using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.EntityFrameworkCore;

namespace DbRelationshipMgmt.Repositories
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly MyAppDbContext _myAppDbContext;

        public TutorialRepository(MyAppDbContext myAppDbContext)
        {
            _myAppDbContext = myAppDbContext;
        }

        public List<Tutorial> Gettutoriallist()
        {
            //return _myAppDbContext.Tutorials.ToList();
            return _myAppDbContext.Tutorials.FromSqlRaw("Select Id,Name,Description from Tutorials").ToList();

        }
    }
}
