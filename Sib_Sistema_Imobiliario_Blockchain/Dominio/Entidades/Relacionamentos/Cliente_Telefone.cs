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
    [DisplayName(nameof(Cliente_Telefone))]
    class Cliente_Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id_ClienteTelefone { get; set; }

        [DisplayName("ClienteFK")]
        public int ClienteFK { get; set; }

        [DisplayName("TelefoneFK")]
        public int TelefoneFK { get; set; }

    }
}
