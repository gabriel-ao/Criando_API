using DadosPessoais.Services;
using DadosPessoais.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("iniciando......");

            var service = new ServiceUsuario();
            Console.WriteLine("Criei instancia do servico");


            AdicionarUsuarioRequest request = new AdicionarUsuarioRequest()
            {
                Nome = "Gabriel Almeida de Oliveira",
                Email = "gabriel-ao@hormail.com",
                Senha = "camundongos",
                Idade = 22

            };

            var response = service.AdicionarUsuario(request);

        }
    }
}
