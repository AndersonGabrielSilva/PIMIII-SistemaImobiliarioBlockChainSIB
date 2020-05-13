namespace Sib_Sistema_Imobiliario_Blockchain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dois : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Email");
        }
    }
}
