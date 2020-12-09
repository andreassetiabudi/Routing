using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Controllers
{
    [RoutePrefix("Borrow")]
    public class BorrowController : Controller
    {
        [Route("LoadItem")]
        // GET: Borrow
        public ActionResult Item()
        {
            return View();
        }
        [Route("BorrowItem")]
        public ActionResult Borrow()
        {
            return View();
        }
    }
}