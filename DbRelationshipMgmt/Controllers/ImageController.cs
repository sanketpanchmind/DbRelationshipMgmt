using DbRelationshipMgmt.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DbRelationshipMgmt.Controllers
{
    public class ImageController : Controller
    {
        private readonly Iuploadimg _iuploadimg;

        public ImageController(Iuploadimg iuploadimg)
        {
            _iuploadimg = iuploadimg;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Addimg() { return View(); }

        [HttpPost]
        public IActionResult Addimg(Iuploadimg iuploadimg, byte[] imagebytes)
        {
            _iuploadimg.Addimg(iuploadimg, imagebytes);
            return View();
        }
    }
}
