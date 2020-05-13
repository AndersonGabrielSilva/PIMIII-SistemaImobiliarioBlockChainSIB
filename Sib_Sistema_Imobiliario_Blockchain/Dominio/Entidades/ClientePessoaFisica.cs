using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades
{
    [DisplayName(nameof(ClientePessoaFisica))]
    class ClientePessoaFisica : Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int id_Funcionario { get; set; }
        public Cargo Cargo { get; set; }       
        
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataAniversario { get; set; }
        public string Escolaridade { get; set; }
        public string Genero { get; set; }
        public string Pis { get; set; }
        public string Nis { get; set; }


        [Browsable(false)]
        public byte[] FotoClienteEmBytes { get; set; }

        [NotMapped]
        public Image Foto
        {
            get
            {
                if (FotoClienteEmBytes == null)
                    return null;

                var ms = new MemoryStream(FotoClienteEmBytes);

                var img = (Image)(new Bitmap(Image.FromStream(ms), new Size(190, 124)));
                return img;
            }
        }

    }
}
