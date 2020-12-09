using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Areas.Client.Controllers
{
    [RouteArea("Client")]
    [RoutePrefix("ClientBorrow")]
    public class ClientBorrowController : Controller
    {
        [Route("LoadItem/{value}")]
        // GET: Client/AdminBorrow
        public ActionResult Item(int value)
        {
            ViewBag.Data = value;
            return View();
        }
        [Route("BorrowItem/{id}")]
        public ActionResult Borrow(string id)
        {
            ViewBag.Data = id;
            return View();
        }
    }
}