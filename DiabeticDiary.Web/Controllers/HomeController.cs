
using System.Web.Mvc;

namespace DiabeticDiary.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonRecordGrid()
        {
            return PartialView("~/Views/PersonRecords/Grid.cshtml");
        }

        public ActionResult PersonRecordAdd()
        {
            return PartialView("~/Views/PersonRecords/Add.cshtml");
        }
    }
}