using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class DataController : Controller
    {
        //
        // GET: /Data/
        public ActionResult Index()
        {
            DemoApp.Models.MailItem item1 = new Models.MailItem();
            item1.Date = new DateTime(2016, 5, 27);
            item1.Id = 0;
            item1.Message = "Sample message detail one";
            item1.Recipients = new string[] { "rec0@rec0.com" };
            item1.Sender = "sender0@sender0.com";
            item1.Subject = "Test subject from sender 0";

            DemoApp.Models.MailItem item2 = new Models.MailItem();
            item2.Date = new DateTime(2016, 5, 27);
            item2.Id = 1;
            item2.Message = "Sample message detail two";
            item2.Recipients = new string[] { "rec1@rec1.com" };
            item2.Sender = "sender1@sender1.com";
            item2.Subject = "Test subject from sender 1";

            DemoApp.Models.MailItem item3 = new Models.MailItem();
            item3.Date = new DateTime(2016, 5, 27);
            item3.Id = 2;
            item3.Message = "Sample message detail three";
            item3.Recipients = new string[] { "rec2@rec2.com" };
            item3.Sender = "sender2@sender1.com";
            item3.Subject = "Test subject from sender 2";

            List<DemoApp.Models.MailItem> mailItems = new List<Models.MailItem>();
            mailItems.Add(item1);
            mailItems.Add(item2);
            mailItems.Add(item3);

            return Json(mailItems, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetById(int Id)
        {
            DemoApp.Models.MailItem item1 = new Models.MailItem();
            item1.Date = new DateTime(2016, 5, 27);
            item1.Id = 0;
            item1.Message = "Sample message detail one";
            item1.Recipients = new string[] { "rec0@rec0.com" };
            item1.Sender = "sender0@sender0.com";
            item1.Subject = "Test subject from sender 0";

            DemoApp.Models.MailItem item2 = new Models.MailItem();
            item2.Date = new DateTime(2016, 5, 27);
            item2.Id = 1;
            item2.Message = "Sample message detail two";
            item2.Recipients = new string[] { "rec1@rec1.com" };
            item2.Sender = "sender1@sender1.com";
            item2.Subject = "Test subject from sender 1";

            DemoApp.Models.MailItem item3 = new Models.MailItem();
            item3.Date = new DateTime(2016, 5, 27);
            item3.Id = 2;
            item3.Message = "Sample message detail three";
            item3.Recipients = new string[] { "rec2@rec2.com" };
            item3.Sender = "sender2@sender1.com";
            item3.Subject = "Test subject from sender 2";

            List<DemoApp.Models.MailItem> mailItems = new List<Models.MailItem>();
            mailItems.Add(item1);
            mailItems.Add(item2);
            mailItems.Add(item3);

            var item = mailItems.FirstOrDefault(x => x.Id == Id);
            return Json(item, JsonRequestBehavior.AllowGet);
        }
	}
}