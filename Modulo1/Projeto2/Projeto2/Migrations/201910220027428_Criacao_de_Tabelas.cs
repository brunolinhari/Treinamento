namespace Projeto2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_de_Tabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tab_banco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tab_conta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        BancoId = c.Int(nullable: false),
                        Agencia = c.String(nullable: false, maxLength: 4, unicode: false),
                        ContaCorrente = c.String(nullable: false, maxLength: 10, unicode: false),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limite = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tab_banco", t => t.BancoId, cascadeDelete: true)
                .ForeignKey("dbo.tab_cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.BancoId);
            
            CreateTable(
                "dbo.tab_cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tab_conta", "ClienteId", "dbo.tab_cliente");
            DropForeignKey("dbo.tab_conta", "BancoId", "dbo.tab_banco");
            DropIndex("dbo.tab_conta", new[] { "BancoId" });
            DropIndex("dbo.tab_conta", new[] { "ClienteId" });
            DropTable("dbo.tab_cliente");
            DropTable("dbo.tab_conta");
            DropTable("dbo.tab_banco");
        }
    }
}
