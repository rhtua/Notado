using AutoMapper;
using Notado.DAO;
using Notado.Enuns;
using Notado.Filtros;
using Notado.Models;
using Notado.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notado.Controllers
{
    public class UsuarioController : Controller
    {
        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(UsuarioViewModel usuarioViewModel)
        {

            var usuarioEntidade = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);

            var dao = new UsuariosDAO();
            dao.Adiciona(usuarioEntidade);


            return RedirectToAction("Sucesso", "Redirect");
        }

        public ActionResult Index()
        {
            UsuariosDAO dao = new UsuariosDAO();
            IList<Usuario> Usuarios = dao.Lista();
            ViewBag.Usuarios = Usuarios;
            return View();

        }


        public ActionResult Excluir(int id)
        {
            UsuariosDAO dao = new UsuariosDAO();
            var usuarioRemover = dao.BuscaPorId(id);
            dao.Excluir(usuarioRemover);

            return RedirectToAction("Index", "Usuario");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            UsuariosDAO Tdao = new UsuariosDAO();
            IList<Usuario> usuario = Tdao.Lista();
            ViewBag.Usuarios = usuario;
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Editar(UsuarioViewModel usuarioViewModel)
        {

            var dao = new UsuariosDAO();
            var usuario = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
            dao.Editar(usuario);
            return RedirectToAction("Sucesso", "Redirect");

        }

    }
}