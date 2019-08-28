
using System.Collections.Generic;

namespace Notado.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int TurmaId { get; set; }

        public virtual Turma Turma { get; set; }
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        public Prova Prova { get; set; }
        public Recuperacao Recuperacao { get; set; }
        public Trabalho Trabalho { get; set; }
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }




    }
}