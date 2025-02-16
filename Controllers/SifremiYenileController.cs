using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class SifremiYenileController : Controller
    {
        // GET: SifremiYenile
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}