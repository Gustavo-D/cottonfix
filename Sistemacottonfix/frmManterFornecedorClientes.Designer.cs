namespace Sistemacottonfix
{
    partial class frmManterFornecedorClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterFornecedorClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._txtPesInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._txtPesRazaoSocial = new System.Windows.Forms.TextBox();
            this._lblEnderecoEmail = new System.Windows.Forms.Label();
            this._txtPesEnderecoEmail = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._txtPesCpfCnpj = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this._chkPesAtivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._dgvTelefoneCliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cb_descricao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_ddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._radPesVendedor = new System.Windows.Forms.RadioButton();
            this._radPesCliente = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._txtPesObservacao = new System.Windows.Forms.TextBox();
            this._txtPesNomeFantasia = new System.Windows.Forms.TextBox();
            this._lblNomeFantasia = new System.Windows.Forms.Label();
            this._tbEndereco = new System.Windows.Forms.TabControl();
            this._tpDadosgerais = new System.Windows.Forms.TabPage();
            this._tpEnderecos = new System.Windows.Forms.TabPage();
            this._dgvEnderecoCliente = new System.Windows.Forms.DataGridView();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tpTelefones = new System.Windows.Forms.TabPage();
            this._gpRazao = new System.Windows.Forms.GroupBox();
            this._btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btaddendereco = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnConcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btmclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvTelefoneCliente)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this._tbEndereco.SuspendLayout();
            this._tpDadosgerais.SuspendLayout();
            this._tpEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvEnderecoCliente)).BeginInit();
            this._tpTelefones.SuspendLayout();
            this._gpRazao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Cliente";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._txtPesInscricaoEstadual);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox3.Controls.Add(this._txtPesRazaoSocial);
            this.groupBox3.Controls.Add(this._lblEnderecoEmail);
            this.groupBox3.Controls.Add(this._txtPesEnderecoEmail);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox3.Controls.Add(this._txtPesCpfCnpj);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.Location = new System.Drawing.Point(4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 192);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Cliente";
            // 
            // _txtPesInscricaoEstadual
            // 
            this._txtPesInscricaoEstadual.Location = new System.Drawing.Point(296, 95);
            this._txtPesInscricaoEstadual.Name = "_txtPesInscricaoEstadual";
            this._txtPesInscricaoEstadual.Size = new System.Drawing.Size(253, 24);
            this._txtPesInscricaoEstadual.TabIndex = 40;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(12, 24);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(148, 18);
            this.bunifuCustomLabel14.TabIndex = 12;
            this.bunifuCustomLabel14.Text = "Nome / Razão social";
            // 
            // _txtPesRazaoSocial
            // 
            this._txtPesRazaoSocial.Location = new System.Drawing.Point(10, 45);
            this._txtPesRazaoSocial.Name = "_txtPesRazaoSocial";
            this._txtPesRazaoSocial.Size = new System.Drawing.Size(539, 24);
            this._txtPesRazaoSocial.TabIndex = 28;
            // 
            // _lblEnderecoEmail
            // 
            this._lblEnderecoEmail.AutoSize = true;
            this._lblEnderecoEmail.Location = new System.Drawing.Point(12, 124);
            this._lblEnderecoEmail.Name = "_lblEnderecoEmail";
            this._lblEnderecoEmail.Size = new System.Drawing.Size(136, 18);
            this._lblEnderecoEmail.TabIndex = 81;
            this._lblEnderecoEmail.Text = "Endereço de e-mail";
            // 
            // _txtPesEnderecoEmail
            // 
            this._txtPesEnderecoEmail.Location = new System.Drawing.Point(10, 145);
            this._txtPesEnderecoEmail.Name = "_txtPesEnderecoEmail";
            this._txtPesEnderecoEmail.Size = new System.Drawing.Size(539, 24);
            this._txtPesEnderecoEmail.TabIndex = 80;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(293, 72);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(129, 18);
            this.bunifuCustomLabel6.TabIndex = 39;
            this.bunifuCustomLabel6.Text = "Inscrição Estadual";
            // 
            // _txtPesCpfCnpj
            // 
            this._txtPesCpfCnpj.Location = new System.Drawing.Point(10, 95);
            this._txtPesCpfCnpj.Name = "_txtPesCpfCnpj";
            this._txtPesCpfCnpj.Size = new System.Drawing.Size(253, 24);
            this._txtPesCpfCnpj.TabIndex = 38;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 74);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 18);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "CPF / CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ativo";
            // 
            // _chkPesAtivo
            // 
            this._chkPesAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this._chkPesAtivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this._chkPesAtivo.Checked = true;
            this._chkPesAtivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this._chkPesAtivo.ForeColor = System.Drawing.Color.White;
            this._chkPesAtivo.Location = new System.Drawing.Point(492, 40);
            this._chkPesAtivo.Margin = new System.Windows.Forms.Padding(4);
            this._chkPesAtivo.Name = "_chkPesAtivo";
            this._chkPesAtivo.Size = new System.Drawing.Size(20, 20);
            this._chkPesAtivo.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btmclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 37);
            this.panel1.TabIndex = 67;
            // 
            // _dgvTelefoneCliente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._dgvTelefoneCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvTelefoneCliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._dgvTelefoneCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvTelefoneCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this._dgvTelefoneCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvTelefoneCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvTelefoneCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvTelefoneCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_descricao,
            this.txt_ddd,
            this.txt_telefone});
            this._dgvTelefoneCliente.DoubleBuffered = false;
            this._dgvTelefoneCliente.EnableHeadersVisualStyles = false;
            this._dgvTelefoneCliente.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this._dgvTelefoneCliente.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this._dgvTelefoneCliente.Location = new System.Drawing.Point(6, 19);
            this._dgvTelefoneCliente.Name = "_dgvTelefoneCliente";
            this._dgvTelefoneCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._dgvTelefoneCliente.Size = new System.Drawing.Size(543, 247);
            this._dgvTelefoneCliente.TabIndex = 72;
            // 
            // cb_descricao
            // 
            this.cb_descricao.FillWeight = 180F;
            this.cb_descricao.HeaderText = "Descrição";
            this.cb_descricao.MinimumWidth = 180;
            this.cb_descricao.Name = "cb_descricao";
            this.cb_descricao.Width = 180;
            // 
            // txt_ddd
            // 
            this.txt_ddd.HeaderText = "ddd";
            this.txt_ddd.MinimumWidth = 50;
            this.txt_ddd.Name = "txt_ddd";
            this.txt_ddd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txt_ddd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txt_ddd.Width = 50;
            // 
            // txt_telefone
            // 
            this.txt_telefone.HeaderText = "Telefone";
            this.txt_telefone.MinimumWidth = 180;
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Width = 180;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._dgvTelefoneCliente);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox4.Location = new System.Drawing.Point(4, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 266);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Telefones";
            // 
            // _radPesVendedor
            // 
            this._radPesVendedor.AutoSize = true;
            this._radPesVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this._radPesVendedor.Location = new System.Drawing.Point(6, 64);
            this._radPesVendedor.Name = "_radPesVendedor";
            this._radPesVendedor.Size = new System.Drawing.Size(89, 22);
            this._radPesVendedor.TabIndex = 83;
            this._radPesVendedor.TabStop = true;
            this._radPesVendedor.Text = "Vendedor";
            this._radPesVendedor.UseVisualStyleBackColor = true;
            // 
            // _radPesCliente
            // 
            this._radPesCliente.AutoSize = true;
            this._radPesCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._radPesCliente.Location = new System.Drawing.Point(101, 64);
            this._radPesCliente.Name = "_radPesCliente";
            this._radPesCliente.Size = new System.Drawing.Size(71, 22);
            this._radPesCliente.TabIndex = 82;
            this._radPesCliente.TabStop = true;
            this._radPesCliente.Text = "Cliente";
            this._radPesCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._txtPesObservacao);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox5.Location = new System.Drawing.Point(9, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(564, 112);
            this.groupBox5.TabIndex = 75;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observações";
            // 
            // _txtPesObservacao
            // 
            this._txtPesObservacao.Location = new System.Drawing.Point(6, 19);
            this._txtPesObservacao.Multiline = true;
            this._txtPesObservacao.Name = "_txtPesObservacao";
            this._txtPesObservacao.Size = new System.Drawing.Size(548, 87);
            this._txtPesObservacao.TabIndex = 73;
            // 
            // _txtPesNomeFantasia
            // 
            this._txtPesNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPesNomeFantasia.Location = new System.Drawing.Point(6, 32);
            this._txtPesNomeFantasia.Name = "_txtPesNomeFantasia";
            this._txtPesNomeFantasia.Size = new System.Drawing.Size(456, 26);
            this._txtPesNomeFantasia.TabIndex = 78;
            // 
            // _lblNomeFantasia
            // 
            this._lblNomeFantasia.AutoSize = true;
            this._lblNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNomeFantasia.Location = new System.Drawing.Point(5, 11);
            this._lblNomeFantasia.Name = "_lblNomeFantasia";
            this._lblNomeFantasia.Size = new System.Drawing.Size(117, 20);
            this._lblNomeFantasia.TabIndex = 79;
            this._lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // _tbEndereco
            // 
            this._tbEndereco.Controls.Add(this._tpDadosgerais);
            this._tbEndereco.Controls.Add(this._tpEnderecos);
            this._tbEndereco.Controls.Add(this._tpTelefones);
            this._tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbEndereco.ItemSize = new System.Drawing.Size(70, 30);
            this._tbEndereco.Location = new System.Drawing.Point(12, 141);
            this._tbEndereco.Name = "_tbEndereco";
            this._tbEndereco.SelectedIndex = 0;
            this._tbEndereco.Size = new System.Drawing.Size(584, 366);
            this._tbEndereco.TabIndex = 82;
            this._tbEndereco.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this._tbEndereco_Deselecting);
            // 
            // _tpDadosgerais
            // 
            this._tpDadosgerais.Controls.Add(this.groupBox3);
            this._tpDadosgerais.Controls.Add(this.groupBox5);
            this._tpDadosgerais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpDadosgerais.Location = new System.Drawing.Point(4, 34);
            this._tpDadosgerais.Name = "_tpDadosgerais";
            this._tpDadosgerais.Padding = new System.Windows.Forms.Padding(3);
            this._tpDadosgerais.Size = new System.Drawing.Size(576, 328);
            this._tpDadosgerais.TabIndex = 0;
            this._tpDadosgerais.Text = "Dados gerais";
            this._tpDadosgerais.UseVisualStyleBackColor = true;
            // 
            // _tpEnderecos
            // 
            this._tpEnderecos.Controls.Add(this.bunifuThinButton22);
            this._tpEnderecos.Controls.Add(this._btaddendereco);
            this._tpEnderecos.Controls.Add(this._dgvEnderecoCliente);
            this._tpEnderecos.Location = new System.Drawing.Point(4, 34);
            this._tpEnderecos.Name = "_tpEnderecos";
            this._tpEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this._tpEnderecos.Size = new System.Drawing.Size(576, 328);
            this._tpEnderecos.TabIndex = 1;
            this._tpEnderecos.Text = "Endereços";
            this._tpEnderecos.UseVisualStyleBackColor = true;
            // 
            // _dgvEnderecoCliente
            // 
            this._dgvEnderecoCliente.AllowUserToAddRows = false;
            this._dgvEnderecoCliente.AllowUserToDeleteRows = false;
            this._dgvEnderecoCliente.BackgroundColor = System.Drawing.Color.White;
            this._dgvEnderecoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvEnderecoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logradouro});
            this._dgvEnderecoCliente.Location = new System.Drawing.Point(5, 6);
            this._dgvEnderecoCliente.Name = "_dgvEnderecoCliente";
            this._dgvEnderecoCliente.ReadOnly = true;
            this._dgvEnderecoCliente.Size = new System.Drawing.Size(562, 266);
            this._dgvEnderecoCliente.TabIndex = 0;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // _tpTelefones
            // 
            this._tpTelefones.Controls.Add(this.bunifuThinButton21);
            this._tpTelefones.Controls.Add(this.bunifuThinButton23);
            this._tpTelefones.Controls.Add(this.groupBox4);
            this._tpTelefones.Location = new System.Drawing.Point(4, 34);
            this._tpTelefones.Name = "_tpTelefones";
            this._tpTelefones.Padding = new System.Windows.Forms.Padding(3);
            this._tpTelefones.Size = new System.Drawing.Size(576, 328);
            this._tpTelefones.TabIndex = 2;
            this._tpTelefones.Text = "Telefones";
            this._tpTelefones.UseVisualStyleBackColor = true;
            // 
            // _gpRazao
            // 
            this._gpRazao.Controls.Add(this.label2);
            this._gpRazao.Controls.Add(this._chkPesAtivo);
            this._gpRazao.Controls.Add(this._radPesVendedor);
            this._gpRazao.Controls.Add(this._lblNomeFantasia);
            this._gpRazao.Controls.Add(this._radPesCliente);
            this._gpRazao.Controls.Add(this._txtPesNomeFantasia);
            this._gpRazao.Location = new System.Drawing.Point(12, 43);
            this._gpRazao.Name = "_gpRazao";
            this._gpRazao.Size = new System.Drawing.Size(584, 92);
            this._gpRazao.TabIndex = 83;
            this._gpRazao.TabStop = false;
            // 
            // _btnCancelar
            // 
            this._btnCancelar.ActiveBorderThickness = 1;
            this._btnCancelar.ActiveCornerRadius = 20;
            this._btnCancelar.ActiveFillColor = System.Drawing.Color.WhiteSmoke;
            this._btnCancelar.ActiveForecolor = System.Drawing.Color.DimGray;
            this._btnCancelar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this._btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnCancelar.BackgroundImage")));
            this._btnCancelar.ButtonText = "Cancelar";
            this._btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._btnCancelar.IdleBorderThickness = 1;
            this._btnCancelar.IdleCornerRadius = 20;
            this._btnCancelar.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this._btnCancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCancelar.Location = new System.Drawing.Point(130, 515);
            this._btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(127, 49);
            this._btnCancelar.TabIndex = 77;
            this._btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnCancelar.Click += new System.EventHandler(this.btmcancelar_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Editar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(139, 280);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(124, 40);
            this.bunifuThinButton22.TabIndex = 85;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btaddendereco
            // 
            this._btaddendereco.ActiveBorderThickness = 1;
            this._btaddendereco.ActiveCornerRadius = 20;
            this._btaddendereco.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btaddendereco.ActiveForecolor = System.Drawing.Color.White;
            this._btaddendereco.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btaddendereco.BackColor = System.Drawing.Color.Transparent;
            this._btaddendereco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btaddendereco.BackgroundImage")));
            this._btaddendereco.ButtonText = "Novo";
            this._btaddendereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btaddendereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btaddendereco.ForeColor = System.Drawing.Color.White;
            this._btaddendereco.IdleBorderThickness = 1;
            this._btaddendereco.IdleCornerRadius = 20;
            this._btaddendereco.IdleFillColor = System.Drawing.Color.Gray;
            this._btaddendereco.IdleForecolor = System.Drawing.Color.White;
            this._btaddendereco.IdleLineColor = System.Drawing.Color.White;
            this._btaddendereco.Location = new System.Drawing.Point(5, 280);
            this._btaddendereco.Margin = new System.Windows.Forms.Padding(5);
            this._btaddendereco.Name = "_btaddendereco";
            this._btaddendereco.Size = new System.Drawing.Size(124, 40);
            this._btaddendereco.TabIndex = 84;
            this._btaddendereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btaddendereco.Click += new System.EventHandler(this._btaddendereco_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Editar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(139, 280);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(124, 40);
            this.bunifuThinButton21.TabIndex = 87;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Novo";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.Location = new System.Drawing.Point(5, 280);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(124, 40);
            this.bunifuThinButton23.TabIndex = 86;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // _btnConcluir
            // 
            this._btnConcluir.ActiveBorderThickness = 1;
            this._btnConcluir.ActiveCornerRadius = 20;
            this._btnConcluir.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btnConcluir.ActiveForecolor = System.Drawing.Color.White;
            this._btnConcluir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btnConcluir.BackColor = System.Drawing.SystemColors.Window;
            this._btnConcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnConcluir.BackgroundImage")));
            this._btnConcluir.ButtonText = "Concluir";
            this._btnConcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnConcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConcluir.ForeColor = System.Drawing.Color.SeaGreen;
            this._btnConcluir.IdleBorderThickness = 1;
            this._btnConcluir.IdleCornerRadius = 20;
            this._btnConcluir.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this._btnConcluir.IdleForecolor = System.Drawing.Color.White;
            this._btnConcluir.IdleLineColor = System.Drawing.Color.White;
            this._btnConcluir.Location = new System.Drawing.Point(267, 515);
            this._btnConcluir.Margin = new System.Windows.Forms.Padding(5);
            this._btnConcluir.Name = "_btnConcluir";
            this._btnConcluir.Size = new System.Drawing.Size(172, 49);
            this._btnConcluir.TabIndex = 76;
            this._btnConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnConcluir.Click += new System.EventHandler(this._btnConcluir_Click);
            // 
            // btmclose
            // 
            this.btmclose.BackColor = System.Drawing.Color.Transparent;
            this.btmclose.Image = global::Sistemacottonfix.Properties.Resources.close2;
            this.btmclose.ImageActive = null;
            this.btmclose.Location = new System.Drawing.Point(568, 4);
            this.btmclose.Name = "btmclose";
            this.btmclose.Size = new System.Drawing.Size(16, 20);
            this.btmclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmclose.TabIndex = 1;
            this.btmclose.TabStop = false;
            this.btmclose.Zoom = 10;
            this.btmclose.Click += new System.EventHandler(this.btmclose_Click);
            // 
            // frmManterFornecedorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(608, 572);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._gpRazao);
            this.Controls.Add(this._tbEndereco);
            this.Controls.Add(this._btnConcluir);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterFornecedorClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterFornecedorClientes";
            this.TopMost = true;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvTelefoneCliente)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this._tbEndereco.ResumeLayout(false);
            this._tpDadosgerais.ResumeLayout(false);
            this._tpEnderecos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvEnderecoCliente)).EndInit();
            this._tpTelefones.ResumeLayout(false);
            this._gpRazao.ResumeLayout(false);
            this._gpRazao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btmclose;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox _chkPesAtivo;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnConcluir;
        private System.Windows.Forms.DataGridViewComboBoxColumn cb_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_telefone;
        private System.Windows.Forms.Label _lblNomeFantasia;
        private System.Windows.Forms.Label _lblEnderecoEmail;
        private System.Windows.Forms.TabControl _tbEndereco;
        private System.Windows.Forms.TabPage _tpDadosgerais;
        private System.Windows.Forms.TabPage _tpEnderecos;
        private System.Windows.Forms.GroupBox _gpRazao;
        private System.Windows.Forms.TabPage _tpTelefones;
        private Bunifu.Framework.UI.BunifuThinButton2 _btaddendereco;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        public System.Windows.Forms.TextBox _txtPesRazaoSocial;
        public System.Windows.Forms.TextBox _txtPesInscricaoEstadual;
        public System.Windows.Forms.TextBox _txtPesCpfCnpj;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox _txtPesObservacao;
        public System.Windows.Forms.TextBox _txtPesNomeFantasia;
        public System.Windows.Forms.TextBox _txtPesEnderecoEmail;
        public System.Windows.Forms.RadioButton _radPesVendedor;
        public System.Windows.Forms.RadioButton _radPesCliente;
        public Bunifu.Framework.UI.BunifuCustomDataGrid _dgvTelefoneCliente;
        public System.Windows.Forms.DataGridView _dgvEnderecoCliente;
    }
}