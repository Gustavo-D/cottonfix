using ControllerCottonFix;
using Modelo;
using ControllerCottonFix.Interfaces;
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemacottonfix
{
    public partial class frmusuarios : Form
    {
        public frmusuarios()
        {
            this.Opacity = 0.1;
            InitializeComponent();

            qq.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            qq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void frmusuarios_Load(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }

        private void btmincluir_Click(object sender, EventArgs e)
        {
            frmManterUsuarios ManterUsuario = new frmManterUsuarios();
            ManterUsuario.Show();
        }

        public void btmeditar_Click(object sender, EventArgs e)
        {
            try
            {
                frmManterUsuarios ManterUsuario = new frmManterUsuarios();

                var row = qq.CurrentRow;

                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    Usuario ModelUsuario = new Usuario();

                    ICRUD<Usuario> ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);

                    var codigo = row.Cells["IdUsuario"].Value;
                    ModelUsuario = ControllerUsuario.PesquisarCodigo(Convert.ToInt32(codigo));

                    ManterUsuario._txtLogin.Text = ModelUsuario.Login.ToString();
                    ManterUsuario._drpTipo.Text = ModelUsuario.AcessoDescricao.ToString();
                    ManterUsuario._txtSenha.Text = ModelUsuario.Senha.ToString();
                    ManterUsuario._txtConfirmaSenha.Text = ModelUsuario.Senha.ToString();
                    ManterUsuario._txtTelefone.Text = ModelUsuario.Telefone.ToString();
                    ManterUsuario._txtEmail.Text = ModelUsuario.Email.ToString();
                    ManterUsuario._txtSMTP.Text = ModelUsuario.SMTP.ToString();
                    ManterUsuario._txtPortaSMTP.Text = ModelUsuario.Porta.ToString();
                    if (ModelUsuario.Status == true)
                    {
                        ManterUsuario._chkStatus.Checked = true;
                    }
                    else
                    {
                        ManterUsuario._chkStatus.Checked = false;
                    }

                    ControllerUsuario.Dispose();
                    Conexao.Fechar();
                }

                ManterUsuario.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CarregaDataGridView()
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    ICRUD<Usuario> ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);

                    dgv_usuariosCadastrados.DataSource = ControllerUsuario.Listar();
                    qq.DataSource = ControllerUsuario.Listar();
                    qq.Columns["IdAcesso"].Visible = false;
                    qq.Columns["Porta"].Visible = false;
                    qq.Columns["IdUsuario"].Visible = false;
                    qq.Columns["SMTP"].Visible = false;

                    ControllerUsuario.Dispose();
                    Conexao.Fechar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmusuarios_Enter(object sender, EventArgs e)
        {
            CarregaDataGridView();
        }

        private void btmexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja alterar status de cliente ?","Status Cliente",MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    using (Conexao.GetInstance)
                    {
                        Conexao.Abrir();
                        ICRUD<Usuario> ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
                        Usuario ModelUsuario = new Usuario();

                        var linha = qq.CurrentRow;

                        ModelUsuario.Status= Convert.ToBoolean(linha.Cells["Status"].Value);
                        ModelUsuario.IdUsuario = Convert.ToInt32(linha.Cells["IdUsuario"].Value);
                        ModelUsuario.Login = Convert.ToString(linha.Cells["Login"].Value);
                        ModelUsuario.Senha = Convert.ToString(linha.Cells["Senha"].Value);
                        ModelUsuario.Email = Convert.ToString(linha.Cells["Email"].Value);
                        ModelUsuario.SMTP = Convert.ToString(linha.Cells["SMTP"].Value);
                        ModelUsuario.Porta = Convert.ToInt32(linha.Cells["Porta"].Value);
                        ModelUsuario.Telefone = Convert.ToInt64(linha.Cells["Telefone"].Value);

                        if (ModelUsuario != null)
                        {
                            if (ControllerUsuario.Excluir(ModelUsuario))
                            {
                                CarregaDataGridView();
                                MessageBox.Show("Status do cliente alterado com sucesso.", "Status Cliente", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgv_usuariosCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
