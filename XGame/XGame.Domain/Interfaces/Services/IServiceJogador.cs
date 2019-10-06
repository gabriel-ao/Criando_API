﻿using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {

        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);

        IEnumerable<JogadorResponse> ListaJogador();

        ReponseBase ExcluirJogador(Guid id);
    }
}