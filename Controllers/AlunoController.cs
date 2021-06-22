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
    public class AlunoController : Controller
    {
        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
        public ActionResult Adicionar()
        {
            TurmasDAO dao = new TurmasDAO();
            IList<Turma> turma = dao.Lista();
            ViewBag.Turmas = turma;
            return View();
        }

        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
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

        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
        public ActionResult Excluir(int id)
        {
            AlunosDAO dao = new AlunosDAO();
            var alunoRemover = dao.BuscaPorId(id);
            dao.Excluir(alunoRemover);

            return RedirectToAction("Index", "aluno");
        }

        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
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

        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
        [HttpPost]
        public ActionResult Editar(AlunoViewModel alunoViewModel)
        {

            var dao = new AlunosDAO();
            var aluno = Mapper.Map<AlunoViewModel, Aluno>(alunoViewModel);
            dao.Editar(aluno);
            return RedirectToAction("Sucesso", "Redirect");

        }
        public ActionResult Usuario()
        {

            return View();

        }
       



    }
}