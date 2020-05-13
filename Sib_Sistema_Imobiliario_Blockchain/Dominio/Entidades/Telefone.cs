using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades
{
    [DisplayName(nameof(Entidades.Telefone))]
    public class Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id_Telefone { get; set; }
        public string Tipo { get; set; }
        public string Ddd { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return $" Tel:({Ddd}) {Tel} - {Tipo}";
        }

    }
}
