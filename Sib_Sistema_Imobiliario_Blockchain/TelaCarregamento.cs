using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sib_Sistema_Imobiliario_Blockchain
{
    public partial class TelaCarregamento : Form
    {
        public TelaCarregamento()
        {
            InitializeComponent();
        }

        private void tmCarregamento_Tick(object sender, EventArgs e)
        {
            progressBar.ForeColor = Color.Blue;
            lbPorcent.Text = progressBar.Value + "%";
            if (progressBar.Value < 100)
            {
                
                progressBar.Value = progressBar.Value + 2;
                
            }
            else
            {
                tmCarregamento.Enabled = false;
                this.Visible = false;               
                TelaLogin login = new TelaLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
