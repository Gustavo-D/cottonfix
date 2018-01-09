namespace Sistemacottonfix
{
    partial class frmsplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsplash));
            this.timerload = new System.Windows.Forms.Timer(this.components);
            this.lbversao = new System.Windows.Forms.Label();
            this.pbload2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pclogo = new System.Windows.Forms.PictureBox();
            this.dpusuario = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtsenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btentrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbusuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbsenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerload
            // 
            this.timerload.Enabled = true;
            this.timerload.Interval = 200;
            this.timerload.Tick += new System.EventHandler(this.timerload_Tick);
            // 
            // lbversao
            // 
            this.lbversao.AutoSize = true;
            this.lbversao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbversao.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbversao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(190)))), ((int)(((byte)(78)))));
            this.lbversao.Location = new System.Drawing.Point(344, 194);
            this.lbversao.Name = "lbversao";
            this.lbversao.Size = new System.Drawing.Size(191, 36);
            this.lbversao.TabIndex = 3;
            this.lbversao.Text = "Versão Alfa 0.1";
            // 
            // pbload2
            // 
            this.pbload2.BackColor = System.Drawing.Color.Silver;
            this.pbload2.BorderRadius = 5;
            this.pbload2.Location = new System.Drawing.Point(69, 360);
            this.pbload2.MaximumValue = 100;
            this.pbload2.Name = "pbload2";
            this.pbload2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(190)))), ((int)(((byte)(78)))));
            this.pbload2.Size = new System.Drawing.Size(438, 19);
            this.pbload2.TabIndex = 5;
            this.pbload2.Value = 0;
            this.pbload2.progressChanged += new System.EventHandler(this.pbload2_progressChanged);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // pclogo
            // 
            this.pclogo.Image = global::Sistemacottonfix.Properties.Resources.splash;
            this.pclogo.Location = new System.Drawing.Point(12, -17);
            this.pclogo.Name = "pclogo";
            this.pclogo.Size = new System.Drawing.Size(538, 420);
            this.pclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pclogo.TabIndex = 6;
            this.pclogo.TabStop = false;
            this.pclogo.Click += new System.EventHandler(this.pclogo_Click);
            // 
            // dpusuario
            // 
            this.dpusuario.BackColor = System.Drawing.Color.Transparent;
            this.dpusuario.BorderRadius = 3;
            this.dpusuario.ForeColor = System.Drawing.Color.White;
            this.dpusuario.Items = new string[0];
            this.dpusuario.Location = new System.Drawing.Point(12, 360);
            this.dpusuario.Name = "dpusuario";
            this.dpusuario.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.dpusuario.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dpusuario.selectedIndex = -1;
            this.dpusuario.Size = new System.Drawing.Size(180, 43);
            this.dpusuario.TabIndex = 7;
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.White;
            this.txtsenha.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.txtsenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsenha.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.txtsenha.BorderThickness = 3;
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsenha.isPassword = true;
            this.txtsenha.Location = new System.Drawing.Point(220, 360);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(168, 43);
            this.txtsenha.TabIndex = 8;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 310);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(545, 35);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btentrar
            // 
            this.btentrar.ActiveBorderThickness = 1;
            this.btentrar.ActiveCornerRadius = 20;
            this.btentrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btentrar.ActiveForecolor = System.Drawing.Color.White;
            this.btentrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btentrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btentrar.BackgroundImage")));
            this.btentrar.ButtonText = "Entrar";
            this.btentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btentrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btentrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btentrar.IdleBorderThickness = 1;
            this.btentrar.IdleCornerRadius = 20;
            this.btentrar.IdleFillColor = System.Drawing.Color.White;
            this.btentrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btentrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btentrar.Location = new System.Drawing.Point(410, 359);
            this.btentrar.Margin = new System.Windows.Forms.Padding(5);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(145, 45);
            this.btentrar.TabIndex = 9;
            this.btentrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbusuario.Location = new System.Drawing.Point(12, 335);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(78, 22);
            this.lbusuario.TabIndex = 11;
            this.lbusuario.Text = "Usuário";
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsenha.Location = new System.Drawing.Point(226, 334);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(62, 22);
            this.lbsenha.TabIndex = 12;
            this.lbsenha.Text = "Senha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.dpusuario);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.pbload2);
            this.Controls.Add(this.lbversao);
            this.Controls.Add(this.pclogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerload;
        private System.Windows.Forms.Label lbversao;
        private Bunifu.Framework.UI.BunifuProgressBar pbload2;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox pclogo;
        private Bunifu.Framework.UI.BunifuDropdown dpusuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsenha;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btentrar;
        private Bunifu.Framework.UI.BunifuCustomLabel lbusuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lbsenha;
    }
}

