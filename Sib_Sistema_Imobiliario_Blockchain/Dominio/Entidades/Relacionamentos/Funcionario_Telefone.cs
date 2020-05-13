using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades.Relacionamentos
{
    [DisplayName(nameof(Funcionario_Telefone))]
    class Funcionario_Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id_FuncionarioTelefone { get; set; }
        public int FuncionarioFK { get; set; }
        public int TelefoneFK { get; set; }

    }
}
