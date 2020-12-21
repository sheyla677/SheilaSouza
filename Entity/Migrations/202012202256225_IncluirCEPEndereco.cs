namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluirCEPEndereco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enderecoes", "CEP", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enderecoes", "CEP");
        }
    }
}
