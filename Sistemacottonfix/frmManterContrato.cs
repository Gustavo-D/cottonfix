using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Microsoft.Reporting.WebForms;
using System.Diagnostics;
using Modelo.Modelo;
using Modelo;
using ControllerCottonFix;

namespace Sistemacottonfix
{
    public partial class frmManterContrato : Form
    {
        public frmManterContrato(string novoOUeditar)
        {
            _tipo = novoOUeditar.ToUpper();
            InitializeComponent();
        }

        public frmManterContrato()
        {
            InitializeComponent();
        }

        private string _tipo = string.Empty;
        private CtrlContrato ControllerContrato = new CtrlContrato(Conexao.GetInstance);
        private CtrlProdutoContrato ControllerProdutoContrato = new CtrlProdutoContrato(Conexao.GetInstance);
        private CtrlUsuario ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
        private CtrlStatus ControllerStatus = new CtrlStatus(Conexao.GetInstance);
        private Pessoa ModelCliente = new Pessoa();
        private Pessoa ModelVendedor = new Pessoa();
        private Contrato ModelContrato = new Contrato();
        private Usuario ModelUsuario = new Usuario();
        private Status ModelStatus = new Status();
        private ICollection<ProdutoContrato> _ProdutosContrato = new List<ProdutoContrato>();

        public void SetCliente(Pessoa cliente)
        {
            ModelCliente = cliente;
        }

        public ICollection<ProdutoContrato> GetListaProdutoContrato
        {
            get
            {
                return _ProdutosContrato;
            }
        }

        public void SetVendedor(Pessoa vendedor)
        {
            ModelVendedor = vendedor;
        }

        public void AtualizaDGV()
        {
            if (_ProdutosContrato.Count > 0)
            {
                _dgvProdutosContrato.DataSource = _ProdutosContrato;
            }
        }

        public bool AdicionarProdutoContrato(ProdutoContrato novo)
        {
            if (novo != null)
            {
                _ProdutosContrato.Add(novo);
                return true;
            }
            return false;
        }

        public bool RemoverProdutoContrato(ProdutoContrato aRemover)
        {
            if (aRemover != null)
            {
                _ProdutosContrato.Remove(aRemover);
                return true;
            }
            return false;
        }

        private void CarregaUsuarios()
        {
            try
            {
                CtrlUsuario ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
                Conexao.Abrir();
                _drpUsuarios.AddItem(" -- Selecione -- ");
                foreach (var i in ControllerUsuario.Listar())
                {
                    _drpUsuarios.AddItem(i.Login);
                }
                _drpUsuarios.selectedIndex = 0;
                Conexao.Fechar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregaStatus()
        {
            try
            {
                _drpStatus.AddItem(" -- Selecione -- ");
                foreach (var i in ControllerStatus.Listar())
                {
                    _drpStatus.AddItem(i.Descricao);
                }
                _drpStatus.selectedIndex = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregaOrigem()
        {
            string estados = "AC,AL,AM,AP,BA,CE,DF,ES,GO,MA,MG,MS,MT,PA,PB,PE,PI,PR,RJ,RN,RO,RR,RS,SC,SE,SP,TO";
            string[] uf = estados.Split(',');
            _drpOrigem.AddItem(" -- Selecione -- ");
            foreach (var i in uf)
            {
                _drpOrigem.AddItem(i);
            }
            _drpOrigem.selectedIndex = 0;
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btmImprimir_Click(object sender, EventArgs e)
        {
            //ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ProcessingMode = ProcessingMode.Local;
            
            ////caminho para o relatório
            //reportViewer.LocalReport.ReportPath = "rptContrato.rdlc";

            ////parametos do relatório
            ////List < ReportParameter > listReportparameter = new List<ReportParameter>();

            ////listReportparameter.Add(new ReportParameter("nome", this.txtnovo.Text));


            ////reportViewer.LocalReport.SetParameters(listReportparameter);

            //Warning[] warnings;
            //string[] streamids;
            //string mineType = "";
            //string encoding = "";
            //string extension = "";

            //byte[] bytePdf = reportViewer.LocalReport.Render("Pdf", null, out mineType, out encoding, out extension, out streamids, out warnings);

            //FileStream fileStreamPdf = null;
            //string nomeArquivoPdf = Path.GetTempPath() + "Contrato"
            //    + DateTime.Now.ToString("dd_MM_yyyy_-HH_mm_ss") + ".pdf";
            //fileStreamPdf = new FileStream(nomeArquivoPdf, FileMode.Create);
            //fileStreamPdf.Write(bytePdf, 0, bytePdf.Length);
            //fileStreamPdf.Close();

            ////abre o arquivo
            //Process.Start(nomeArquivoPdf);
        }

        private void _btnPesquisarVendedor_Click(object sender, EventArgs e)
        {
            frmPesquisaCliVen frm = new frmPesquisaCliVen(this,"vendedor");
            frm.Show();
            frm.Focus();
        }

        private void _btnPesquisarCLiente_Click(object sender, EventArgs e)
        {
            frmPesquisaCliVen frm = new frmPesquisaCliVen(this,"cliente");
            frm.Show();
            frm.Focus();
        }

        private void btmCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnCarga_Click(object sender, EventArgs e)
        {
            frmManterProdutoContrato frm = new frmManterProdutoContrato(this);
            frm.Show();
            frm.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {   
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    string dataPorExtenso = _dateContrato.Value.ToString("dd {0} MMMM {1} yyyy");
                    string data = string.Format(dataPorExtenso, "de", "de");

                    ModelUsuario = ControllerUsuario.Pesquisarlogin(_drpUsuarios.selectedValue);
                    ModelContrato.IdUsuario = ModelUsuario.IdUsuario;
                    ModelContrato.IdCliente = ModelCliente.IdPessoa;
                    ModelContrato.IdVendedor = ModelVendedor.IdPessoa;
                    if (_drpStatus.selectedIndex > 0)
                        ModelContrato.IdContratoStatus = _drpStatus.selectedIndex;
                    ModelContrato.Numero = _txtNumeroContrato.Text;
                    ModelContrato.RegistroBBM = Convert.ToInt32(_txtRegistroBBM.Text);
                    ModelContrato.CondicaoPagamento = _txtFormaPagamento.Text;
                    ModelContrato.Observacao = _txtObservacoes.Text;
                    ModelContrato.EnderecoCliente = _drpClienteEndereco.selectedValue;
                    ModelContrato.ValorTotal = Convert.ToDouble(_txtTotalContrato.Text);
                    ModelContrato.Embarque = _txtEmbarque.Text;
                    ModelContrato.Data = _dateContrato.Value.ToString("dd/MM/yyyy");
                    ModelContrato.Origem = _drpOrigem.selectedValue;
                    ModelContrato.EnderecoCobranca = _drpEnderecoCobranca.selectedValue;
                    ModelContrato.EnderecoEntrega = _drpEnderecoEntrega.selectedValue;
                    ModelContrato.Retirada = _txtRetirada.Text;
                    ModelContrato.EnderecoVendedor = _drpVendedorEndereco.selectedValue;

                    if (ModelContrato.IdCliente > 0 && ModelContrato.IdVendedor > 0 && ModelContrato.IdUsuario > 0)
                    {
                        Contrato novo = ControllerContrato.Criar(ModelContrato);
                        if (novo != null)
                        {
                            //if(SUCESSO)
                            //{
                            int ultimoID = ControllerContrato.BuscaUltimoIdContrato();
                            Contrato existente = ControllerContrato.PesquisarCodigo(ultimoID);
                            if (existente.IdContrato == ultimoID)
                            {
                                foreach (var i in _ProdutosContrato)
                                {
                                    i.IdContrato = existente.IdContrato;
                                    ControllerProdutoContrato.Criar(i);
                                }
                            }
                            //}
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void frmManterContrato_Load(object sender, EventArgs e)
        {
            CarregaOrigem();
            CarregaStatus();
            CarregaUsuarios();
        }
            
        private void _dgvProdutosContrato_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double soma = 0;
            foreach (DataGridViewRow i in _dgvProdutosContrato.Rows)
            {
                soma += Convert.ToDouble(i.Cells["ValorTotal"].Value);
            }
            _txtTotalContrato.Text = soma.ToString("C");
        }
                
    }
}