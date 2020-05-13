using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sib_Sistema_Imobiliario_Blockchain
{
    public partial class TelaLogin : Form
    {
        Thread nt;

        public TelaLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static string loginUser = "";
        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "Usuário")
            {
                txtUser.Clear();
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Senha")
            {
                txtPassword.Clear();
            }

            txtPassword.PasswordChar = '*';
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "admin" && txtPassword.Text == "123")
            {
                loginUser = txtUser.Text;
                
                this.Close();                
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                
            }
            else
            {
                MessageBox.Show("Falha no login");
            }
           
        }

        private void novoForm()
        {
            
            Application.Run(new TelaPrincipal());
        }
    }
}
