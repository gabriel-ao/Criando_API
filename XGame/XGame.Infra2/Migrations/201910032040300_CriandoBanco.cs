namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogador",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 50),
                        SegundoNome = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 200),
                        Senha = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "UK_JOGADOR_EMAIL");
            
            CreateTable(
                "dbo.Plataformas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Jogador", "UK_JOGADOR_EMAIL");
            DropTable("dbo.Plataformas");
            DropTable("dbo.Jogador");
        }
    }
}
