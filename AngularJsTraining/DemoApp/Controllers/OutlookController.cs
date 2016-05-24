using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class OutlookController : Controller
    {
        //
        // GET: /Outlook/
        public ActionResult Index()
        {
            return PartialView();
        }
	}
}