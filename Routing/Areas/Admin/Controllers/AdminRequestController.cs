using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("AdminRequest")]
    public class AdminRequestController : Controller
    {
        [Route("LoadItem/{value}")]
        // GET: Admin/AdminBorrow
        public ActionResult Item(int value)
        {
            ViewBag.Data = value;
            return View();
        }
        [Route("AcceptRequest/{id}")]
        public ActionResult Accept(string id)
        {
            ViewBag.Data = id;
            return View();
        }
        [Route("DeclineRequest/{name}")]
        public ActionResult Decline(string name)
        {
            ViewBag.Data = name;
            return View();
        }
    }
}