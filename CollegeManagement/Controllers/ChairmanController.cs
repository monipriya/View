
using System.Collections.Generic;
using System.Web.Mvc;
using Repository;
using CollegeDetail.Entity;
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
       
    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(Detail Detail)
    {
           package.AddPackage(Detail);
        TempData["Message"] = "Package added";
        return RedirectToAction("Index");
        
    }
    public ActionResult Edit(int id)
    {
            Detail pack = package.GetPackageById(id);
        return View(pack);
    }
    public ActionResult Delete(int id)
    {
        package.DeletePackage(id);
        TempData["Message"] = "Package deleted";
        return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult Update(Detail packageDetails)
    {
        // if (ModelState.IsValid)
        //{
        package.UpdatePackage(packageDetails);
        TempData["Message"] = "Package updated";
        return RedirectToAction("Index");
        //}
        //return View("Edit",packageDetails);
    }
}
}