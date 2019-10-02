using DadosPessoais.Enum;
using System;

namespace DadosPessoais
{
    public class Dados
    {
        public Dados(Guid id, string nome, string email, EnumGenero genero, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Genero = genero;
            Idade = idade;
        }

        public Dados(Guid id, string nome, string email, EnumGenero genero, int idade, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Genero = genero;
            Idade = idade;
            Senha = senha;
        }

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public EnumGenero Genero { get; private set; }

        public int  Idade { get; private set; }

        public string Senha { get; private set; }

    }
}
