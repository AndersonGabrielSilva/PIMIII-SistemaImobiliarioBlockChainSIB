using Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades;
using Sib_Sistema_Imobiliario_Blockchain.Model.Dao;
using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros.Formularios;
using Sib_Sistema_Imobiliario_Blockchain.View.Telas.Consultas;
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
    public partial class frmFuncionario : Form
    {
        FuncionarioDAO funcDao = new FuncionarioDAO();
        Funcionario FuncionarioSelecionado;
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario frmCadastro = new frmCadastroFuncionario();
            frmCadastro.ShowDialog();
            CarregarGrid();
        }

        private void dgvViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvViewFuncionarios.ClearSelection();
            var funcSelecionado = (Funcionario)dgvViewFuncionarios.CurrentRow.DataBoundItem;
            FuncionarioSelecionado = funcSelecionado;
            maskPesquisarCpfFuncionario.Text = funcSelecionado.Cpf;

            roundPicture1.Image = funcSelecionado.Foto;
            roundPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNome.Text = funcSelecionado.Nome;
            lblCPF.Text = funcSelecionado.Cpf;
            lblEmail.Text = funcSelecionado.Email;
            mskDataFuncSel.Text = funcSelecionado.DataAniversario.ToString();

            pnlResumoFuncionario.Visible = true;
        }

        private void pnlFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
           

           // bwSelectGrid.RunWorkerAsync();
        }

        private void bwSelectGrid_DoWork(object sender, DoWorkEventArgs e)
        {
            dgvViewFuncionarios.DataSource = funcDao.Listar();
            
        }

        private void CarregarGrid()
        {
            dgvViewFuncionarios.DataSource = null;
            dgvViewFuncionarios.Refresh();
            dgvViewFuncionarios.DataSource = funcDao.Listar();            
            dgvViewFuncionarios.Columns["Nome"].DisplayIndex = 0;
            dgvViewFuncionarios.Columns["Cpf"].DisplayIndex = 1;
            dgvViewFuncionarios.Columns["Rg"].DisplayIndex = 2;
            dgvViewFuncionarios.Columns["Email"].DisplayIndex = 3;
            dgvViewFuncionarios.Columns["Escolaridade"].DisplayIndex = 4;
            dgvViewFuncionarios.Columns["DataAniversario"].DisplayIndex = 5;
            dgvViewFuncionarios.Columns["EstadoCivil"].DisplayIndex = 6;
            dgvViewFuncionarios.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlResumoFuncionario.Visible = false;
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            frmEditarFuncionario EditarFuncionario = new frmEditarFuncionario(FuncionarioSelecionado);
            EditarFuncionario.ShowDialog();
            dgvViewFuncionarios.Refresh();
        }
    }
}
