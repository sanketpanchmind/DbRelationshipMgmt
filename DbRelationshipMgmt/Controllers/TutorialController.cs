using DbRelationshipMgmt.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DbRelationshipMgmt.Controllers
{
    public class TutorialController : Controller
    {
        private readonly ITutorialRepository _repository;

        public TutorialController(ITutorialRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var data = _repository.Gettutoriallist();
            return View(data);
        }
    }
}
