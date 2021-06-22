using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }

        public int DisciplinaId { get; set; }

        public int Bimestre { get; set; }

        public float Prova { get; set; }
        public float Recuperacao { get; set; }
        public float Trabalho { get; set; }




    }
}