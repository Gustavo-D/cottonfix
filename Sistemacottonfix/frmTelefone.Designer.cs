namespace Sistemacottonfix
{
    partial class frmTelefone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefone));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._lblDescricao = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._txtDescricao = new System.Windows.Forms.TextBox();
            this._gpEndereco = new System.Windows.Forms.GroupBox();
            this._txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this._btgravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._gpEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(219, 21);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(65, 18);
            this.bunifuCustomLabel16.TabIndex = 29;
            this.bunifuCustomLabel16.Text = "Telefone";
            // 
            // _lblDescricao
            // 
            this._lblDescricao.AutoSize = true;
            this._lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this._lblDescricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._lblDescricao.Location = new System.Drawing.Point(3, 21);
            this._lblDescricao.Name = "_lblDescricao";
            this._lblDescricao.Size = new System.Drawing.Size(76, 18);
            this._lblDescricao.TabIndex = 39;
            this._lblDescricao.Text = "Descrição";
            // 
            // _txtDescricao
            // 
            this._txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDescricao.Location = new System.Drawing.Point(6, 42);
            this._txtDescricao.Name = "_txtDescricao";
            this._txtDescricao.Size = new System.Drawing.Size(177, 26);
            this._txtDescricao.TabIndex = 46;
            // 
            // _gpEndereco
            // 
            this._gpEndereco.Controls.Add(this._txtTelefone);
            this._gpEndereco.Controls.Add(this._txtDescricao);
            this._gpEndereco.Controls.Add(this._lblDescricao);
            this._gpEndereco.Controls.Add(this.bunifuCustomLabel16);
            this._gpEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gpEndereco.Location = new System.Drawing.Point(6, -2);
            this._gpEndereco.Name = "_gpEndereco";
            this._gpEndereco.Size = new System.Drawing.Size(368, 88);
            this._gpEndereco.TabIndex = 88;
            this._gpEndereco.TabStop = false;
            this._gpEndereco.Text = "Cadastro de telefone";
            // 
            // _txtTelefone
            // 
            this._txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTelefone.Location = new System.Drawing.Point(222, 42);
            this._txtTelefone.Mask = "(00) 00000-0000";
            this._txtTelefone.Name = "_txtTelefone";
            this._txtTelefone.Size = new System.Drawing.Size(140, 26);
            this._txtTelefone.TabIndex = 47;
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
            this._btgravar.Location = new System.Drawing.Point(31, 94);
            this._btgravar.Margin = new System.Windows.Forms.Padding(5);
            this._btgravar.Name = "_btgravar";
            this._btgravar.Size = new System.Drawing.Size(124, 40);
            this._btgravar.TabIndex = 89;
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
            this._btCancelar.Location = new System.Drawing.Point(224, 94);
            this._btCancelar.Margin = new System.Windows.Forms.Padding(5);
            this._btCancelar.Name = "_btCancelar";
            this._btCancelar.Size = new System.Drawing.Size(124, 40);
            this._btCancelar.TabIndex = 90;
            this._btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btCancelar.Click += new System.EventHandler(this._btCancelar_Click);
            // 
            // frmTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 139);
            this.Controls.Add(this._btgravar);
            this.Controls.Add(this._btCancelar);
            this.Controls.Add(this._gpEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTelefone";
            this._gpEndereco.ResumeLayout(false);
            this._gpEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 _btgravar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 _btCancelar;
        private System.Windows.Forms.GroupBox _gpEndereco;
        private System.Windows.Forms.TextBox _txtDescricao;
        private Bunifu.Framework.UI.BunifuCustomLabel _lblDescricao;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.MaskedTextBox _txtTelefone;
    }
}