namespace Projeto3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mercadinho3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Saldo = c.Int(nullable: false),
                        Minimo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produto", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 60, unicode: false),
                        VlCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lucro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VlVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        ProdutoId = c.Int(nullable: false),
                        DtaRecebimento = c.DateTime(nullable: false),
                        VlUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QtdRecebida = c.Int(nullable: false),
                        VlTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Id)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.Fornecedor_Id);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 60, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "Id", "dbo.Produto");
            DropForeignKey("dbo.Pedido", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Pedido", "Fornecedor_Id", "dbo.Fornecedor");
            DropIndex("dbo.Pedido", new[] { "Fornecedor_Id" });
            DropIndex("dbo.Pedido", new[] { "ProdutoId" });
            DropIndex("dbo.Estoque", new[] { "Id" });
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Pedido");
            DropTable("dbo.Produto");
            DropTable("dbo.Estoque");
            DropTable("dbo.cliente");
        }
    }
}
