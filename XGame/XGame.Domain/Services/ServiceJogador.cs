using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueIObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);
            

            Jogador jogador = new Jogador(nome, email, request.Senha);

            if (IsValid())
            {
                return null;
            }

            jogador = _repositoryJogador.Adicionar(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
            {
                // notificacao caso o request esteja NULO
                AddNotification("AlterarJogadorResponse", Message.X0_E_OBRIGATORIO.ToFormat("AlterarJogadorRequest"));
            }

            // puxa dados do banco de dados atraves do ID
            Jogador jogador = _repositoryJogador.ObterPorId(request.Id);

            // verifica se o jogador esta NULO
            if(jogador == null)
            {
                AddNotification("Id", Message.NAO_HA_DADOS);
                return null;
            }

            var email = new Email(request.Email);
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);


            jogador.AlterarJogador(nome, email, jogador.Status);

            AddNotifications(jogador);

            if (IsInvalid())
            {
                return null;
            }

            _repositoryJogador.Editar(jogador);

            return (AlterarJogadorResponse)jogador;
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification ("AutenticarJogadorResquest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorResquest"));
            }

            var email = new Email(request.Email);

            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email); 

            if (jogador.IsInvalid())
            {
                return null;
            }

            jogador = _repositoryJogador.ObterPor(x=>x.Email.Endereco == jogador.Email.Endereco, x=>x.Senha == jogador.Senha);


            return (AutenticarJogadorResponse)jogador;
        }

        public IEnumerable<JogadorResponse> ListaJogador()
        {

            return _repositoryJogador.Listar().Select(jogador => (JogadorResponse)jogador).ToList();
        }

        private bool IsEmail(string email)
        {
            return false;
        }

        public ReponseBase ExcluirJogador(Guid id)
        {
            Jogador jogador = _repositoryJogador.ObterPorId(id);

            if(jogador == null)
            {
                AddNotification("Id", Message.NAO_HA_DADOS);
                return null;
            }

            _repositoryJogador.Remover(jogador);

            return new ReponseBase() { Message = Message.X0_SUCESSO };
        }

    }
}
