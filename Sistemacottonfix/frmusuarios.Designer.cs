namespace Sistemacottonfix
{
    partial class frmusuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_usuariosCadastrados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.seleciona = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbusuarios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btmexcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btmeditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btmincluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qq = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuariosCadastrados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qq)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgv_usuariosCadastrados
            // 
            this.dgv_usuariosCadastrados.AllowUserToAddRows = false;
            this.dgv_usuariosCadastrados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_usuariosCadastrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_usuariosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_usuariosCadastrados.BackgroundColor = System.Drawing.Color.White;
            this.dgv_usuariosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuariosCadastrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuariosCadastrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_usuariosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuariosCadastrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleciona,
            this.codigo,
            this.nome,
            this.cargo,
            this.email,
            this.datacadastro,
            this.inativo});
            this.dgv_usuariosCadastrados.DoubleBuffered = true;
            this.dgv_usuariosCadastrados.EnableHeadersVisualStyles = false;
            this.dgv_usuariosCadastrados.GridColor = System.Drawing.Color.White;
            this.dgv_usuariosCadastrados.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_usuariosCadastrados.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_usuariosCadastrados.Location = new System.Drawing.Point(2, 2);
            this.dgv_usuariosCadastrados.Name = "dgv_usuariosCadastrados";
            this.dgv_usuariosCadastrados.ReadOnly = true;
            this.dgv_usuariosCadastrados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_usuariosCadastrados.Size = new System.Drawing.Size(983, 396);
            this.dgv_usuariosCadastrados.TabIndex = 0;
            // 
            // seleciona
            // 
            this.seleciona.HeaderText = "";
            this.seleciona.Name = "seleciona";
            this.seleciona.ReadOnly = true;
            this.seleciona.Width = 5;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_funcionario";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 55;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.ToolTipText = "Código";
            this.codigo.Width = 55;
            // 
            // nome
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            this.nome.DefaultCellStyle = dataGridViewCellStyle4;
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 300;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 300;
            // 
            // cargo
            // 
            this.cargo.FillWeight = 180F;
            this.cargo.HeaderText = "Cargo";
            this.cargo.MinimumWidth = 180;
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cargo.Width = 180;
            // 
            // email
            // 
            this.email.HeaderText = "e-mail";
            this.email.MinimumWidth = 200;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // datacadastro
            // 
            this.datacadastro.HeaderText = "Data do cadastro";
            this.datacadastro.MinimumWidth = 140;
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.ReadOnly = true;
            this.datacadastro.Width = 140;
            // 
            // inativo
            // 
            this.inativo.HeaderText = "Inativo";
            this.inativo.MinimumWidth = 50;
            this.inativo.Name = "inativo";
            this.inativo.ReadOnly = true;
            this.inativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inativo.Width = 50;
            // 
            // lbusuarios
            // 
            this.lbusuarios.AutoSize = true;
            this.lbusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuarios.Location = new System.Drawing.Point(7, 9);
            this.lbusuarios.Name = "lbusuarios";
            this.lbusuarios.Size = new System.Drawing.Size(261, 29);
            this.lbusuarios.TabIndex = 17;
            this.lbusuarios.Text = "Cadastro de usuários";
            // 
            // btmexcluir
            // 
            this.btmexcluir.ActiveBorderThickness = 1;
            this.btmexcluir.ActiveCornerRadius = 20;
            this.btmexcluir.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.btmexcluir.ActiveForecolor = System.Drawing.Color.White;
            this.btmexcluir.ActiveLineColor = System.Drawing.Color.Firebrick;
            this.btmexcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btmexcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmexcluir.BackgroundImage")));
            this.btmexcluir.ButtonText = "Ativo / Inativo";
            this.btmexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmexcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmexcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btmexcluir.IdleBorderThickness = 1;
            this.btmexcluir.IdleCornerRadius = 20;
            this.btmexcluir.IdleFillColor = System.Drawing.Color.White;
            this.btmexcluir.IdleForecolor = System.Drawing.Color.Firebrick;
            this.btmexcluir.IdleLineColor = System.Drawing.Color.Firebrick;
            this.btmexcluir.Location = new System.Drawing.Point(302, 603);
            this.btmexcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btmexcluir.Name = "btmexcluir";
            this.btmexcluir.Size = new System.Drawing.Size(140, 49);
            this.btmexcluir.TabIndex = 23;
            this.btmexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btmexcluir.Click += new System.EventHandler(this.btmexcluir_Click);
            // 
            // btmeditar
            // 
            this.btmeditar.ActiveBorderThickness = 1;
            this.btmeditar.ActiveCornerRadius = 20;
            this.btmeditar.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.ActiveForecolor = System.Drawing.Color.White;
            this.btmeditar.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.BackColor = System.Drawing.SystemColors.Window;
            this.btmeditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmeditar.BackgroundImage")));
            this.btmeditar.ButtonText = "Editar";
            this.btmeditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmeditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmeditar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.IdleBorderThickness = 1;
            this.btmeditar.IdleCornerRadius = 20;
            this.btmeditar.IdleFillColor = System.Drawing.Color.White;
            this.btmeditar.IdleForecolor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.IdleLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.Location = new System.Drawing.Point(156, 603);
            this.btmeditar.Margin = new System.Windows.Forms.Padding(5);
            this.btmeditar.Name = "btmeditar";
            this.btmeditar.Size = new System.Drawing.Size(120, 49);
            this.btmeditar.TabIndex = 22;
            this.btmeditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btmeditar.Click += new System.EventHandler(this.btmeditar_Click);
            // 
            // btmincluir
            // 
            this.btmincluir.ActiveBorderThickness = 1;
            this.btmincluir.ActiveCornerRadius = 20;
            this.btmincluir.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btmincluir.ActiveForecolor = System.Drawing.Color.White;
            this.btmincluir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btmincluir.BackColor = System.Drawing.SystemColors.Window;
            this.btmincluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmincluir.BackgroundImage")));
            this.btmincluir.ButtonText = "Incluir";
            this.btmincluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmincluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmincluir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btmincluir.IdleBorderThickness = 1;
            this.btmincluir.IdleCornerRadius = 20;
            this.btmincluir.IdleFillColor = System.Drawing.Color.White;
            this.btmincluir.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btmincluir.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btmincluir.Location = new System.Drawing.Point(12, 603);
            this.btmincluir.Margin = new System.Windows.Forms.Padding(5);
            this.btmincluir.Name = "btmincluir";
            this.btmincluir.Size = new System.Drawing.Size(120, 49);
            this.btmincluir.TabIndex = 21;
            this.btmincluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btmincluir.Click += new System.EventHandler(this.btmincluir_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(12, 65);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(345, 42);
            this.bunifuTextbox1.TabIndex = 16;
            this.bunifuTextbox1.text = "Pesquisar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.dgv_usuariosCadastrados);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(12, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 399);
            this.panel1.TabIndex = 26;
            // 
            // qq
            // 
            this.qq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.qq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qq.Location = new System.Drawing.Point(394, 12);
            this.qq.Name = "qq";
            this.qq.ReadOnly = true;
            this.qq.Size = new System.Drawing.Size(603, 150);
            this.qq.TabIndex = 27;
            // 
            // frmusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1011, 671);
            this.Controls.Add(this.qq);
            this.Controls.Add(this.btmexcluir);
            this.Controls.Add(this.btmeditar);
            this.Controls.Add(this.btmincluir);
            this.Controls.Add(this.lbusuarios);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmusuarios";
            this.Text = "frmusuarios";
            this.Load += new System.EventHandler(this.frmusuarios_Load);
            this.Enter += new System.EventHandler(this.frmusuarios_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuariosCadastrados)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv_usuariosCadastrados;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbusuarios;
        private Bunifu.Framework.UI.BunifuThinButton2 btmincluir;
        private Bunifu.Framework.UI.BunifuThinButton2 btmexcluir;
        private Bunifu.Framework.UI.BunifuThinButton2 btmeditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inativo;
        public System.Windows.Forms.DataGridView qq;
    }
}