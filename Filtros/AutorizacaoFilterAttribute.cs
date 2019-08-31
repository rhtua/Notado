using Notado.Enuns;
using Notado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Notado.Filtros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public Autorizacao[] Roles { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isLogin = false;


            object usuario = filterContext.HttpContext.Session["usuarioLogado"];

            if (usuario != null && usuario is Usuario)
            {

                if (Roles != null && Roles.Length > 0)
                {
                    Autorizacao tipo = (Autorizacao)(usuario as Usuario).Autorizacao;
                    int indexOf = Array.IndexOf(Roles, tipo);
                    if (indexOf > -1)
                    {
                        isLogin = true;
                    }
                }
                else
                {
                    isLogin = true;
                }
            }

            //Se não estiver logado (isLogin falso), redireciona para página de login
            if (!isLogin)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new
                        { controller = "Login", action = "Index" }
                        ));
            }


        }


    }
}