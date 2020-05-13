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
    [Table(nameof(Cargo))]
    public class Cargo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id_cargo { get; set; }
        public string Funcao { get; set; }
        public string Creci { get; set; }
        public double Salario { get; set; }
    }
}
