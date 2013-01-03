using System.Web.Mvc;
using Web.Model;

namespace Web.Controllers
{
    public class LandingPageController : Controller
    {
        //
        // GET: /LandingPage/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /LandingPage/ThankYOU

        public ActionResult ThankYou()
        {
            return View();
        }

    }
}
