
using System.Collections.Generic;
using System.Web.Mvc;
using Repository;
using CollegeDetail;
namespace CollegeManagement.Controllers
{
    public class ChairmanController : Controller
    {
        CollegeRepository package;
        public ChairmanController()
        {
            package = new CollegeRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Detail> packages = package.GetCollegeDetails();
            return View(packages);
        }
        public ActionResult DataPassing()
        {
            IEnumerable<Detail> packages = package.GetCollegeDetails();
            ViewBag.Package = packages;
            ViewData["packages"] = packages;
            return View();
        }
        public ActionResult TempDataChecking()
        {
            IEnumerable<Detail> packages = package.GetCollegeDetails();
            TempData["packages"] = packages;
            return View();
        }
    }
}