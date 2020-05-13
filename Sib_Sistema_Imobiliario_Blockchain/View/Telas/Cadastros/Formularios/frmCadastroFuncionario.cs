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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros.Formularios
{
    public partial class frmCadastroFuncionario : Form
    {

        #region Construtor
        public frmCadastroFuncionario()
        {

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Propriedades
        Funcionario funcionario = new Funcionario();
        FuncionarioDAO FuncionarioDAO = new FuncionarioDAO();
        byte[] BytesImagem;
        OpenFileDialog OpenFileDialog = new OpenFileDialog();
        Endereco endereco;
        Telefone Celular = new Telefone();
        Telefone Residencial = new Telefone();
        List<Telefone> telefones = new List<Telefone>();

        #endregion       

        #region Mascaras
        private void mskNomeFuncionario_Click(object sender, EventArgs e)
        {
            mskNomeFuncionario.MaskMudar("Default");
        }

        private void mskEmailFuncionario_Click(object sender, EventArgs e)
        {
            mskEmailFuncionario.MaskMudar("Default");
        }

        private void mskCpfFuncionario_Click(object sender, EventArgs e)
        {
            mskCpfFuncionario.MaskMudar("Cpf");
        }

        private void mskRgFuncionario_Click(object sender, EventArgs e)
        {
            mskRgFuncionario.MaskMudar("Rg");
        }

        private void mskDataNascimentoFuncionario_Click(object sender, EventArgs e)
        {
            //mskDataNascimentoFuncionario.MaskMudar("Data");
        }

        private void mskCelularFuncionario_Click(object sender, EventArgs e)
        {
            mskCelularFuncionario.MaskMudar("Celular");
        }

        private void mskTelefoneFuncionario_Click(object sender, EventArgs e)
        {
            mskTelefoneFuncionario.MaskMudar("Telefone");
        }

        private void mskProfissaoFuncionario_Click(object sender, EventArgs e)
        {
            mskProfissaoFuncionario.MaskMudar("Default");
        }

        private void mskCepFuncionario_Click(object sender, EventArgs e)
        {
            mskCepFuncionario.MaskMudar("Cep");
        }

        private void mskLogradouroFuncionario_Click(object sender, EventArgs e)
        {
            mskLogradouroFuncionario.MaskMudar("Default");
        }

        private void mskBairroFuncionario_Click(object sender, EventArgs e)
        {
            mskBairroFuncionario.MaskMudar("Default");
        }

        private void mskCidadeFuncionario_Click(object sender, EventArgs e)
        {
            mskCidadeFuncionario.MaskMudar("Default");
        }

        private void mskEstadoFuncionario_Click(object sender, EventArgs e)
        {
            mskEstadoFuncionario.MaskMudar("Default");
        }

        private void mskNumeroFuncionario_Click(object sender, EventArgs e)
        {
            mskNumeroFuncionario.MaskMudar("Numero");
        }

        private void mskComplementoFuncionario_Click(object sender, EventArgs e)
        {
            mskComplementoFuncionario.MaskMudar("Default");
        }

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Botões 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            
            //Registro de endereço
            endereco = new Endereco();
            endereco.Cep = int.Parse(mskCepFuncionario.Text);
            endereco.Logadouro = mskLogradouroFuncionario.Text;
               // if (mskNumeroFuncionario.Text.Equals("Numero"))
            endereco.Numero = Convert.ToInt32(mskNumeroFuncionario.Text);
            endereco.Bairro = mskBairroFuncionario.Text;
            endereco.Cidade = mskCidadeFuncionario.Text;
            endereco.Estado = mskEstadoFuncionario.Text;
            endereco.Complemento = mskComplementoFuncionario.Text;
            

            //Montando funcionario
            //var DataRegex = Regex.Replace(mskDataNascimentoFuncionario.Text, @"([0-9]{2})([0-9]{2})([0-9]{4})", "$1/$2/$3");
            funcionario.Nome = mskNomeFuncionario.Text;
            funcionario.Cargo = new Cargo();
            funcionario.Cargo.Funcao = mskProfissaoFuncionario.Text;
            funcionario.Cargo.Creci = mskCreciFuncionario.Text;
            funcionario.Cpf = mskCpfFuncionario.Text;
            funcionario.Rg = mskRgFuncionario.Text;
            funcionario.DataAniversario = new DateTime();
            funcionario.DataAniversario = dtpDataNascimento.Value;
            funcionario.EstadoCivil = cbbEstadoCivilFuncionario.Text;
            funcionario.Email = mskEmailFuncionario.Text;
            funcionario.FotoFuncionarioEmBytes = BytesImagem;
            funcionario.EnderecoCliente = endereco;
            funcionario.Sexo = cbbGereroFuncionario.Text;
            funcionario.Fg_Ativo = 1;

            //Gerando Lista de Telefones
            Celular.Ddd = mskCelularFuncionario.Text.Substring(0, 2);
            Celular.Tel = mskCelularFuncionario.Text.Substring(2);
            Celular.Tipo = "Cel";

            Residencial.Ddd = mskTelefoneFuncionario.Text.Substring(0, 2);
            Residencial.Tel = mskTelefoneFuncionario.Text.Substring(2);
            Residencial.Tipo = "Fixo";
                        
            telefones.Add(Celular);
            telefones.Add(Residencial);

            //Vinculando Lista de Telefones com o funcionario
            funcionario.TelefoneList = telefones;           

            FuncionarioDAO.Adicionar(funcionario);            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
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

        #endregion

        #region Eventos
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

    }
}
