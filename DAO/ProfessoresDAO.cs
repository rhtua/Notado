using Notado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.DAO
{
    public class ProfessoresDAO
    {
        public void Adiciona(Professor professor)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Professores.Add(professor);
                contexto.SaveChanges();
            }
        }

        public IList<Professor> Lista()
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Professores.ToList();
            }
        }
        public Professor BuscaPorId(int id)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Professores.Where(t => t.Id == id).FirstOrDefault();
            }
        }

        public void Excluir(Professor professorRemover)
        {
            using (var contexto = new NotadoContext())
            {

                contexto.Remove(professorRemover);
                contexto.SaveChanges();
            }

        }

        public void Editar(Professor professor)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Professores.Update(professor);
                contexto.SaveChanges();
            }

        }
    }
}