namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCamposClientes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "Endereco_EnderecoId1", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "Endereco_EnderecoId1" });
            AddColumn("dbo.Clientes", "CEP", c => c.String());
            AddColumn("dbo.Clientes", "Logradouro", c => c.String());
            AddColumn("dbo.Clientes", "Numero", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Complemento", c => c.String());
            AddColumn("dbo.Clientes", "Cidade", c => c.String());
            AddColumn("dbo.Clientes", "Estado", c => c.String());
            DropColumn("dbo.Clientes", "Endereco_EnderecoId");
            DropColumn("dbo.Clientes", "Endereco_EnderecoId1");
            DropTable("dbo.Enderecoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        CEP = c.String(),
                        Logradouro = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
            AddColumn("dbo.Clientes", "Endereco_EnderecoId1", c => c.Int());
            AddColumn("dbo.Clientes", "Endereco_EnderecoId", c => c.Int());
            DropColumn("dbo.Clientes", "Estado");
            DropColumn("dbo.Clientes", "Cidade");
            DropColumn("dbo.Clientes", "Complemento");
            DropColumn("dbo.Clientes", "Numero");
            DropColumn("dbo.Clientes", "Logradouro");
            DropColumn("dbo.Clientes", "CEP");
            CreateIndex("dbo.Clientes", "Endereco_EnderecoId1");
            AddForeignKey("dbo.Clientes", "Endereco_EnderecoId1", "dbo.Enderecoes", "EnderecoId");
        }
    }
}
