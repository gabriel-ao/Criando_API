﻿using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.ValueIObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }
    }
}
