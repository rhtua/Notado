using Notado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.DAO
{
    public class TurmasDAO
    {
        public void Adiciona(Turma turma)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Turmas.Add(turma);
                contexto.SaveChanges();
            }
        }

        public IList<Turma> Lista()
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Turmas.ToList();
            }
        }
        public Turma BuscaPorId(int id)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Turmas.Where(t => t.Id == id).FirstOrDefault();
            }
        }

        public void Excluir(Turma turmaRemover)
        {
            using (var contexto = new NotadoContext())
            {
         
                contexto.Remove(turmaRemover);
                contexto.SaveChanges();
            }

        }

        public void Editar(Turma turma)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Turmas.Update(turma);
                contexto.SaveChanges();
            }

        }
    }
}