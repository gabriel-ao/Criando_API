using DadosPessoais.Services;
using DadosPessoais.Usuario;
using System;

namespace Dados.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("iniciando......");

            var service = new ServiceUsuario();
            Console.WriteLine("Criei instancia do servico");


            var AdicionarRequest = new AdicionarUsuarioRequest()
            {
                Nome = "Gabriel Almeida de Oliveira",
                Email = "gabriel-ao@hormail.com",
                Senha = "camundongos",
                Idade = 23,
                Genero = 0
            };

            var response = service.AdicionarUsuario(AdicionarRequest);

        }
    }
}
