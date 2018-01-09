namespace Sistemacottonfix
{
    partial class frmEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndereco));
            this._gpEndereco = new System.Windows.Forms.GroupBox();
            this._txtObservacao = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this._txtCep = new System.Windows.Forms.MaskedTextBox();
            this._txtCidade = new System.Windows.Forms.TextBox();
            this._txtUF = new System.Windows.Forms.TextBox();
            this._txtComplemento = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._txtBairro = new System.Windows.Forms.TextBox();
            this._txtRua = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._txtNumero = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this._btgravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._gpEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gpEndereco
            // 
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel1);
            this._gpEndereco.Controls.Add(this._txtObservacao);
            this._gpEndereco.Controls.Add(this._txtCep);
            this._gpEndereco.Controls.Add(this._txtCidade);
            this._gpEndereco.Controls.Add(this._txtUF);
            this._gpEndereco.Controls.Add(this._txtComplemento);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel7);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel5);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel4);
            this._gpEndereco.Controls.Add(this._txtBairro);
            this._gpEndereco.Controls.Add(this._txtRua);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel2);
            this._gpEndereco.Controls.Add(this._txtNumero);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel3);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel16);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel17);
            this._gpEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gpEndereco.Location = new System.Drawing.Point(12, 12);
            this._gpEndereco.Name = "_gpEndereco";
            this._gpEndereco.Size = new System.Drawing.Size(566, 290);
            this._gpEndereco.TabIndex = 70;
            this._gpEndereco.TabStop = false;
            this._gpEndereco.Text = "Cadastro de Endereço";
            // 
            // _txtObservacao
            // 
            this._txtObservacao.BorderColor = System.Drawing.Color.SeaGreen;
            this._txtObservacao.Location = new System.Drawing.Point(13, 202);
            this._txtObservacao.Multiline = true;
            this._txtObservacao.Name = "_txtObservacao";
            this._txtObservacao.Size = new System.Drawing.Size(542, 82);
            this._txtObservacao.TabIndex = 94;
            // 
            // _txtCep
            // 
            this._txtCep.Location = new System.Drawing.Point(13, 142);
            this._txtCep.Mask = "00000-000";
            this._txtCep.Name = "_txtCep";
            this._txtCep.Size = new System.Drawing.Size(90, 26);
            this._txtCep.TabIndex = 93;
            // 
            // _txtCidade
            // 
            this._txtCidade.Location = new System.Drawing.Point(199, 94);
            this._txtCidade.Name = "_txtCidade";
            this._txtCidade.Size = new System.Drawing.Size(177, 26);
            this._txtCidade.TabIndex = 46;
            // 
            // _txtUF
            // 
            this._txtUF.Location = new System.Drawing.Point(389, 94);
            this._txtUF.Name = "_txtUF";
            this._txtUF.Size = new System.Drawing.Size(166, 26);
            this._txtUF.TabIndex = 45;
            // 
            // _txtComplemento
            // 
            this._txtComplemento.Location = new System.Drawing.Point(140, 142);
            this._txtComplemento.Name = "_txtComplemento";
            this._txtComplemento.Size = new System.Drawing.Size(415, 26);
            this._txtComplemento.TabIndex = 44;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(148, 121);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(102, 18);
            this.bunifuCustomLabel7.TabIndex = 43;
            this.bunifuCustomLabel7.Text = "Complemento";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(386, 73);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(55, 18);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "Estado";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(196, 73);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(54, 18);
            this.bunifuCustomLabel4.TabIndex = 39;
            this.bunifuCustomLabel4.Text = "Cidade";
            // 
            // _txtBairro
            // 
            this._txtBairro.Location = new System.Drawing.Point(13, 94);
            this._txtBairro.Name = "_txtBairro";
            this._txtBairro.Size = new System.Drawing.Size(172, 26);
            this._txtBairro.TabIndex = 34;
            // 
            // _txtRua
            // 
            this._txtRua.Location = new System.Drawing.Point(13, 44);
            this._txtRua.Name = "_txtRua";
            this._txtRua.Size = new System.Drawing.Size(428, 26);
            this._txtRua.TabIndex = 28;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 121);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(39, 18);
            this.bunifuCustomLabel2.TabIndex = 37;
            this.bunifuCustomLabel2.Text = "CEP";
            // 
            // _txtNumero
            // 
            this._txtNumero.Location = new System.Drawing.Point(466, 44);
            this._txtNumero.Name = "_txtNumero";
            this._txtNumero.Size = new System.Drawing.Size(89, 26);
            this._txtNumero.TabIndex = 36;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(15, 23);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(72, 18);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Endereço";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(15, 73);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(48, 18);
            this.bunifuCustomLabel16.TabIndex = 29;
            this.bunifuCustomLabel16.Text = "Bairro";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(479, 23);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel17.TabIndex = 15;
            this.bunifuCustomLabel17.Text = "Número";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // _btgravar
            // 
            this._btgravar.ActiveBorderThickness = 1;
            this._btgravar.ActiveCornerRadius = 20;
            this._btgravar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btgravar.ActiveForecolor = System.Drawing.Color.White;
            this._btgravar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btgravar.BackColor = System.Drawing.Color.White;
            this._btgravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btgravar.BackgroundImage")));
            this._btgravar.ButtonText = "Gravar";
            this._btgravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btgravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btgravar.ForeColor = System.Drawing.Color.White;
            this._btgravar.IdleBorderThickness = 1;
            this._btgravar.IdleCornerRadius = 20;
            this._btgravar.IdleFillColor = System.Drawing.Color.Gray;
            this._btgravar.IdleForecolor = System.Drawing.Color.White;
            this._btgravar.IdleLineColor = System.Drawing.Color.White;
            this._btgravar.Location = new System.Drawing.Point(157, 310);
            this._btgravar.Margin = new System.Windows.Forms.Padding(5);
            this._btgravar.Name = "_btgravar";
            this._btgravar.Size = new System.Drawing.Size(124, 40);
            this._btgravar.TabIndex = 91;
            this._btgravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btgravar.Click += new System.EventHandler(this._btgravar_Click);
            // 
            // _btCancelar
            // 
            this._btCancelar.ActiveBorderThickness = 1;
            this._btCancelar.ActiveCornerRadius = 20;
            this._btCancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btCancelar.ActiveForecolor = System.Drawing.Color.White;
            this._btCancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btCancelar.BackColor = System.Drawing.Color.White;
            this._btCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btCancelar.BackgroundImage")));
            this._btCancelar.ButtonText = "Cancelar";
            this._btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this._btCancelar.IdleBorderThickness = 1;
            this._btCancelar.IdleCornerRadius = 20;
            this._btCancelar.IdleFillColor = System.Drawing.Color.Gray;
            this._btCancelar.IdleForecolor = System.Drawing.Color.White;
            this._btCancelar.IdleLineColor = System.Drawing.Color.White;
            this._btCancelar.Location = new System.Drawing.Point(304, 310);
            this._btCancelar.Margin = new System.Windows.Forms.Padding(5);
            this._btCancelar.Name = "_btCancelar";
            this._btCancelar.Size = new System.Drawing.Size(124, 40);
            this._btCancelar.TabIndex = 92;
            this._btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btCancelar.Click += new System.EventHandler(this._btCancelar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(14, 179);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(102, 20);
            this.bunifuCustomLabel1.TabIndex = 95;
            this.bunifuCustomLabel1.Text = "Observações";
            // 
            // frmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 364);
            this.Controls.Add(this._btgravar);
            this.Controls.Add(this._btCancelar);
            this.Controls.Add(this._gpEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEndereco";
            this.Text = "frmEndereco";
            this._gpEndereco.ResumeLayout(false);
            this._gpEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gpEndereco;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 _btgravar;
        private Bunifu.Framework.UI.BunifuThinButton2 _btCancelar;
        public System.Windows.Forms.TextBox _txtCidade;
        public System.Windows.Forms.TextBox _txtUF;
        public System.Windows.Forms.TextBox _txtComplemento;
        public System.Windows.Forms.TextBox _txtBairro;
        public System.Windows.Forms.TextBox _txtRua;
        public System.Windows.Forms.TextBox _txtNumero;
        public System.Windows.Forms.MaskedTextBox _txtCep;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox _txtObservacao;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}