using System;
using DadosPessoais.Interfaces.Repositories;
using DadosPessoais.Usuario;

namespace DadosPessoais.Services
{
    public class ServiceUsuario
    {
        private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario()
        {

        }

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        } 

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            var nome = request.Nome;
            var email = request.Email;
            var idade = request.Idade;
            var genero = request.Genero;
            var senha = request.Senha;

            Dados dados = new Dados(nome, email, genero, idade, senha);


            dados = _repositoryUsuario.AdicionarUsuario(dados);


            return (AdicionarUsuarioResponse)dados;
        }


    }
}
