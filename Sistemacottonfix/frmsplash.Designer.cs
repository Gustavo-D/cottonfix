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
            this.senha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbusuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbsenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.user = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pclogo = new System.Windows.Forms.PictureBox();
            this.btmclose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).BeginInit();
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
            this.lbversao.Location = new System.Drawing.Point(352, 198);
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
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.White;
            this.senha.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.senha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.senha.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.senha.BorderThickness = 3;
            this.senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.senha.isPassword = true;
            this.senha.Location = new System.Drawing.Point(220, 359);
            this.senha.Margin = new System.Windows.Forms.Padding(4);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(168, 43);
            this.senha.TabIndex = 2;
            this.senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbusuario.Location = new System.Drawing.Point(8, 332);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(86, 25);
            this.lbusuario.TabIndex = 11;
            this.lbusuario.Text = "Usuário";
            // 
            // lbsenha
            // 
            this.lbsenha.AutoSize = true;
            this.lbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbsenha.Location = new System.Drawing.Point(215, 332);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(74, 25);
            this.lbsenha.TabIndex = 12;
            this.lbsenha.Text = "Senha";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.White;
            this.user.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.user.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.user.BorderThickness = 3;
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user.isPassword = false;
            this.user.Location = new System.Drawing.Point(13, 359);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(168, 43);
            this.user.TabIndex = 1;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user.OnValueChanged += new System.EventHandler(this.txtUsername_OnValueChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 20;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.ButtonText = "Entrar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnEntrar.IdleBorderThickness = 1;
            this.btnEntrar.IdleCornerRadius = 20;
            this.btnEntrar.IdleFillColor = System.Drawing.Color.White;
            this.btnEntrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnEntrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(158)))), ((int)(((byte)(68)))));
            this.btnEntrar.Location = new System.Drawing.Point(412, 353);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(145, 45);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // pclogo
            // 
            this.pclogo.Image = global::Sistemacottonfix.Properties.Resources.splash;
            this.pclogo.Location = new System.Drawing.Point(12, -17);
            this.pclogo.Name = "pclogo";
            this.pclogo.Size = new System.Drawing.Size(562, 420);
            this.pclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pclogo.TabIndex = 6;
            this.pclogo.TabStop = false;
            this.pclogo.Click += new System.EventHandler(this.pclogo_Click);
            // 
            // btmclose
            // 
            this.btmclose.BackColor = System.Drawing.Color.Transparent;
            this.btmclose.Image = global::Sistemacottonfix.Properties.Resources.close2;
            this.btmclose.ImageActive = null;
            this.btmclose.Location = new System.Drawing.Point(547, 4);
            this.btmclose.Name = "btmclose";
            this.btmclose.Size = new System.Drawing.Size(19, 25);
            this.btmclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmclose.TabIndex = 14;
            this.btmclose.TabStop = false;
            this.btmclose.Zoom = 10;
            this.btmclose.Click += new System.EventHandler(this.btmclose_Click);
            // 
            // frmsplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 422);
            this.Controls.Add(this.btmclose);
            this.Controls.Add(this.user);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.pbload2);
            this.Controls.Add(this.lbversao);
            this.Controls.Add(this.pclogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btmclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerload;
        private System.Windows.Forms.Label lbversao;
        private Bunifu.Framework.UI.BunifuProgressBar pbload2;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox pclogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox senha;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private Bunifu.Framework.UI.BunifuCustomLabel lbusuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lbsenha;
        private Bunifu.Framework.UI.BunifuMetroTextbox user;
        private Bunifu.Framework.UI.BunifuImageButton btmclose;
    }
}

