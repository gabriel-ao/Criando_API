namespace Dados.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 200),
                        Genero = c.Int(nullable: false),
                        Idade = c.Int(nullable: false),
                        Senha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "UK_USUARIO_EMAIL");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", "UK_USUARIO_EMAIL");
            DropTable("dbo.Usuario");
        }
    }
}
