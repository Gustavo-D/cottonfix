using ControllerCottonFix.Interfaces;
using Modelo.Modelo;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace ControllerCottonFix
{
    public class CtrlProdutoContrato : IAtualizaInsere<ProdutoContrato>, IDisposable
    {
        private Conexao _Connection;

        public CtrlProdutoContrato(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public ProdutoContrato Criar(ProdutoContrato model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUTO_CONTRATO (ID_CONTRATO, ID_STATUS, QUANTIDADE, VALOR_TOTAL, ICMS, COND_PAGAMENTO, FARDOS, LOTE, COR, TIPO_FOLHA, PRECO_NEGOCIADO, SAFRA) VALUES (@ID_CONTRATO, @ID_STATUS, @QUANTIDADE, @VALOR_TOTAL, @ICMS, @COND_PAGAMENTO, @FARDOS, @LOTE, @COR, @TIPO_FOLHA, @PRECO_NEGOCIADO, @SAFRA)";

                cmd.Parameters.Add("@ID_CONTRATO", SqlDbType.Int).Value = model.IdContrato;
                cmd.Parameters.Add("@ID_STATUS", SqlDbType.Int).Value = model.IdStatus;
                cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Float).Value = model.Quantidade;
                cmd.Parameters.Add("@VALOR_TOTAL", SqlDbType.Float).Value = model.ValorTotal;
                cmd.Parameters.Add("@ICMS", SqlDbType.Float).Value = model.ICMS;
                cmd.Parameters.Add("@COND_PAGAMENTO", SqlDbType.NVarChar).Value = model.CondicoesPagamento;
                cmd.Parameters.Add("@FARDOS", SqlDbType.Int).Value = model.Fardos;
                cmd.Parameters.Add("@LOTE", SqlDbType.Int).Value = model.Lote;
                cmd.Parameters.Add("@COR", SqlDbType.Int).Value = model.Cor;
                cmd.Parameters.Add("@TIPO_FOLHA", SqlDbType.Int).Value = model.TipoFolha;
                cmd.Parameters.Add("@PRECO_NEGOCIADO", SqlDbType.Float).Value = model.PrecoNegociado;
                cmd.Parameters.Add("@SAFRA", SqlDbType.NVarChar).Value = model.Safra;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
            }

            return default(ProdutoContrato);
        }

        public ProdutoContrato Atualizar(ProdutoContrato model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE PRODUTO_CONTRATO SET ID_CONTRATO = @ID_CONTRATO, ID_STATUS = @ID_STATUS, QUANTIDADE = @QUANTIDADE, VALOR_TOTAL = @VALOR_TOTAL, ICMS = @ICMS, COND_PAGAMENTO = @COND_PAGAMENTO, FARDOS = @FARDOS, LOTE = @LOTE, COR = @COR, TIPO_FOLHA = @TIPO_FOLHA, PRECO_NEGOCIADO = @PRECO_NEGOCIADO, SAFRA = @SAFRA WHERE ID_PRODUTO_CONTRATO = @ID_PRODUTO_CONTRATO";

                cmd.Parameters.Add("@ID_PRODUTO_CONTRATO", SqlDbType.Int).Value = model.IdProdutoContrato;
                cmd.Parameters.Add("@ID_CONTRATO", SqlDbType.Int).Value = model.IdContrato;
                cmd.Parameters.Add("@ID_STATUS", SqlDbType.Int).Value = model.IdStatus;
                cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Float).Value = model.Quantidade;
                cmd.Parameters.Add("@VALOR_TOTAL", SqlDbType.Float).Value = model.ValorTotal;
                cmd.Parameters.Add("@ICMS", SqlDbType.Float).Value = model.ICMS;
                cmd.Parameters.Add("@COND_PAGAMENTO", SqlDbType.NVarChar).Value = model.CondicoesPagamento;
                cmd.Parameters.Add("@FARDOS", SqlDbType.Int).Value = model.Fardos;
                cmd.Parameters.Add("@LOTE", SqlDbType.Int).Value = model.Lote;
                cmd.Parameters.Add("@COR", SqlDbType.Int).Value = model.Cor;
                cmd.Parameters.Add("@TIPO_FOLHA", SqlDbType.Int).Value = model.TipoFolha;
                cmd.Parameters.Add("@PRECO_NEGOCIADO", SqlDbType.Float).Value = model.PrecoNegociado;
                cmd.Parameters.Add("@SAFRA", SqlDbType.NVarChar).Value = model.Safra;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
                return default(ProdutoContrato);
            }
        }

        public Collection<ProdutoContrato> ListaPeloId(int codigoPessoa)
        {
            Collection<ProdutoContrato> ProdutoContratosListados = new Collection<ProdutoContrato>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PRODUTO_CONTRATO WHERE ID_CONTRATO = @ID_CONTRATO";

                cmd.Parameters.Add("@ID_CONTRATO", SqlDbType.Int).Value = codigoPessoa;

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        ProdutoContrato produto = new ProdutoContrato() { IdContrato = Convert.ToInt32(i["ID_CONTRATO"]),
                            IdStatus = Convert.ToInt32(i["ID_STATUS"]),
                            Quantidade = Convert.ToDouble(i["QUANTIDADE"]),
                            ValorTotal = Convert.ToDouble(i["VALOR_TOTAL"]),
                            ICMS = Convert.ToDouble(i["ICMS"]),
                            CondicoesPagamento = Convert.ToString(i["COND_PAGAMENTO"]),
                            Fardos = Convert.ToInt32(i["FARDOS"]),
                            Lote = Convert.ToInt32(i["LOTE"]),
                            Cor = Convert.ToInt32(i["COR"]),
                            TipoFolha = Convert.ToInt32(i["TIPO_FOLHA"]),
                            PrecoNegociado = Convert.ToDouble(i["PRECO_NEGOCIADO"]),
                            Safra = Convert.ToString(i["SAFRA"])
                        };

                        ProdutoContratosListados.Add(produto);
                    }
                }
            }
            return ProdutoContratosListados;
        }

        public Collection<ProdutoContrato> Listar()
        {
            Collection<ProdutoContrato> ProdutoContratosListados = new Collection<ProdutoContrato>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PRODUTO_CONTRATO";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        ProdutoContrato produto = new ProdutoContrato()
                        {
                            IdContrato = Convert.ToInt32(i["ID_CONTRATO"]),
                            IdStatus = Convert.ToInt32(i["ID_STATUS"]),
                            Quantidade = Convert.ToDouble(i["QUANTIDADE"]),
                            ValorTotal = Convert.ToDouble(i["VALOR_TOTAL"]),
                            ICMS = Convert.ToDouble(i["ICMS"]),
                            CondicoesPagamento = Convert.ToString(i["COND_PAGAMENTO"]),
                            Fardos = Convert.ToInt32(i["FARDOS"]),
                            Lote = Convert.ToInt32(i["LOTE"]),
                            Cor = Convert.ToInt32(i["COR"]),
                            TipoFolha = Convert.ToInt32(i["TIPO_FOLHA"]),
                            PrecoNegociado = Convert.ToDouble(i["PRECO_NEGOCIADO"]),
                            Safra = Convert.ToString(i["SAFRA"])
                        };

                        ProdutoContratosListados.Add(produto);
                    }
                }
            }
            return ProdutoContratosListados;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
