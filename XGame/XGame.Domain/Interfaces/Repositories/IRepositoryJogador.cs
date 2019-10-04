using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string Email, string Senha);

        Jogador AdicionarJogador(Jogador jogador);

        IEnumerable<Jogador> ListarJogador();

        Jogador ObterJogadorPorId(Guid Id);

        void AlterarJogador(Jogador jogador);
    }
}
