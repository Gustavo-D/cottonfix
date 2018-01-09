using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerCottonFix;
using Modelo.Modelo;
using Modelo;
using ControllerCottonFix.Interfaces;


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
        private Usuario ModelUsuario = new Usuario();
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

        public int GetIdUsuarioLogado
        {
            get
            {
                return ModelUsuario.IdUsuario;
            }
        }
        private void btentrar_Click(object sender, EventArgs e)
        {
            //Tuple<ulong, ulong?, string> result = new Tuple<ulong, ulong?, string>(0, null, String.Empty);

            //try
            //{
            //    using (Conexao.GetInstance)
            //    {
            //        Conexao.Abrir();
            //        ICRUD<Usuario> ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
            //        Usuario ModelUsuario = new Usuario();
            //        ModelUsuario.Login = user.Text;
            //        ModelUsuario.Senha = senha.Text;
            //        Login login = new Login(ModelUsuario);
            //        result = login.logar(login);
            //        ModelUsuario.IdUsuario = Convert.ToInt32(result.Item1);
            //        Conexao.Fechar();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //if (result.Item1 == 0) //88 retorno 0 e invalido, item1 == IdUsuario
            //{
            //    MessageBox.Show("Usuário ou senha inválidos. Tente novamente.");
            //}
            //else
            //{
            //MessageBox.Show(result.ToString());
            lbsenha.Visible = false;
            lbusuario.Visible = false;
            user.Visible = false;
            senha.Visible = false;
            pbload2.Visible = true;
            btnEntrar.Visible = false;
            timerload.Enabled = true; // Enable the timer.
            timerload.Start();
            timerload.Interval = 250; // The time per tick.
            pbload2.MaximumValue = 6;
            timerload.Tick += new EventHandler(timerload_Tick);
            lbversao.Text = "Versão Alfa 0.1";
            pbload2.ForeColor = Color.FromArgb(190, 184, 81);
            frmprincipal formprincipal = new frmprincipal();            
            //}
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
            //pbload2.ForeColor = Color.FromArgb(190, 184, 81);;
        }

        private void btmclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
