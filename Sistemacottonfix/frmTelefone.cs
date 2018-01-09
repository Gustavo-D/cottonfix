using ControllerCottonFix;
using Modelo;
using Modelo.Modelo;
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
    public partial class frmTelefone : Form
    {
        public frmTelefone(frmManterFornecedorClientes form)
        {
            InitializeComponent();
            frm = form;
        }

        frmManterFornecedorClientes frm;

        private void _btgravar_Click(object sender, EventArgs e)
        {
            try
            {
                    Telefone ModelTelefone = new Telefone();

                    ModelTelefone.Descricao = Convert.ToString(_txtDescricao.Text).ToUpper();
                    _txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    ModelTelefone.Numero = Convert.ToInt64(_txtTelefone.Text);
                    ModelTelefone.IdPessoa = frmManterFornecedorClientes._clienteVendedor.IdPessoa;

                    if (ModelTelefone != null)
                    {                       
                        frm.AdicionaTelefone(ModelTelefone);
                        frm.CarregaDGVEnderecoTelefoneParaCadastrar();
                    }              
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void _btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
