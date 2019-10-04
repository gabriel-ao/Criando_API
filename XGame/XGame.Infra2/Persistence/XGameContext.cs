using System.Data.Entity;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("XGameConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false; 
        }

        public IDbSet<Jogador> Jogadores { get; set; }

        public IDbSet<Plataforma> Plataformas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // exemplo nao pratico de utilizar
            //modelBuilder.Configurations.Add(new JogadorMap());
            //modelBuilder.Configurations.Add(new PlataformaMap());

            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);
        }

    }
}
