﻿using System;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Plataforma;
using XGame.Domain.ValueIObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {

        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest request);



    }
}
