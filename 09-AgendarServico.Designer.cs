namespace autoMestreJuan
{
    partial class frmAgendarServico
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
            this.pnlAgendarServico = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblDataServico = new System.Windows.Forms.Label();
            this.mesAgenda = new System.Windows.Forms.MonthCalendar();
            this.cmbMecanico = new System.Windows.Forms.ComboBox();
            this.lblMecanico = new System.Windows.Forms.Label();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.cmbVeiculo = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAgendar = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlAgendarServico.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgendarServico
            // 
            this.pnlAgendarServico.BackColor = System.Drawing.Color.Black;
            this.pnlAgendarServico.Controls.Add(this.txtData);
            this.pnlAgendarServico.Controls.Add(this.lblDataServico);
            this.pnlAgendarServico.Controls.Add(this.mesAgenda);
            this.pnlAgendarServico.Controls.Add(this.cmbMecanico);
            this.pnlAgendarServico.Controls.Add(this.lblMecanico);
            this.pnlAgendarServico.Controls.Add(this.cmbServico);
            this.pnlAgendarServico.Controls.Add(this.cmbVeiculo);
            this.pnlAgendarServico.Controls.Add(this.txtCliente);
            this.pnlAgendarServico.Controls.Add(this.lblProprietario);
            this.pnlAgendarServico.Controls.Add(this.txtValor);
            this.pnlAgendarServico.Controls.Add(this.lblValor);
            this.pnlAgendarServico.Controls.Add(this.lblVeiculo);
            this.pnlAgendarServico.Controls.Add(this.cmbStatus);
            this.pnlAgendarServico.Controls.Add(this.btnSair);
            this.pnlAgendarServico.Controls.Add(this.lblStatus);
            this.pnlAgendarServico.Controls.Add(this.txtKm);
            this.pnlAgendarServico.Controls.Add(this.lblKm);
            this.pnlAgendarServico.Controls.Add(this.txtDescricao);
            this.pnlAgendarServico.Controls.Add(this.lblDescricao);
            this.pnlAgendarServico.Controls.Add(this.lblServico);
            this.pnlAgendarServico.Controls.Add(this.lblTitulo);
            this.pnlAgendarServico.Controls.Add(this.lblAgendar);
            this.pnlAgendarServico.Controls.Add(this.btnLimpar);
            this.pnlAgendarServico.Controls.Add(this.btnSalvar);
            this.pnlAgendarServico.Location = new System.Drawing.Point(55, 16);
            this.pnlAgendarServico.Name = "pnlAgendarServico";
            this.pnlAgendarServico.Size = new System.Drawing.Size(1200, 600);
            this.pnlAgendarServico.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(904, 308);
            this.txtData.Mask = "               00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(226, 26);
            this.txtData.TabIndex = 52;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataServico
            // 
            this.lblDataServico.AutoSize = true;
            this.lblDataServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblDataServico.Location = new System.Drawing.Point(901, 113);
            this.lblDataServico.Name = "lblDataServico";
            this.lblDataServico.Size = new System.Drawing.Size(128, 18);
            this.lblDataServico.TabIndex = 51;
            this.lblDataServico.Text = "DATA SERVIÇO";
            // 
            // mesAgenda
            // 
            this.mesAgenda.Location = new System.Drawing.Point(903, 134);
            this.mesAgenda.MaxSelectionCount = 1;
            this.mesAgenda.Name = "mesAgenda";
            this.mesAgenda.TabIndex = 50;
            this.mesAgenda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mesAgenda_DateChanged);
            // 
            // cmbMecanico
            // 
            this.cmbMecanico.FormattingEnabled = true;
            this.cmbMecanico.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbMecanico.Location = new System.Drawing.Point(826, 428);
            this.cmbMecanico.Name = "cmbMecanico";
            this.cmbMecanico.Size = new System.Drawing.Size(305, 21);
            this.cmbMecanico.TabIndex = 7;
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMecanico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblMecanico.Location = new System.Drawing.Point(823, 407);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(96, 18);
            this.lblMecanico.TabIndex = 49;
            this.lblMecanico.Text = "MECÂNICO";
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbServico.Location = new System.Drawing.Point(161, 134);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(699, 21);
            this.cmbServico.TabIndex = 0;
            // 
            // cmbVeiculo
            // 
            this.cmbVeiculo.FormattingEnabled = true;
            this.cmbVeiculo.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbVeiculo.Location = new System.Drawing.Point(161, 364);
            this.cmbVeiculo.Name = "cmbVeiculo";
            this.cmbVeiculo.Size = new System.Drawing.Size(493, 21);
            this.cmbVeiculo.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(672, 364);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(458, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProprietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblProprietario.Location = new System.Drawing.Point(669, 343);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(131, 18);
            this.lblProprietario.TabIndex = 45;
            this.lblProprietario.Text = "PROPRIETÁRIO";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(443, 428);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(152, 20);
            this.txtValor.TabIndex = 5;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblValor.Location = new System.Drawing.Point(440, 407);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(62, 18);
            this.lblValor.TabIndex = 43;
            this.lblValor.Text = "VALOR";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblVeiculo.Location = new System.Drawing.Point(158, 343);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(79, 18);
            this.lblVeiculo.TabIndex = 41;
            this.lblVeiculo.Text = "VEÍCULO";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(615, 428);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(192, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::autoMestreJuan.Properties.Resources.sair;
            this.btnSair.Location = new System.Drawing.Point(1144, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 34);
            this.btnSair.TabIndex = 39;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblStatus.Location = new System.Drawing.Point(612, 407);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 18);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "STATUS";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(161, 428);
            this.txtKm.MaxLength = 10;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(263, 20);
            this.txtKm.TabIndex = 4;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblKm.Location = new System.Drawing.Point(158, 407);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(33, 18);
            this.lblKm.TabIndex = 32;
            this.lblKm.Text = "KM";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(161, 196);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(699, 130);
            this.txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblDescricao.Location = new System.Drawing.Point(158, 175);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(105, 18);
            this.lblDescricao.TabIndex = 26;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblServico.Location = new System.Drawing.Point(158, 113);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(81, 18);
            this.lblServico.TabIndex = 24;
            this.lblServico.Text = "SERVIÇO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 600);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "S\r\nE\r\nR\r\nV\r\nI\r\nÇ\r\nO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgendar
            // 
            this.lblAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(92)))), ((int)(((byte)(41)))));
            this.lblAgendar.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.lblAgendar.Location = new System.Drawing.Point(100, 0);
            this.lblAgendar.Name = "lblAgendar";
            this.lblAgendar.Size = new System.Drawing.Size(1100, 82);
            this.lblAgendar.TabIndex = 22;
            this.lblAgendar.Text = "AGENDAR";
            this.lblAgendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(29)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(748, 531);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(201, 34);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(29)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(353, 531);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(201, 34);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmAgendarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1311, 632);
            this.Controls.Add(this.pnlAgendarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar";
            this.TransparencyKey = System.Drawing.Color.NavajoWhite;
            this.Load += new System.EventHandler(this.frmAgendarServico_Load);
            this.pnlAgendarServico.ResumeLayout(false);
            this.pnlAgendarServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgendarServico;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblDataServico;
        private System.Windows.Forms.MonthCalendar mesAgenda;
        private System.Windows.Forms.ComboBox cmbMecanico;
        private System.Windows.Forms.Label lblMecanico;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.ComboBox cmbVeiculo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAgendar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}