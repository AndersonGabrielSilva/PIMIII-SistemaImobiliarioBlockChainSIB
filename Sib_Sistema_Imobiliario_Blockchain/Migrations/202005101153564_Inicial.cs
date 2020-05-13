namespace Sib_Sistema_Imobiliario_Blockchain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        Id_cargo = c.Int(nullable: false, identity: true),
                        Funcao = c.String(),
                        Creci = c.String(),
                        Salario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id_cargo);
            
            CreateTable(
                "dbo.Cliente_Endereco",
                c => new
                    {
                        Id_ClienteEndereco = c.Int(nullable: false, identity: true),
                        ClienteFk = c.Int(nullable: false),
                        EnderecoFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_ClienteEndereco);
            
            CreateTable(
                "dbo.Cliente_Telefone",
                c => new
                    {
                        Id_ClienteTelefone = c.Int(nullable: false, identity: true),
                        ClienteFK = c.Int(nullable: false),
                        TelefoneFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_ClienteTelefone);
            
            CreateTable(
                "dbo.ClientePessoaFisicas",
                c => new
                    {
                        id_Funcionario = c.Int(nullable: false, identity: true),
                        Cpf = c.String(),
                        Rg = c.String(),
                        EstadoCivil = c.String(),
                        DataAniversario = c.DateTime(nullable: false),
                        Escolaridade = c.String(),
                        Genero = c.String(),
                        Pis = c.String(),
                        Nis = c.String(),
                        FotoClienteEmBytes = c.Binary(),
                        Nome = c.String(maxLength: 60),
                        Cargo_Id_cargo = c.Int(),
                        EnderecoCliente_Id_Endereco = c.Int(),
                    })
                .PrimaryKey(t => t.id_Funcionario)
                .ForeignKey("dbo.Cargo", t => t.Cargo_Id_cargo)
                .ForeignKey("dbo.Endereco", t => t.EnderecoCliente_Id_Endereco)
                .Index(t => t.Cargo_Id_cargo)
                .Index(t => t.EnderecoCliente_Id_Endereco);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id_Endereco = c.Int(nullable: false, identity: true),
                        Cep = c.Int(nullable: false),
                        Logadouro = c.String(),
                        Cidade = c.String(),
                        Bairro = c.String(),
                        Estado = c.String(),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.Id_Endereco);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        id_Funcionario = c.Int(nullable: false, identity: true),
                        Cpf = c.String(),
                        Rg = c.String(),
                        EstadoCivil = c.String(),
                        DataAniversario = c.DateTime(),
                        DataAdmin = c.DateTime(),
                        Escolaridade = c.String(),
                        Email = c.String(),
                        FotoFuncionarioEmBytes = c.Binary(),
                        Fg_Ativo = c.Int(nullable: false),
                        Nome = c.String(maxLength: 60),
                        Cargo_Id_cargo = c.Int(),
                        EnderecoCliente_Id_Endereco = c.Int(),
                    })
                .PrimaryKey(t => t.id_Funcionario)
                .ForeignKey("dbo.Cargo", t => t.Cargo_Id_cargo)
                .ForeignKey("dbo.Endereco", t => t.EnderecoCliente_Id_Endereco)
                .Index(t => t.Cargo_Id_cargo)
                .Index(t => t.EnderecoCliente_Id_Endereco);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        Id_Telefone = c.Int(nullable: false, identity: true),
                        Tipo = c.String(),
                        Ddd = c.String(),
                        Tel = c.String(),
                        Funcionario_id_Funcionario = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Telefone)
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_id_Funcionario)
                .Index(t => t.Funcionario_id_Funcionario);
            
            CreateTable(
                "dbo.Funcionario_Endereco",
                c => new
                    {
                        Id_FuncionarioEndereco = c.Int(nullable: false, identity: true),
                        FuncionarioFK = c.Int(nullable: false),
                        EnderecoFk = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_FuncionarioEndereco);
            
            CreateTable(
                "dbo.Funcionario_Telefone",
                c => new
                    {
                        Id_FuncionarioTelefone = c.Int(nullable: false, identity: true),
                        FuncionarioFK = c.Int(nullable: false),
                        TelefoneFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_FuncionarioTelefone);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefones", "Funcionario_id_Funcionario", "dbo.Funcionarios");
            DropForeignKey("dbo.Funcionarios", "EnderecoCliente_Id_Endereco", "dbo.Endereco");
            DropForeignKey("dbo.Funcionarios", "Cargo_Id_cargo", "dbo.Cargo");
            DropForeignKey("dbo.ClientePessoaFisicas", "EnderecoCliente_Id_Endereco", "dbo.Endereco");
            DropForeignKey("dbo.ClientePessoaFisicas", "Cargo_Id_cargo", "dbo.Cargo");
            DropIndex("dbo.Telefones", new[] { "Funcionario_id_Funcionario" });
            DropIndex("dbo.Funcionarios", new[] { "EnderecoCliente_Id_Endereco" });
            DropIndex("dbo.Funcionarios", new[] { "Cargo_Id_cargo" });
            DropIndex("dbo.ClientePessoaFisicas", new[] { "EnderecoCliente_Id_Endereco" });
            DropIndex("dbo.ClientePessoaFisicas", new[] { "Cargo_Id_cargo" });
            DropTable("dbo.Funcionario_Telefone");
            DropTable("dbo.Funcionario_Endereco");
            DropTable("dbo.Telefones");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Endereco");
            DropTable("dbo.ClientePessoaFisicas");
            DropTable("dbo.Cliente_Telefone");
            DropTable("dbo.Cliente_Endereco");
            DropTable("dbo.Cargo");
        }
    }
}
