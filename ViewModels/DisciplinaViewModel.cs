using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.ViewModels
{
    public class DisciplinaViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int ProfessorId { get; set; }
        public virtual ProfessorViewModel Professor { get; set; }
        public int TurmaId { get; set; }
        public virtual TurmaViewModel Turma { get; set; }

        public float CargaHoraria { get; set; }

    }
}