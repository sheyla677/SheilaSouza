namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterarCampos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
            AddColumn("dbo.Clientes", "Sobrenome", c => c.String());
            AddColumn("dbo.Clientes", "Endereco_EnderecoId", c => c.Int());
            CreateIndex("dbo.Clientes", "Endereco_EnderecoId");
            AddForeignKey("dbo.Clientes", "Endereco_EnderecoId", "dbo.Enderecoes", "EnderecoId");
            DropColumn("dbo.Clientes", "Email");
            DropColumn("dbo.Clientes", "Telefone");
            DropColumn("dbo.Clientes", "Sexo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Sexo", c => c.String());
            AddColumn("dbo.Clientes", "Telefone", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Email", c => c.String());
            DropForeignKey("dbo.Clientes", "Endereco_EnderecoId", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "Endereco_EnderecoId" });
            DropColumn("dbo.Clientes", "Endereco_EnderecoId");
            DropColumn("dbo.Clientes", "Sobrenome");
            DropTable("dbo.Enderecoes");
        }
    }
}
