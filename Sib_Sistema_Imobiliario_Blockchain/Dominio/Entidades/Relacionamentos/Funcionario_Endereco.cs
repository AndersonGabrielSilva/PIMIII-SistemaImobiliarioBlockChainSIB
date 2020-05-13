using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades.Relacionamentos
{
    class Funcionario_Endereco
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key]
        public int Id_FuncionarioEndereco { get; set; }
        public int FuncionarioFK { get; set; }
        public int EnderecoFk { get; set; }

    }
}
