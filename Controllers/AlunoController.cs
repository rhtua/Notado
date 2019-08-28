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
    public class AlunoController : Controller
    {
        public ActionResult Adicionar()
        {
            TurmasDAO dao = new TurmasDAO();
            IList<Turma> turma = dao.Lista();
            ViewBag.Turmas = turma;
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(AlunoViewModel alunoViewModel)
        {

            var alunoEntidade = Mapper.Map<AlunoViewModel, Aluno>(alunoViewModel);

            var dao = new AlunosDAO();
            dao.Adiciona(alunoEntidade);


            return RedirectToAction("Sucesso", "Redirect");
        }

        public ActionResult Index()
        {
            AlunosDAO dao = new AlunosDAO();
            IList<Aluno> alunos = dao.Lista();
            ViewBag.Alunos = alunos;
            return View();

        }


        public ActionResult Excluir(int id)
        {
            AlunosDAO dao = new AlunosDAO();
            var alunoRemover = dao.BuscaPorId(id);
            dao.Excluir(alunoRemover);

            return RedirectToAction("Index", "aluno");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            TurmasDAO Tdao = new TurmasDAO();
            IList<Turma> turma = Tdao.Lista();
            ViewBag.Turmas = turma;
            var dao = new AlunosDAO();
            Aluno aluno = dao.BuscaPorId(id);
            var Aluno = Mapper.Map<Aluno, AlunoViewModel>(aluno);
            ViewBag.Aluno = Aluno;
            return View(Aluno);
        }

        [HttpPost]
        public ActionResult Editar(AlunoViewModel alunoViewModel)
        {

            var dao = new AlunosDAO();
            var aluno = Mapper.Map<AlunoViewModel, Aluno>(alunoViewModel);
            dao.Editar(aluno);
            return RedirectToAction("Sucesso", "Redirect");

        }


    }
}