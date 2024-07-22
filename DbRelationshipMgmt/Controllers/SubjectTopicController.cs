using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbRelationshipMgmt.Controllers
{
    public class SubjectTopicController : Controller
    {
        private readonly ISubjectTopic _subjectTopic;

        public SubjectTopicController(ISubjectTopic subjectTopic)
        {
           _subjectTopic = subjectTopic;
        }

        public IActionResult Index()
        {
            var subjecttopicdata = _subjectTopic.GetallsubjectTpoic();
            if(subjecttopicdata != null)
            {
             return View(subjecttopicdata);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult GetsubjecttopicsbyId(int id)
        {
           var data =  _subjectTopic.GetsubjecttopicsbyId(id);
            return View("Index",data);
        }
        public IActionResult AddTopic()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTopic(SubjectTopic subjecttopic)
        {
            subjecttopic = _subjectTopic.AddTopic(subjecttopic);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Search(string search)
        {
            var data = _subjectTopic.SearchsubjectTopic(search);
            return View("Index",data);
        }
    }
}
