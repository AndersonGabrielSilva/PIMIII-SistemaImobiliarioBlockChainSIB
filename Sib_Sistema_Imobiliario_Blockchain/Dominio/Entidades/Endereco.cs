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
    [Table(nameof(Endereco))]
    public class Endereco
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int Id_Endereco { get; set; }
        public int Cep { get; set; }
        public string Logadouro { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public override string ToString()
        {
            return $"Logadouro: {Logadouro}, Nº {Numero} Cidade: {Cidade}-{Estado}";
        }
    }
}
