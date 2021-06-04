using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampMVC.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager ifm = new ImageFileManager(new EFImageFileDAL());
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
    }
}