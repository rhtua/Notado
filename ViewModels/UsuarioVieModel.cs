using Notado.Enuns;
using Notado.ViewModels;

namespace Notado.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public Autorizacao Autorizacao { get; set; }


    }

    
}