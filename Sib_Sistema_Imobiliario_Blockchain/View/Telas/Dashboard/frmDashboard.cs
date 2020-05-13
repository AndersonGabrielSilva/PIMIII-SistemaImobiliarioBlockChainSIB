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
using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros;
using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Imoveis;
using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Dashboard;
using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Blockchain;

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

        //Botão de fechar
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja Sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Botão de minimizar
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Botão de normalizar
        private void btnMini_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Refresh();
            btnMini.Visible = false;
            btnMax.Visible = true;
            
        }

        //Botão de maximizar
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMini.Visible = true;
            btnMax.Visible = false;
        }

        //Possiblitando o usuário de mexer o painel
        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      

        //Criando a label de dada e hora e pegando a informação do usuário logado
        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbData.Text = DateTime.Now.ToLongDateString();
            //lbUser.Text = TelaLogin.codigo;

        }

        

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            mddDashboard.Controle();
        }

        //Botão para diminuir a aumentar o menu lateral
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Width == 250)
            {
                pnlMenu.Width = 50;
                rpbUserMini.Visible = true;
            }
            else
            {
                pnlMenu.Width = 250;
                rpbUserMini.Visible = false;
            }
        }

        //Botões do menu lateral
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            mddCadastro.Controle();
        }

        private void btnImoveis_Click(object sender, EventArgs e)
        {
            mddImoveis.Controle();
        }

        private void btnBlockchain_Click(object sender, EventArgs e)
        {
            mddBlockchain.Controle();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            mddAgenda.Controle();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            mddRelatorios.Controle();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            mddInformacoes.Controle();
        }

        //Botões que vão chamar as telas
        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            cliente.FormBorderStyle = FormBorderStyle.None;
            cliente.Visible = true;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(cliente);
            pnlBody.Refresh();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.TopLevel = false;
            funcionario.Dock = DockStyle.Fill;
            funcionario.FormBorderStyle = FormBorderStyle.None;
            funcionario.Visible = true;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(funcionario);
            pnlBody.Refresh();
        }

        private void btnAdicionarImovel_Click(object sender, EventArgs e)
        {
            frmCadastroImovel imovel = new frmCadastroImovel();
            imovel.TopLevel = false;
            imovel.Dock = DockStyle.Fill;
            imovel.FormBorderStyle = FormBorderStyle.None;
            imovel.Visible = true;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(imovel);
            pnlBody.Refresh();
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            frmPortfolioImovel portfolio = new frmPortfolioImovel();
            portfolio.TopLevel = false;
            portfolio.Dock = DockStyle.Fill;
            portfolio.FormBorderStyle = FormBorderStyle.None;
            portfolio.Visible = true;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(portfolio);
            pnlBody.Refresh();
        }

        private void btnVisaoGeral_Click(object sender, EventArgs e)
        {
            frmBody corpo = new frmBody();
            corpo.TopLevel = false;
            corpo.Dock = DockStyle.Fill;
            corpo.FormBorderStyle = FormBorderStyle.None;
            corpo.Visible = true;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(corpo);
            pnlBody.Refresh();
        }

        private void btnTransation_Click(object sender, EventArgs e)
        {
            frmCadastrarTransacao transacao = new frmCadastrarTransacao();
            transacao.TopLevel = false;
            transacao.Dock = DockStyle.Fill;
            transacao.FormBorderStyle = FormBorderStyle.None;
            transacao.Visible = true;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(transacao);
            pnlBody.Refresh();
        }
    }
}
