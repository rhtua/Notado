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

    public class NotaController : Controller
    {

        public ActionResult Index(int id)
        {
            AlunosDAO dao = new AlunosDAO();
            IList<Aluno> alunos = dao.BuscaPorTurma(id);
            ViewBag.Alunos = alunos;
            return View();
        }
        [HttpGet]

        public ActionResult Adicionar(int id)
        {
            DisciplinasDAO dao = new DisciplinasDAO();
            IList<Disciplina> disciplina = dao.Lista();
            ViewBag.Disciplinas = disciplina;

            var ndao = new NotasDAO();
            Aluno aluno = ndao.BuscaPorId(id);
            ViewBag.Aluno = aluno;
            return View();
        }


        [HttpPost]
        public ActionResult Adicionar(NotaViewModel nota)
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

        public ActionResult Vazio()
        {
            return View();
        }

        [HttpGet]
        public ActionResult VerNota(int id)
        {

            var pr = new NotasDAO();
            Prova prova = pr.BuscaPorProva(id);

            var rec = new NotasDAO();
            Recuperacao recu = rec.BuscaPorRecuperacao(id);

            var tr = new NotasDAO();
            Trabalho trab = tr.BuscaPorTrabalho(id);

            var ndao = new NotasDAO();
            Aluno aluno = ndao.BuscaPorId(id);
            ViewBag.Aluno = aluno;

            if (trab != null && (prova != null || recu != null))
            {
                var Notas = new Nota();
                Notas.Trabalho = trab.Nota;
                Notas.Recuperacao = recu.Nota;
                Notas.Prova = prova.Nota;
                Notas.Bimestre = prova.Bimestre;
                ViewBag.Notas = Notas;

                return View();

            }
            else
            {
                return RedirectToAction("Vazio");

            }

        }

        public ActionResult Busca()
        {
            TurmasDAO dao = new TurmasDAO();
            IList<Turma> Turmas = dao.Lista();
            ViewBag.Turmas = Turmas;
            return View();

        }



    }
}