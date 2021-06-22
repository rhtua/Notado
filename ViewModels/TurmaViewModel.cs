using Notado.ViewModels;
using System.Collections.Generic;

namespace Notado.ViewModels
{
    public class TurmaViewModel 
    {
        public int Id { get; set; }

        public string Ensino { get; set; }
        public int Ano { get; set; }
        public string Divisor { get; set; }
        public virtual IEnumerable<AvaliacaoViewModel> Avaliacoes { get; set; }
        public virtual IEnumerable<AlunoViewModel> Alunos { get; set; }
        public virtual IEnumerable<DisciplinaViewModel> Disciplinas { get; set; }



    }
}