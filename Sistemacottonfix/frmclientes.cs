using ControllerCottonFix;
using Modelo;
using ControllerCottonFix.Interfaces;
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
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        IPesquisaSimples<Vendedor> ControllerVendedor = new CtrlVendedor(Conexao.GetInstance);
        IPesquisaSimples<Cliente> ControllerCliente = new CtrlCliente(Conexao.GetInstance);

        private void CarregaDataGridView()
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    ICRUD<Pessoa> ControllerVendedor = new CtrlPessoa(Conexao.GetInstance);

                    _dgvClienteVendedor.DataSource = ControllerVendedor.Listar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btmincluir_Click(object sender, EventArgs e)
        {
            frmManterFornecedorClientes ManterFornecedorClientes = new frmManterFornecedorClientes();
            ManterFornecedorClientes.Show();
        }

        private void btmeditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmManterFornecedorClientes ManterFornecedorClientes = new frmManterFornecedorClientes();
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    Pessoa ModelPessoa = null;
                    bool vendedor = false;                   

                    int codigo = Convert.ToInt32(_dgvClienteVendedor.CurrentRow.Cells["IdPessoa"].Value);

                    Vendedor vend = ControllerVendedor.PesquisarCodigo(Convert.ToInt32(codigo));
                    if(vend != null)
                    {
                        ModelPessoa = (Vendedor)vend;
                        ModelPessoa.IdPessoa = vend.IdVendedor;
                        vendedor = true;
                    }
                    else
                    {
                        var cli = ControllerCliente.PesquisarCodigo(Convert.ToInt32(codigo));
                        if (cli != null)
                        {
                            ModelPessoa = (Cliente)cli;
                            ModelPessoa.IdPessoa = cli.IdCliente;
                        }
                    }

                    ManterFornecedorClientes._txtPesNomeFantasia.Text = ModelPessoa.Nome.ToString();
                    if (vendedor)
                    {
                        ManterFornecedorClientes._radPesVendedor.Checked = true;
                    }
                    else
                    {
                        ManterFornecedorClientes._radPesCliente.Checked = true;
                    }
                    ManterFornecedorClientes._txtPesRazaoSocial.Text = ModelPessoa.RazaoSocial.ToString();
                    ManterFornecedorClientes._txtPesCpfCnpj.Text = ModelPessoa.CpfCnpj.ToString();
                    ManterFornecedorClientes._txtPesInscricaoEstadual.Text = ModelPessoa.InscricaoEstadual.ToString();
                    ManterFornecedorClientes._txtPesEnderecoEmail.Text = ModelPessoa.EnderecoEmail.ToString();
                    ManterFornecedorClientes._txtPesObservacao.Text = ModelPessoa.Observacao.ToString();

                    ManterFornecedorClientes.CarregaDGVEndecoTelefoneCadastrados(ModelPessoa.IdPessoa);

                    frmManterFornecedorClientes._clienteVendedor = ModelPessoa;
                    
                    ManterFornecedorClientes.Show();
                    Conexao.Fechar();
                }
            }
            catch (Exception)
            {
                throw;
            }           
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }

        private void frmclientes_Enter(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }
    }
}
