using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampMvc.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactValidator cv = new ContactValidator();
        ContactManager cm = new ContactManager(new EfContactDal());

        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);

        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}