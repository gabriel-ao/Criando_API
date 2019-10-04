﻿namespace XGame.Infra2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MapeandoPlataforma : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Plataformas", newName: "Plataforma");
            AlterColumn("dbo.Plataforma", "Nome", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plataforma", "Nome", c => c.String(maxLength: 100, unicode: false));
            RenameTable(name: "dbo.Plataforma", newName: "Plataforma");
        }
    }
}
