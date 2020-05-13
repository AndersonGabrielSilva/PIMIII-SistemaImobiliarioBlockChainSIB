namespace Sib_Sistema_Imobiliario_Blockchain
{
    partial class TelaCarregamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCarregamento));
            this.tmCarregamento = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new Sib_Sistema_Imobiliario_Blockchain.GradientPanel();
            this.lbPorcent = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.imgLogoSIB = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSIB)).BeginInit();
            this.SuspendLayout();
            // 
            // tmCarregamento
            // 
            this.tmCarregamento.Enabled = true;
            this.tmCarregamento.Interval = 50;
            this.tmCarregamento.Tick += new System.EventHandler(this.tmCarregamento_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Colorbottom = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.gradientPanel1.Controls.Add(this.lbPorcent);
            this.gradientPanel1.Controls.Add(this.progressBar);
            this.gradientPanel1.Controls.Add(this.imgLogoSIB);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(489, 261);
            this.gradientPanel1.TabIndex = 3;
            // 
            // lbPorcent
            // 
            this.lbPorcent.AutoSize = true;
            this.lbPorcent.BackColor = System.Drawing.Color.Transparent;
            this.lbPorcent.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPorcent.Location = new System.Drawing.Point(226, 199);
            this.lbPorcent.Name = "lbPorcent";
            this.lbPorcent.Size = new System.Drawing.Size(21, 13);
            this.lbPorcent.TabIndex = 4;
            this.lbPorcent.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(77, 218);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(324, 2);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // imgLogoSIB
            // 
            this.imgLogoSIB.BackColor = System.Drawing.Color.Transparent;
            this.imgLogoSIB.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoSIB.Image")));
            this.imgLogoSIB.Location = new System.Drawing.Point(138, 12);
            this.imgLogoSIB.Name = "imgLogoSIB";
            this.imgLogoSIB.Size = new System.Drawing.Size(200, 200);
            this.imgLogoSIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoSIB.TabIndex = 1;
            this.imgLogoSIB.TabStop = false;
            // 
            // TelaCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCarregamento";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoSIB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox imgLogoSIB;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbPorcent;
        private System.Windows.Forms.Timer tmCarregamento;
    }
}

