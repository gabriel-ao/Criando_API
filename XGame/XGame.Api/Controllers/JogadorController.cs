﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XGame.Api.Controllers.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Interfaces.Services;
using XGame.Infra2.Transactions;

namespace XGame.Api.Controllers
{
    [RoutePrefix("api/jogador")]
    public class JogadorController : ControllerBase
    {
        private readonly IServiceJogador _serviceJogador;

        public JogadorController(IUnitOfWork unitOfWork, IServiceJogador serviceJogador) : base(unitOfWork)
        {
            _serviceJogador = serviceJogador;
        }

        [HttpGet]
        public IHttpActionResult Teste()
        {
            return Ok(new { Foi = true });
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarJogadorRequest request)
        {
            try
            {
                var response = _serviceJogador.AdicionarJogador(request);

                return await ResponseAsync(response, _serviceJogador);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


    }
}