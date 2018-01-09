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
    public partial class frmManterProdutoContrato : Form
    {
        public frmManterProdutoContrato(frmManterContrato form)
        {
            InitializeComponent();
            frm = form;
        }
        private frmManterContrato frm = new frmManterContrato();
        private CtrlStatus ControllerStatus = new CtrlStatus(Conexao.GetInstance);
        private ProdutoContrato ModelProdutoContrato = new ProdutoContrato();
        private Status ModelStatus = new Status();
        private double SubTotal = 0;
        
        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] Split(string palavra, bool incluiEspaco)
        {
            if (!incluiEspaco)
                palavra = palavra.Replace(" ", "");

            var array = new string[palavra.Length];

            for (int i = 0; i < array.Length; i++)
                array[i] = palavra[i].ToString();

            return array;

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

        private void _btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();
                    string[] x = _txtMercadoria.Text.Split('-');
                    string k = x[0] + x[1];
                    string[] j = Split(k, false);
                    ModelProdutoContrato.Cor = Convert.ToInt32(j[1]);
                    string y = Convert.ToString(j[0] + j[2]);
                    ModelProdutoContrato.TipoFolha = Convert.ToInt32(y);
                    ModelStatus = ControllerStatus.PesquisarDescricao(_drpStatus.selectedValue);
                    ModelProdutoContrato.IdStatus = ModelStatus.IdStatus;
                    if (_radPrecoBase.Checked)
                    {
                        CtrlAgilDesagilBBM ControllerBBM = new CtrlAgilDesagilBBM(ModelProdutoContrato.TipoFolha, ModelProdutoContrato.Cor, Convert.ToDouble(_txtPreco.Text));
                        ModelProdutoContrato.PrecoNegociado = (ControllerBBM.GetNovoPreco() * 2.2046);
                        ModelProdutoContrato.CondicoesPagamento = _radPrecoBase.Text;
                    }
                    else if (_radPrecoLote.Checked)
                    {
                        ModelProdutoContrato.PrecoNegociado = (Convert.ToDouble(_txtPreco.Text) * 2.2046);
                        ModelProdutoContrato.CondicoesPagamento = _radPrecoLote.Text;
                    }
                    ModelProdutoContrato.Safra = _txtSafra.Text.ToString();
                    ModelProdutoContrato.Fardos = Convert.ToInt32(_txtFardos.Text);
                    ModelProdutoContrato.Quantidade = (ModelProdutoContrato.Fardos * 200);
                    SubTotal = (ModelProdutoContrato.Quantidade * ModelProdutoContrato.PrecoNegociado);
                    ModelProdutoContrato.ICMS = 1.12;
                    ModelProdutoContrato.ValorTotal = (SubTotal * ModelProdutoContrato.ICMS);
                    ModelProdutoContrato.Lote = Convert.ToInt32(_txtLote.Text);

                    if (ModelProdutoContrato != null)
                    {
                        frm.AdicionarProdutoContrato(ModelProdutoContrato);
                        frm.AtualizaDGV();
                    }
                    Conexao.Fechar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void _txtFardos_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //int x = Convert.ToInt32(_txtFardos.Text);
            //_txtTotalQuantidadeKG.Text = (x * 200).ToString();
            ////    string n = string.Empty;
            ////    if (_txtPreco.Text.Contains(","))
            ////    {
            ////        string[] m = _txtPreco.Text.Split(',');
            ////        n = m[0] + "." + m[1] + m[2];
            ////    }
            ////    double q = Convert.ToDouble(_txtTotalQuantidadeKG.Text);
            ////    double p = Convert.ToDouble(n);
            ////    double r = (q * p);
            ////    _lblSubTotal.Text = r.ToString("C");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void frmManterProdutoContrato_Load(object sender, EventArgs e)
        {
            CarregaStatus();
        }
    }
}
