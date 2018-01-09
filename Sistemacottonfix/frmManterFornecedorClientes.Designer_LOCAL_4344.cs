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
            this._txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._txtCpfCnpj = new System.Windows.Forms.TextBox();
            this._txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._chkAtivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._dgvTelefones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cb_descricao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txt_ddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._radVendedor = new System.Windows.Forms.RadioButton();
            this._radCliente = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._txtObservacao = new System.Windows.Forms.TextBox();
            this._txtNomeFantasia = new System.Windows.Forms.TextBox();
            this._lblNomeFantasia = new System.Windows.Forms.Label();
            this._txtEnderecoEmail = new System.Windows.Forms.TextBox();
            this._lblEnderecoEmail = new System.Windows.Forms.Label();
            this._tbEndereco = new System.Windows.Forms.TabControl();
            this._tpDadosgerais = new System.Windows.Forms.TabPage();
            this._tpEnderecos = new System.Windows.Forms.TabPage();
            this._gpRazao = new System.Windows.Forms.GroupBox();
            this._tpTelefones = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btaddendereco = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnConcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btmclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvTelefones)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this._tbEndereco.SuspendLayout();
            this._tpDadosgerais.SuspendLayout();
            this._tpEnderecos.SuspendLayout();
            this._gpRazao.SuspendLayout();
            this._tpTelefones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox3.Controls.Add(this._txtInscricaoEstadual);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox3.Controls.Add(this._txtRazaoSocial);
            this.groupBox3.Controls.Add(this._lblEnderecoEmail);
            this.groupBox3.Controls.Add(this._txtEnderecoEmail);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox3.Controls.Add(this._txtCpfCnpj);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.Location = new System.Drawing.Point(4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 192);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Cliente";
            // 
            // _txtInscricaoEstadual
            // 
            this._txtInscricaoEstadual.Location = new System.Drawing.Point(267, 95);
            this._txtInscricaoEstadual.Name = "_txtInscricaoEstadual";
            this._txtInscricaoEstadual.Size = new System.Drawing.Size(204, 24);
            this._txtInscricaoEstadual.TabIndex = 40;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(273, 72);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(129, 18);
            this.bunifuCustomLabel6.TabIndex = 39;
            this.bunifuCustomLabel6.Text = "Inscrição Estadual";
            // 
            // _txtCpfCnpj
            // 
            this._txtCpfCnpj.Location = new System.Drawing.Point(10, 95);
            this._txtCpfCnpj.Name = "_txtCpfCnpj";
            this._txtCpfCnpj.Size = new System.Drawing.Size(226, 24);
            this._txtCpfCnpj.TabIndex = 38;
            // 
            // _txtRazaoSocial
            // 
            this._txtRazaoSocial.Location = new System.Drawing.Point(10, 45);
            this._txtRazaoSocial.Name = "_txtRazaoSocial";
            this._txtRazaoSocial.Size = new System.Drawing.Size(548, 24);
            this._txtRazaoSocial.TabIndex = 28;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._chkAtivo);
            this.groupBox2.Location = new System.Drawing.Point(494, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 36);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ativo";
            // 
            // _chkAtivo
            // 
            this._chkAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this._chkAtivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this._chkAtivo.Checked = true;
            this._chkAtivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this._chkAtivo.ForeColor = System.Drawing.Color.White;
            this._chkAtivo.Location = new System.Drawing.Point(8, 11);
            this._chkAtivo.Margin = new System.Windows.Forms.Padding(4);
            this._chkAtivo.Name = "_chkAtivo";
            this._chkAtivo.Size = new System.Drawing.Size(20, 20);
            this._chkAtivo.TabIndex = 41;
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
            // _dgvTelefones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._dgvTelefones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvTelefones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this._dgvTelefones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvTelefones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this._dgvTelefones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvTelefones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_descricao,
            this.txt_ddd,
            this.txt_telefone});
            this._dgvTelefones.DoubleBuffered = false;
            this._dgvTelefones.EnableHeadersVisualStyles = false;
            this._dgvTelefones.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this._dgvTelefones.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this._dgvTelefones.Location = new System.Drawing.Point(6, 19);
            this._dgvTelefones.Name = "_dgvTelefones";
            this._dgvTelefones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._dgvTelefones.Size = new System.Drawing.Size(543, 87);
            this._dgvTelefones.TabIndex = 72;
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
            this.groupBox4.Controls.Add(this._dgvTelefones);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox4.Location = new System.Drawing.Point(4, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 297);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Telefones";
            // 
            // _radVendedor
            // 
            this._radVendedor.AutoSize = true;
            this._radVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this._radVendedor.Location = new System.Drawing.Point(486, 39);
            this._radVendedor.Name = "_radVendedor";
            this._radVendedor.Size = new System.Drawing.Size(89, 22);
            this._radVendedor.TabIndex = 83;
            this._radVendedor.TabStop = true;
            this._radVendedor.Text = "Vendedor";
            this._radVendedor.UseVisualStyleBackColor = true;
            // 
            // _radCliente
            // 
            this._radCliente.AutoSize = true;
            this._radCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._radCliente.Location = new System.Drawing.Point(486, 11);
            this._radCliente.Name = "_radCliente";
            this._radCliente.Size = new System.Drawing.Size(71, 22);
            this._radCliente.TabIndex = 82;
            this._radCliente.TabStop = true;
            this._radCliente.Text = "Cliente";
            this._radCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._txtObservacao);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox5.Location = new System.Drawing.Point(5, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(564, 112);
            this.groupBox5.TabIndex = 75;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observações";
            // 
            // _txtObservacao
            // 
            this._txtObservacao.Location = new System.Drawing.Point(10, 19);
            this._txtObservacao.Multiline = true;
            this._txtObservacao.Name = "_txtObservacao";
            this._txtObservacao.Size = new System.Drawing.Size(548, 87);
            this._txtObservacao.TabIndex = 73;
            this._txtObservacao.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // _txtNomeFantasia
            // 
            this._txtNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNomeFantasia.Location = new System.Drawing.Point(6, 32);
            this._txtNomeFantasia.Name = "_txtNomeFantasia";
            this._txtNomeFantasia.Size = new System.Drawing.Size(456, 26);
            this._txtNomeFantasia.TabIndex = 78;
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
            // _txtEnderecoEmail
            // 
            this._txtEnderecoEmail.Location = new System.Drawing.Point(10, 145);
            this._txtEnderecoEmail.Name = "_txtEnderecoEmail";
            this._txtEnderecoEmail.Size = new System.Drawing.Size(178, 24);
            this._txtEnderecoEmail.TabIndex = 80;
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
            // _tbEndereco
            // 
            this._tbEndereco.Controls.Add(this._tpDadosgerais);
            this._tbEndereco.Controls.Add(this._tpEnderecos);
            this._tbEndereco.Controls.Add(this._tpTelefones);
            this._tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbEndereco.ItemSize = new System.Drawing.Size(70, 30);
            this._tbEndereco.Location = new System.Drawing.Point(12, 127);
            this._tbEndereco.Name = "_tbEndereco";
            this._tbEndereco.SelectedIndex = 0;
            this._tbEndereco.Size = new System.Drawing.Size(584, 424);
            this._tbEndereco.TabIndex = 82;
            // 
            // _tpDadosgerais
            // 
            this._tpDadosgerais.Controls.Add(this.groupBox3);
            this._tpDadosgerais.Controls.Add(this.groupBox5);
            this._tpDadosgerais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tpDadosgerais.Location = new System.Drawing.Point(4, 34);
            this._tpDadosgerais.Name = "_tpDadosgerais";
            this._tpDadosgerais.Padding = new System.Windows.Forms.Padding(3);
            this._tpDadosgerais.Size = new System.Drawing.Size(576, 386);
            this._tpDadosgerais.TabIndex = 0;
            this._tpDadosgerais.Text = "Dados gerais";
            this._tpDadosgerais.UseVisualStyleBackColor = true;
            // 
            // _tpEnderecos
            // 
            this._tpEnderecos.Controls.Add(this.bunifuThinButton22);
            this._tpEnderecos.Controls.Add(this._btaddendereco);
            this._tpEnderecos.Controls.Add(this.dataGridView1);
            this._tpEnderecos.Location = new System.Drawing.Point(4, 34);
            this._tpEnderecos.Name = "_tpEnderecos";
            this._tpEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this._tpEnderecos.Size = new System.Drawing.Size(576, 386);
            this._tpEnderecos.TabIndex = 1;
            this._tpEnderecos.Text = "Endereços";
            this._tpEnderecos.UseVisualStyleBackColor = true;
            // 
            // _gpRazao
            // 
            this._gpRazao.Controls.Add(this._radVendedor);
            this._gpRazao.Controls.Add(this._lblNomeFantasia);
            this._gpRazao.Controls.Add(this._radCliente);
            this._gpRazao.Controls.Add(this._txtNomeFantasia);
            this._gpRazao.Location = new System.Drawing.Point(12, 43);
            this._gpRazao.Name = "_gpRazao";
            this._gpRazao.Size = new System.Drawing.Size(584, 78);
            this._gpRazao.TabIndex = 83;
            this._gpRazao.TabStop = false;
            // 
            // _tpTelefones
            // 
            this._tpTelefones.Controls.Add(this.bunifuThinButton21);
            this._tpTelefones.Controls.Add(this.bunifuThinButton23);
            this._tpTelefones.Controls.Add(this.groupBox4);
            this._tpTelefones.Location = new System.Drawing.Point(4, 34);
            this._tpTelefones.Name = "_tpTelefones";
            this._tpTelefones.Padding = new System.Windows.Forms.Padding(3);
            this._tpTelefones.Size = new System.Drawing.Size(576, 386);
            this._tpTelefones.TabIndex = 2;
            this._tpTelefones.Text = "Telefones";
            this._tpTelefones.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logradouro});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(562, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(157, 327);
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
            this._btaddendereco.Location = new System.Drawing.Point(23, 327);
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(144, 324);
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
            this.bunifuThinButton23.Location = new System.Drawing.Point(10, 324);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(124, 40);
            this.bunifuThinButton23.TabIndex = 86;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this._btnCancelar.Location = new System.Drawing.Point(446, 559);
            this._btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(127, 49);
            this._btnCancelar.TabIndex = 77;
            this._btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnCancelar.Click += new System.EventHandler(this.btmcancelar_Click);
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
            this._btnConcluir.Location = new System.Drawing.Point(12, 559);
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
            this.ClientSize = new System.Drawing.Size(608, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._gpRazao);
            this.Controls.Add(this._tbEndereco);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._btnConcluir);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterFornecedorClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterFornecedorClientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmManterFornecedorClientes_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvTelefones)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this._tbEndereco.ResumeLayout(false);
            this._tpDadosgerais.ResumeLayout(false);
            this._tpEnderecos.ResumeLayout(false);
            this._gpRazao.ResumeLayout(false);
            this._gpRazao.PerformLayout();
            this._tpTelefones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtRazaoSocial;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btmclose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox _txtInscricaoEstadual;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox _txtCpfCnpj;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox _chkAtivo;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid _dgvTelefones;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnConcluir;
        private System.Windows.Forms.TextBox _txtObservacao;
        private System.Windows.Forms.DataGridViewComboBoxColumn cb_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_telefone;
        private System.Windows.Forms.Label _lblNomeFantasia;
        private System.Windows.Forms.TextBox _txtNomeFantasia;
        private System.Windows.Forms.Label _lblEnderecoEmail;
        private System.Windows.Forms.TextBox _txtEnderecoEmail;
        private System.Windows.Forms.RadioButton _radVendedor;
        private System.Windows.Forms.RadioButton _radCliente;
        private System.Windows.Forms.TabControl _tbEndereco;
        private System.Windows.Forms.TabPage _tpDadosgerais;
        private System.Windows.Forms.TabPage _tpEnderecos;
        private System.Windows.Forms.GroupBox _gpRazao;
        private System.Windows.Forms.TabPage _tpTelefones;
        private Bunifu.Framework.UI.BunifuThinButton2 _btaddendereco;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}