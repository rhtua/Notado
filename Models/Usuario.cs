
using Notado.Enuns;

namespace Notado.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public Autorizacao Autorizacao { get; set; }



    }

    
}