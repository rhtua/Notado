using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Notado.Models;

namespace Notado.DAO
{
    public class UsuariosDAO
    {

        public void Adiciona(Usuario usuario)
        {
            using (var context = new NotadoContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public Usuario BuscaPorId(int id)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Usuarios.Find(id);
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using (var contexto = new NotadoContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }

        public void Excluir(Usuario usuarioRemover)
        {
            using (var contexto = new NotadoContext())
            {

                contexto.Remove(usuarioRemover);
                contexto.SaveChanges();
            }

        }

        public void Editar(Usuario usuario)
        {
            using (var contexto = new NotadoContext())
            {
                contexto.Usuarios.Update(usuario);
                contexto.SaveChanges();
            }

        }
    }
}