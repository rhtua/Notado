using Notado.Enuns;
using Notado.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notado.Controllers
{   
    
    [AutorizacaoFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm, Autorizacao.aluno })]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}