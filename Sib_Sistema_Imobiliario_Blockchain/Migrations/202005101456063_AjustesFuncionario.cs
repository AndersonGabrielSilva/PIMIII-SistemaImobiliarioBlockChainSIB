namespace Sib_Sistema_Imobiliario_Blockchain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustesFuncionario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionarios", "Sexo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Funcionarios", "Sexo");
        }
    }
}
