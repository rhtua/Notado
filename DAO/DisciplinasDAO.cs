using Notado.Models;
using Notado.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.DAO
{
    public class DisciplinasDAO
    {
        public void Adiciona(Disciplina disciplina)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Disciplinas.Add(disciplina);
                contexto.SaveChanges();
            }
        }

        public IList<Disciplina> Lista()
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Disciplinas.ToList();
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