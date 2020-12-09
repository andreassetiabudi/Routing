using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("AdminBorrow")]
    public class AdminBorrowController : Controller
    {
        [Route("LoadItem/{value}")]
        // GET: Admin/AdminBorrow
        public ActionResult Item(int value)
        {
            ViewBag.Data = value;
            return View();
        }
        [Route("AcceptBorrow/{id}")]
        public ActionResult Accept(string id)
        {
            ViewBag.Data = id;
            return View();
        }
        [Route("DeclineBorrow/{name}")]
        public ActionResult Decline(string name)
        {
            ViewBag.Data = name;
            return View();
        }
    }
}