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
using System.Text.RegularExpressions;

namespace Sistemacottonfix
{
    public partial class frmManterUsuarios : Form
    {
        public frmManterUsuarios()
        {
            InitializeComponent();
        }

        private Usuario user = null;
        IPesquisaSimples<Acesso> ControllerAcesso = new CtrlAcesso(Conexao.GetInstance);
        CtrlUsuario ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
        Acesso ModelAcesso = new Acesso();
        Usuario ModelUsuario = new Usuario();

        private bool ValidaEmail(string email)
        {
            bool valido = false;
            try
            {
                Regex expressaoRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                if (expressaoRegex.IsMatch(email))
                {
                    valido = true;
                }
                else
                {
                    valido = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo de e-mail não esta no formato correto!", "Erro e-mail", MessageBoxButtons.OK);
            }
            return valido;
        }

        private void CarregaComboBoxAcesso()
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    _drpTipo.AddItem(" -- Selecione -- ");
                    foreach (Acesso i in ControllerAcesso.Listar())
                    {
                        _drpTipo.AddItem(i.Descricao);
                    }
                    _drpTipo.selectedIndex = 0;

                    Conexao.Fechar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Usuario UsuarioExistente()
        {           
            Usuario ModelUsuario = null;

            var existente = ControllerUsuario.Pesquisarlogin(_txtLogin.Text.ToString());
            if (existente != null)
            {
                return ModelUsuario = existente;
            }
            return ModelUsuario;
        }

        private void LimpaCampos()
        {
            _txtLogin.Clear();
            _txtSenha.Clear();
            _txtConfirmaSenha.Clear();
            _txtEmail.Clear();
            _txtPortaSMTP.Clear();
            _txtSMTP.Clear();
            _txtTelefone.Clear();
            _drpTipo.selectedIndex = 0;
        }

        private bool VerificaControlsVazios()
        {
            bool novo = false;

            foreach (Control i in this.Controls)
            {
                if (i.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrEmpty(i.Text))
                    {
                        return novo = true;
                    }
                }
            }
            return novo;
        }

        private void btmConcluir_Click(object sender, EventArgs e)
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

                    if (_txtLogin.Text.Length > 3 && _txtLogin.Text.Length < 11)
                    {
                        ModelUsuario.Login = _txtLogin.Text.ToString().ToUpper();
                    }
                    else
                    {
                        _mensagemForm = "Login válido: entre 4 e 10 caracteres";
                        _tituloForm = "Login Inválido";
                    }

                    if (_txtSenha.Text.Length > 3 && _txtSenha.Text.Length < 9)
                    {
                        if (_txtSenha.Text.Contains(_txtConfirmaSenha.Text))
                        {
                            ModelUsuario.Senha = _txtSenha.Text.ToString();
                        }
                    }
                    else
                    {
                        _mensagemForm = "Senha válida: entre 4 e 8 caracteres";
                        _tituloForm = "Senha Inválida";
                    }

                    if (ValidaEmail(_txtEmail.Text))
                    {
                        ModelUsuario.Email = _txtEmail.Text.ToString().ToLower();
                    }
                    else
                    {
                        _mensagemForm = "Email válido: xxxx@xxx.xxx";
                        _tituloForm = "Email Inválido";
                    }

                    string tipoAcesso = _drpTipo.selectedValue.ToString();
                    if (tipoAcesso == "-- Selecione --" || _drpTipo.selectedIndex == 0)
                    {
                        _mensagemForm = "Preencha o tipo de acesso corretamente e demais campos.";
                        _tituloForm = "Tipo de Acesso Inválido";
                    }
                    else
                    {
                        ModelAcesso = ControllerAcesso.PesquisarDescricao(_drpTipo.selectedValue.ToString());
                    }

                    ModelUsuario.Telefone = Convert.ToInt64(_txtTelefone.Text);
                    ModelUsuario.IdAcesso = ModelAcesso.IdAcesso;
                    ModelUsuario.AcessoDescricao = ModelAcesso.Descricao.ToUpper();
                    ModelUsuario.SMTP = _txtSMTP.Text.ToString();                   
                    if (_chkStatus.Checked == true)
                    {
                        ModelUsuario.Status = true;
                    }
                    else
                    {
                        ModelUsuario.Status = false;
                    }
                    ModelUsuario.Porta = Convert.ToInt32(_txtPortaSMTP.Text);

                     if (user == null && String.IsNullOrEmpty(_mensagemForm))
                    {
                        Usuario novo = ControllerUsuario.Criar(ModelUsuario);

                        if (novo != null)
                        {
                            _mensagemErroSucesso = "Usuário " + novo.Login + " criado com sucesso !";
                            _tituloErroScesso = "Inserir";
                        }
                    }
                    else if(String.IsNullOrEmpty(_mensagemForm))
                    {
                        ModelUsuario.IdUsuario = user.IdUsuario;

                        if (ControllerUsuario.Atualizar(ModelUsuario))
                        {
                            _mensagemErroSucesso = "Usuário atualizado com sucesso.";
                            _tituloErroScesso = "Atualizar";
                        }
                        else
                        {
                            _mensagemForm = "Verifique se preencheu todos os campos!";
                            _tituloForm = "Formulário Inválido";
                        }
                    }
                    
                }
            }
            catch (ArgumentException)
            {
                if (_txtLogin.Text.Length < 4 && _txtSenha.Text.Length < 4)
                {
                    _mensagemErroSucesso = "Preencha o formulário!";
                    _tituloErroScesso = "Erro cadastro";
                }
                else
                {
                    _mensagemErroSucesso = "Preencha o tipo de acesso do usuário no sistema!";
                    _tituloErroScesso = "Erro cadastro";
                }
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

        private void frmManterUsuarios_Load(object sender, EventArgs e)
        {
            CarregaComboBoxAcesso();
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    var existente = UsuarioExistente();
                    if (existente != null)
                    {
                        user = existente;
                    }

                    Conexao.Fechar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void btmclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}