using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules_FluentValidation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context _Context = new Context();
        ContactManager cm = new ContactManager(new EFContactDAL());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetById(id);
            return View(contactvalues);
        }

        public PartialViewResult ContactMenuPartial()
        {
            var receiverMail = _Context.Messages.Count(m => m.ReceiverMail == "furkan@gmail.com").ToString();
            ViewBag.receiverMail = receiverMail;

            var senderMail = _Context.Messages.Count(m => m.SenderMail == "furkan@gmail.com").ToString();
            ViewBag.senderMail = senderMail;

            var contact = _Context.Contacts.Count().ToString();
            ViewBag.contact = contact;
            
            return PartialView();
        }
    }
}