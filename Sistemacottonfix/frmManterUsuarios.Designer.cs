namespace Sistemacottonfix
{
    partial class frmManterUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterUsuarios));
            this._drpTipo = new Bunifu.Framework.UI.BunifuDropdown();
            this._txtTelefone = new System.Windows.Forms.TextBox();
            this._txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this._txtSenha = new System.Windows.Forms.TextBox();
            this._txtLogin = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._txtPortaSMTP = new System.Windows.Forms.TextBox();
            this._txtSenhaEmail = new System.Windows.Forms.TextBox();
            this._txtSMTP = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this._btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnConcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this._chkStatus = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).BeginInit();
            this.SuspendLayout();
            // 
            // _drpTipo
            // 
            this._drpTipo.BackColor = System.Drawing.Color.Transparent;
            this._drpTipo.BorderRadius = 3;
            this._drpTipo.ForeColor = System.Drawing.Color.White;
            this._drpTipo.Items = new string[0];
            this._drpTipo.Location = new System.Drawing.Point(10, 94);
            this._drpTipo.Name = "_drpTipo";
            this._drpTipo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this._drpTipo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this._drpTipo.selectedIndex = -1;
            this._drpTipo.Size = new System.Drawing.Size(204, 24);
            this._drpTipo.TabIndex = 33;
            // 
            // _txtTelefone
            // 
            this._txtTelefone.Location = new System.Drawing.Point(9, 190);
            this._txtTelefone.Name = "_txtTelefone";
            this._txtTelefone.Size = new System.Drawing.Size(204, 24);
            this._txtTelefone.TabIndex = 32;
            // 
            // _txtConfirmaSenha
            // 
            this._txtConfirmaSenha.Location = new System.Drawing.Point(239, 142);
            this._txtConfirmaSenha.Name = "_txtConfirmaSenha";
            this._txtConfirmaSenha.Size = new System.Drawing.Size(204, 24);
            this._txtConfirmaSenha.TabIndex = 31;
            // 
            // _txtSenha
            // 
            this._txtSenha.Location = new System.Drawing.Point(9, 142);
            this._txtSenha.Name = "_txtSenha";
            this._txtSenha.Size = new System.Drawing.Size(205, 24);
            this._txtSenha.TabIndex = 30;
            // 
            // _txtLogin
            // 
            this._txtLogin.Location = new System.Drawing.Point(9, 47);
            this._txtLogin.Name = "_txtLogin";
            this._txtLogin.Size = new System.Drawing.Size(205, 24);
            this._txtLogin.TabIndex = 28;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(7, 73);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(110, 18);
            this.bunifuCustomLabel11.TabIndex = 24;
            this.bunifuCustomLabel11.Text = "Tipo de usuário";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(7, 169);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(65, 18);
            this.bunifuCustomLabel12.TabIndex = 22;
            this.bunifuCustomLabel12.Text = "Telefone";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(7, 121);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(50, 18);
            this.bunifuCustomLabel13.TabIndex = 13;
            this.bunifuCustomLabel13.Text = "Senha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._chkStatus);
            this.groupBox3.Controls.Add(this._drpTipo);
            this.groupBox3.Controls.Add(this._txtTelefone);
            this.groupBox3.Controls.Add(this._txtConfirmaSenha);
            this.groupBox3.Controls.Add(this._txtSenha);
            this.groupBox3.Controls.Add(this._txtLogin);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel11);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel12);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel13);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel15);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox3.Location = new System.Drawing.Point(12, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 223);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Usuário";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(7, 26);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(60, 18);
            this.bunifuCustomLabel14.TabIndex = 12;
            this.bunifuCustomLabel14.Text = "Usuário";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(236, 121);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(118, 18);
            this.bunifuCustomLabel15.TabIndex = 14;
            this.bunifuCustomLabel15.Text = "Confirmar senha";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._txtPortaSMTP);
            this.groupBox4.Controls.Add(this._txtSenhaEmail);
            this.groupBox4.Controls.Add(this._txtSMTP);
            this.groupBox4.Controls.Add(this._txtEmail);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel16);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel17);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel18);
            this.groupBox4.Controls.Add(this.bunifuCustomLabel19);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox4.Location = new System.Drawing.Point(12, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 118);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurações de email";
            // 
            // _txtPortaSMTP
            // 
            this._txtPortaSMTP.Location = new System.Drawing.Point(238, 87);
            this._txtPortaSMTP.Name = "_txtPortaSMTP";
            this._txtPortaSMTP.Size = new System.Drawing.Size(204, 24);
            this._txtPortaSMTP.TabIndex = 33;
            // 
            // _txtSenhaEmail
            // 
            this._txtSenhaEmail.Location = new System.Drawing.Point(238, 43);
            this._txtSenhaEmail.Name = "_txtSenhaEmail";
            this._txtSenhaEmail.Size = new System.Drawing.Size(205, 24);
            this._txtSenhaEmail.TabIndex = 34;
            // 
            // _txtSMTP
            // 
            this._txtSMTP.Location = new System.Drawing.Point(8, 87);
            this._txtSMTP.Name = "_txtSMTP";
            this._txtSMTP.Size = new System.Drawing.Size(204, 24);
            this._txtSMTP.TabIndex = 35;
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(8, 43);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(204, 24);
            this._txtEmail.TabIndex = 36;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(239, 22);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(89, 18);
            this.bunifuCustomLabel16.TabIndex = 29;
            this.bunifuCustomLabel16.Text = "Senha email";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(18, 22);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(45, 18);
            this.bunifuCustomLabel17.TabIndex = 15;
            this.bunifuCustomLabel17.Text = "Email";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(239, 66);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(90, 18);
            this.bunifuCustomLabel18.TabIndex = 20;
            this.bunifuCustomLabel18.Text = "Porta SMTP";
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(18, 66);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(50, 18);
            this.bunifuCustomLabel19.TabIndex = 18;
            this.bunifuCustomLabel19.Text = "SMTP";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 76);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 20);
            this.txtUsuario.TabIndex = 58;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btmclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 32);
            this.panel1.TabIndex = 59;
            // 
            // btmclose
            // 
            this.btmclose.BackColor = System.Drawing.Color.Transparent;
            this.btmclose.Image = global::Sistemacottonfix.Properties.Resources.close2;
            this.btmclose.ImageActive = null;
            this.btmclose.Location = new System.Drawing.Point(447, 8);
            this.btmclose.Name = "btmclose";
            this.btmclose.Size = new System.Drawing.Size(16, 20);
            this.btmclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmclose.TabIndex = 1;
            this.btmclose.TabStop = false;
            this.btmclose.Zoom = 10;
            this.btmclose.Click += new System.EventHandler(this.btmclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Usuário";
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
            this._btnCancelar.Location = new System.Drawing.Point(51, 408);
            this._btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(127, 49);
            this._btnCancelar.TabIndex = 65;
            this._btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
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
            this._btnConcluir.Location = new System.Drawing.Point(266, 408);
            this._btnConcluir.Margin = new System.Windows.Forms.Padding(5);
            this._btnConcluir.Name = "_btnConcluir";
            this._btnConcluir.Size = new System.Drawing.Size(172, 49);
            this._btnConcluir.TabIndex = 64;
            this._btnConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnConcluir.Click += new System.EventHandler(this.btmConcluir_Click);
            // 
            // _chkStatus
            // 
            this._chkStatus.AutoSize = true;
            this._chkStatus.Location = new System.Drawing.Point(295, 58);
            this._chkStatus.Name = "_chkStatus";
            this._chkStatus.Size = new System.Drawing.Size(59, 22);
            this._chkStatus.TabIndex = 34;
            this._chkStatus.Text = "Ativo";
            this._chkStatus.UseVisualStyleBackColor = true;
            // 
            // frmManterUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(472, 470);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this._btnConcluir);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterUsuarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmManterUsuarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 _btnCancelar;
        public Bunifu.Framework.UI.BunifuDropdown _drpTipo;
        public System.Windows.Forms.TextBox _txtTelefone;
        public System.Windows.Forms.TextBox _txtConfirmaSenha;
        public System.Windows.Forms.TextBox _txtSenha;
        public System.Windows.Forms.TextBox _txtLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox _txtPortaSMTP;
        public System.Windows.Forms.TextBox _txtSenhaEmail;
        public System.Windows.Forms.TextBox _txtSMTP;
        public System.Windows.Forms.TextBox _txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnConcluir;
        private Bunifu.Framework.UI.BunifuImageButton btmclose;
        public System.Windows.Forms.TextBox txtUsuario;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox _chkStatus;
    }
}