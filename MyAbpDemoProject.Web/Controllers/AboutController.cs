using System.Web.Mvc;

namespace MyAbpDemoProject.Web.Controllers
{
    public class AboutController : MyAbpDemoProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}