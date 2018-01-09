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
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbload2.Visible = false;
            timerload.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    
        private void timerload_Tick(object sender, EventArgs e)
        {
            

            if (pbload2.Value != 6)
            {
                pbload2.Value++;
            }
            else
            {
                timerload.Stop();
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

     

        private void pbload2_progressChanged(object sender, EventArgs e)
        {

        }

        private void pclogo_Click(object sender, EventArgs e)
        {
           
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            string senha;
            senha = txtsenha.Text;

            if (senha == "1234")
            {
                dpusuario.Visible = false;
                lbsenha.Visible = false;
                lbusuario.Visible = false;
                txtsenha.Visible = false;
                pbload2.Visible = true;
                btentrar.Visible = false;
                timerload.Enabled = true; // Enable the timer.
                timerload.Start();//Strart it
                timerload.Interval = 1000; // The time per tick.
                pbload2.MaximumValue = 6;
                timerload.Tick += new EventHandler(timerload_Tick);
                lbversao.Text = "Versão Alfa 0.1";
                pbload2.ForeColor = Color.FromArgb(190, 184, 81);
                frmprincipal formprincipal = new frmprincipal();
            }
        }
    }
}
