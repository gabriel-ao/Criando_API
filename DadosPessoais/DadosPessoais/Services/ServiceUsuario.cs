using DadosPessoais.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais.Services
{
    public class ServiceUsuario
    {

        public ServiceUsuario()
        {

        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            var nome = request.Nome;
            var email = request.Email;
            var idade = request.Idade;



            return 0;
        }



    }
}
