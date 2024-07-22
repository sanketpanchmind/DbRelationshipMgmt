using DbRelationshipMgmt.Models;

namespace DbRelationshipMgmt.Interface
{
    public interface IArticleRepository
    {
        List<Article> Getarticlelist();

        List<Article> GetarticlebytutorialId(int id);
    }
}
