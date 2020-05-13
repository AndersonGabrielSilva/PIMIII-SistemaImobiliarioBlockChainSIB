using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading;

namespace Sib_Sistema_Imobiliario_Blockchain
{
    class MaskComponente : MaskedTextBox
    {
        public string Mascara { get; set; }
        private string Memoria;
        private bool auxMemoria;
        private string MaskSelecionada;
        private bool auxMaskSelecionada;
        private string Data = "00/00/0000";
        private string Cep = "00000 - 000";
        private string Cpf = @"000\.000\.000\. - 00";
        private string Rg = @"00\.000\.000\. - 0";
        private string Telefone = "(00) 0000-0000";
        private string Celular = "(00) 00000-0000";
        private string Titulo = @"0000\.0000\.0000\.00";
        private string Numero = "0000";
        private string Default = "";

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (!auxMemoria) { Memoria = value; auxMemoria = true; }
                

                base.Text = value;
            }
        }

        #region Mudar Mascara
        /// <summary>
        /// Mascara informada no codigo
        /// </summary>
        /// <param name="mask"></param>
        public void MaskMudar(string mask)
        {
            MaskSelecionada = mask;
            switch (mask)
            {
                case nameof(this.Data):
                    if(this.Text.Equals(Memoria))
                        this.Text = string.Empty;

                    this.Mask = Data;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Cep):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Cep;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;


                    break;

                case nameof(this.Celular):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Celular;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Telefone):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Telefone;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Cpf):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Cpf;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Rg):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Rg;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Titulo):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Titulo;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Numero):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Numero;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Default):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Default;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                default: 

                    break;
            }
            
        }

        /// <summary>
        /// Mascara informada na proprieda do design
        /// </summary>
        public void MaskMudar()
        {
            var mask = this.Mascara;
            MaskSelecionada = mask;

            switch (mask)
            {
                case nameof(this.Data):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;

                    this.Mask = Data;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Cep):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Cep;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;


                    break;

                case nameof(this.Celular):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Celular;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Telefone):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Telefone;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Cpf):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Cpf;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Rg):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Rg;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Titulo):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Titulo;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Numero):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Numero;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                case nameof(this.Default):
                    if (this.Text.Equals(Memoria))
                        this.Text = string.Empty;
                    this.Mask = Default;
                    this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    break;

                default:

                    break;
            }

        }
        #endregion

        protected override void OnKeyDown(KeyEventArgs e)
        {
          if (this.Text.Equals(Memoria) && !this.auxMaskSelecionada)
            {
                this.Text = string.Empty;
                auxMaskSelecionada = true;
                MaskMudar();
                
                this.Refresh();
            }
            base.OnKeyDown(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Equals(string.Empty))
            {
                this.Mask = string.Empty;
                this.Text = Memoria;
                this.auxMaskSelecionada = false;
                this.Refresh();
            }
            base.OnLeave(e);
        }
    }
}
