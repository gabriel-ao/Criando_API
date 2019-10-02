using DadosPessoais.Interfaces.Arguments;
using System;


namespace DadosPessoais.Usuario
{
    public class AdicionarUsuarioResponse : IResponse
    {

        public Guid Id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarUsuarioResponse(Dados entidade)
        {
            return new AdicionarUsuarioResponse()
            {
                Id = entidade.Id,
                Message = DadosPessoais.Resources.Message.X0_SUCESSO
            };
        }
    }
}
