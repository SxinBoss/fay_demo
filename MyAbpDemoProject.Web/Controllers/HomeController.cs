using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyAbpDemoProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyAbpDemoProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}