using System.ComponentModel.DataAnnotations;

namespace Notado.Models
{
    public class Recuperacao
    {
        public int Id { get; set; }

        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        public float Nota { get; set; }

        public int DisciplinaID { get; set; }
        public virtual Disciplina Disciplina { get; set; }

        [Required, Range(1, 4)]
        public int Bimestre { get; set; }
    }
}