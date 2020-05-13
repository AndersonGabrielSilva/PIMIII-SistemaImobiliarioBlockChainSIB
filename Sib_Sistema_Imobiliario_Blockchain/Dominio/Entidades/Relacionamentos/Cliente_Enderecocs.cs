using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades.Relacionamentos
{
    [DisplayName(nameof(Cliente_Endereco))]
    class Cliente_Endereco
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id_ClienteEndereco { get; set; }

        public int ClienteFk { get; set; }
        public int EnderecoFK { get; set; }

    }
}
