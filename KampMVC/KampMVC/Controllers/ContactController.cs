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
        MessageManager mm = new MessageManager(new EFMessageDAL());
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
            var receiverMail = _Context.Messages.Count(x => x.ReceiverMail == "furkan@gmail.com").ToString();
            ViewBag.receiverMail = receiverMail;

            var senderMail = _Context.Messages.Count(x => x.SenderMail == "furkan@gmail.com").ToString();
            ViewBag.senderMail = senderMail;

            var contact = _Context.Contacts.Count().ToString();
            ViewBag.contact = contact;

            var draft = _Context.Messages.Count(x => x.isDraft == true).ToString();
            ViewBag.draft = draft;

            var readMessage = mm.GetList().Count();
            ViewBag.readMessage = readMessage;

            var unReadMessage = mm.GetListUnRead().Count();
            ViewBag.unReadMessage = unReadMessage;

            return PartialView();
        }
    }
}