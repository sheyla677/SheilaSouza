namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestePratico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.Int(nullable: false),
                        Email = c.String(),
                        Telefone = c.Int(nullable: false),
                        Sexo = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
