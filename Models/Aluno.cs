using Notado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notado.Models

{
    public class Aluno : Pessoa
    {
        public string vinculo { get; set; }
        public string profissao_responsavel_1 { get; set; }
        public string profissao_responsavel_2 { get; set; }


        public DateTime dtnasc_responsavel_1 { get; set; }

        public string estadoCivil_responsavel_1 { get; set; }

        public string escolaridade_responsavel_1 { get; set; }

        public string telefone_responsavel_1 { get; set; }

        public string telefone2_responsavel_1 { get; set; }

        public string telefone_responsavel_2 { get; set; }

        public string telefone2_responsavel_2 { get; set; }

        public string escolaridade_responsavel_2 { get; set; }

        public string estadoCivil_responsavel_2 { get; set; }

        public DateTime dtnasc_responsavel_2 { get; set; }

        public string vinculo2 { get; set; }

        public string nome_responsavel_1 { get; set; }

        public string email_responsavel_1 { get; set; }

        public string rg_responsavel_1 { get; set; }

        public long cpf_responsavel_1 { get; set; }

        public string nome_responsavel_2 { get; set; }

        public string email_responsavel_2 { get; set; }

        public string rg_responsavel_2 { get; set; }

        public string cpf_responsavel_2 { get; set; }

        public virtual IEnumerable<Avaliacao> Avaliacoes { get; set; }

        public int TurmaId { get; set; }

        public virtual Turma Turma { get; set; }
    }
}