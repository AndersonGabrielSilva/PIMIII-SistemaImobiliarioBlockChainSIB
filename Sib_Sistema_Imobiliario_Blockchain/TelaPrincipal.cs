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


namespace Sib_Sistema_Imobiliario_Blockchain
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            principal.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja Sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Refresh();
            btnMini.Visible = false;
            btnMax.Visible = true;
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMini.Visible = true;
            btnMax.Visible = false;
        }

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      /*  private void btnMenu_Click(object sender, EventArgs e)
        {
           if(pnlMenu.Width == 250)
            {
                pnlMenu.Width = 50;
                imgLoginMin.Visible = true;
            }
            else
            {
                pnlMenu.Width = 250;
                imgLoginMin.Visible = false;
            }
            
        }*/

        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbData.Text = DateTime.Now.ToLongDateString();
            //lbUser.Text = TelaLogin.codigo;

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            menuDropDown1.Controle();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Width == 250)
            {
                pnlMenu.Width = 50;
            }
            else
            {
                pnlMenu.Width = 250;
            }
        }
    }
}
