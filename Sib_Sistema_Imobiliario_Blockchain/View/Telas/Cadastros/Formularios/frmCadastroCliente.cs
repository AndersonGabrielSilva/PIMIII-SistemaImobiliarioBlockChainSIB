using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros.Formularios
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

       /* private void txtDataNascimento_Click(object sender, EventArgs e)
        {
            if (txtDataNascimento.Equals("Data Nascimento*"))
            {
                txtDataNascimento.Visible = false;
               
            }
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskNomeCliente_Click(object sender, EventArgs e)
        {
            mskNomeCliente.MaskMudar("Default");
        }

        private void mskEmailCliente_Click(object sender, EventArgs e)
        {
            mskEmailCliente.MaskMudar("Default");
        }

        private void mskCpfCliente_Click(object sender, EventArgs e)
        {
            mskCpfCliente.MaskMudar("Cpf");
        }

        private void mskRgCliente_Click(object sender, EventArgs e)
        {
            mskRgCliente.MaskMudar("Rg");
        }

        private void mskDataNascimentoCliente_Click(object sender, EventArgs e)
        {
            mskDataNascimentoCliente.MaskMudar("Data");
        }

        private void mskCelularCliente_Click(object sender, EventArgs e)
        {
            mskCelularCliente.MaskMudar("Celular");
        }

        private void mskTelefoneCliente_Click(object sender, EventArgs e)
        {
            mskTelefoneCliente.MaskMudar("Telefone");
        }

        private void mskTituloCliente_Click(object sender, EventArgs e)
        {
            mskTituloCliente.MaskMudar("Titulo");
        }

        private void mskProfissaoCliente_Click(object sender, EventArgs e)
        {
            mskProfissaoCliente.MaskMudar("Default");
        }

        private void mskCepCliente_Click(object sender, EventArgs e)
        {
            mskCepCliente.MaskMudar("Cep");
        }

        private void mskLogradouroCliente_Click(object sender, EventArgs e)
        {
            mskLogradouroCliente.MaskMudar("Default");
        }

        private void mskBairroCliente_Click(object sender, EventArgs e)
        {
            mskBairroCliente.MaskMudar("Default");
        }

        private void mskCidadeCliente_Click(object sender, EventArgs e)
        {
            mskCidadeCliente.MaskMudar("Default");
        }

        private void mskEstadoCliente_Click(object sender, EventArgs e)
        {
            mskEstadoCliente.MaskMudar("Default");
        }

        private void mskNumeroCliente_Click(object sender, EventArgs e)
        {
            mskNumeroCliente.MaskMudar("Numero");
        }

        private void mskComplementoCliente_Click(object sender, EventArgs e)
        {
            mskComplementoCliente.MaskMudar("Default");
        }

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
