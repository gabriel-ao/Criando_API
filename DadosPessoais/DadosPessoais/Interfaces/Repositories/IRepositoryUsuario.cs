namespace DadosPessoais.Interfaces.Repositories
{
    public interface IRepositoryUsuario
    {
        Dados AdicionarUsuario(string Email, string Senha);

        Dados AdicionarUsuario(Dados dados);

        

    }
}
