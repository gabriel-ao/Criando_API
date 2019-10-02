using DadosPessoais.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais.Usuario 
{
    public class AdicionarUsuarioRequest : IRequest
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }

        public int Idade { get; set; }

        public EnumGenero Genero { get;  set; }


    }
}
