using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades
{
    public class Pessoa
    {
        [MaxLength(60),]
        public string Nome { get; set; }

        [Browsable(false)]
        public Endereco EnderecoCliente { get; set; }

    }
}
