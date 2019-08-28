using Notado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.DAO
{
    public class NotasDAO
    {
        public void AdicionaProva(Prova Prova)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Provas.Add(Prova);
                contexto.SaveChanges();
            }
        }

        public void AdicionaRecuperacao(Recuperacao Recuperacao)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Recuperacoes.Add(Recuperacao);
                contexto.SaveChanges();
            }
        }

        public void AdicionaTrabalho(Trabalho Trabalho)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Trabalhos.Add(Trabalho);
                contexto.SaveChanges();
            }
        }

        public IList<Aluno> AlunosDaTurma(int turmaId)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Alunos.Where(m => m.TurmaId == turmaId).ToList();
            }
        }
        public Disciplina BuscaPorId(int id)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Disciplinas.Where(t => t.Id == id).FirstOrDefault();
            }
        }

        public void Excluir(Disciplina disciplinaRemover)
        {
            using (var contexto = new NotadoContext())
            {

                contexto.Remove(disciplinaRemover);
                contexto.SaveChanges();
            }

        }

        public void Editar(Disciplina disciplina)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Disciplinas.Update(disciplina);
                contexto.SaveChanges();
            }

        }
    }
}