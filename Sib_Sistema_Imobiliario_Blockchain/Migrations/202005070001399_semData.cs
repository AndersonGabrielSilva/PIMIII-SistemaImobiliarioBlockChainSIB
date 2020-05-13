namespace Sib_Sistema_Imobiliario_Blockchain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semData : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Funcionarios", "DataAniversario");
            DropColumn("dbo.Funcionarios", "DataAdmin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Funcionarios", "DataAdmin", c => c.DateTime(nullable: false));
            AddColumn("dbo.Funcionarios", "DataAniversario", c => c.DateTime(nullable: false));
        }
    }
}
