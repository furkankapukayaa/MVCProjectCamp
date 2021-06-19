using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace KampMVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        AdminManager adminManager = new AdminManager(new EFAdminDAL());

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string password = admin.AdminPassword;
            string result = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(password)));
            admin.AdminPassword = result;
            admin.AdminRole = "A";
            adminManager.AdminAdd(admin);
            return RedirectToAction("Index", "Login");
        }
    }
}