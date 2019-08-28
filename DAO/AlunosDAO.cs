using Notado.Models;
using Notado.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.DAO
{
    public class AlunosDAO
    {
        public void Adiciona(Aluno aluno)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Alunos.Add(aluno);
                contexto.SaveChanges();
            }
        }

        public IList<Aluno> Lista()
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Alunos.ToList();
            }
        }
        public Aluno BuscaPorId(int id)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Alunos.Where(t => t.Id == id).FirstOrDefault();
            }
        }

        public void Excluir(Aluno alunoRemover)
        {
            using (var contexto = new NotadoContext())
            {

                contexto.Remove(alunoRemover);
                contexto.SaveChanges();
            }

        }

        public void Editar(Aluno aluno)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Alunos.Update(aluno);
                contexto.SaveChanges();
            }

        }
    }
}