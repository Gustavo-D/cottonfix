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

        private void btmusuarios_Click(object sender, EventArgs e)
        {
            this.pnvisualiza.Controls.Clear();

            frmusuarios newform = new frmusuarios();
            newform.TopLevel = false;
            newform.AutoScroll = true;
            this.Controls.Add(pnvisualiza);
            this.pnvisualiza.Controls.Add(newform);
            newform.Show();
        }
    }
}
