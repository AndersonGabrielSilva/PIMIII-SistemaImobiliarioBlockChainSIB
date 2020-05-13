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
    [DisplayName(nameof(Funcionario))]
    public class Funcionario : Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        [Browsable(false)]
        public int id_Funcionario { get; set; }        
        
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [DisplayName("RG")]
        public string Rg { get; set; }
        
        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }

        [DisplayName("Genero")]
        public string Sexo { get; internal set; }

        [DisplayName("Data de Aniversario")]
        public DateTime? DataAniversario { get; set; }

        [DisplayName("Data de Admissão")]
        public DateTime? DataAdmin { get; set; }

        [DisplayName("Escolaridade")]
        public string Escolaridade { get; set; }

        [DisplayName("E-Mail")]
        public string Email { get; internal set; }
       
        [Browsable(false)]
        public Cargo Cargo { get; set; } 

        [Browsable(false)]
        public byte[] FotoFuncionarioEmBytes { get; set; }

        [Browsable(false), DisplayName("fg_ativo")]
        public int Fg_Ativo { get; set; }

        [Browsable(false), DisplayName("Telefone")]
        public List<Telefone> TelefoneList { get; set; }

        [NotMapped]
        [Browsable(false)]
        public Image Foto
        {
            get
            {
                if (FotoFuncionarioEmBytes == null)
                    return null;

                var ms = new MemoryStream(FotoFuncionarioEmBytes);

                var img = (Image)(new Bitmap(Image.FromStream(ms), new Size(190, 124)));
                return img;
            }
        }

    }
}
