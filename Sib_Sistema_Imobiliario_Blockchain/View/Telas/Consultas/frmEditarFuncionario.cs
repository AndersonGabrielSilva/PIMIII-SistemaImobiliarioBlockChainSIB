using Sib_Sistema_Imobiliario_Blockchain.Dominio.Entidades;
using Sib_Sistema_Imobiliario_Blockchain.Model.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sib_Sistema_Imobiliario_Blockchain.View.Telas.Consultas
{
        #region Propriedades
    public partial class frmEditarFuncionario : Form
    {
        Funcionario funcionario;
        FuncionarioDAO FuncionarioDAO = new FuncionarioDAO();
        byte[] BytesImagem;
        OpenFileDialog OpenFileDialog = new OpenFileDialog();       
        Telefone Celular = new Telefone();
        Telefone Residencial = new Telefone();
        List<Telefone> telefones = new List<Telefone>();

        #endregion

        #region Construtor
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frmEditarFuncionario()
        {
            InitializeComponent();
        }

        public frmEditarFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
            InitializeComponent();
        }

        private void frmEditarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFormulario();
        }

        #endregion

        #region Metodos
        private void CarregarFormulario()
        {
            //Carregando Funcionario
            rpFotoFuncionario.Image = funcionario.Foto;
            mskNomeFuncionario.Text = funcionario.Nome;
            mskProfissaoFuncionario.Text = funcionario.Cargo.Funcao;
            mskCreciFuncionario.Text = funcionario.Cargo.Creci;
            //mskCpfFuncionario.Text = Regex.Replace(funcionario.Cpf, @"([0-9]{3})([0-9]{3})([0-9]{3})([0-9]{2})", "$1.$2.$3-$4");
            //mskRgFuncionario.Text = Regex.Replace(funcionario.Rg, @"([0-9]{2})([0-9]{3})([0-9]{3})([0-9]{1})", "$1.$2.$3-$4");
            mskCpfFuncionario.Text = funcionario.Cpf;
            mskRgFuncionario.Text = funcionario.Rg;
            dtpDataNascimento.Value = funcionario.DataAniversario.Value;
            cbbEstadoCivilFuncionario.Text = funcionario.EstadoCivil;
            mskEmailFuncionario.Text = funcionario.Email;
            BytesImagem = funcionario.FotoFuncionarioEmBytes;
            cbbGereroFuncionario.Text = funcionario.Sexo;
           
            //Carregando Endereço
            //mskCepFuncionario.Text = Regex.Replace(funcionario.EnderecoCliente.Cep.ToString(), @"([0-9]{5})([0-9]{3})", "$1-$2");
            mskCepFuncionario.Text = funcionario.EnderecoCliente.Cep.ToString();
            mskLogradouroFuncionario.Text = funcionario.EnderecoCliente.Logadouro;
            mskNumeroFuncionario.Text = funcionario.EnderecoCliente.Numero.ToString();
            mskBairroFuncionario.Text = funcionario.EnderecoCliente.Bairro;
            mskCidadeFuncionario.Text = funcionario.EnderecoCliente.Cidade;
            mskEstadoFuncionario.Text = funcionario.EnderecoCliente.Estado;
            mskComplementoFuncionario.Text = funcionario.EnderecoCliente.Complemento;

            //Montando view dos Telefones
            var Celular = funcionario.TelefoneList.ElementAt(0);
            var Telefone = funcionario.TelefoneList.ElementAt(1);

            //mskCelularFuncionario.Text = $"({Celular.Ddd}) {int.Parse(Celular.Tel).ToString("00000 - 0000")}";
            //mskCelularFuncionario.Text = $"({Celular.Ddd}) {int.Parse(Celular.Tel).ToString("00000 - 0000")}";
            //mskTelefoneFuncionario.Text = $"({Telefone.Ddd}) {int.Parse(Telefone.Tel).ToString("0000 - 0000")}";

            mskCelularFuncionario.Text = $"({Celular.Ddd}) {Celular.Tel}";
            mskTelefoneFuncionario.Text = $"({Telefone.Ddd}) {Telefone.Tel}";
        }

        private void Editar()
        {
            //Montando funcionario
            funcionario.FotoFuncionarioEmBytes = BytesImagem;
            funcionario.Nome = mskNomeFuncionario.Text;
            funcionario.Cargo.Funcao = mskProfissaoFuncionario.Text;
            funcionario.Cargo.Creci = mskCreciFuncionario.Text;
            funcionario.Cpf = mskCpfFuncionario.Text;
            funcionario.Rg = mskRgFuncionario.Text;
            funcionario.DataAniversario = dtpDataNascimento.Value;
            funcionario.EstadoCivil = cbbEstadoCivilFuncionario.Text;
            funcionario.Email = mskEmailFuncionario.Text;
            funcionario.Sexo = cbbGereroFuncionario.Text;

            //Montando Endereço
            funcionario.EnderecoCliente.Cep = int.Parse(mskCepFuncionario.Text);
            funcionario.EnderecoCliente.Logadouro = mskLogradouroFuncionario.Text;
            funcionario.EnderecoCliente.Numero = Convert.ToInt32(mskNumeroFuncionario.Text);
            funcionario.EnderecoCliente.Bairro = mskBairroFuncionario.Text;
            funcionario.EnderecoCliente.Cidade = mskCidadeFuncionario.Text;
            funcionario.EnderecoCliente.Estado = mskEstadoFuncionario.Text;
            funcionario.EnderecoCliente.Complemento = mskComplementoFuncionario.Text;

            //Gerando Lista de Telefones
            Celular.Ddd = mskCelularFuncionario.Text.Substring(0, 2);
            Celular.Tel = mskCelularFuncionario.Text.Substring(2);
            Celular.Tipo = "Cel";

            Residencial.Ddd = mskTelefoneFuncionario.Text.Substring(0, 2);
            Residencial.Tel = mskTelefoneFuncionario.Text.Substring(2);
            Residencial.Tipo = "Fixo";

            //Atualizando Lista de Telefone
            foreach (var Telefone in funcionario.TelefoneList)
            {
                if (Telefone.Tipo == "Cel")
                {
                    Telefone.Ddd = Celular.Ddd;
                    Telefone.Tel = Celular.Tel;
                }

                if (Telefone.Tipo == "Fixo")
                {
                    Telefone.Ddd = Residencial.Ddd;
                    Telefone.Tel = Residencial.Tel;
                }
            }
        }

        private void ConverterImagem(string EnderecoImagem)
        {
            try
            {
                if (!string.IsNullOrEmpty(EnderecoImagem))
                {

                    byte[] imagemBytes = null;
                    FileStream fs = new FileStream(EnderecoImagem, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imagemBytes = br.ReadBytes(1200000);
                    BytesImagem = imagemBytes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Botoes      
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var caminhoImagem = OpenFileDialog.FileName;
                ConverterImagem(caminhoImagem);
                rpFotoFuncionario.ImageLocation = caminhoImagem;
                rpFotoFuncionario.SizeMode = PictureBoxSizeMode.StretchImage;
                rpFotoFuncionario.Load(); ;
            }
        }
        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            Editar();
            FuncionarioDAO.Atualizar(funcionario);
            MessageBox.Show($"Funcionario '{funcionario.Nome}', atualizado com sucesso", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            funcionario.Fg_Ativo = 0;
            FuncionarioDAO.RemoverLog(funcionario);
            MessageBox.Show($"Funcionario '{ funcionario.Nome}' Deletado", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        
    }
}
