using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.ViewModels
{
    public class ProfessorViewModel : PessoaViewModel
    {
        public string Formacao { get; set; }
        public string Disciplina { get; set; }
    }
}