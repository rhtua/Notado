

using System.Collections.Generic;

namespace Notado.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Ensino { get; set; }
        public int Ano { get; set; }
        public string Divisor { get; set; }
        public virtual IEnumerable<Avaliacao> Avaliacoes { get; set; }
        public virtual IEnumerable<Aluno> Alunos { get; set; }
        public virtual IEnumerable<Disciplina> Disciplinas { get; set; }



    }
}