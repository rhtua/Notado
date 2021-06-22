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
    [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]

    public class DisciplinaController : Controller
    {
        public ActionResult Adicionar()
        {
            TurmasDAO Tdao = new TurmasDAO();
            IList<Turma> turma = Tdao.Lista();
            ViewBag.Turmas = turma;
            ProfessoresDAO dao = new ProfessoresDAO();
            IList<Professor> professor = dao.Lista();
            ViewBag.Professores = professor;
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(DisciplinaViewModel disciplinaViewModel)
        {

            var disciplinaEntidade = Mapper.Map<DisciplinaViewModel, Disciplina>(disciplinaViewModel);

            var dao = new DisciplinasDAO();
            dao.Adiciona(disciplinaEntidade);


            return RedirectToAction("Sucesso", "Redirect");
        }

        public ActionResult Index()
        {
            DisciplinasDAO dao = new DisciplinasDAO();
            IList<Disciplina> Disciplinas = dao.Lista();
            ViewBag.Disciplinas = Disciplinas;
            return View();

        }


        public ActionResult Excluir(int id)
        {
            DisciplinasDAO dao = new DisciplinasDAO();
            var disciplinaRemover = dao.BuscaPorId(id);
            dao.Excluir(disciplinaRemover);

            return RedirectToAction("Index", "Disciplina");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            TurmasDAO Tdao = new TurmasDAO();
            IList<Turma> turma = Tdao.Lista();
            ViewBag.Turmas = turma;
            ProfessoresDAO Pdao = new ProfessoresDAO();
            IList<Professor> professor = Pdao.Lista();
            ViewBag.Professores = professor;
            var dao = new DisciplinasDAO();
            Disciplina disciplina = dao.BuscaPorId(id);
            var Disciplina = Mapper.Map<Disciplina, DisciplinaViewModel>(disciplina);
            ViewBag.Disciplinas = Disciplina;
            return View(Disciplina);
        }

        [HttpPost]
        public ActionResult Editar(DisciplinaViewModel disciplinaViewModel)
        {

            var dao = new DisciplinasDAO();
            var disciplina = Mapper.Map<DisciplinaViewModel, Disciplina>(disciplinaViewModel);
            dao.Editar(disciplina);
            return RedirectToAction("Sucesso", "Redirect");

        }
    }
}