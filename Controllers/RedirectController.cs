using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notado.Controllers
{
    public class RedirectController : Controller
    {
        public ActionResult Sucesso()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}