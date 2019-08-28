using Notado.ViewModels;
using System.Collections.Generic;

namespace Notado.ViewModels
{
    public class AvaliacaoViewModel
    {
        public int Id { get; internal set; }
        public int AlunoId { get; internal set; }
        public virtual AlunoViewModel Aluno { get; internal set; }
        public int TurmaId { get; internal set; }

        public virtual TurmaViewModel Turma { get; internal set; }
        public int DisciplinaId { get; internal set; }

        public virtual DisciplinaViewModel Disciplina { get; set; }

        public ProvaViewModel Prova { get; set; }
        public RecuperacaoViewModel Recuperacao { get; set; }
        public virtual IEnumerable<AlunoViewModel> Alunos { get; set; }
        public TrabalhoViewModel Trabalho { get; set; }
    }




}
