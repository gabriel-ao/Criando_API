using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame.Domain.Resources;
using XGame.Domain.ValueIObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {


        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;


            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, "Senha deve conter entre 6 a 32 chars");

        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome  = nome;
            Email = email;
            Senha = senha;
            Id    = Guid.NewGuid();
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 30, Message.X0_SENHA.ToFormat("Senha", "6", "50"));

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            

            AddNotifications(Nome, Email);
        }

        public Guid Id { get; private set; }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        public EnumSituacaoJogador Status { get; set; }

        public override string ToString()
        {
            return this.Nome.PrimeiroNome + " " + this.Nome.SegundoNome;
        }


    }
}
