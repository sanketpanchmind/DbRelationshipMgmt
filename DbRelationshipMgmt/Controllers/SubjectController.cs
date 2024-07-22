using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbRelationshipMgmt.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubject _subject;

        public SubjectController(ISubject subject)
        {
            _subject = subject;
        }

        public IActionResult Index()
        {
            var data = _subject.GetallSubjects();
            return View(data);
        }

        public IActionResult AddSubject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSubject(Subject subject)
        {
            subject = _subject.AddSubject(subject);
            return RedirectToAction("Index");
        }
    }
}
