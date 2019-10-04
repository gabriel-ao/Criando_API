using System.Data.Entity;
namespace Dados.Infra.Persistence
{
    public class DadosContext : DbContext
    {

        public DadosContext() : base("DadosConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        //acessando dados na tabela 
        public IDbSet<DadosPessoais.Dados> Dados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.AddFromAssembly(typeof(DadosContext).Assembly);
        }
    }
}
