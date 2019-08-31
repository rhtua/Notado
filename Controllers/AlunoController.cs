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

        [AutorizacaoFilter(Roles = new Autorizacao[] { Autorizacao.adm })]
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
        //---------------------------------------------------
        //Notas

        public ActionResult IndexNota()
        {
            AlunosDAO dao = new AlunosDAO();
            IList<Aluno> alunos = dao.Lista();
            ViewBag.Alunos = alunos;
            return View();
        }
        [HttpGet]

        public ActionResult AdicionarNota(int id)
        {
            TurmasDAO Tdao = new TurmasDAO();
            IList<Turma> turma = Tdao.Lista();
            ViewBag.Turmas = turma;

            DisciplinasDAO dao = new DisciplinasDAO();
            IList<Disciplina> disciplina = dao.Lista();
            ViewBag.Disciplinas = disciplina;

            var ndao = new NotasDAO();
            Aluno aluno = ndao.BuscaPorId(id);
            ViewBag.Aluno = aluno;
            return View();
        }


        [HttpPost]
        public ActionResult AdicionarNota(NotaViewModel nota)
        {
            var Prova = new ProvaViewModel
            {
                AlunoId = nota.Id,
                Nota = nota.Prova,
                DisciplinaID = nota.DisciplinaId,
                Bimestre = nota.Bimestre
            };
            var provaEntidade = Mapper.Map<ProvaViewModel, Prova>(Prova);

            var pr = new NotasDAO();
            pr.AdicionaProva(provaEntidade);

            var Recuperacao = new RecuperacaoViewModel
            {
                AlunoId = nota.Id,
                Nota = nota.Recuperacao,
                DisciplinaID = nota.DisciplinaId,
                Bimestre = nota.Bimestre
            };
            var recuperacaoEntidade = Mapper.Map<RecuperacaoViewModel, Recuperacao>(Recuperacao);

            var rc = new NotasDAO();
            rc.AdicionaRecuperacao(recuperacaoEntidade);

            var Trabalho = new TrabalhoViewModel
            {
                AlunoId = nota.Id,
                Nota = nota.Trabalho,
                DisciplinaID = nota.DisciplinaId,
                Bimestre = nota.Bimestre
            };
            var trabalhoEntidade = Mapper.Map<TrabalhoViewModel, Trabalho>(Trabalho);

            var tr = new NotasDAO();
            tr.AdicionaTrabalho(trabalhoEntidade);

            return RedirectToAction("Sucesso", "Redirect");
        }

        [HttpGet]
        public ActionResult VerNota(int id)
        {
            
            var pr = new NotasDAO();
            Prova prova = pr.BuscaPorProva(id);

            var rec = new NotasDAO();
            Recuperacao recu = rec.BuscaPorRecuperacao(id);

            var tr = new NotasDAO();
            Prova trab = tr.BuscaPorProva(id);

            var ndao = new NotasDAO();
            Aluno aluno = ndao.BuscaPorId(id);
            ViewBag.Aluno = aluno;

            var Notas = new Nota();
            Notas.Trabalho = trab.Nota;
            Notas.Recuperacao = recu.Nota;
            Notas.Prova = prova.Nota;
            Notas.Bimestre = prova.Bimestre;
            ViewBag.Notas = Notas;

            return View();

        }



    }
}