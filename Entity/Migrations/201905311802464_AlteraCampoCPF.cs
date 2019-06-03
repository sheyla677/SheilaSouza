namespace Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteraCampoCPF : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CPF", c => c.Int(nullable: false));
        }
    }
}
