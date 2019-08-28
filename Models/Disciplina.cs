using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }

        public int TurmaId { get; set; }
        public virtual Turma Turma { get; set; }

        public float CargaHoraria { get; set; }
        public virtual IEnumerable<Avaliacao> Avaliacoes { get; set; }

    }
}