using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemacottonfix
{
    public partial class frmprincipal : Form
    {
        int X = 0;
        int Y = 0;

        //Botões retirados
        //int frmlogistica = 2; 
        //int frmfinanceiro = 3;
        //int frmfornecedores = 5;
        int frmcontrato = 1;
        int frmclientes = 4;
        int frmprodutos = 6;
        int frmrelatorios = 7;
        int frmusuarios = 8;
        int frmconfiguracoes = 9;
        

        int formulario;
        string titulo;

        private void reloadbotoes()
        {
            btmcontrato.Normalcolor = Color.FromArgb(64, 64, 64);
            btmclientes.Normalcolor = Color.FromArgb(64, 64, 64);
        }

        public void novoform(int formulario)
        {
            this.formulario = formulario;

            this.pnvisualiza.Controls.Clear();

            reloadbotoes();

            if (formulario == frmcontrato)
            {
                btmcontrato.Normalcolor = Color.SeaGreen;
                frmcontrato newform = new frmcontrato();
                titulo = "Contrato";
                newform.TopLevel = false;
                newform.AutoScroll = true;
                this.Controls.Add(pnvisualiza);
                this.pnvisualiza.Controls.Add(newform);
                newform.Show();
            }

            //Botôes retirados do projeto

            //else if (formulario == frmlogistica)
            //{
            //    btmlogistica.Normalcolor = Color.SeaGreen;
            //    frmlogistica newform = new frmlogistica();
            //    titulo = "Logistica";
            //    newform.TopLevel = false;
            //    newform.AutoScroll = true;
            //    this.Controls.Add(pnvisualiza);
            //    this.pnvisualiza.Controls.Add(newform);
            //    newform.Show();
            //}
            //else if (formulario == frmfinanceiro)
            //{
            //    btmfinanceiro.Normalcolor = Color.SeaGreen;
            //    frmfinanceiro newform = new frmfinanceiro();
            //    titulo = "Financeiro";
            //    newform.TopLevel = false;
            //    newform.AutoScroll = true;
            //    this.Controls.Add(pnvisualiza);
            //    this.pnvisualiza.Controls.Add(newform);
            //    newform.Show();
            //}
            else if (formulario == frmclientes)
            {
                btmclientes.Normalcolor = Color.SeaGreen;
                frmclientes newform = new frmclientes();
                titulo = "Clientes";
                newform.TopLevel = false;
                newform.AutoScroll = true;
                this.Controls.Add(pnvisualiza);
                this.pnvisualiza.Controls.Add(newform);
                newform.Show();
            }
            //else if (formulario == frmfornecedores)
            //{
            //    btmfornecedor.Normalcolor = Color.SeaGreen;
            //    frmfornecedores newform = new frmfornecedores();
            //    titulo = "Fornecedores";
            //    newform.TopLevel = false;
            //    newform.AutoScroll = true;
            //    this.Controls.Add(pnvisualiza);
            //    this.pnvisualiza.Controls.Add(newform);
            //    newform.Show();
            //}
            //else if (formulario == frmprodutos)
            //{
            //    btmprodutos.Normalcolor = Color.SeaGreen;
            //    frmprodutos newform = new frmprodutos();
            //    titulo = "Produtos";
            //    newform.TopLevel = false;
            //    newform.AutoScroll = true;
            //    this.Controls.Add(pnvisualiza);
            //    this.pnvisualiza.Controls.Add(newform);
            //    newform.Show();
            //}
            //else if (formulario == frmrelatorios)
            //{
            //    btmrelatorios.Normalcolor = Color.SeaGreen;
            //    frmrelatorios newform = new frmrelatorios();
            //    titulo = "Relatórios";
            //    newform.TopLevel = false;
            //    newform.AutoScroll = true;
            //    this.Controls.Add(pnvisualiza);
            //    this.pnvisualiza.Controls.Add(newform);
            //    newform.Show();
            //}
            else if (formulario == frmusuarios)
            {
                frmusuarios newform = new frmusuarios();
                titulo = "Usuários";
                newform.TopLevel = false;
                newform.AutoScroll = true;
                this.Controls.Add(pnvisualiza);
                this.pnvisualiza.Controls.Add(newform);
                newform.Show();
            }
            //else if (formulario == frmconfiguracoes)
            //{
            //    btmconfiguracoes.Normalcolor = Color.SeaGreen;
            //    frmconfiguracoes newform = new frmconfiguracoes();
            //    titulo = "Configurações";
            //    newform.TopLevel = false;
            //    newform.AutoScroll = true;
            //    this.Controls.Add(pnvisualiza);
            //    this.pnvisualiza.Controls.Add(newform);
            //    newform.Show();
            //}

           
            this.lbtela.Text = titulo;

           
        }



        public frmprincipal()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmprincipal_MouseDown);
            this.MouseMove += new MouseEventHandler(frmprincipal_MouseMove);
        }

        private void frmprincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmprincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            frmlogin newform = new frmlogin();
            newform.TopLevel = false;
            newform.AutoScroll = true;
            this.Controls.Add(pnvisualiza);
            this.pnvisualiza.Controls.Add(newform);
            newform.Show();
            

        }

        private void pnlateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnvisualiza_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void btmusuarios_Click(object sender, EventArgs e)
        {
            this.novoform(frmusuarios);
        }

        private void btmcontrato_Click(object sender, EventArgs e)
        {
            this.novoform(frmcontrato);
        }

        //private void btmlogistica_Click(object sender, EventArgs e)
        //{
        //    this.novoform(frmlogistica);
        //}

        //private void btmfinanceiro_Click(object sender, EventArgs e)
        //{
        //    this.novoform(frmfinanceiro);
        //}

        private void btmclientes_Click(object sender, EventArgs e)
        {
            this.novoform(frmclientes);
        }

        //private void btmfornecedor_Click(object sender, EventArgs e)
        //{
        //    this.novoform(frmfornecedores);
        //}

        private void btmprodutos_Click(object sender, EventArgs e)
        {
            this.novoform(frmprodutos);
        }

        private void btmrelatorios_Click(object sender, EventArgs e)
        {
            this.novoform(frmrelatorios);
        }

        private void btmconfiguracoes_Click(object sender, EventArgs e)
        {
            this.novoform(frmconfiguracoes);
        }
    }
}
