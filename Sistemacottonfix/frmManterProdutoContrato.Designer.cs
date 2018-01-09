namespace Sistemacottonfix
{
    partial class frmManterProdutoContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterProdutoContrato));
            this._txtMercadoria = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this._txtSafra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtLote = new System.Windows.Forms.TextBox();
            this._tabelaProduto = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtFardos = new System.Windows.Forms.TextBox();
            this._lblExibeTotalicms = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this._txtTotalQuantidadeKG = new System.Windows.Forms.MaskedTextBox();
            this._lblSubTotal = new System.Windows.Forms.Label();
            this._btnGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this._radPrecoBase = new System.Windows.Forms.RadioButton();
            this._radPrecoLote = new System.Windows.Forms.RadioButton();
            this._txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._txtIcms = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this._drpStatus = new Bunifu.Framework.UI.BunifuDropdown();
            this._tabelaProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtMercadoria
            // 
            this._txtMercadoria.BackColor = System.Drawing.Color.White;
            this._txtMercadoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtMercadoria.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this._txtMercadoria.Location = new System.Drawing.Point(4, 39);
            this._txtMercadoria.Mask = "00-0";
            this._txtMercadoria.Name = "_txtMercadoria";
            this._txtMercadoria.Size = new System.Drawing.Size(154, 13);
            this._txtMercadoria.TabIndex = 0;
            this._txtMercadoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(173, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "MERCADORIA: Algodão em Pluma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SAFRA";
            // 
            // _txtSafra
            // 
            this._txtSafra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtSafra.Location = new System.Drawing.Point(272, 39);
            this._txtSafra.Mask = "00/00";
            this._txtSafra.Name = "_txtSafra";
            this._txtSafra.Size = new System.Drawing.Size(87, 13);
            this._txtSafra.TabIndex = 3;
            this._txtSafra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOTE";
            // 
            // _txtLote
            // 
            this._txtLote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtLote.Location = new System.Drawing.Point(400, 39);
            this._txtLote.Name = "_txtLote";
            this._txtLote.Size = new System.Drawing.Size(92, 13);
            this._txtLote.TabIndex = 5;
            this._txtLote.Text = "0";
            this._txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _tabelaProduto
            // 
            this._tabelaProduto.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._tabelaProduto.ColumnCount = 6;
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.65676F));
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34324F));
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this._tabelaProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tabelaProduto.Controls.Add(this.label3, 3, 0);
            this._tabelaProduto.Controls.Add(this._txtMercadoria, 0, 1);
            this._tabelaProduto.Controls.Add(this._txtLote, 2, 1);
            this._tabelaProduto.Controls.Add(this.label1, 1, 0);
            this._tabelaProduto.Controls.Add(this.label2, 2, 0);
            this._tabelaProduto.Controls.Add(this._txtSafra, 1, 1);
            this._tabelaProduto.Controls.Add(this.label4, 4, 0);
            this._tabelaProduto.Controls.Add(this.bunifuCustomLabel1, 0, 0);
            this._tabelaProduto.Controls.Add(this.label6, 5, 0);
            this._tabelaProduto.Controls.Add(this._txtFardos, 3, 1);
            this._tabelaProduto.Controls.Add(this._lblExibeTotalicms, 5, 2);
            this._tabelaProduto.Controls.Add(this.a, 4, 2);
            this._tabelaProduto.Controls.Add(this._txtTotalQuantidadeKG, 4, 1);
            this._tabelaProduto.Controls.Add(this._lblSubTotal, 5, 1);
            this._tabelaProduto.Location = new System.Drawing.Point(11, 85);
            this._tabelaProduto.Name = "_tabelaProduto";
            this._tabelaProduto.RowCount = 3;
            this._tabelaProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.78688F));
            this._tabelaProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.42623F));
            this._tabelaProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.78689F));
            this._tabelaProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tabelaProduto.Size = new System.Drawing.Size(877, 109);
            this._tabelaProduto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FARDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTIDADE (KG) (LP)APROX.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "SUB-TOTAL";
            // 
            // _txtFardos
            // 
            this._txtFardos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtFardos.Location = new System.Drawing.Point(499, 39);
            this._txtFardos.Name = "_txtFardos";
            this._txtFardos.Size = new System.Drawing.Size(86, 13);
            this._txtFardos.TabIndex = 11;
            this._txtFardos.Text = "0";
            this._txtFardos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtFardos.TextChanged += new System.EventHandler(this._txtFardos_TextChanged);
            // 
            // _lblExibeTotalicms
            // 
            this._lblExibeTotalicms.AutoSize = true;
            this._lblExibeTotalicms.Location = new System.Drawing.Point(747, 73);
            this._lblExibeTotalicms.Name = "_lblExibeTotalicms";
            this._lblExibeTotalicms.Size = new System.Drawing.Size(35, 13);
            this._lblExibeTotalicms.TabIndex = 15;
            this._lblExibeTotalicms.Text = "label9";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(592, 73);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(145, 20);
            this.a.TabIndex = 16;
            this.a.Text = "Total + 12% ICMS:  ";
            // 
            // _txtTotalQuantidadeKG
            // 
            this._txtTotalQuantidadeKG.Location = new System.Drawing.Point(592, 39);
            this._txtTotalQuantidadeKG.Mask = "KG 00.000";
            this._txtTotalQuantidadeKG.Name = "_txtTotalQuantidadeKG";
            this._txtTotalQuantidadeKG.Size = new System.Drawing.Size(100, 20);
            this._txtTotalQuantidadeKG.TabIndex = 19;
            this._txtTotalQuantidadeKG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // _lblSubTotal
            // 
            this._lblSubTotal.AutoSize = true;
            this._lblSubTotal.Location = new System.Drawing.Point(747, 36);
            this._lblSubTotal.Name = "_lblSubTotal";
            this._lblSubTotal.Size = new System.Drawing.Size(35, 13);
            this._lblSubTotal.TabIndex = 20;
            this._lblSubTotal.Text = "label7";
            // 
            // _btnGravar
            // 
            this._btnGravar.ActiveBorderThickness = 1;
            this._btnGravar.ActiveCornerRadius = 20;
            this._btnGravar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btnGravar.ActiveForecolor = System.Drawing.Color.White;
            this._btnGravar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btnGravar.BackColor = System.Drawing.Color.White;
            this._btnGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnGravar.BackgroundImage")));
            this._btnGravar.ButtonText = "Adicionar ao Contrato";
            this._btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnGravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGravar.ForeColor = System.Drawing.Color.SeaGreen;
            this._btnGravar.IdleBorderThickness = 1;
            this._btnGravar.IdleCornerRadius = 20;
            this._btnGravar.IdleFillColor = System.Drawing.Color.White;
            this._btnGravar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this._btnGravar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this._btnGravar.Location = new System.Drawing.Point(338, 202);
            this._btnGravar.Margin = new System.Windows.Forms.Padding(5);
            this._btnGravar.Name = "_btnGravar";
            this._btnGravar.Size = new System.Drawing.Size(222, 41);
            this._btnGravar.TabIndex = 7;
            this._btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnGravar.Click += new System.EventHandler(this._btnGravar_Click);
            // 
            // _btnCancelar
            // 
            this._btnCancelar.ActiveBorderThickness = 1;
            this._btnCancelar.ActiveCornerRadius = 20;
            this._btnCancelar.ActiveFillColor = System.Drawing.Color.Black;
            this._btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this._btnCancelar.ActiveLineColor = System.Drawing.Color.Black;
            this._btnCancelar.BackColor = System.Drawing.Color.White;
            this._btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnCancelar.BackgroundImage")));
            this._btnCancelar.ButtonText = "Cancelar";
            this._btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this._btnCancelar.IdleBorderThickness = 1;
            this._btnCancelar.IdleCornerRadius = 20;
            this._btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this._btnCancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this._btnCancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this._btnCancelar.Location = new System.Drawing.Point(771, 202);
            this._btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(117, 41);
            this._btnCancelar.TabIndex = 8;
            this._btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PREÇO NEGOCIADO";
            // 
            // _radPrecoBase
            // 
            this._radPrecoBase.AutoSize = true;
            this._radPrecoBase.Location = new System.Drawing.Point(270, 12);
            this._radPrecoBase.Name = "_radPrecoBase";
            this._radPrecoBase.Size = new System.Drawing.Size(80, 17);
            this._radPrecoBase.TabIndex = 11;
            this._radPrecoBase.Text = "Preço Base";
            this._radPrecoBase.UseVisualStyleBackColor = true;
            // 
            // _radPrecoLote
            // 
            this._radPrecoLote.AutoSize = true;
            this._radPrecoLote.Checked = true;
            this._radPrecoLote.Location = new System.Drawing.Point(388, 12);
            this._radPrecoLote.Name = "_radPrecoLote";
            this._radPrecoLote.Size = new System.Drawing.Size(70, 17);
            this._radPrecoLote.TabIndex = 12;
            this._radPrecoLote.TabStop = true;
            this._radPrecoLote.Text = "Pelo Lote";
            this._radPrecoLote.UseVisualStyleBackColor = true;
            // 
            // _txtPreco
            // 
            this._txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtPreco.Location = new System.Drawing.Point(126, 14);
            this._txtPreco.Mask = "0.0000";
            this._txtPreco.Name = "_txtPreco";
            this._txtPreco.Size = new System.Drawing.Size(100, 13);
            this._txtPreco.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "VALOR ICMS";
            // 
            // _txtIcms
            // 
            this._txtIcms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtIcms.Enabled = false;
            this._txtIcms.Location = new System.Drawing.Point(126, 52);
            this._txtIcms.Mask = "00%";
            this._txtIcms.Name = "_txtIcms";
            this._txtIcms.Size = new System.Drawing.Size(100, 13);
            this._txtIcms.TabIndex = 15;
            this._txtIcms.Text = "12";
            this._txtIcms.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.CausesValidation = false;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(627, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 17);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "Status";
            // 
            // _drpStatus
            // 
            this._drpStatus.BackColor = System.Drawing.Color.Transparent;
            this._drpStatus.BorderRadius = 3;
            this._drpStatus.ForeColor = System.Drawing.Color.White;
            this._drpStatus.Items = new string[0];
            this._drpStatus.Location = new System.Drawing.Point(630, 30);
            this._drpStatus.Name = "_drpStatus";
            this._drpStatus.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this._drpStatus.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this._drpStatus.selectedIndex = -1;
            this._drpStatus.Size = new System.Drawing.Size(258, 35);
            this._drpStatus.TabIndex = 17;
            // 
            // frmManterProdutoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 264);
            this.Controls.Add(this._drpStatus);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this._txtIcms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._txtPreco);
            this.Controls.Add(this._radPrecoLote);
            this.Controls.Add(this._radPrecoBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._btnCancelar);
            this.Controls.Add(this._btnGravar);
            this.Controls.Add(this._tabelaProduto);
            this.Name = "frmManterProdutoContrato";
            this.Text = "frmManterProdutoContrato";
            this.Load += new System.EventHandler(this.frmManterProdutoContrato_Load);
            this._tabelaProduto.ResumeLayout(false);
            this._tabelaProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox _txtMercadoria;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox _txtSafra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtLote;
        private System.Windows.Forms.TableLayoutPanel _tabelaProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtFardos;
        private System.Windows.Forms.Label _lblExibeTotalicms;
        private System.Windows.Forms.Label a;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnGravar;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton _radPrecoBase;
        private System.Windows.Forms.RadioButton _radPrecoLote;
        private System.Windows.Forms.MaskedTextBox _txtPreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox _txtIcms;
        private System.Windows.Forms.MaskedTextBox _txtTotalQuantidadeKG;
        private System.Windows.Forms.Label _lblSubTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown _drpStatus;
    }
}