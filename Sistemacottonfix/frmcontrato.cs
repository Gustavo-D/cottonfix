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
    public partial class frmcontrato : Form
    {
        public frmcontrato()
        {
            InitializeComponent();
        }

        private void frmcontrato_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void lbusuarios_Click(object sender, EventArgs e)
        {

        }

        private void btmincluir_Click(object sender, EventArgs e)
        {
            frmManterContrato frmmantercontrato = new frmManterContrato("novo");
            frmmantercontrato.ShowDialog(this);
        }

        private void btmeditar_Click(object sender, EventArgs e)
        {
            frmManterContrato frmmantercontrato = new frmManterContrato("editar");
            frmmantercontrato.ShowDialog(this);
        }
    }
}
