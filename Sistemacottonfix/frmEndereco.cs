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
    public partial class frmEndereco : Form
    {
        public frmEndereco(frmManterFornecedorClientes form)
        {
            InitializeComponent();
            frm = form;
        }

        frmManterFornecedorClientes frm;

        private void _btgravar_Click(object sender, EventArgs e)
        {
            try
            {               
                    Endereco ModelEndereco = new Endereco();
                    
                    ModelEndereco.Rua = Convert.ToString(_txtRua.Text).ToUpper();
                    ModelEndereco.Numero = Convert.ToInt32(_txtNumero.Text);
                    ModelEndereco.Complemento = Convert.ToString(_txtComplemento.Text).ToUpper();
                    ModelEndereco.Bairro = Convert.ToString(_txtBairro.Text).ToUpper();
                    _txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    ModelEndereco.CEP = Convert.ToInt32(_txtCep.Text);
                    ModelEndereco.Cidade = Convert.ToString(_txtCidade.Text).ToUpper();
                    ModelEndereco.UF = Convert.ToString(_txtUF.Text).ToUpper();
                    ModelEndereco.Observacao = Convert.ToString(_txtObservacao.Text).ToUpper();
                    ModelEndereco.IdPessoa = frmManterFornecedorClientes._clienteVendedor.IdPessoa;

                    if (ModelEndereco != null)
                    {
                        frm.AdicionaEndereço(ModelEndereco);
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
