namespace Sistemacottonfix
{
    partial class frmPesquisaCliVen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaCliVen));
            this._dgvClientesBuscados = new System.Windows.Forms.DataGridView();
            this._txtPesquisa = new Bunifu.Framework.UI.BunifuTextbox();
            this._btnPesquisar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnListar = new Bunifu.Framework.UI.BunifuThinButton2();
            this._btnSelecionar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this._dgvClientesBuscados)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgvClientesBuscados
            // 
            this._dgvClientesBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvClientesBuscados.Location = new System.Drawing.Point(12, 69);
            this._dgvClientesBuscados.Name = "_dgvClientesBuscados";
            this._dgvClientesBuscados.Size = new System.Drawing.Size(760, 252);
            this._dgvClientesBuscados.TabIndex = 0;
            // 
            // _txtPesquisa
            // 
            this._txtPesquisa.BackColor = System.Drawing.Color.Silver;
            this._txtPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_txtPesquisa.BackgroundImage")));
            this._txtPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._txtPesquisa.ForeColor = System.Drawing.Color.SeaGreen;
            this._txtPesquisa.Icon = ((System.Drawing.Image)(resources.GetObject("_txtPesquisa.Icon")));
            this._txtPesquisa.Location = new System.Drawing.Point(12, 12);
            this._txtPesquisa.Name = "_txtPesquisa";
            this._txtPesquisa.Size = new System.Drawing.Size(471, 36);
            this._txtPesquisa.TabIndex = 1;
            this._txtPesquisa.text = "Pesquise pelo nome";
            // 
            // _btnPesquisar
            // 
            this._btnPesquisar.ActiveBorderThickness = 1;
            this._btnPesquisar.ActiveCornerRadius = 20;
            this._btnPesquisar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btnPesquisar.ActiveForecolor = System.Drawing.Color.White;
            this._btnPesquisar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this._btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnPesquisar.BackgroundImage")));
            this._btnPesquisar.ButtonText = "Pesquisar";
            this._btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnPesquisar.ForeColor = System.Drawing.Color.SeaGreen;
            this._btnPesquisar.IdleBorderThickness = 1;
            this._btnPesquisar.IdleCornerRadius = 20;
            this._btnPesquisar.IdleFillColor = System.Drawing.Color.White;
            this._btnPesquisar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this._btnPesquisar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this._btnPesquisar.Location = new System.Drawing.Point(508, 12);
            this._btnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this._btnPesquisar.Name = "_btnPesquisar";
            this._btnPesquisar.Size = new System.Drawing.Size(119, 35);
            this._btnPesquisar.TabIndex = 2;
            this._btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnPesquisar.Click += new System.EventHandler(this._btnPesquisar_Click);
            // 
            // _btnListar
            // 
            this._btnListar.ActiveBorderThickness = 1;
            this._btnListar.ActiveCornerRadius = 20;
            this._btnListar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btnListar.ActiveForecolor = System.Drawing.Color.White;
            this._btnListar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btnListar.BackColor = System.Drawing.SystemColors.Control;
            this._btnListar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnListar.BackgroundImage")));
            this._btnListar.ButtonText = "Listar";
            this._btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnListar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnListar.ForeColor = System.Drawing.Color.SeaGreen;
            this._btnListar.IdleBorderThickness = 1;
            this._btnListar.IdleCornerRadius = 20;
            this._btnListar.IdleFillColor = System.Drawing.Color.White;
            this._btnListar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this._btnListar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this._btnListar.Location = new System.Drawing.Point(637, 12);
            this._btnListar.Margin = new System.Windows.Forms.Padding(5);
            this._btnListar.Name = "_btnListar";
            this._btnListar.Size = new System.Drawing.Size(119, 35);
            this._btnListar.TabIndex = 3;
            this._btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnListar.Click += new System.EventHandler(this._btnListar_Click);
            // 
            // _btnSelecionar
            // 
            this._btnSelecionar.ActiveBorderThickness = 1;
            this._btnSelecionar.ActiveCornerRadius = 20;
            this._btnSelecionar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._btnSelecionar.ActiveForecolor = System.Drawing.Color.White;
            this._btnSelecionar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._btnSelecionar.BackColor = System.Drawing.SystemColors.Control;
            this._btnSelecionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_btnSelecionar.BackgroundImage")));
            this._btnSelecionar.ButtonText = "Selecionar";
            this._btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnSelecionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSelecionar.ForeColor = System.Drawing.Color.SeaGreen;
            this._btnSelecionar.IdleBorderThickness = 1;
            this._btnSelecionar.IdleCornerRadius = 20;
            this._btnSelecionar.IdleFillColor = System.Drawing.Color.White;
            this._btnSelecionar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this._btnSelecionar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this._btnSelecionar.Location = new System.Drawing.Point(597, 327);
            this._btnSelecionar.Margin = new System.Windows.Forms.Padding(5);
            this._btnSelecionar.Name = "_btnSelecionar";
            this._btnSelecionar.Size = new System.Drawing.Size(173, 32);
            this._btnSelecionar.TabIndex = 4;
            this._btnSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnSelecionar.Click += new System.EventHandler(this._btnSelecionar_Click);
            // 
            // frmPesquisaCliVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 369);
            this.Controls.Add(this._btnSelecionar);
            this.Controls.Add(this._btnListar);
            this.Controls.Add(this._btnPesquisar);
            this.Controls.Add(this._txtPesquisa);
            this.Controls.Add(this._dgvClientesBuscados);
            this.Name = "frmPesquisaCliVen";
            this.Text = "frmPesquisaCliVen";
            ((System.ComponentModel.ISupportInitialize)(this._dgvClientesBuscados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvClientesBuscados;
        private Bunifu.Framework.UI.BunifuTextbox _txtPesquisa;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnPesquisar;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnListar;
        private Bunifu.Framework.UI.BunifuThinButton2 _btnSelecionar;
    }
}