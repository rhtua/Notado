using System.ComponentModel.DataAnnotations;

namespace Notado.ViewModels
{
    public class ProvaViewModel
    {
        public int AlunoId { get; set; }
        public virtual AlunoViewModel Aluno { get; set; }

        public float Nota { get; set; }

        public int DisciplinaID { get; set; }
        public virtual DisciplinaViewModel Disciplina { get; set; }

        [Required, Range(1, 4)]
        public int Bimestre { get; set; }
    }
}