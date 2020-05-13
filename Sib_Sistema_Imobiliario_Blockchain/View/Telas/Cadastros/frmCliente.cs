using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastro = new frmCadastroCliente();
            frmCadastro.ShowDialog();
        }
    }
}
