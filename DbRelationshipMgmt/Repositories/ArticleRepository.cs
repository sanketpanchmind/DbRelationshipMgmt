using DbRelationshipMgmt.Data;
using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.EntityFrameworkCore;

namespace DbRelationshipMgmt.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MyAppDbContext _myAppDbContext;

        public ArticleRepository(MyAppDbContext myAppDbContext)
        {
            _myAppDbContext = myAppDbContext;
        }


        public List<Article> GetarticlebytutorialId(int id)
        {
            return _myAppDbContext.Articles.Where(a => a.Id == id).ToList();
        }

        public List<Article> Getarticlelist()
        {
            //return _myAppDbContext.Articles.ToList();
            return _myAppDbContext.Articles.FromSqlRaw("Select Id,Name,Description from Articles").ToList();
        }

    }
}
