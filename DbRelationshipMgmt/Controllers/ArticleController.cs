using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbRelationshipMgmt.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Displayarticle(int id)
        {
            List<Article> articles = _articleRepository.GetarticlebytutorialId(id);
            return View(articles);
        }

    }
}
