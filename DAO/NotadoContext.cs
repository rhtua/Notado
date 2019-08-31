using Microsoft.EntityFrameworkCore;
using Notado.DAO;
using Notado.Models;

namespace Notado.DAO
{
    public class NotadoContext : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public DbSet<Adm> Adms { get; set; }

        public DbSet<Prova> Provas { get; set; }
        public DbSet<Recuperacao> Recuperacoes { get; set; }
        public DbSet<Trabalho> Trabalhos { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nota> Nota { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>().HasOne(i => i.Turma).WithMany(i => i.Avaliacoes)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Avaliacao>().HasOne(i => i.Aluno).WithMany(i => i.Avaliacoes)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Avaliacao>().HasOne(i => i.Turma).WithMany(i => i.Avaliacoes)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Aluno>().HasOne(i => i.Turma).WithMany(i => i.Alunos)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Disciplina>().HasOne(i => i.Turma).WithMany(i => i.Disciplinas)
                .OnDelete(DeleteBehavior.Restrict);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Notado; Trusted_Connection = true; ");
        }
    }


}