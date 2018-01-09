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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusuarios));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbusuarios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btmincluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btmeditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btmexcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 121);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(987, 456);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(12, 62);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(308, 42);
            this.bunifuTextbox1.TabIndex = 16;
            this.bunifuTextbox1.text = "Bunifu TextBox";
            // 
            // lbusuarios
            // 
            this.lbusuarios.AutoSize = true;
            this.lbusuarios.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuarios.Location = new System.Drawing.Point(7, 9);
            this.lbusuarios.Name = "lbusuarios";
            this.lbusuarios.Size = new System.Drawing.Size(224, 29);
            this.lbusuarios.TabIndex = 17;
            this.lbusuarios.Text = "Cadastro de usuários";
            this.lbusuarios.Click += new System.EventHandler(this.lbusuarios_Click);
            // 
            // btmincluir
            // 
            this.btmincluir.ActiveBorderThickness = 1;
            this.btmincluir.ActiveCornerRadius = 20;
            this.btmincluir.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btmincluir.ActiveForecolor = System.Drawing.Color.White;
            this.btmincluir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btmincluir.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // btmeditar
            // 
            this.btmeditar.ActiveBorderThickness = 1;
            this.btmeditar.ActiveCornerRadius = 20;
            this.btmeditar.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.ActiveForecolor = System.Drawing.Color.White;
            this.btmeditar.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btmeditar.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // btmexcluir
            // 
            this.btmexcluir.ActiveBorderThickness = 1;
            this.btmexcluir.ActiveCornerRadius = 20;
            this.btmexcluir.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.btmexcluir.ActiveForecolor = System.Drawing.Color.White;
            this.btmexcluir.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btmexcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btmexcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmexcluir.BackgroundImage")));
            this.btmexcluir.ButtonText = "Excluir";
            this.btmexcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmexcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmexcluir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btmexcluir.IdleBorderThickness = 1;
            this.btmexcluir.IdleCornerRadius = 20;
            this.btmexcluir.IdleFillColor = System.Drawing.Color.White;
            this.btmexcluir.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btmexcluir.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btmexcluir.Location = new System.Drawing.Point(302, 603);
            this.btmexcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btmexcluir.Name = "btmexcluir";
            this.btmexcluir.Size = new System.Drawing.Size(120, 49);
            this.btmexcluir.TabIndex = 23;
            this.btmexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 671);
            this.Controls.Add(this.btmexcluir);
            this.Controls.Add(this.btmeditar);
            this.Controls.Add(this.btmincluir);
            this.Controls.Add(this.lbusuarios);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmusuarios";
            this.Text = "frmusuarios";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbusuarios;
        private Bunifu.Framework.UI.BunifuThinButton2 btmincluir;
        private Bunifu.Framework.UI.BunifuThinButton2 btmexcluir;
        private Bunifu.Framework.UI.BunifuThinButton2 btmeditar;
    }
}