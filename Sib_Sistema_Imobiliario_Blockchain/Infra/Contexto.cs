using Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades;
using Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades.Relacionamentos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Infra
{
    class Contexto : DbContext
    {
        public Contexto() : base("DefaultConnection") { }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<ClientePessoaFisica> ClientePessoaFisicas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Cliente_Endereco> Cliente_Endereco { get; set; }
        public DbSet<Cliente_Telefone> Cliente_Telefone { get; set; }
        public DbSet<Funcionario_Endereco> Funcionario_Endereco { get; set; }
        public DbSet<Funcionario_Telefone> Funcionario_Telefone { get; set; }
    }
}
