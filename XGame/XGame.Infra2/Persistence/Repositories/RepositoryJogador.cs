using System;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Infra.Persistence;
using XGame.Infra.Persistence.Repositories.Base;

namespace XGame.Infra2.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase <Jogador, Guid>, IRepositoryJogador
    {
        // criando dependencias
        protected readonly XGameContext _context;

        public RepositoryJogador(XGameContext context) : base(context)
        {
            _context = context;
        }

        //public Jogador AdicionarJogador(Jogador jogador)
        //{
        //    _context.Jogadores.Add(jogador);
        //    _context.SaveChanges();

        //    return jogador;
        //}

        //public void AlterarJogador(Jogador jogador)
        //{
        //    throw new NotImplementedException();
        //}

        //public Jogador AutenticarJogador(string Email, string Senha)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Jogador> ListarJogador()
        //{
        //    return _context.Jogadores.ToList();
        //}

        //public Jogador ObterJogadorPorId(Guid Id)
        //{
        //    throw new NotImplementedException();
        //}


        //// professor do curso apagou, deixar anotado para utilizar no futuro
        //public int CalcularJogadores()
        //{

        //    string nome = "Gabriel";
        //    string ultimoNome = "Oliveira";
        //    string sexo = string.Empty;

        ////    // utilizado para melhorar performance, monta a query antes do banco de dados
        //    IQueryable<Jogador> jogadores = _context.Jogadores.AsNoTracking().AsQueryable();

        //    if (!string.IsNullOrEmpty(nome))
        //    {
        //        var jogadoresFiltro = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(nome));
        //    }

        //    if (!string.IsNullOrEmpty(ultimoNome))
        //    {
        //        var jogadoresFiltro = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(ultimoNome));
        //    }

        //    if (!string.IsNullOrEmpty(sexo))
        //    {
        //        var jogadoresFiltro = jogadores.Where(x => x.Nome.PrimeiroNome.StartsWith(sexo));
        //    }

        ////    // consulta no banco mais rapida, com asParallel  - toList listando nomes
        //    return jogadores.AsParallel().ToList().Count();
        //}


    }
}
