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



            //AutenticarJogadorRequest QutenticarRequest = new AutenticarJogadorRequest();
            //Console.WriteLine("Criei instancia do meu objeto request");
            //QutenticarRequest.Email = "Gabriel@oliveira.com";
            //QutenticarRequest.Senha = "7777777";

            //var AdicionarRequest = new AdicionarJogadorRequest()
            //{
            //    Email = "gabriel.testando@outlook.com",
            //    PrimeiroNome = "Gabriel ",
            //    UltimoNome = "de Oliveira",
            //    Senha = "caminhandoVarrendo"
            //};


            //var response = service.AdicionarJogador(AdicionarRequest);

            //var response2 = service.AutenticarJogador(QutenticarRequest);

            var result = service.ListaJogador();

            Console.WriteLine("Servico e valido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();


        }
    }
}
