using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampMVC.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Categories.Count();
            var result2 = context.Headings.Count(x => x.Category.CategoryID == 1024);
            var result3 = context.Writers.Count(x => x.WriterName.Contains("a"));
            var result4 = context.Headings.Max(x => x.Category.CategoryName);
            var result5 = context.Categories.Count(x => x.CategoryStatus == true);
            var result6 = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.CategoryCount = result;
            ViewBag.Heading = result2;
            ViewBag.Writer = result3;
            ViewBag.HeadingMax = result4;
            ViewBag.Status = (result5 - result6);
            return View();
        }
    }
}