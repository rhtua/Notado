using AutoMapper;
using Notado.DAO;
using Notado.Models;
using Notado.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Notado.Controllers
{
    public class ProfessorController : Controller
    {
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(ProfessorViewModel professorViewModel)
        {

            var professorEntidade = Mapper.Map<ProfessorViewModel, Professor>(professorViewModel);

            var dao = new ProfessoresDAO();
            dao.Adiciona(professorEntidade);


            return RedirectToAction("Sucesso", "Redirect");
        }

        public ActionResult Index()
        {
            ProfessoresDAO dao = new ProfessoresDAO();
            IList<Professor> professores = dao.Lista();
            ViewBag.Professores = professores;
            return View();

        }


        public ActionResult Excluir(int id)
        {
            ProfessoresDAO dao = new ProfessoresDAO();
            var professorRemover = dao.BuscaPorId(id);
            dao.Excluir(professorRemover);

            return RedirectToAction("Index", "professor");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var dao = new ProfessoresDAO();
            Professor professor = dao.BuscaPorId(id);
            var Professor = Mapper.Map<Professor, ProfessorViewModel>(professor);
            ViewBag.Professor = Professor;
            return View(Professor);
        }

        [HttpPost]
        public ActionResult Editar(ProfessorViewModel professorViewModel)
        {

            var dao = new ProfessoresDAO();
            var professor = Mapper.Map<ProfessorViewModel, Professor>(professorViewModel);
            dao.Editar(professor);
            return RedirectToAction("Sucesso", "Redirect");

        }
    }
}