using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueIObjects
{
    public class Nome : Notifiable
    {

        protected Nome()
        {

        }
        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;

            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, Message.X0_NOME.ToFormat("Primeiro nome", "3", "50"));
            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.SegundoNome, 3, 50, Message.X0_NOME.ToFormat("Segundo nome", "3", "50"));

        }

        public string PrimeiroNome { get; private set; }

        public string SegundoNome { get; private set; }
    }
}
