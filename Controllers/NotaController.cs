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
    public class NotaController : Controller
    {
        public ActionResult Index()
        {
            TurmasDAO Tdao = new TurmasDAO();
            IList<Turma> turma = Tdao.Lista();
            ViewBag.Turmas = turma;

            DisciplinasDAO dao = new DisciplinasDAO();
            IList<Disciplina> Disciplina = dao.Lista();
            ViewBag.Disciplinas = Disciplina;

            AlunosDAO Adao = new AlunosDAO();
            IList<Aluno> alunos = Adao.Lista();
            ViewBag.Alunos = alunos;

            return View();
        }

        public ActionResult Adicionar(NotaViewModel nota)
        {
            var Prova = new ProvaViewModel
            {
                AlunoId = nota.AlunoId,
                Nota = nota.Prova,
                DisciplinaID = nota.DisciplinaId,
                Bimestre = nota.Bimestre
            };
            var provaEntidade = Mapper.Map<ProvaViewModel, Prova>(Prova);

            var pr = new NotasDAO();
            pr.AdicionaProva(provaEntidade);

            var Recuperacao = new RecuperacaoViewModel
            {
                AlunoId = nota.AlunoId,
                Nota = nota.Recuperacao,
                DisciplinaID = nota.DisciplinaId,
                Bimestre = nota.Bimestre
            };
            var recuperacaoEntidade = Mapper.Map<RecuperacaoViewModel, Recuperacao>(Recuperacao);

            var rc = new NotasDAO();
            rc.AdicionaRecuperacao(recuperacaoEntidade);

            var Trabalho = new TrabalhoViewModel
            {
                AlunoId = nota.AlunoId,
                Nota = nota.Trabalho,
                DisciplinaID = nota.DisciplinaId,
                Bimestre = nota.Bimestre
            };
            var trabalhoEntidade = Mapper.Map<TrabalhoViewModel, Trabalho>(Trabalho);

            var tr = new NotasDAO();
            tr.AdicionaTrabalho(trabalhoEntidade);

            return View();
        }

    }
}