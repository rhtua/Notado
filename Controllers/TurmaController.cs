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

    [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm, Autorizacao.professor })]

    public class TurmaController : Controller
    {
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(TurmaViewModel turmaViewModel)
        {

            var turmaEntidade = Mapper.Map<TurmaViewModel, Turma>(turmaViewModel);

            var dao = new TurmasDAO();
            dao.Adiciona(turmaEntidade);


            return RedirectToAction("Sucesso", "Redirect");
        }

        public ActionResult Index()
        {
            TurmasDAO dao = new TurmasDAO();
            IList<Turma> Turmas = dao.Lista();
            ViewBag.Turmas = Turmas;
            return View();

        }

       
        public ActionResult Excluir(int id)
        {
            TurmasDAO dao = new TurmasDAO();
            var turmaRemover = dao.BuscaPorId(id);
            dao.Excluir(turmaRemover);

            return RedirectToAction("Index", "Turma");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var dao = new TurmasDAO();
            Turma turma = dao.BuscaPorId(id);
            var Turma = Mapper.Map<Turma, TurmaViewModel>(turma);
            ViewBag.Turmas = Turma;
            return View(Turma);
        }

        [HttpPost]
        public ActionResult Editar(TurmaViewModel turmaViewModel)
        {

                var dao = new TurmasDAO();
                var turma = Mapper.Map<TurmaViewModel, Turma>(turmaViewModel);
                dao.Editar(turma);
                return RedirectToAction("Sucesso", "Redirect");

        }
    }
}