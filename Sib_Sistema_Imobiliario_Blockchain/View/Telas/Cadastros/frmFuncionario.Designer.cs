namespace Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros
{
    partial class frmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlResumoFuncionario = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlDadosFuncio = new System.Windows.Forms.Panel();
            this.pctFecharDadosFuncio = new System.Windows.Forms.PictureBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbIdadeFuncionario = new System.Windows.Forms.Label();
            this.lbEmailFuncionario = new System.Windows.Forms.Label();
            this.lbCpfFuncionario = new System.Windows.Forms.Label();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlLinhaEmail = new System.Windows.Forms.Panel();
            this.pnlLinhaCpf = new System.Windows.Forms.Panel();
            this.pnlLinhaNome = new System.Windows.Forms.Panel();
            this.pnlFuncionario = new System.Windows.Forms.Panel();
            this.lbCPF = new System.Windows.Forms.Label();
            this.maskPesquisarCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lbFuncionarios = new System.Windows.Forms.Label();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.dgvViewFuncionarios = new System.Windows.Forms.DataGridView();
            this.bwSelectGrid = new System.ComponentModel.BackgroundWorker();
            this.roundPicture1 = new Sib_Sistema_Imobiliario_Blockchain.View.Componentes.RoundPicture();
            this.mskDataFuncSel = new System.Windows.Forms.MaskedTextBox();
            this.pnlResumoFuncionario.SuspendLayout();
            this.pnlDadosFuncio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFecharDadosFuncio)).BeginInit();
            this.pnlFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlResumoFuncionario
            // 
            this.pnlResumoFuncionario.Controls.Add(this.splitter1);
            this.pnlResumoFuncionario.Controls.Add(this.pnlDadosFuncio);
            this.pnlResumoFuncionario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlResumoFuncionario.Location = new System.Drawing.Point(727, 0);
            this.pnlResumoFuncionario.Name = "pnlResumoFuncionario";
            this.pnlResumoFuncionario.Size = new System.Drawing.Size(307, 504);
            this.pnlResumoFuncionario.TabIndex = 0;
            this.pnlResumoFuncionario.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 504);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlDadosFuncio
            // 
            this.pnlDadosFuncio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDadosFuncio.BackColor = System.Drawing.Color.White;
            this.pnlDadosFuncio.Controls.Add(this.mskDataFuncSel);
            this.pnlDadosFuncio.Controls.Add(this.pctFecharDadosFuncio);
            this.pnlDadosFuncio.Controls.Add(this.lblCPF);
            this.pnlDadosFuncio.Controls.Add(this.lblEmail);
            this.pnlDadosFuncio.Controls.Add(this.lblNome);
            this.pnlDadosFuncio.Controls.Add(this.roundPicture1);
            this.pnlDadosFuncio.Controls.Add(this.lbIdadeFuncionario);
            this.pnlDadosFuncio.Controls.Add(this.lbEmailFuncionario);
            this.pnlDadosFuncio.Controls.Add(this.lbCpfFuncionario);
            this.pnlDadosFuncio.Controls.Add(this.lbNomeFuncionario);
            this.pnlDadosFuncio.Controls.Add(this.pnlData);
            this.pnlDadosFuncio.Controls.Add(this.pnlLinhaEmail);
            this.pnlDadosFuncio.Controls.Add(this.pnlLinhaCpf);
            this.pnlDadosFuncio.Controls.Add(this.pnlLinhaNome);
            this.pnlDadosFuncio.Location = new System.Drawing.Point(0, 72);
            this.pnlDadosFuncio.Name = "pnlDadosFuncio";
            this.pnlDadosFuncio.Size = new System.Drawing.Size(286, 375);
            this.pnlDadosFuncio.TabIndex = 0;
            // 
            // pctFecharDadosFuncio
            // 
            this.pctFecharDadosFuncio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctFecharDadosFuncio.Image = global::Sib_Sistema_Imobiliario_Blockchain.Properties.Resources.sairrr;
            this.pctFecharDadosFuncio.Location = new System.Drawing.Point(270, 3);
            this.pctFecharDadosFuncio.Name = "pctFecharDadosFuncio";
            this.pctFecharDadosFuncio.Size = new System.Drawing.Size(13, 13);
            this.pctFecharDadosFuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFecharDadosFuncio.TabIndex = 24;
            this.pctFecharDadosFuncio.TabStop = false;
            this.pctFecharDadosFuncio.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(71, 250);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "label4";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(71, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "label3";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(71, 217);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "label1";
            // 
            // lbIdadeFuncionario
            // 
            this.lbIdadeFuncionario.AutoSize = true;
            this.lbIdadeFuncionario.Location = new System.Drawing.Point(30, 318);
            this.lbIdadeFuncionario.Name = "lbIdadeFuncionario";
            this.lbIdadeFuncionario.Size = new System.Drawing.Size(34, 13);
            this.lbIdadeFuncionario.TabIndex = 18;
            this.lbIdadeFuncionario.Text = "Idade";
            // 
            // lbEmailFuncionario
            // 
            this.lbEmailFuncionario.AutoSize = true;
            this.lbEmailFuncionario.Location = new System.Drawing.Point(30, 284);
            this.lbEmailFuncionario.Name = "lbEmailFuncionario";
            this.lbEmailFuncionario.Size = new System.Drawing.Size(35, 13);
            this.lbEmailFuncionario.TabIndex = 17;
            this.lbEmailFuncionario.Text = "E-mail";
            // 
            // lbCpfFuncionario
            // 
            this.lbCpfFuncionario.AutoSize = true;
            this.lbCpfFuncionario.Location = new System.Drawing.Point(30, 250);
            this.lbCpfFuncionario.Name = "lbCpfFuncionario";
            this.lbCpfFuncionario.Size = new System.Drawing.Size(27, 13);
            this.lbCpfFuncionario.TabIndex = 16;
            this.lbCpfFuncionario.Text = "CPF";
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.Location = new System.Drawing.Point(30, 217);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(35, 13);
            this.lbNomeFuncionario.TabIndex = 15;
            this.lbNomeFuncionario.Text = "Nome";
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.pnlData.Location = new System.Drawing.Point(33, 333);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(200, 1);
            this.pnlData.TabIndex = 12;
            // 
            // pnlLinhaEmail
            // 
            this.pnlLinhaEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.pnlLinhaEmail.Location = new System.Drawing.Point(33, 299);
            this.pnlLinhaEmail.Name = "pnlLinhaEmail";
            this.pnlLinhaEmail.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaEmail.TabIndex = 13;
            // 
            // pnlLinhaCpf
            // 
            this.pnlLinhaCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.pnlLinhaCpf.Location = new System.Drawing.Point(33, 265);
            this.pnlLinhaCpf.Name = "pnlLinhaCpf";
            this.pnlLinhaCpf.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaCpf.TabIndex = 14;
            // 
            // pnlLinhaNome
            // 
            this.pnlLinhaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.pnlLinhaNome.Location = new System.Drawing.Point(33, 232);
            this.pnlLinhaNome.Name = "pnlLinhaNome";
            this.pnlLinhaNome.Size = new System.Drawing.Size(200, 1);
            this.pnlLinhaNome.TabIndex = 11;
            // 
            // pnlFuncionario
            // 
            this.pnlFuncionario.Controls.Add(this.lbCPF);
            this.pnlFuncionario.Controls.Add(this.maskPesquisarCpfFuncionario);
            this.pnlFuncionario.Controls.Add(this.lbFuncionarios);
            this.pnlFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlFuncionario.Controls.Add(this.btnPesquisarFuncionario);
            this.pnlFuncionario.Controls.Add(this.dgvViewFuncionarios);
            this.pnlFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnlFuncionario.Name = "pnlFuncionario";
            this.pnlFuncionario.Size = new System.Drawing.Size(727, 504);
            this.pnlFuncionario.TabIndex = 1;
            this.pnlFuncionario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFuncionario_Paint);
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(265, 36);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(31, 15);
            this.lbCPF.TabIndex = 21;
            this.lbCPF.Text = "CPF";
            // 
            // maskPesquisarCpfFuncionario
            // 
            this.maskPesquisarCpfFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskPesquisarCpfFuncionario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maskPesquisarCpfFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskPesquisarCpfFuncionario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskPesquisarCpfFuncionario.Location = new System.Drawing.Point(297, 32);
            this.maskPesquisarCpfFuncionario.Mask = "000\\.000\\.000 - 00";
            this.maskPesquisarCpfFuncionario.Name = "maskPesquisarCpfFuncionario";
            this.maskPesquisarCpfFuncionario.Size = new System.Drawing.Size(114, 21);
            this.maskPesquisarCpfFuncionario.TabIndex = 20;
            this.maskPesquisarCpfFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFuncionarios
            // 
            this.lbFuncionarios.AutoSize = true;
            this.lbFuncionarios.Font = new System.Drawing.Font("Arial", 15F);
            this.lbFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.lbFuncionarios.Location = new System.Drawing.Point(21, 33);
            this.lbFuncionarios.Name = "lbFuncionarios";
            this.lbFuncionarios.Size = new System.Drawing.Size(196, 23);
            this.lbFuncionarios.TabIndex = 17;
            this.lbFuncionarios.Text = "Lista de Funcionários";
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(156)))));
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Arial", 8F);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(587, 28);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(111, 29);
            this.btnCadastrarFuncionario.TabIndex = 18;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(156)))));
            this.btnPesquisarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnPesquisarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarFuncionario.Font = new System.Drawing.Font("Arial", 8F);
            this.btnPesquisarFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(438, 28);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(111, 29);
            this.btnPesquisarFuncionario.TabIndex = 19;
            this.btnPesquisarFuncionario.Text = "Pesquisar";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = false;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.btnPesquisarFuncionario_Click);
            // 
            // dgvViewFuncionarios
            // 
            this.dgvViewFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewFuncionarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvViewFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewFuncionarios.EnableHeadersVisualStyles = false;
            this.dgvViewFuncionarios.Location = new System.Drawing.Point(25, 72);
            this.dgvViewFuncionarios.Name = "dgvViewFuncionarios";
            this.dgvViewFuncionarios.ReadOnly = true;
            this.dgvViewFuncionarios.RowHeadersVisible = false;
            this.dgvViewFuncionarios.Size = new System.Drawing.Size(673, 375);
            this.dgvViewFuncionarios.TabIndex = 8;
            this.dgvViewFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewFuncionarios_CellContentClick);
            // 
            // bwSelectGrid
            // 
            this.bwSelectGrid.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSelectGrid_DoWork);
            // 
            // roundPicture1
            // 
            this.roundPicture1.Location = new System.Drawing.Point(57, 27);
            this.roundPicture1.Name = "roundPicture1";
            this.roundPicture1.Size = new System.Drawing.Size(159, 159);
            this.roundPicture1.TabIndex = 19;
            this.roundPicture1.TabStop = false;
            // 
            // mskDataFuncSel
            // 
            this.mskDataFuncSel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskDataFuncSel.Location = new System.Drawing.Point(71, 316);
            this.mskDataFuncSel.Mask = "00/00/0000";
            this.mskDataFuncSel.Name = "mskDataFuncSel";
            this.mskDataFuncSel.Size = new System.Drawing.Size(127, 13);
            this.mskDataFuncSel.TabIndex = 25;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 504);
            this.Controls.Add(this.pnlFuncionario);
            this.Controls.Add(this.pnlResumoFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuncionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.pnlResumoFuncionario.ResumeLayout(false);
            this.pnlDadosFuncio.ResumeLayout(false);
            this.pnlDadosFuncio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFecharDadosFuncio)).EndInit();
            this.pnlFuncionario.ResumeLayout(false);
            this.pnlFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResumoFuncionario;
        private System.Windows.Forms.Panel pnlFuncionario;
        private System.Windows.Forms.DataGridView dgvViewFuncionarios;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.MaskedTextBox maskPesquisarCpfFuncionario;
        private System.Windows.Forms.Label lbFuncionarios;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
        private System.Windows.Forms.Panel pnlDadosFuncio;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private Componentes.RoundPicture roundPicture1;
        private System.Windows.Forms.Label lbIdadeFuncionario;
        private System.Windows.Forms.Label lbEmailFuncionario;
        private System.Windows.Forms.Label lbCpfFuncionario;
        private System.Windows.Forms.Label lbNomeFuncionario;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlLinhaEmail;
        private System.Windows.Forms.Panel pnlLinhaCpf;
        private System.Windows.Forms.Panel pnlLinhaNome;
        private System.ComponentModel.BackgroundWorker bwSelectGrid;
        private System.Windows.Forms.PictureBox pctFecharDadosFuncio;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MaskedTextBox mskDataFuncSel;
    }
}