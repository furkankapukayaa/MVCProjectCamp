using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampMVC.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        HeadingManager hm = new HeadingManager(new EFHeadingDAL());
        ContentManager cm = new ContentManager(new EFContentDAL());
        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }

        public PartialViewResult Index(int id = 1)
        {
            var contentlist = cm.GetListByHeadingID(id);
            return PartialView(contentlist);
        }
    }
}