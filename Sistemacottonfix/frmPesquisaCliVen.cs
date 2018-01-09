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
    public partial class frmPesquisaCliVen : Form
    {
        public frmPesquisaCliVen(frmManterContrato form, string clienteOUvendedor)
        {
            InitializeComponent();
            frm = form;
            if (clienteOUvendedor.ToUpper().Contains("CLIENTE"))
            {
                _tipo = 1;
            }
            else if (clienteOUvendedor.ToUpper().Contains("VENDEDOR"))
            {
                _tipo = 2;
            }
        }
        
        private int _tipo = 0;
        private CtrlPessoa ControllerPessoa = new CtrlPessoa(Conexao.GetInstance);
        private CtrlEndereco ControllerEndereco = new CtrlEndereco(Conexao.GetInstance);        
        private Pessoa ModelPessoa = new Pessoa();
        private frmManterContrato frm = new frmManterContrato();

        private void _btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    _dgvClientesBuscados.DataSource = ControllerPessoa.Listar();

                    Conexao.Fechar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void _btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    ICollection<Pessoa> PessoasListadas = new List<Pessoa>();
                    PessoasListadas = ControllerPessoa.Listar(_txtPesquisa.text.ToString());

                    if (PessoasListadas != null)
                    {
                        _dgvClientesBuscados.DataSource = PessoasListadas;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void _btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    int IdPessoa = Convert.ToInt32(_dgvClientesBuscados.CurrentRow.Cells["IdPessoa"].Value);
                    ModelPessoa = ControllerPessoa.PesquisarCodigo(IdPessoa);

                    if (ModelPessoa != null && IdPessoa > 0)
                    {
                        if (_tipo == 1)
                        {
                            frm.SetCliente(ModelPessoa);
                            frm._drpClienteEndereco.AddItem(" -- Selecione -- ");
                            foreach (Endereco i in ControllerEndereco.ListaPeloId(IdPessoa))
                            {
                                frm._drpClienteEndereco.AddItem(i.Rua + ", " + i.Numero + ", " + i.Bairro + ", " + i.Cidade + " - " + i.UF + ", " + i.CEP);
                                frm._drpEnderecoEntrega.AddItem(i.Rua + ", " + i.Numero + ", " + i.Bairro + ", " + i.Cidade + " - " + i.UF + ", " + i.CEP);
                                frm._drpEnderecoCobranca.AddItem(i.Rua + ", " + i.Numero + ", " + i.Bairro + ", " + i.Cidade + " - " + i.UF + ", " + i.CEP);
                            }
                            frm._drpClienteEndereco.selectedIndex = 0;
                            frm._txtClienteNome.Text = (ModelPessoa.Nome + " - Razao Social: " + ModelPessoa.RazaoSocial).ToString();
                            frm._txtClienteCNPJ.Text = ModelPessoa.CpfCnpj.ToString();
                            frm._txtClienteInscricaoEst.Text = ModelPessoa.InscricaoEstadual.ToString();
                        }
                        else if (_tipo == 2)
                        {
                            frm.SetVendedor(ModelPessoa);
                            frm._drpVendedorEndereco.AddItem(" -- Selecione -- ");
                            foreach (Endereco i in ControllerEndereco.ListaPeloId(IdPessoa))
                            {
                                frm._drpVendedorEndereco.AddItem(i.Rua + ", " + i.Numero + ", " + i.Bairro + ", " + i.Cidade + " - " + i.UF + ", " + i.CEP);
                            }
                            frm._drpVendedorEndereco.selectedIndex = 0;
                            frm._txtVendedorNome.Text = (ModelPessoa.Nome + " - Razao Social: " + ModelPessoa.RazaoSocial).ToString();
                            frm._txtVendedorCNPJ.Text = ModelPessoa.CpfCnpj.ToString();
                            frm._txtVendedorInscricaoEst.Text = ModelPessoa.InscricaoEstadual.ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
