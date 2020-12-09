using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routing.Areas.Client.Controllers
{
    [RouteArea("Client")]
    [RoutePrefix("ClientRequest")]
    public class ClientRequestController : Controller
    {
        [Route("LoadItem/{value}")]
        // GET: Client/ClientRequest
        public ActionResult Item(int value)
        {
            ViewBag.Data = value;
            return View();
        }
        [Route("RequestItem/{id}")]
        public ActionResult Requests(string id)
        {
            ViewBag.Data = id;
            return View();
        }
    }
}