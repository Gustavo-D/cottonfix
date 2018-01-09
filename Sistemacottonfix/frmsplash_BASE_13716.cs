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
        private void timerload_Tick(object sender, EventArgs e)
        {
            if (pbload2.Value != 6)
            {
                pbload2.Value++;
            }
            else
            {
                timerload.Stop();
                Close();
                DialogResult = DialogResult.OK;
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
            Login login = new Login(user.Text, senha.Text);
            Tuple<UInt64, UInt64, string> result;
            result = login.logar();
            if (result.Item1 == 0)
            {
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente.");
            }
            else
            { 
                MessageBox.Show(result.ToString());
                lbsenha.Visible = false;
                lbusuario.Visible = false;
                user.Visible = false;
                senha.Visible = false;
                pbload2.Visible = true;
                btnEntrar.Visible = false;
                btnRegistrar.Visible = false;
                timerload.Enabled = true; // Enable the timer.
                timerload.Start();
                timerload.Interval = 1000; // The time per tick.
                pbload2.MaximumValue = 6;
                timerload.Tick += new EventHandler(timerload_Tick);
                lbversao.Text = "Versão Alfa 0.1";
                pbload2.ForeColor = Color.FromArgb(190, 184, 81);
                frmprincipal formprincipal = new frmprincipal();
            }
        }
        private void lbversao_Click(object sender, EventArgs e)
        {

        }
        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //lbsenha.Visible = false;
            //lbusuario.Visible = false;
            //user.Visible = false;
            //senha.Visible = false;
            //pbload2.Visible = true;
            //btnEntrar.Visible = false;
            //btnRegistrar.Visible = false;
            //timerload.Enabled = true; // Enable the timer.
            //timerload.Start();
            //timerload.Interval = 1000; // The time per tick.
            //pbload2.MaximumValue = 6;
            //timerload.Tick += new EventHandler(timerload_Tick);
            //lbversao.Text = "Versão Alfa 0.1";
            //pbload2.ForeColor = Color.FromArgb(190, 184, 81);
            frmRegistrarDemo frmRegistrarDemo = new frmRegistrarDemo();
            frmRegistrarDemo.Show();
        }
    }
}
