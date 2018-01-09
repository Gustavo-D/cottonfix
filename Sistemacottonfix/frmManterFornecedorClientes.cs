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
    public partial class frmManterFornecedorClientes : Form
    {
        public frmManterFornecedorClientes()
        {
            InitializeComponent();
          
            _clienteVendedor = new Pessoa();
            EnderecosParaCadastrado = new List<Endereco>();
            TelefonesParaCadastrado = new List<Telefone>();
        }

        static private List<Endereco> EnderecosParaCadastrado = new List<Endereco>();
        static private List<Telefone> TelefonesParaCadastrado = new List<Telefone>();
        static public Pessoa _clienteVendedor;
        Pessoa ModelPessoa = new Pessoa();
        CtrlPessoa ControllerPessoa = new CtrlPessoa(Conexao.GetInstance);
        CtrlVendedor ControllerVendedor = new CtrlVendedor(Conexao.GetInstance);
        CtrlCliente ControllerCliente = new CtrlCliente(Conexao.GetInstance);
        IAtualizaInsere<Endereco> ControllerEndereco = new CtrlEndereco(Conexao.GetInstance);
        IAtualizaInsere<Telefone> ControllerTelefone = new CtrlTelefone(Conexao.GetInstance);

        public int GetId()
        {            
            return _clienteVendedor.IdPessoa;           
        }

        public void CarregaDGVEndecoTelefoneCadastrados(int idCliente)
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();
                                       
                    _dgvEnderecoCliente.DataSource = ControllerEndereco.ListaPeloId(idCliente);
                    _dgvTelefoneCliente.DataSource = ControllerTelefone.ListaPeloId(idCliente);

                    _dgvEnderecoCliente.Columns["IdPessoa"].Visible = false;
                    _dgvEnderecoCliente.Columns["IdEndereco"].Visible = false;
                    _dgvTelefoneCliente.Columns["IdPessoa"].Visible = false;
                    _dgvTelefoneCliente.Columns["IdTelefone"].Visible = false;

                    Conexao.Fechar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CarregaDGVEnderecoTelefoneParaCadastrar()
        {
            //Inserir linhas no data grid view somente adicionar se ja tiver existentes
            _dgvTelefoneCliente.DataSource = TelefonesParaCadastrado;
            _dgvEnderecoCliente.DataSource = EnderecosParaCadastrado;
        }

        public void AdicionaEndereço(Endereco model)
        {
            if (model != null)
            {
                EnderecosParaCadastrado.Add(model);
            }
        }     
        
        public void AdicionaTelefone(Telefone model)
        {
            if (model != null)
            {
                TelefonesParaCadastrado.Add(model);
            }
        }

        private Pessoa ClienteVendedorExistente()
        {
            Pessoa existente = ControllerPessoa.PesquisarCnpjInscricaoEstadual(Convert.ToInt64(_txtPesCpfCnpj.Text), Convert.ToInt64(_txtPesInscricaoEstadual.Text));           

            if (existente != null)
            {
                return existente;
            }
            return _clienteVendedor;
        }

        private void btmclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnConcluir_Click(object sender, EventArgs e)
        {
            string _mensagemForm = string.Empty;
            string _tituloForm = string.Empty;
            string _mensagemErroSucesso = string.Empty;
            string _tituloErroScesso = string.Empty;

            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();                    

                    ModelPessoa.Nome = Convert.ToString(_txtPesNomeFantasia.Text).ToUpper();
                    ModelPessoa.RazaoSocial = Convert.ToString(_txtPesRazaoSocial.Text).ToUpper();
                    ModelPessoa.CpfCnpj = Convert.ToInt64(_txtPesCpfCnpj.Text);
                    ModelPessoa.InscricaoEstadual = Convert.ToInt64(_txtPesInscricaoEstadual.Text);
                    ModelPessoa.EnderecoEmail = Convert.ToString(_txtPesEnderecoEmail.Text).ToUpper();
                    ModelPessoa.Status = Convert.ToBoolean(_chkPesAtivo.CanSelect);
                    ModelPessoa.Observacao = Convert.ToString(_txtPesObservacao.Text).ToUpper();
                    ModelPessoa._EnderecosCadastrados = EnderecosParaCadastrado;
                    ModelPessoa._TelefonesCadastrados = TelefonesParaCadastrado;
                    if (_radPesVendedor.Checked == false && _radPesCliente.Checked == false)
                    {
                        _mensagemForm = "Verifique se preencheu tipo corretamente!";
                        _tituloForm = "Tipo de cliente";
                    }

                    if (_clienteVendedor.IdPessoa == 0)
                    {
                        _clienteVendedor = ControllerPessoa.Criar(ModelPessoa);                        
                        ModelPessoa = ClienteVendedorExistente();
                        _clienteVendedor.IdPessoa = ModelPessoa.IdPessoa;
                        if (_radPesVendedor.Checked)
                        {
                            ControllerVendedor.Criar(_clienteVendedor.IdPessoa);
                        }
                        else if (_radPesCliente.Checked)
                        {
                            ControllerCliente.Criar(_clienteVendedor.IdPessoa);
                        }

                        if (_clienteVendedor != null)
                        {
                            _mensagemErroSucesso = _clienteVendedor.Nome + " criado com sucesso !";
                            _tituloErroScesso = "Inserir";
                        }

                    }
                    else
                    {
                        ModelPessoa.IdPessoa = _clienteVendedor.IdPessoa;

                        if (ControllerPessoa.Atualizar(ModelPessoa))
                        {
                            _mensagemErroSucesso = "Cliente/Vendedor atualizado com sucesso.";
                            _tituloErroScesso = "Atualizar";
                        }
                        else
                        {
                            _mensagemForm = "Verifique se preencheu todos os campos!";
                            _tituloForm = "Formulário Inválido";
                        }
                    }

                    foreach (Telefone i in TelefonesParaCadastrado)
                    {                        
                        ControllerTelefone.Criar(new Telefone { IdPessoa = _clienteVendedor.IdPessoa, Descricao = i.Descricao, Numero = i.Numero });                        
                    }
                   
                    foreach (Endereco i in EnderecosParaCadastrado)
                    {
                        ControllerEndereco.Criar(new Endereco { IdPessoa = _clienteVendedor.IdPessoa, Rua = i.Rua, Bairro = i.Bairro, CEP = i.CEP, Cidade = i.Cidade, Complemento = i.Complemento, Numero = i.Numero, UF = i.UF, Observacao = i.Observacao });                        
                    }

                    Conexao.Fechar();
                }
            }
            catch (ArgumentException)
            {
                //_mensagemErroSucesso = "Preencha os campos com os valores corretos, texto para texto, números para números!";
                //_tituloErroScesso = "Erro cadastro";
            }
            catch (FormatException)
            {
                _mensagemErroSucesso = "Preencha os campos com os valores corretos, texto para texto, números para números!";
                _tituloErroScesso = "Erro cadastro";
            }
            catch (Exception ex)
            {
                _mensagemErroSucesso = ex.Message;
                _tituloErroScesso = "Erro cadastro";
            }

            if (_mensagemErroSucesso != string.Empty && _tituloErroScesso != string.Empty)
            {
                MessageBox.Show(_mensagemErroSucesso, _tituloErroScesso, MessageBoxButtons.OK);
            }

            if (_mensagemForm != string.Empty && _tituloForm != string.Empty)
            {
                MessageBox.Show(_mensagemForm, _tituloForm, MessageBoxButtons.OK);
            }

        }

        private void _btaddendereco_Click(object sender, EventArgs e)
        {
            frmEndereco frm = new frmEndereco(this);            
            frm.Show();
            frm.Focus();
        }

        private void frmManterFornecedorClientes_Load(object sender, EventArgs e)
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    var existente = ClienteVendedorExistente();
                    if (existente != null)
                    {
                        _clienteVendedor = existente;
                    }

                    Conexao.Fechar();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }      

        private void _tbEndereco_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            CarregaDGVEndecoTelefoneCadastrados(GetId());
            if (_dgvEnderecoCliente.Rows.Count < 1 || _dgvTelefoneCliente.Rows.Count < 1)
            {
                CarregaDGVEnderecoTelefoneParaCadastrar();
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            frmTelefone frm = new frmTelefone(this);
            frm.Show();
            frm.Focus();
        }
    }
}