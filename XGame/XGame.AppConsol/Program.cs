using System;
using System.Linq;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("iniciando......");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico");



            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");
            request.Email = "Gabriel@oliveira.com";
            request.Senha = "7777777";



            var response = service.AutenticarJogador(request);

            Console.WriteLine("Servico e valido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x => {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();


        }
    }
}
