using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Sib_Sistema_Imobiliario_Blockchain.View.Componentes
{
    public class MenuDropDown : Panel
    {
        /// <summary>
        /// Indica se o Menu esta aberto ou fechado
        /// </summary>
        public bool Aberto { get; set; }
        public override Size MinimumSize { get => base.MinimumSize; set => base.MinimumSize = TamanhoPrimeiroButton(); }
        private Size TamanhoPrimeiroButton()
        {
            var primeiroBotao = (Button)this.Controls[this.Controls.Count - 1];
            return primeiroBotao.Size;
        }

        /// <summary>
        /// Expande o menu de acordo com a quantidade de button dentro
        /// </summary>
        public void Expandir()
        {
            for (int x = 0; x < this.Controls.Count -1; x++)
            {
                if (this.Controls[x].GetType().FullName.Equals("System.Windows.Forms.Button"))//Se for um Button
                {
                    var botaoAtual = (Button)this.Controls[x];
                    this.Height += botaoAtual.Height;
                }
            }
            this.Aberto = true;
            this.Refresh();
        }

        /// <summary>
        /// Fecha o menu
        /// </summary>
        public void Fechar()
        {
            if (this.Controls.Count != 0)
            {
                Button primeiroBotao = (Button)this.Controls[this.Controls.Count - 1];

                for (int x = 0; x < this.Controls.Count; x++)
                {
                    if (this.Controls[x].GetType().FullName.Equals("System.Windows.Forms.Button"))//Se for um Button
                    {
                        var botaoAtual = (Button)this.Controls[x];
                        this.Height -= botaoAtual.Height;
                    }
                }

                //this.Height += primeiroBotao.Height;
                this.Aberto = false;
                this.Refresh();
            }           
        }

        /// <summary>
        /// Realiza todo o controle de abertura do menu 
        /// </summary>
        public void Controle()
        {
            if (this.Aberto)
            {
                this.Fechar();
            }
            else
            {
                this.Expandir();
            }
        }
    }
}
    

