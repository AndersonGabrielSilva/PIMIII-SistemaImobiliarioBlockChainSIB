namespace Sib_Sistema_Imobiliario_Blockchain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "DataAniversario", c => c.DateTime());
            AddColumn("dbo.Funcionarios", "DataAdmin", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "DataAdmin");
            DropColumn("dbo.Funcionarios", "DataAniversario");
        }
    }
}
