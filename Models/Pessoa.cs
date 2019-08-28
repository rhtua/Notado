using Notado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.Models
{
    public abstract class Pessoa
    {
        public int Id { get;  set; }

        public string nome { get;  set; }

        public string email { get; set; }

        public long cpf { get;  set; }

        public DateTime dtnasc { get; set; }

        public string telefone { get;  set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public int numero { get;  set; }

        public string complemento { get;  set; }

        public int cep { get;  set; }
    }
}